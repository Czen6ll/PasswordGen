using System;
namespace psswdgen
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true == true){
            
            ulong passwordlength = 0;
            int passwordoption = 0;
            string endQuery = "";
            Console.Clear();
            
            int fine = 0;
            while(fine == 0){
                
                Console.WriteLine("Select an option    1:Numbers + ABS's + Special    2:ABC's    3:Numbers");
                string temp;
                temp = Console.ReadLine();
                
                if (temp == "1" | temp == "2" | temp == "3"){
                    passwordoption = Convert.ToByte(temp);
                    fine = 1;
                }
                else{
                    Console.WriteLine("Invalid Input");
                    fine = 0;    
                }
            }
            
            System.Console.WriteLine("How long do you want your passwords?");
            if(endQuery == ""){
                passwordlength = Convert.ToUInt64(Console.ReadLine());
            }

            if(passwordlength >= 18446744073709551615){
                while(passwordlength >= 18446744073709551615){
                System.Console.WriteLine("Please set a shorter length.     < 18,446,744,073,709,551,616");
                passwordlength = Convert.ToUInt64(Console.ReadLine());
                }
            }
            
            var chars = "";
            switch (passwordoption){
                    case 1:
                        chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$";
                        break;
                    case 2:
                        chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                        break;
                    case 3:
                        chars = "0123456789";
                        break;
            }  
            
            Console.WriteLine(Gen(chars, passwordlength));
            Console.ReadLine();
            }
        }

        static string Gen(string chars, ulong passwordlength){
            
            var stringChars = new char[passwordlength];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++){
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return finalString;
        }
    }
}
