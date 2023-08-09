using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConaAppSealedEx
{
    internal class AppDev : Dev
    {
        string osType;
        public AppDev(int id, string name, string project, string osType) : base(id, name, project)
        {
            this.osType = osType;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("OSType:\t"+osType);
        }
    }
}
