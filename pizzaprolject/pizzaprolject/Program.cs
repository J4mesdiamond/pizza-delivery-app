using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    
    private static double credits;
    private static double availableCredits;
    private static double toppingsCredits;
    private static double pizzaPrice;
    private static double totalPizzaPrice = pizzaPrice + toppingsCredits;

    static void Main(string[] args)
    {
        


        while (true)
        {
            Console.WriteLine("................UCLAN PIZZAS");
            Console.WriteLine("................SELECT TRANSACTION");
            Console.WriteLine("\t 1. add credits");
            Console.WriteLine("\t 2. place an order");
            Console.WriteLine("\t 3. exit");
            int opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)
            {
                addcredits();

            }
            else if (opt == 2)
            {
               pizzaSize();
            }
            else if (opt == 3)
            {
                Console.Clear();
            }
           
            else
            {
                Console.WriteLine("WRONG INPUT");
            }

            
        }


    }







    public static void addcredits()
    {
        Console.WriteLine("enter ammount of credits to be added");
        credits = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" /..........Your available credits: " + credits);
        
    }

    public static void pizzaSize()
    {
        Console.WriteLine("............................");
        Console.WriteLine("size 7: 3 credits");
        Console.WriteLine("size 8: 4 credits");
        Console.WriteLine("size 9: 5 credits");
        Console.WriteLine("size 10: 6 credits");
        Console.WriteLine("size 11: 7 credits");
        Console.WriteLine("size 12: 8 credits");
        Console.WriteLine("size 13: 9 credits");
        Console.WriteLine("size 14: 10 credits");
        Console.WriteLine("enter pizza size");
        int pizzasize = Convert.ToInt32(Console.ReadLine());
        if (pizzasize == 7)
        {
            pizzaPrice = 3;
            availableCredits = credits - 3;
        }
        else if (pizzasize == 8)
        {
            pizzaPrice = 4;
            availableCredits = credits - 4;
        }
        else if (pizzasize == 9)
        {
            pizzaPrice = 5;
            availableCredits = credits - 5;
        }
        else if (pizzasize == 10)
        {
            pizzaPrice = 6;
            availableCredits = credits - 6;
        }
        else if (pizzasize == 11)
        {
            pizzaPrice = 7;
            availableCredits = credits - 7;
        }
        else if (pizzasize == 12)
        {
            pizzaPrice = 8;
            availableCredits = credits - 8;
        }
        else if (pizzasize == 13)
        {
            pizzaPrice = 9;
            availableCredits = credits - 9;
        }
        else if (pizzasize == 14)
        {
            pizzaPrice = 10;
            availableCredits = credits - 10;
        }
        Console.WriteLine("..........................................");
        Console.WriteLine("Your remaining credits " + availableCredits);

        if (pizzasize < 7 || pizzasize > 14)
        {
            Console.WriteLine("there is no pizza of this size");
            pizzasize = 7;
            Console.WriteLine("pizza set to 7");
        }
        else
        {
            pizzasize = pizzasize;
        }
    

        while (true)
        {
            Console.WriteLine(".............CHOOSE FROM THE FOLLOWING TOPPINGS..........");
            Console.WriteLine("\t 1. ham: 0.80 credits");
            Console.WriteLine("\t 2. mushroom: 0.50 credits");
            Console.WriteLine("\t 3. pepperoni: 1.0 credits");
            Console.WriteLine("\t 4. olives: 0.50 credits");
            Console.WriteLine("\t 5. pineapple: 0.60 credits");
            Console.WriteLine("\t 6. extra cheese: 1.20 credits");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                toppingsCredits = 0.80;
                double hamcredits = 0.80;
                double Credits = availableCredits - hamcredits;
                Console.WriteLine("remaining credits: " + Credits);
            }

            else if (option == 2)
            {
                toppingsCredits = 0.50;
                double mushroomcredits = 0.50;
                double Credits = availableCredits - mushroomcredits;
                Console.WriteLine("remaining credits: " + Credits);
            }

            else if (option == 3)
            {
                toppingsCredits = 1.00;
                double pepperonicredits = 1.00;
                double Credits = availableCredits - pepperonicredits;
                Console.WriteLine("remaining credits: " + Credits);
            }

            else if (option == 4)
            {
                toppingsCredits = 0.50;
                double olivescredits = 0.50;
                double Credits = availableCredits - olivescredits;
                Console.WriteLine("remaining credits: " + Credits);
            }

            else if (option == 5)
            {
                toppingsCredits = 0.60;
                double pineapplecredits = 0.60;
                double Credits = availableCredits - pineapplecredits;
                Console.WriteLine("remaining credits: " + Credits);
            }

            else if (option == 6)
            {
                toppingsCredits = 1.20;
                double cheesecredits = 1.20;
                double Credits = availableCredits - cheesecredits;
                Console.WriteLine("remaining credits: " + Credits);
            }



            else
            {
                Console.WriteLine("WRONG INPUT!!!");
            }
            break;
            
            
            
        }

            
            
            while (true)
            {
                Console.WriteLine("do you want to add more toppings?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                int Opt = Convert.ToInt32(Console.ReadLine());

                if (Opt == 1)
                {
                    Console.WriteLine(".............CHOOSE FROM THE FOLLOWING TOPPINGS..........");
                    Console.WriteLine("\t 1. ham: 0.80 credits");
                    Console.WriteLine("\t 2. mushroom: 0.50 credits");
                    Console.WriteLine("\t 3. pepperoni: 1.0 credits");
                    Console.WriteLine("\t 4. olives: 0.50 credits");
                    Console.WriteLine("\t 5. pineapple: 0.60 credits");
                    Console.WriteLine("\t 6. extra cheese: 1.20 credits");

                    int option2 = Convert.ToInt32(Console.ReadLine());

                    if (option2 == 1)
                    {
                        toppingsCredits = 0.80;
                        double hamcredits = 0.80;
                        double Credits = availableCredits - hamcredits - hamcredits;
                        Console.WriteLine("remaining credits: " + Credits);
                    }

                    else if (option2 == 2)
                    {
                        toppingsCredits = 0.50;
                        double mushroomcredits = 0.50;
                        double Credits = availableCredits - mushroomcredits - mushroomcredits;
                        Console.WriteLine("remaining credits: " + Credits);
                    }

                    else if (option2 == 3)
                    {
                        toppingsCredits = 1.00;
                        double pepperonicredits = 1.00;
                        double Credits = availableCredits - pepperonicredits - pepperonicredits;
                        Console.WriteLine("remaining credits: " + Credits);
                    }

                    else if (option2 == 4)
                    {
                        toppingsCredits = 0.50;
                        double olivescredits = 0.50;
                        double Credits = availableCredits - olivescredits - olivescredits;
                        Console.WriteLine("remaining credits: " + Credits);
                    }

                    else if (option2 == 5)
                    {
                        toppingsCredits = 0.60;
                        double pineapplecredits = 0.60;
                        double Credits = availableCredits - pineapplecredits - pineapplecredits;
                        Console.WriteLine("remaining credits: " + Credits);
                    }

                    else if (option2 == 6)
                    {
                        toppingsCredits = 1.20;
                        double cheesecredits = 1.20;
                        double Credits = availableCredits - cheesecredits - cheesecredits;
                        Console.WriteLine("remaining credits: " + Credits);
                    Console.WriteLine("..............................");
                    }

                    else
                    {
                        Console.WriteLine("WRONG INPUT!!!");
                    }

                double choice2 = toppingsCredits;
                //credits = availableCredits - choice2;

                    Console.WriteLine("available balance: " + credits);
                    Console.WriteLine(".............................");
                    Console.WriteLine("pizza price: " + (pizzaPrice + choice2 + choice2));
                }
                else if(Opt == 2)
                {
                    Console.WriteLine("available balance: " + credits);

                    Console.WriteLine("pizza price: " + (pizzaPrice + toppingsCredits));
             
                }

                break;
            }
            
     }
}

   

