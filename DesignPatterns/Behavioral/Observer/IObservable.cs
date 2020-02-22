﻿namespace DesignPatterns.Behavioral.Observer
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
    }
}
