using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace tinycrm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                var dskiada = new Customer("123456789");
                dskiada.VatNumber = "123456";
                dskiada.IsValidVatNumber();
                dskiada.IsValidEmail();

            } catch (Exception ex) {
            Console.WriteLine($"(ex.Message)");
            }*/

            string filePath = @"C:\Users\Διαμάντω\Desktop\Text.txt";

            string[] lines = File.ReadAllLines(filePath);

            foreach(string i in lines)
            {
                /* (!IsNotNullOrWhiteSpaceOrDouble())
                {

                }*/
                Console.WriteLine(i);
            }


        }

        public static bool IsNotNullOrWhiteSpaceOrDouble(string lines)
    }
}
