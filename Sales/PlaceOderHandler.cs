using System;
using System.Threading;
using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Sales
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        private static ILog log = LogManager.GetLogger<PlaceOrderHandler>();
        static Random random = new Random();

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");

            // This is normally where some business logic would occur

            Thread.Sleep(500);

            //if(random.Next(0,5)==0)
            //    throw new Exception("Oops");


            var orderPlaced = new OrderPlaced
            {
                OrderId = message.OrderId
            };
            return context.Publish(orderPlaced);
        }
    }




}
