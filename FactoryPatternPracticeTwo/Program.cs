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
            BeverageStore beverageStore = new BeverageStore(new BeverageFactory());
            Console.WriteLine("客人點了綠茶");
            beverageStore.OrderBeverage("GreenTea");
        }
    }

    //將產生實體化的部分提取出到BeverageFactory類別
    public class BeverageStore
    {
        private readonly BeverageFactory _beverageFactory;

        public BeverageStore(BeverageFactory beverageFactory)
        {
            _beverageFactory = beverageFactory;
        }

        public IMakeBeverage OrderBeverage(string beverageType)
        {
            var beverage = _beverageFactory.CreateBeverage(beverageType);
            beverage.AddMaterial();
            beverage.Brew();
            beverage.PouredCup();
            return beverage;
        }
    }

    //建立工廠類別由CreateBeverage方法來決定要產生哪一個飲品類別，日後如要增加新飲品類別就由此處修改即可。
    public class BeverageFactory
    {
        public IMakeBeverage CreateBeverage(string beverageType)
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