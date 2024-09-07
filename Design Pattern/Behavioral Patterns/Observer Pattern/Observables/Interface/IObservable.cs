using Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observers;

namespace Design_Pattern.Behavioral_Patterns.Observer_Pattern.Observables
{
    internal interface IObservable
    {
        public void Add(IObserver observer);

        public void Remove(IObserver observer);

        public void Notify();
    }
}