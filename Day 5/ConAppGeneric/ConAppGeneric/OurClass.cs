using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGeneric
{
    public class OurClass<T, U>
    {
        T fieldOne;
        U fieldTwo;

        public void SetInfo(T fieldOne, U fieldTwo)
        {
            this.fieldOne = fieldOne;
            this.fieldTwo = fieldTwo;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Field One Stored Value: \t" + fieldOne + "\t Data Type: \t"+fieldOne.GetType());
            Console.WriteLine("Field Two Stored Value: \t" + fieldTwo + "\t Data Type: \t" + fieldTwo.GetType());
        }
    }
}
