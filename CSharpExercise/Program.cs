//使用接口来取代委托
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toyCarFactory = new ToyCarFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Box box1 = wrapFactory.WrapProduct(pizzaFactory);
            Box box2 = wrapFactory.WrapProduct(toyCarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            return product;
        }
    }

    class Product
    {
        public string Name { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory   //模板方法
    {
        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            box.Product = product;
            return box;
        }
    }
}