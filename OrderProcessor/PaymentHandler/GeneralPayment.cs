﻿using System;
using System.Collections.Generic;

namespace OrderProcessor
{
    public abstract class GeneralPayment : GeneralObservable<PaymentDto>, IPayment
    {
        protected GeneralPayment(List<IObserver<PaymentDto>> observers) : base(observers)
        {
        }

        public abstract void ProcessPayment(PaymentDto paymentDto);
    }
}
