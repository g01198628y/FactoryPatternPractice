using System;

namespace FactoryMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFactory frenchFriesFactory = new FrenchFriesFactory();
            IProduct normalFrenchFries = frenchFriesFactory.GetProduct();
            normalFrenchFries.Describe();
            IProduct spicyFlavorFrenchFries = frenchFriesFactory.GetProduct("Spicy");
            spicyFlavorFrenchFries.Describe();
        }
    }

    //1.要先有商品和工廠的介面
    //Product Interface
    public interface IProduct
    {
        //描述是甚麼產品
        void Describe();
    }

    // Factory Interface
    public interface IFactory
    {
        //工廠返回產品
        IProduct GetProduct();

        IProduct GetProduct(string flavor);
    }

    //2.實現薯條和薯條工廠
    //實現薯條
    public class FrenchFries : IProduct
    {
        //default Flavor HasSalt
        private readonly string _flavor = "HasSalt";

        //constructor
        public FrenchFries()
        {
        }

        //帶入flavor的constructor
        public FrenchFries(string flavor)
        {
            _flavor = flavor;
        }

        public void Describe()
        {
            Console.WriteLine($"I am {_flavor} FrenchFries.");
        }
    }

    //實現薯條工廠
    public class FrenchFriesFactory : IFactory
    {
        //返回一般HasSalt的薯條
        public IProduct GetProduct()
        {
            return new FrenchFries();
        }

        //返回我們想要的口味的薯條
        public IProduct GetProduct(string flavor)
        {
            return new FrenchFries(flavor);
        }
    }
}