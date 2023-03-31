using FluentAssertions;
using NUnit.Framework;
using Scooters.Exeptions;

namespace Scooters.Tests;

public class ScooterServiceTests
{
    private IScooterService _scooterService;
    private List<Scooter> _scooters;
    private const string ScooterId = "1";
    private const decimal Price = 1m;

    [SetUp]
    public void Setup()
    {
        _scooters = new List<Scooter>();
        _scooterService = new ScooterService(_scooters);
    }

    [Test]
    public void AddScooter_AddValidScooter_ScooterAdded()
    {
        _scooterService.AddScooter(ScooterId, Price);

        _scooters.Count.Should().Be(1);
    }

    [Test]
    public void AddScooter_AddScooterWithouthID_ThrwosNoScooterIdExeption()
    {
        Action act = () =>
        {
            _scooterService.AddScooter("", 1m);
        };
        act.Should().Throw<NoScooterIdExeption>();
    }

    [Test]
    public void AddScooter_AddScooterWithNegativePrice_ThrwosInvalidPriceExeption()
    {
        Action act = () =>
        {
            _scooterService.AddScooter("", -0.1m);
        };
        act.Should().Throw<InvalidPriceExeption>();
    }

    [Test]
    public void AddScooter_AddingDuplicateScooter_ThrwosScooterExistsExeption()
    {
        _scooterService.AddScooter(ScooterId, Price);
        Action act = () => _scooterService.AddScooter(ScooterId, Price);
        act.Should().Throw<ScooterExistsExeption>();
    }

    [Test]
    public void RemoveScooter_ValidIdProvided_ScooterRemoved()
    {
        _scooters.Add(new Scooter(ScooterId, Price));
        _scooterService.RemoveScooter(ScooterId);

        _scooters.Any(x => x.Id == ScooterId).Should().BeFalse();
    }

    [Test]
    public void RemoveScooter_NullIdProvided_ScooterRemoved()
    {
        Action act = () =>
        {
            _scooterService.RemoveScooter(null);
        };

        act.Should().Throw<NoScooterIdExeption>();
    }

    [Test]
    public void RemoveScooter_ScooterInRent_ThrowsScooterRentedExeption()
    {
        _scooters.Add(new Scooter(ScooterId, Price) { IsRented = true });
        Action act = () => _scooterService.RemoveScooter(ScooterId);
        act.Should().Throw<ScooterRentedExeption>();
    }

    [Test]
    public void GetScooters_ReturnsAllScooters()
    {
        _scooters.Add(new Scooter(ScooterId, Price));
        var scooters = _scooterService.GetScooters();
        scooters.Count.Should().Be(1);
    }

    [Test]
    public void GetScootersById_ValidIdProvided_ReturnScooter()
    {
        var scooter = new Scooter(ScooterId, Price);
        _scooters.Add(scooter);
        _scooterService.GetScooterById(scooter.Id).Should().Be(scooter);
    }

    [Test]
    public void GetScootersById_NullIdProvided_ScooterRemoved()
    {
        Action act = () =>
        {
            _scooterService.GetScooterById(null);
        };

        act.Should().Throw<NoScooterIdExeption>();
    }
}
