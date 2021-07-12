﻿using System;
using System.Collections.Generic;

namespace OrderProcessor
{
    public class UpgradeMembershipPayment : GeneralPayment
    {
        public UpgradeMembershipPayment(List<IObserver<PaymentDto>> observers) : base(observers)
        {
        }

        public override void ProcessPayment(PaymentDto paymentDto)
        {
            System.Console.WriteLine("Payment Process");
            Process(paymentDto);
        }
    }
}
