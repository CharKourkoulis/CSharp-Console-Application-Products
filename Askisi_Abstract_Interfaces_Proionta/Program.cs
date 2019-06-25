using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askisi_Abstract_Interfaces_Proionta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Iproduct> ProductList = new List<Iproduct>();




            Iproduct p1 = new Bag(15,"bag", "white");
            Iproduct p2 = new Wear(10, "tshirt", "black");
            Iproduct p3 = new Bag(25, "bag", "red");
            Iproduct p4 = new Wear(30, "trousers", "brown");
            Iproduct p5 = new Shoe(45, "shoes", "black");
            ProductList.Add(p1);
            ProductList.Add(p2);
            ProductList.Add(p3);
            ProductList.Add(p4);
            ProductList.Add(p5);



            Iproduct p = ProductMaker();
            ProductList.Add(p);

            RepeatProductMaker(ProductList);






            foreach (var item in ProductList)
            {
                item.Output();
            }





        }

        public static Iproduct ProductMaker()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TYPE '1' (or anything else) TO CREATE WEAR STUFF,\nTYPE '2'TO CREATE BAG\nTYPE '3' TO CREATE SHOES");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            int type = Convert.ToInt32(Console.ReadLine());

                if (type == 1)
                    {

                        Console.WriteLine("You will get a WEARSTUFF Product!");
                        Console.WriteLine();
                        Console.WriteLine("Type the type of your choice (e.g TSHIRT, TROUSERS etc): ");
                        string typeprod = Console.ReadLine();
                        Console.WriteLine("Type the color of your choice: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Type the (int)price of your choice: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        Iproduct proion = new Wear(price, typeprod, color);
                        return proion;

                    }
                    else if (type == 2)
                    {
                        Console.WriteLine("You will get a BAG Product!");
                        Console.WriteLine();               
                        Console.WriteLine("Type the color of your choice: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Type the (int)price of your choice: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        Iproduct proion = new Bag(price, "BAG", color);
                        return proion;
                    }
                    else if (type == 3)
                    {
                        Console.WriteLine("You will get a SHOES Product!");
                        Console.WriteLine();
                        Console.WriteLine("Type the brand of your choice: ");
                        string typeprod = Console.ReadLine();
                        Console.WriteLine("Type the color of your choice: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Type the (int)price of your choice: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        Iproduct proion = new Wear(price, "BAG", color);
                        return proion;
                    }
                    else
                    {
                        Console.WriteLine("You will get a WEARSTUFF Product!");
                        Console.WriteLine();
                        Console.WriteLine("Type the type of your choice (e.g TSHIRT, TROUSERS etc): ");
                        string typeprod = Console.ReadLine();
                        Console.WriteLine("Type the color of your choice: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Type the (int)price of your choice: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        Iproduct proion = new Shoe(price, typeprod, color);
                        return proion;
                    }

        }

        public static void RepeatProductMaker(List<Iproduct> listaProiontwn)
        {

            bool valid = true;
            do
            {

                Iproduct proion = ProductMaker();
                listaProiontwn.Add(proion);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("PRODUCT HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another product?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Product");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);
        }


    }



    interface Iproduct
    {
         void Output();
    }


    abstract class WearProducts : Iproduct
    {
        protected abstract int Price { get; set; }

        protected abstract string Type { get; set; }

        protected abstract string Color { get; set; }

        protected WearProducts()
        {

        }

        public WearProducts(int price, string type, string color)
        {
            Price = price;
            Type = type;
            Color = color;
        }


        public abstract void Output();
        
    }



    class Wear : WearProducts, Iproduct
    {
        protected override int Price { get; set; }
        protected override string Type { get; set; }
        protected override string Color { get; set; }


        public Wear(int timi, string eidos, string xrwma)
        {
            Price = timi;
            Type = eidos;
            Color = xrwma;
        }



        public override void Output()
        {
            Console.WriteLine($" {Color,-10} product  |  type: {Type,-15} | price: {Price,-3} euro");
        }

    }


        class Bag : WearProducts
        {
            protected override int Price { get; set; }
            protected override string Type { get; set; }
            protected override string Color { get; set; }


            public Bag(int price, string type, string color)
            {
                Price = price;
                Type = type;
                Color = color;
            }


            public override void Output()
            {
                Console.WriteLine($" {Color,-10} product  |  type: {Type,-15} | price: {Price,-3} euro");
            }
        }


        class Shoe : WearProducts
        {
            protected override int Price { get; set; }
            protected override string Type { get; set; }
            protected override string Color { get; set; }

            public Shoe(int price, string type, string color)
            {
                Price = price;
                Type = type;
                Color = color;
            }



            public override void Output()
            {
                Console.WriteLine($" {Color,-10} prpduct  |  type: {Type,-15} | price: {Price,-3} euro");
            }
        }






    

}
