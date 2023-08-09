using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingExampleThree
{
    //Delegate
    class OrderEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    class Order
    {
        public event EventHandler<OrderEventArgs>Created;

        public void Create(string oName, string Email,  string Phone)
        {
            Console.WriteLine($"Order for {oName} has/have been placed");
            if(Created != null)
            {
                Created(this,new OrderEventArgs { Email = Email, Phone = Phone });
            }
        }
    }

    class Email
    {
        public static void send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send an Email to {e.Email}");
        }
    }

    class SMS
    {
        public static void send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send an SMS to {e.Phone}");
        }
    }
}
