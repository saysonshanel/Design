using ActivityFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating the Order/Product details
            OrderDetails orderDetails = new OrderDetails("C# Design Pattern Book", "Simplified book on design patterns in   C#", 500.0F, 10.0F, "Street No 1", "Educational Area", 1212, "4156213754");

            //Create each Subsystem Object Accordingly and call the commented functions passing
            //appropirate info

            // Client Code without Facade.

            // Updating the inventory.
            // IInventor.Update(productno);

            // Verfying various details for the order such as the shipping address.
            // IOrderVerify.VerifyShippingAddress(PinCode);



            // Calculating the final cost after applying various discounts.
            // orderDetails.Price = ICosting.ApplyDiscounts(Price, DiscountPercent);

            // Going through various steps if payment gateway like card verification, charging from  the card.
            //IPaymentGateway.VerifyCardDetails(CardNo);
            // IPaymentGateway.ProcessPayment(CardNo, Price);

            // Completing the order by providing Logistics.
            //ILogistics.ShipProduct(ProductName, string.Format("{0}, {1} - {2}.",AddressLine1, AddressLine2,PinCode));
            OnlineShoppingFacade facade = new OnlineShoppingFacade();
            facade.finalizeOrder(orderDetails);
        }
    }
}
