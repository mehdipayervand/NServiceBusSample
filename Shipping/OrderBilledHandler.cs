﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace Shipping
{
    class OrderBilledHandler : IHandleMessages<OrderBilled>
    {
        private static ILog log = LogManager.GetLogger<OrderBilledHandler>();
        
        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            log.Info($"Shipping.OrderBilledHandler Received OrderBilled, OrderId = {message.OrderId}  - Should we ship now?");

            return Task.CompletedTask;
        }
    }
}
