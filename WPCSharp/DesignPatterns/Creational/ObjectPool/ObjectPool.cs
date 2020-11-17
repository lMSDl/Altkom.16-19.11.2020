using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public class ObjectPool<T>
    {
        private ICollection<T> _freeObjects = new List<T>();
        private ICollection<T> _objects = new List<T>();

        public ObjectPool(int size, Func<T> createFunc)
        {
            for (int i = 0; i < size; i++)
            {
                _freeObjects.Add(createFunc());
            }
        }

        public T Acquire()
        {
            var @object = _freeObjects.Take(1).SingleOrDefault();
            if(@object != null)
            {
                _freeObjects.Remove(@object);
                _objects.Add(@object);
            }
            return @object;
        }

        public void Release(T @object)
        {
            _objects.Remove(@object);
            _freeObjects.Add(@object);
        }
    }
}
