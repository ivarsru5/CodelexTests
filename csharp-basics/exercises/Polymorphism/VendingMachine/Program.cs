using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert coins to buy something");

            var insert = true;
            var summ = new Money();
            var vendingMachine = new VendingMachine("Bosch");

            while (insert)
            {
                Console.Write("Insert: ");
                var coin = Convert.ToDouble(Console.ReadLine());

                var coinValue = ValidateCoin(coin);
                var coinValidator = coinValue.Euros < 0 || coinValue.Cents < 0;

                while (coinValidator == true)
                {
                    Console.WriteLine("Coin is not valid, please try again!");
                    coin = Convert.ToDouble(Console.ReadLine());
                }

                summ = vendingMachine.InsertCoin(coinValue);
                var balance = summ.Euros + (summ.Cents * 1.0 / 100);

                Console.WriteLine("Available balance: {0}", balance);

                Console.Write("Display products {0}, or insert coin{1}", 2, 1);
                var select = Convert.ToDouble(Console.ReadLine());

                if (select == 1)
                {
                    continue;
                }
                else
                {
                    insert = false;
                }

            }

            var selected = SelectProduct(vendingMachine.Products);
            if (selected != null)
            {
                vendingMachine.ProcessDeal((Product)selected);
                Console.WriteLine("Deal done successfuly");
                var change = vendingMachine.Amount.Euros + (vendingMachine.Amount.Cents * 1.0 / 100);
                Console.WriteLine("Change: {0}", change);
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }

        public static Money ValidateCoin(double coin)
        {
            Money insertedCoin = new Money();
            switch (coin)
            {
                case 0.10:
                    insertedCoin = new Money { Euros = 0, Cents = 10 };
                    break;
                case 0.20:
                    insertedCoin = new Money { Euros = 0, Cents = 20 };
                    break;
                case 0.50:
                    insertedCoin = new Money { Euros = 0, Cents = 50 };
                    break;
                case 1.00:
                    insertedCoin = new Money { Euros = 1, Cents = 0 };
                    break;
                case 2.00:
                    insertedCoin = new Money { Euros = 2, Cents = 0 };
                    break;
                default:
                    break;
            }
            return insertedCoin;
        }

        public static Product? SelectProduct(Product[] products)
        {
            for (var index = 0; index < products.Length; index++)
            {
                Console.WriteLine("{0}: {1} price: {2}", index + 1, products[index].Name, products[index].Price);
            }
            Console.Write("Select product: ");
            var productIndex = Convert.ToInt32(Console.ReadLine());

            if (productIndex >= 0 && productIndex <= products.Length)
            {
                return products[productIndex - 1];
            }
            else
            {
                return null;
            }
        }
    }
}
