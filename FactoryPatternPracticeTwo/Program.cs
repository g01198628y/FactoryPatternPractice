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
            OrderTea();
        }

        public static GreenTea OrderTea()
        {
            GreenTea greenTea = new GreenTea();
            greenTea.AddMaterial(); //加料
            greenTea.Brew(); // 沖泡
            greenTea.PouredCup(); // 裝杯
            return greenTea;
        }
    }

    internal class GreenTea
    {
        public void AddMaterial()
        {
            Console.WriteLine("加料");
        }

        public void Brew()
        {
            Console.WriteLine("沖泡");
        }

        public void PouredCup()
        {
            Console.WriteLine("裝杯");
        }
    }
}