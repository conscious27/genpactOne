using System;

namespace ExerciseOne
{
    public class HerbalProduct : Product
    {
        string herbsUsed;
        DateTime mfDate;
        DateTime expDate;

        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter the Herbs Used: ");
            herbsUsed = Console.ReadLine();
            Console.WriteLine("Enter the Manufacturing Date: ");
            mfDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Expiry Datew: ");
            expDate = DateTime.Parse(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Herbs Used:\t" + herbsUsed + "\nManufacturing Date:\t" + mfDate +
                "\nExpiry Date:\t" + expDate);
        }
    }
}