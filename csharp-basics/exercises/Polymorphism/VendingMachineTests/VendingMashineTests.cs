using FluentAssertions;
using Moq.AutoMock;
using VendingMachine;
using VendingMachine.Exceptions;

namespace VendingMachineTests;

public class VendingMachineTests
{
    private IVendingMachine _vending;
    private AutoMocker _mocker;

    [SetUp]
    public void Setup()
    {
        _mocker = new AutoMocker();
        _vending = new VendingMachine.VendingMachine("Test");
    }

    [Test]
    public void CeckManufacturer()
    {
        _vending.Manufacturer.Should().Be("Test");
    }

    [Test]
    public void VendingMachine_CheckProducts_ReturnTrue()
    {
        _vending.HasProducts.Should().BeTrue();
    }

    [Test]
    public void Money_NoMoneyInserted()
    {
        var amount = new Money();

        var actual = _vending.Amount;
        actual.Should().Be(amount);
    }

    [Test]
    public void VendingMachine_CheckProducts_ReturnsTwo()
    {
        _vending.Products.Length.Should().Be(2);
    }

    [Test]
    public void VendingMachine_InsertCoin_AddsToBalance()
    {
        var insertedAmount = new Money() { Euros = 0, Cents = 10 };

        _vending.InsertCoin(insertedAmount);

        _vending.Amount.Should().Be(insertedAmount);
    }

    [Test]
    public void VendingMachine_ReturnMoney_ReturnsChange()
    {
        var change = _vending.ReturnMoney();
        change.Should().Be(_vending.Amount);
    }

    [Test]
    public void VendingMachine_AddProduct_ProductAdded()
    {
        var name = "TestProduct";
        var price = new Money() { Euros = 0, Cents = 75 };
        var amount = 1;

        var result = _vending.AddProduct(name, price, amount);
        result.Should().BeTrue();
    }

    [Test]
    public void VendingMachine_AddProduct_InvalidName_ReturnFalse()
    {
        var name = "";
        var price = new Money() { Euros = 0, Cents = 75 };
        var amount = 1;

        var result = _vending.AddProduct(name, price, amount);
        result.Should().BeFalse();
    }

    [Test]
    public void VendingMachine_AddProduct_NoPrice_ReturnFalse()
    {
        var name = "TestProduct";
        var price = new Money() { Euros = 0, Cents = 75 };
        var amount = 1;

        var result = _vending.AddProduct(name, price, amount);
        result.Should().BeFalse();
    }

    [Test]
    public void VendingMachine_AddProduct_NoAmount_ReturnFalse()
    {
        var name = "TestProduct";
        var price = new Money() { Euros = 0, Cents = 0 };
        var amount = 0;

        var result = _vending.AddProduct(name, price, amount);
        result.Should().BeFalse();
    }

    [Test]
    public void VendingMachine_UpdateProduct_ReturnsTrue()
    {
        var productNumber = 1;
        var productName = "Pepsi";
        var productPrice = new Money() { Euros = 1, Cents = 75};
        var productCount = 10;

        var result = _vending.UpdateProduct(productNumber, productName, productPrice, productCount);

        result.Should().BeTrue();
    }

    [Test]
    public void VendingMachine_UpdateProduct_InvalidProductNumber_ReturnsFalse()
    {
        var productNumber = 3;
        var productName = "Pepsi";
        var productPrice = new Money() { Euros = 1, Cents = 75 };
        var productCount = 10;

        var result = _vending.UpdateProduct(productNumber, productName, productPrice, productCount);

        result.Should().BeFalse();
    }

    [Test]
    public void VendingMachine_UpdateProduct_NoNameProvided_ReturnsFalse()
    {
        var productNumber = 1;
        var productPrice = new Money() { Euros = 1, Cents = 75 };
        var productCount = 10;

        var result = _vending.UpdateProduct(productNumber, null, productPrice, productCount);

        result.Should().BeFalse();
    }

    [Test]
    public void VendingMachine_UpdateProduct_NoPrice_ReturnsFalse()
    {
        var productNumber = 1;
        var productName = "Pepsi";
        var productCount = 10;

        var result = _vending.UpdateProduct(productNumber, productName, null, productCount);

        result.Should().BeFalse();
    }

    [Test]
    public void VendingMachine_UpdateProduct_NoProdctCount_ReturnsFalse()
    {
        var productNumber = 1;
        var productName = "Pepsi";
        var productPrice = new Money() { Euros = 1, Cents = 75 };
        var productCount = 0;

        var result = _vending.UpdateProduct(productNumber, productName, null, productCount);

        result.Should().BeFalse();
    }
}
