﻿using System;
using System.Collections.Generic;
using System.Text;

using Binance.Serialization;

namespace Binance
{
    [FormData]
    public class Order
    {
        [FormField(Name = "symbol")]
        public String Symbol { get; set; }

        [FormField(Name = "side")]
        public OrderSide? Side { get; set; }

        [FormField(Name = "type")]
        public OrderType? Type { get; set; }

        [FormField(Name = "timeInForce")]
        public TimeInForce? TimeInForce { get; set; }

        public decimal? Quantity { get; set; }

        [FormField(Name = "quantity")]
        public String QuantityStr
        {
            get
            {
                if (Quantity == null)
                    return null;
                else
                    return ((decimal)Quantity).ToString("G29");
            }
        }

        public decimal? Price { get; set; }

        [FormField(Name = "price")]
        public String PriceStr
        {
            get
            {
                if (Price == null)
                    return null;
                else
                    return ((decimal)Price).ToString("G29");
            }
        }

        [FormField(Name = "newClientOrderId")]
        public String NewClientOrderId { get; set; }

        public decimal? StopPrice { get; set; }

        [FormField(Name = "stopPrice")]
        public String StopPriceStr
        {
            get
            {
                if (StopPrice == null)
                    return null;
                else
                    return ((decimal)StopPrice).ToString("G29");
            }
        }

        public decimal? IcebergQuantity { get; set; }

        [FormField(Name = "icebergQty")]
        public String IcebergQuantityStr
        {
            get
            {
                if (IcebergQuantity == null)
                    return null;
                else
                    return ((decimal)IcebergQuantity).ToString("G29");
            }
        }

        [FormField(Name = "newOrderRespType")]
        public OrderResponseType? OrderResponseType { get; set; }

        [FormField(Name = "recvWindow")]
        public long? RecvWindow { get; set; }

        [FormField(Name = "timestamp")]
        public long? Timestamp { get; set; }

        public override string ToString()
        {
            return FormDataSerializer.Serialize(this);
        }
    }
}
