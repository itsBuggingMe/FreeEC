using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeEC
{
    public struct FastStack<T>(int initalComponents = 4) : IEnumerable<T>
    {
        private T[] _buffer = new T[initalComponents > 0 ? initalComponents : throw new ArgumentException()];
        private int _nextIndex = 0;

        public readonly T Top => _buffer[_nextIndex - 1];
        public readonly bool HasElements => _nextIndex >= 0;
        public readonly ref T this[int i] => ref _buffer[i];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Push(T comp)
        {
            if ((uint)_nextIndex < (uint)_buffer.Length)
            {
                _buffer[_nextIndex++] = comp;
            }//i think this avoids extra bounds check
            else
            {
                Array.Resize(ref _buffer, _buffer.Length * 2);
                _buffer[_nextIndex++] = comp;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Pop() => _buffer[--_nextIndex];

        public void RemoveAtReplace(int index)
        {
            _buffer[index] = _buffer[--_nextIndex];
            _buffer[_nextIndex] = default!;
        }

        /// <summary>
        /// DO NOT ALTER WHILE SPAN IS IN USE
        /// </summary>
        public readonly Span<T> AsSpan() => new(_buffer, 0, (int)_nextIndex);

        public void Clear()
        {
            if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
                AsSpan().Clear();
            _nextIndex = 0;
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        //foreach uses this as from duck typing
        public FastStackEnumerator GetEnumerator() => new FastStackEnumerator(this);

        //Enumerator for convience
        //slightly slower than using span, and still not safe with modifying stack (needs to be class in order to do that)
        public struct FastStackEnumerator(FastStack<T> stack) : IEnumerator<T>
        {
            private T[] _elements = stack._buffer;
            private int _max = stack._nextIndex;
            private int _index = -1;
            public readonly T Current => _elements[_index];
            readonly object? IEnumerator.Current => _elements[_index];
            public void Dispose() => _elements = null!;
            public bool MoveNext() => ++_index < _max;
            public void Reset() => _index = -1;
        }
    }
}
