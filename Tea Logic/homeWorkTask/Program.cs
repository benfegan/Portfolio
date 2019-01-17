using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int teaMilkSugar = 0;
            int teaMilk = 0;
            int teaSugar = 0;
            int inputtedUser = 0;

            do
            {
                Console.WriteLine("These are the drinks that we have on offer");
                Console.WriteLine("1: Tea and Milk and Sugar");
                Console.WriteLine("2: Tea and Milk and No Sugar");
                Console.WriteLine("3: Tea and No Milk and Sugar");
                Console.WriteLine("4: QUIT!");
                Console.WriteLine("Please enter the drink that you would like");
                inputtedUser = Convert.ToInt32(Console.ReadLine());

                switch (inputtedUser)
                {
                    case 1:
                        teaMilkSugar++;
                        Console.WriteLine("You have selected Tea and Milk and Sugar, there has currently been " + teaMilkSugar + " orders the same as yours");
                        break;
                    case 2:
                        teaMilk++;
                        Console.WriteLine("You have selected Tea and Milk and No Sugar, there has currently been " + teaMilk + " orders the same as yours");
                        break;
                    case 3:
                        teaSugar++;
                        Console.WriteLine("You have selected Tea and No Milk and Sugar, the has currently been " + teaSugar + " orders the same as yours");
                        break;
                }   
           }
                while (inputtedUser != 4);
        }
    }
}
