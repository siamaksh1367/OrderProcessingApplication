using System;
using System.Collections.Generic;

namespace OrderProcessor
{
    public abstract class GeneralObservable<T> : IObservable<T>
    {

        private List<IObserver<T>> _observers;

        public GeneralObservable(List<IObserver<T>> observers) : this()
        {
            if (observers != null)
            {
                _observers = observers;
                foreach (var observer in _observers)
                    Subscribe(observer);
            }
        }
        public GeneralObservable()
        {
            if (_observers == null)
                _observers = new List<IObserver<T>>();
        }
        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        protected virtual void Process(T t)
        {
            foreach (var observer in _observers)
                if (t != null)
                    observer.OnNext(t);
        }

        protected virtual void ProcessFinished()
        {
            foreach (var observer in _observers)
                observer.OnCompleted();
            _observers.Clear();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<T>> _observers;
            private IObserver<T> _observer;

            internal Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
