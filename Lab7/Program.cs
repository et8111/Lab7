using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        public static bool NameVal()
        {
            Console.Write("ENTER NAME: ");
            string name = Console.ReadLine();
            if (!Regex.IsMatch(name, @"^[a-zA-Z]{0,30}$"))
            {
                Console.WriteLine("Invalid Name Format.");
                NameVal();
            }
            return true;
        }

        public static bool EmailVal()
        {
            Console.Write("ENTER EMAIL: ");
            string email = Console.ReadLine();
            bool flag = Regex.IsMatch(email, @"^[A-Za-z0-9@]{5,30}.{3}[.a-z]$");
            if (!email.Contains("@"))
            {
                Console.WriteLine("Invalid Email Address Format.");
                EmailVal();
            }
            if (!email.Contains("."))
            {
                Console.WriteLine("Invalid Email Address Format.");
                EmailVal();
            }
            if (email.IndexOf('.') >= email.Length - 4 && email.IndexOf('.') <= email.Length - 3)
                flag = true;
            else
            {
                Console.WriteLine("Invalid Email Address Format.");
                EmailVal();
            }
            return true;
        }

        public static bool PhoneVal()
        {
            Console.Write("PHONE: ");
            string phone = Console.ReadLine();
            if (!Regex.Match(phone, @"\d\d\d-\d\d\d-\d\d\d\d$").Success)
            {
                Console.WriteLine("Invalid Phone Number Format.");
                PhoneVal();
            }
            return true;
        }
        
        public static bool DateVal()
        {
            Console.Write("WHENS YOUR BIRTHDAY: ");
            string date = Console.ReadLine();
            if (!Regex.Match(date, @"\d\d/\d\d/\d\d\d\d$").Success)
            {
                Console.WriteLine("Invalid Birthday Format.");
                DateVal();
            }
            return true;
        }

        static void Main(string[] args)
        {
            NameVal();
            Console.WriteLine();
            EmailVal();
            Console.WriteLine();
            PhoneVal();
            Console.WriteLine();
            DateVal();
            Console.WriteLine("\n HELL YEAH");
        }
    }
}
