using System;

namespace FizzBuzz
{
    public abstract class Filter
    {
        private Filter _nextFilter;

        public String GetValue(int number) {
            return Verify(number) ? Results(number) : _nextFilter.GetValue(number);
        }

        public abstract String Results(int number);

        public abstract bool Verify(int number);

        public void SetNextFilter(Filter nextFilter)
        {
            this._nextFilter = nextFilter;
        } 
    }
}