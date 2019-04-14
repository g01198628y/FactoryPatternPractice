using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPracticeTwo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BeverageStore beverageStore = new BeverageStore();
            beverageStore.OrderBeverage("BlackTea");
        }
    }

    public class BeverageStore
    {
        public IMakeBeverage OrderBeverage(string beverageType)
        {
            IMakeBeverage beverage;
            switch (beverageType)
            {
                case "GreenTea":
                    beverage = new GreenTea();
                    break;

                case "BlackTea":
                    beverage = new BlackTea();
                    break;

                default:
                    return null;
            }

            beverage.AddMaterial();
            beverage.Brew();
            beverage.PouredCup();
            return beverage;
        }
    }

    public class GreenTea : IMakeBeverage
    {
        public void AddMaterial()
        {
            Console.WriteLine("加入綠茶包");
        }

        public void Brew()
        {
            Console.WriteLine("加入水沖泡");
        }

        public void PouredCup()
        {
            Console.WriteLine("將綠茶裝杯");
        }
    }

    public class BlackTea : IMakeBeverage
    {
        public void AddMaterial()
        {
            Console.WriteLine("加入紅茶包");
        }

        public void Brew()
        {
            Console.WriteLine("加入水沖泡");
        }

        public void PouredCup()
        {
            Console.WriteLine("將紅茶裝杯");
        }
    }

    public interface IMakeBeverage
    {
        void AddMaterial();

        void Brew();

        void PouredCup();
    }
}