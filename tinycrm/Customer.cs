using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace tinycrm
{
    public class Customer
    {
        public DateTime Created { get; private set; } //hmeromhnia eggrafhs
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string VatNumber { get; private set; }
        public string Phone { get; set; }
        public decimal TotalGross { get; private set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }

        public Customer(string vatNumber)
        {
            if (!IsValidVatNumber(vatNumber))
            {
                throw new Exception("Invalid VatNumber");
            }

            VatNumber = vatNumber;
            Created = DateTime.Now;

        }
        public bool IsValidVatNumber(string vatNumber)
        {
            return
                !string.IsNullOrWhiteSpace(vatNumber) &&
                vatNumber.Length == 9;
           

            /*vatNumber = vatNumber.Trim();

            if (vatNumber.Length != 9)
            {
                return false;
            }

            if (!int.TryParse(vat, out int number))
            {
                return false;
            }
            return true;*/
        }

        public bool IsAdult()
        {
            return Age >= 18 && Age < 100;
        }

        public bool IsValidEmail(string mail)
        {
            //var email = default(string);
            //var anInt = default(int);
            //var abool = default(bool);

            if (!string.IsNullOrWhiteSpace(mail))
            {
                mail = mail.Trim();

                if (mail.Contains("@") &&
                    (mail.EndsWith(".com") || mail.EndsWith(".gr")))
                {
                    return true;
                }
            }
            return false;

        }
    
    }



}
