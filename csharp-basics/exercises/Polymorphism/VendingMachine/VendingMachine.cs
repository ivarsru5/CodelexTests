using System;
using System.Linq;
using System.Reflection;
using VendingMachine.Exceptions;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private string _manufacturer;
        private Product[] _products;
        private Money _amount;

        public VendingMachine(string manufacturer)
        {
            _manufacturer = manufacturer;
            _amount = new Money();
            _products = new Product[]
            {
                new Product
                {
                    Available = 10,
                    Price = new Money
                    {
                        Euros = 1,
                        Cents = 25
                    },
                    Name = "Patao chips"
                },

                new Product
                {
                    Available = 11,
                    Price = new Money
                    {
                        Euros = 0,
                        Cents = 75
                    },
                    Name = "Coca-Cola can"
                }
            };
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
        }

        public bool HasProducts
        {
            get { return _products.Length > 0; }
        }

        public Money Amount
        {
            get { return _amount; }
        }

        public Product[] Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public Money InsertCoin(Money amount)
        {
            var balance = _amount.Euros + (_amount.Cents * 1.0 / 100);
            var inserted = amount.Euros + (amount.Cents * 1.0 / 100);

            var newBalance = balance + inserted;

            var euros = (int)newBalance;
            var cents = (int)((newBalance - euros) * 100);

            _amount.Euros = euros;
            _amount.Cents = cents;

            return Amount; 
        }

        public Money ReturnMoney()
        {
            return _amount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            var newPrice = price.Euros + (price.Cents * 1.0 / 100);

            if (!string.IsNullOrEmpty(name) && newPrice != 0.00 && count != 0)
            {
                var product = new Product
                {
                    Available = count,
                    Price = price,
                    Name = name
                };
                var index = _products.Length - 1;
                _products[index] = product;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber >= 0 && productNumber < _products.Length && price.HasValue && !string.IsNullOrEmpty(name))
            {
                var product = _products[productNumber - 1];
                product.Name = name;
                product.Price = (Money)price;
                product.Available = amount;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ProcessDeal(Product selectedProduct)
        {
            var balance = _amount.Euros + (_amount.Cents * 1.0 / 100);
            var productPrice = selectedProduct.Price.Euros! + (selectedProduct.Price.Cents * 1.0 / 100);
            var remainingBalance = balance - productPrice;

            var euro = (int)remainingBalance;
            var cents = (int)((remainingBalance - euro) * 100);
            _amount.Euros = euro;
            _amount.Cents = cents;
        }
    }
}


