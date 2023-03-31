using System;
using FluentAssertions;
using NUnit.Framework;
using Moq.AutoMock;
using Scooters.Exeptions;
using Scooters.Interfaces;
using Scooters.Classes;
using Moq;

namespace Scooters.Tests
{
	public class RenatlCompanyTests
	{
        private IRentalCompany _company;
        private AutoMocker _mocker;
        private const string CompanyName = "Test";
        private const string ScooterId = "1";
        private const decimal Price = 1m;

        [SetUp]
        public void Setup()
        {
            _mocker = new AutoMocker();
            _company = new RentalCompany("Test", _mocker.GetMock<IScooterService>().Object, _mocker.GetMock<IRentalArchive>().Object);
        }

        [Test]
        public void CreateRentalCompany_TestAsNameProvideed_NameShouldBeTest()
        {
            _company.Name.Should().Be(CompanyName);
        }

        [Test]
        public void StartRent_ValidIdProvided_ScooterIsRented()
        {
            var scooter = new Scooter(ScooterId, Price);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById(ScooterId)).Returns(scooter);

            _company.StartRent(ScooterId);
            scooter.IsRented.Should().BeTrue();
        }

        [Test]
        public void StartRent_RecordCreated_AddedToArchive()
        {
            var scooter = new Scooter(ScooterId, Price);

            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById(ScooterId)).Returns(scooter);

            _company.StartRent(scooter.Id);

            var rentMock = _mocker.GetMock<IRentalArchive>();
            rentMock.Verify(x => x.AddToArchive(It.IsAny<IRentalRecord>()), Times.Once);
        }

        [Test]
        public void StartRent_ScooterWithIdNotExists_ThrwoNoScooterExeption()
        {
            var scooter = new Scooter(ScooterId, Price);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById(scooter.Id)).Returns(scooter);

            Action act = () => _company.StartRent("2");
            act.Should().Throw<NoScooterExeption>();
        }

        [Test]
        public void StartRent_ScooterAlreadyRented_ThrowScooterRentedExeption()
        {
            var scooter = new Scooter(ScooterId, Price);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById(scooter.Id)).Returns(scooter);
            scooter.IsRented = true;

            Action act = () => _company.StartRent(scooter.Id);
            act.Should().Throw<ScooterRentedExeption>();
        }

        [Test]
        public void EndRent_InvalidId_ScooterDoesNotExistsInRentedList()
        {
            var scooter = new Scooter(ScooterId, Price);

            var scooterMock = _mocker.GetMock<IScooterService>();
            scooterMock.Setup(x => x.GetScooterById(scooter.Id)).Returns(scooter);

            var archiveMock = _mocker.GetMock<IRentalArchive>();
            archiveMock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { new RentalRecord(ScooterId, scooter.PricePerMinute, DateTime.Now) });

            Action act = () => _company.EndRent("2");
            act.Should().Throw<ScooterNotRentedExeption>();
        }

        [Test]
        public void EndRent_InvalidId_ScooterDoesNotExists()
        {
            var scooter = new Scooter(ScooterId, Price);

            var scooterMoc = _mocker.GetMock<IScooterService>();
            scooterMoc.Setup(x => x.GetScooterById("2")).Returns(scooter);

            var archiveMock = _mocker.GetMock<IRentalArchive>();
            archiveMock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { new RentalRecord(ScooterId, scooter.PricePerMinute, DateTime.Now) });

            Action act = () => _company.EndRent(scooter.Id);
            act.Should().Throw<NoScooterExeption>();
        }

        [Test]
        public void EndRent_ScooterIsRented_CalculatesTotalPrice()
        {
            var scooter = new Scooter(ScooterId, Price);
            var rentalRecord = new RentalRecord(ScooterId, scooter.PricePerMinute, DateTime.Now.AddMinutes(-20));

            var mockScooterService = _mocker.GetMock<IScooterService>();
            mockScooterService.Setup(x => x.GetScooterById(scooter.Id)).Returns(scooter);

            var archiveMock = _mocker.GetMock<IRentalArchive>();
            archiveMock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { rentalRecord });

            var expectedPrice = rentalRecord.PricePerMinute * 20m;

            var actualPrice = _company.EndRent(scooter.Id);
            scooter.IsRented.Should().BeFalse();

            rentalRecord.Cost.Should().Be(actualPrice);

            actualPrice.Should().Be(expectedPrice);
        }

        [Test]
        public void CauculateIncome_NoYearProvided_NoActiveRentals()
        {
            var activeRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-20));
            var finishedRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-10));
            finishedRecord.EndRent = DateTime.Now;

            var mock = _mocker.GetMock<IRentalArchive>();
            mock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { activeRecord });
            mock.Setup(y => y.AllRecords).Returns(new List<IRentalRecord> { finishedRecord });

            var result = _company.CalculateIncome(null, false);
            result.Should().Be(finishedRecord.Cost);
        }

        [Test]
        public void CauculateIncome_Year2023_NoActiveRentals()
        {
            var activeRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-20));
            var finishedRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-10));
            finishedRecord.EndRent = DateTime.Now;

            var mock = _mocker.GetMock<IRentalArchive>();
            mock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { activeRecord });
            mock.Setup(y => y.AllRecords).Returns(new List<IRentalRecord> { finishedRecord });

            var result = _company.CalculateIncome(2023, false);
            result.Should().Be(finishedRecord.Cost);
        }

        [Test]
        public void CauculateIncome_InvalidYear_WithActiveRentals()
        {
            var activeRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-20));
            var finishedRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-10));
            finishedRecord.EndRent = DateTime.Now;

            var mock = _mocker.GetMock<IRentalArchive>();
            mock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { activeRecord });
            mock.Setup(y => y.AllRecords).Returns(new List<IRentalRecord> { finishedRecord });

            var result = _company.CalculateIncome(2022, true);
            result.Should().Be(activeRecord.Cost);
        }

        [Test]
        public void CauculateIncome_InvalidYear_NoActiveRentals()
        {
            var activeRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-20));
            var finishedRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-10));
            finishedRecord.EndRent = DateTime.Now;

            var mock = _mocker.GetMock<IRentalArchive>();
            mock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { activeRecord });
            mock.Setup(y => y.AllRecords).Returns(new List<IRentalRecord> { finishedRecord });

            var result = _company.CalculateIncome(2022, false);
            result.Should().Be(0m);
        }

        [Test]
        public void CauculateIncome_Year2023_WithActiveRentals()
        {
            var activeRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-20));
            var finishedRecord = new RentalRecord(ScooterId, Price, DateTime.Now.AddMinutes(-10));
            finishedRecord.EndRent = DateTime.Now;

            var mock = _mocker.GetMock<IRentalArchive>();
            mock.Setup(x => x.ActiveRecords).Returns(new List<IRentalRecord> { activeRecord });
            mock.Setup(y => y.AllRecords).Returns(new List<IRentalRecord> { finishedRecord });

            var result = _company.CalculateIncome(2023, true);

            result.Should().Be(20m);
        }
    }
}

