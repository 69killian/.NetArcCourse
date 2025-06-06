using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique pour créer plusieurs constructeurs 
                                        // dans une classe avec différents paramètres

            Pizza pizza1 = new Pizza("thicc crust", "tomato", "mozzarella");

            Console.ReadKey();
        }
    }

    class Pizza
    {
        public string bread;
        public string sauce;
        public string cheese;
        public string topping;

        public Pizza(string bread)
        {
            this.bread = bread;
        }

        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        
        
    }
}
