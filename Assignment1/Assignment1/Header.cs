using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*/
 * The Header Class
 * *****************
 * This is the main area that the header is kept, seperate from the rest of the application.
 * Allows to easily display the header where it is needed.
 * ***************
 */

namespace Assignment1
{
    public class Header
    {
        public static void mainHeader()
        {
            //Draws out the look of the header.
            Console.WriteLine("│──────────────────────────────────────────────────────────────────│");          
            Console.WriteLine("│                                                                  │");
            Console.WriteLine("│                            Assignment 1                          │");
            Console.WriteLine("│                                                                  │");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────│");
            Console.WriteLine("│                 Welcome to my telephone directory                │");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────│");

            //Used to name the application instead of being called the path of where the application was saved followed by Assignment1.vshost.exe.
            Console.Title = "Telephone Directory";
        }
 
    }
}
