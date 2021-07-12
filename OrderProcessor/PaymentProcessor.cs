using System;
using System.Collections.Generic;

namespace OrderProcessor
{
    public class PaymentProcessor : IObservable<Payment>
    {

        private List<IObserver<Payment>> _observers;
        private List<Payment> _payments;


        public PaymentProcessor()
        {
            _observers = new List<IObserver<Payment>>();
            _payments = payments;
        }
        public IDisposable Subscribe(IObserver<Payment> observer)
        {
            throw new NotImplementedException();
        }
    }
}
