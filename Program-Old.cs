using System;

namespace psswdgen
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("a or n or a&n&s aka:1 2 or 3");
            var functionans = Console.ReadLine();
            if(functionans == "1")
            {
            while (true == true)
            {
            //Console.Clear();
            var passwordlength = Console.ReadLine();
            Console.Clear();
            if (passwordlength == null)
            {
                throw new ArgumentNullException("error \n no value");
                Environment.Exit(0);
            }
            int x = Int32.Parse(passwordlength);
            if (passwordlength == "lambda")
            {
                System.Console.WriteLine("7A11");
            }
            if (x >= 1000000000)
            {
                throw new ArgumentNullException("stop");
                Environment.Exit(0);
            }
            else
            {    
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$";
                var stringChars = new char[x];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                System.Console.WriteLine(finalString);
            }    
            }
            }
            if(functionans == "2")
            {
            while (true == true)
            {
            //Console.Clear();
            var passwordlength = Console.ReadLine();
            Console.Clear();
            if (passwordlength == null)
            {
                throw new ArgumentNullException("error \n no value");
                Environment.Exit(0);
            }
            int x = Int32.Parse(passwordlength);
            if (passwordlength == "lambda")
            {
                System.Console.WriteLine("7A11");
            }
            if (x >= 1000000000)
            {
                throw new ArgumentNullException("stop");
                Environment.Exit(0);
            }
            else
            {    
                var chars = "0123456789";
                var stringChars = new char[x];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                System.Console.WriteLine(finalString);
            }    
            }
            }
            if(functionans == "3")
            {
            while (true == true)
            {
            //Console.Clear();
            var passwordlength = Console.ReadLine();
            Console.Clear();
            if (passwordlength == null)
            {
                throw new ArgumentNullException("error \n no value");
                Environment.Exit(0);
            }
            int x = Int32.Parse(passwordlength);
            if (passwordlength == "lambda")
            {
                System.Console.WriteLine("7A11");
            }
            if (x >= 1000000000)
            {
                throw new ArgumentNullException("stop");
                Environment.Exit(0);
            }
            else
            {    
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$";
                var stringChars = new char[x];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                System.Console.WriteLine(finalString);
            }    
            }
            }
        }
    }
}
