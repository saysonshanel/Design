using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    interface IPaymentGateway
    {
        bool VerifyCardDetails(string cardNo);
        bool ProcessPayment(string cardNo, float cost);
    }


    class PaymentGatewayManager : IPaymentGateway
    {
        public bool VerifyCardDetails(string cardNo)
        {
            Console.WriteLine(string.Format("Card# {0} has been verified and is accepted.", cardNo));
            return true;
        }

        public bool ProcessPayment(string cardNo, float cost)
        {
            Console.WriteLine("Card# "+ cardNo + " is used to make a payment of  "+cost);
           return true;
        }
    }
}
