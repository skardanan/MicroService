using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Framework
{
    public abstract class ValueObject
    {
        private const int HighPrime = 8987;
        protected abstract IEnumerable<Object> GetAtomicValues();
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
