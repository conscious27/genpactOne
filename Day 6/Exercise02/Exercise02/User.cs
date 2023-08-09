using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class User
    {
        string name;
        string email;
        string password;

        public void Register()
        {
            try
            {

                Console.WriteLine("Enter the name:");
                name = Console.ReadLine();
                if(name.Length < 6)
                {
                    throw new ValidationException("Name must be greater than 6 words!");
                }
                Console.WriteLine("Enter the email:");
                email = Console.ReadLine();
                Console.WriteLine("Enter the Password: ");
                password = Console.ReadLine();
                if (password.Length < 6)
                {
                    throw new ValidationException("Password must be greater than 6 words!");
                }
            }
            catch(ValidationException ve)
            {
                Console.WriteLine("Validation Exception! "+ve.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Format Exception! "+fe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR! "+ex.Message);
            }
            finally
            {
                Console.WriteLine("******************");
            }
        }

    }
}
