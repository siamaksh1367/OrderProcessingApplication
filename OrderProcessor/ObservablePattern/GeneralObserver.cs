using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor
{

    public abstract class GeneralObserver<T> : IObserver<T>
    {
        private IDisposable _unsubscrivber = null;

        public void Subscribe(IObservable<T> provider)
        {
            if (provider != null)
            {
                _unsubscrivber = provider.Subscribe(this);
            }
        }
        public virtual void OnCompleted()
        {
            Console.WriteLine("Process is completed");
            Unscubscribe();
        }

        public virtual void OnError(Exception error)
        {
            throw error;
        }

        public abstract void OnNext(T value);

        public void Unscubscribe()
        {
            if (_unsubscrivber != null)
                _unsubscrivber.Dispose();
        }
    }
}
