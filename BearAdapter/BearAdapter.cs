using System;

namespace BearAdapter
{
    public class BearAdapter : IDog
    {
        private IBear bear;
        private Random random;

        public void Bark()
        {
            TryToggleHibernation();
            bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            TryToggleHibernation();
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            bear.TryEat(objectToFetch);
        }

        private void TryToggleHibernation()
        {
            if (random.NextDouble() < 0.2)
                bear.Hibernating = !bear.Hibernating;
        }

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
            random = new Random();
        }
    }
}