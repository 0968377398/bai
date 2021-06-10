namespace EX1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MobilePhone mobilePhone = new MobilePhone();
            mobilePhone.PhoneName = "Oppo";
            mobilePhone.PhoneType = "mobile";
            mobilePhone.PhonePrice = 1500;
            mobilePhone.display();

            Phone phone = new Phone();
            phone.PhoneName = "Ip";
            phone.PhoneType = "phone";
            phone.PhonePrice = 4000;
            phone.display();
        }
    }
}