using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode;
            string lang;
            string choice;
            do
            {
                Console.WriteLine("Enter Country Code");
                cCode = Console.ReadLine();
                switch (cCode)
                {
                    case "uk":
                        {
                            lang = "English";
                            break;
                        }
                    case "af":
                        {
                            lang = "Dari,Pashto";
                            break;
                        }
                    case "in":
                        {
                            lang = "Hindi,English,Tamil,Telgu,Punjabi";
                            break;
                        }
                    case "uae":
                    case "ksa":
                    case "om":
                        {
                            lang = "Arabic";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Sorry!! Your Country{cCode}is not in ourDb");
                            lang = "Not Found!!!";
                            break;
                        }


                }
                Console.WriteLine("Country Code" + cCode + " " + "Language(s)" + lang);
                Console.WriteLine("Do you wanna continue if yes press y \n To exit pres any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
        }

    }
}
