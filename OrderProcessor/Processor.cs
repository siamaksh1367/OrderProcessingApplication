using System;
using System.Collections.Generic;

namespace OrderProcessor
{

    public abstract class MidProcessor<T,S> where T : EventArgs where S : EventArgs 
    {
        public MidProcessor()
        {

        }
        public event EventHandler<S> Process;
        public abstract void GetCalled(object sender, T t);


        protected virtual void OnProcessed(S s)
        {
            Process?.Invoke(this, s);
        }
    }

    public abstract class FinishProcessor<T> where T : EventArgs 
    {
        public FinishProcessor()
        {

        }
        public abstract void GetCalled(object sender, T t);
    }

    public abstract class StartingProcessor<T> where T : EventArgs 
    {
        public StartingProcessor()
        {

        }
        public event EventHandler<T> Process;
        protected virtual void OnProcessed(T t)
        {
            Process?.Invoke(this, t);
        }
    }
}