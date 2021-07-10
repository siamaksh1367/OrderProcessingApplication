using System;

namespace OrderProcessor
{
    public class OrderEventArgs : EventArgs
    {
        public OrderEventArgs(Order order)
        {
        }
    }
}