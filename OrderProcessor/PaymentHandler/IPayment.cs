﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor
{
    public interface IPayment
    {
        void ProcessPayment(PaymentDto paymentDto);
    }

    
}
