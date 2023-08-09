using System;


namespace ConAppCustomExc
{
    public class OurCustomEx : Exception
    {
        public OurCustomEx(string msg):base(msg) { } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            try
            {
                Console.WriteLine("Enter Age: ");
                userAge = int.Parse(Console.ReadLine());

                if(userAge < 0)
                {
                    throw new OurCustomEx("Invalid Age! Age Must be a positive number");
                }
                else if(userAge >= 18)
                {
                    Console.WriteLine("User is eligible for voting!");
                }
                else
                {
                    Console.WriteLine("Not Eligible for voting");
                }
            }
            catch(OurCustomEx e)
            {
                Console.WriteLine("Custom Exception: "+e.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Format Exception: "+fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
