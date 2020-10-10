using System;

namespace MicroService.Shoping.Framework
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
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
