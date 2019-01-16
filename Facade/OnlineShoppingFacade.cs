using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityFacade
{
    class OnlineShoppingFacade
    {
        CostManager costManager;
        InventoryManager inventoryManager;
        LogisticsManager logManager;
        PaymentGatewayManager paymentGatewayManager;
        OrderVerificationManager orderVerifyManager;
        public OnlineShoppingFacade()
        {
            this.costManager = new CostManager();
            this.inventoryManager = new InventoryManager();
            this.logManager = new LogisticsManager();
            this.paymentGatewayManager = new PaymentGatewayManager();
            this.orderVerifyManager = new OrderVerificationManager();
        }

        public void finalizeOrder(OrderDetails orderDetail)
        {
            inventoryManager.Update(orderDetail.ProductNo);
            orderVerifyManager.VerifyShippingAddress(orderDetail.PinCode);
            orderDetail.Price = costManager.ApplyDiscounts(orderDetail.Price, orderDetail.DiscountPercent);
            paymentGatewayManager.VerifyCardDetails(orderDetail.CardNo);
            paymentGatewayManager.ProcessPayment(orderDetail.CardNo, orderDetail.Price);
            logManager.ShipProduct(orderDetail.ProductName, string.Format("{0}, {1} - {2}.", orderDetail.AddressLine1, orderDetail.AddressLine2, orderDetail.PinCode));
        }
    }
}
