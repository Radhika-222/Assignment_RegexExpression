using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_13
{
    public class Program
    {
        public void Count()
        {
            Console.WriteLine("enter a text to count number of words in it");
            string text = Console.ReadLine();
            int count = Regex.Matches(text, @"\b\w+\b").Count;
            Console.WriteLine("total words in the text is " + count);
        }
        public void Email()
        {
            Console.WriteLine("enter email");
            string mail = Console.ReadLine();
            string pattern = @"[a-z0-9._%+-]+@[a-z0-9]+\.[a-z]{2,4}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("valid email");
            }
            else
            {
                Console.WriteLine("invaild email");
            }
        }
        public void Mobile()
        {
            Console.WriteLine("Enter your mobile number e.g.+918678456534");
            string mobile = Console.ReadLine();
            string pattern = @"^\+\d{12}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mobile))
            {
                Console.WriteLine($"Valid mobile number {mobile}");
            }
            else
            {
                Console.WriteLine($"Invalid  mobile {mobile}!!!");

            }
           

        }

        
        public void CustomRegexSearch()
        {
            Console.WriteLine("Enter your custom regex:");
            string customRegex = Console.ReadLine();
            //string input = "Hello, 123 World";
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(customRegex))
            {
                Console.WriteLine($"Found:{customRegex}");
            }
            else
            {
                Console.WriteLine($"Not found:{customRegex}");
            }
        }

       
        static void Main(string[] args)
        {
            Program counting = new Program();
            counting.Count();

            Program email = new Program();
            email.Email();


            Program number = new Program();
            number.Mobile();
            Console.ReadKey();

            Program customRegex = new Program();
            customRegex.CustomRegexSearch();
            Console.ReadKey();

            

        }
    }
}

