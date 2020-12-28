using System;

namespace FruitShop
{
    class MainClass
    {
        

        public static void Main(string[] args)
        {
            Shop();
            

            void Shop()
            {
                double balance = 0;
                double price = 0;



                Console.WriteLine("WELCOME TO MY SHOP");
                Console.WriteLine("ENTER IN YOUR BALANCE IN £:");
                balance = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Balance:£" + balance);
                Console.WriteLine("");
                Console.WriteLine("SHOP ITEMS");
                string[] items = new string[6];
                items[0] = ".Apple";
                items[1] = ".Srawberry";
                items[2] = ".Pear";
                items[3] = ".Bannana";
                items[4] = ".Grapefruit";
                items[5] = ".Rasberry";


                for (int x = 0; x < items.Length; x++)
                {
                    Console.WriteLine(items[x]);
                }

                string fruit = Console.ReadLine();
                if (fruit == "Apple" || fruit == "apple")
                {
                    price = 4;
                    Console.WriteLine("APPLE COST: £" + price);

                }
                

                
                if (fruit == "Strawberry" || fruit == "strawberry")
                {
                    price = 1;
                    Console.WriteLine("STRAWBERRY COST: £" + price);

                }
               

                if (fruit == "Pear" || fruit == "pear")
                {
                    price = 4.40;
                    Console.WriteLine("PEAR COST: £" + price);

                }
              

                if (fruit == "Bannana" || fruit == "bannana")
                {
                    price = 1.50;
                    Console.WriteLine("BANNANA COST: £" + price);

                }
               
                if (fruit == "Grapefruit" || fruit == "grapefruit")
                {
                    price = 2.50;
                    Console.WriteLine("GRAPEFRUIT COST: £" + price);

                }
                
                if (fruit == "Rasberry" || fruit == "rasberry")
                {
                    price = 3.99;
                    Console.WriteLine("RASBERRY COST: £" + price);

                }
               


                Console.WriteLine("WOULD YOU LIKE TO PURCHASE?");
                Console.WriteLine("YES OR NO?");
                string yn = Console.ReadLine();
                
                
                

                
                

                if (yn == "yes")
                {
                    double bag = 0.05;
                    Console.WriteLine("WOULD YOU LIKE A BAG?");
                    Console.WriteLine("YES OR NO?");
                    string ynbag = Console.ReadLine();

                    if(ynbag == "yes")
                    {
                        double result = balance - price + bag;
                        Console.WriteLine("YOUR REMAINDING BALANCE IS:" + " " + "£" + result);
                    }

                    if (ynbag == "no")
                    {
                        double result = balance - price;
                        Console.WriteLine("YOUR REMAINDING BALANCE IS:" + " " + "£" + result);
                    }




                }
                else if (yn == "no")
                {
                    Console.WriteLine("THANK YOU!");
                }

               


            }

           


        }

        


        


    }
}
