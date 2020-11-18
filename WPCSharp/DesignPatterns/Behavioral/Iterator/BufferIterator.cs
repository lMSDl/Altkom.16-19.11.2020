﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Behavioral.Iterator
{
    public class BufferIterator<T> : IEnumerator<T[]>
    {
        private IEnumerator<T> _enumerator;
        private T _buffer;

        public BufferIterator(IEnumerable<T> enumerable)
        {
            _enumerator = enumerable.GetEnumerator();
            Reset();
        }

        public T[] Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator = null;
            Current = null;
            _buffer = default;
        }

        public bool MoveNext()
        {
            if(_enumerator.MoveNext())
            {
                Current = new[] { _buffer, _enumerator.Current };
                _buffer = _enumerator.Current;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            if (_enumerator.MoveNext())
            {
                _buffer = _enumerator.Current;
            }
            else
                _buffer = default;

            Current = new T[2];
        }
    }
}
