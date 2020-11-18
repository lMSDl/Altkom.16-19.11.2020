using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Iterator
{
    public class Buffer<T> : IEnumerable<T[]>
    {
        private IEnumerable<T> _enumerable;

        public Buffer(IEnumerable<T> enumerable)
        {
            _enumerable = enumerable;
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            return new BufferIterator<T>(_enumerable);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
