using System;

namespace EX1
{
    public class Phone
    {
        public string PhoneName { get; set; }
        public string PhoneType { get; set; }
        public float PhonePrice { get; set; }

        public void display()
        {
            Console.WriteLine($"Name: {PhoneName}, type:  {PhoneType}, price: {PhonePrice}");
        }
    }
    }
    