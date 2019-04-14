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
            OrderBlackTea();
        }

        public static GreenTea OrderGreenTeaTea()
        {
            GreenTea greenTea = new GreenTea();
            greenTea.AddMaterial();
            greenTea.Brew();
            greenTea.PouredCup();
            return greenTea;
        }

        public static BlackTea OrderBlackTea()
        {
            BlackTea blackTea = new BlackTea();
            blackTea.AddMaterial();
            blackTea.Brew();
            blackTea.PouredCup();
            return blackTea;
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

    internal interface IMakeBeverage
    {
        void AddMaterial();

        void Brew();

        void PouredCup();
    }
}