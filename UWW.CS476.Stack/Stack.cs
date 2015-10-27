using System;

namespace UWW.CS476.Stack
{
    /// <summary>
    /// Represents a last-in, first-out fixed-length data collection.
    /// </summary>
    /// <typeparam name="T">The type of the collection elements.</typeparam>
    public class Stack<T>
    {
        private T[] _data;
        private const int DefaultSize = 20;
        private int _numberOfElements = 0;

        /// <summary>
        /// Initializes a new instance of <c>Stack</c> with the default capacity.
        /// </summary>
        public Stack()
        {
            _data = new T[DefaultSize];
        }

        /// <summary>
        /// Initializes a new instance of <c>Stack</c> with the specified capacity.
        /// </summary>
        /// <param name="capacity">The number of elements to allow in the Stack.</param>
        public Stack(int capacity)
        {
            _data = new T[capacity];
        }

        /// <summary>
        /// Removes and returns the first element in the Stack.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the Stack is empty.</exception>
        /// <returns>The first element in the Stack.</returns>
        public T Pop()
        {
            if (_numberOfElements == 0)
            {
                throw new InvalidOperationException("The Stack is empty.");
            }

            T item = Peek();

            // Remove item from _data
            _data[_numberOfElements] = default(T);
            _numberOfElements--;

            return item;
        }

        /// <summary>
        /// Add the specified element to the top of the Stack.
        /// </summary>
        /// <param name="item">The element to add to the Stack. The value can be <c>null</c> for reference types.</param>
        /// <returns>The element that was added to the Stack.</returns>
        public T Push(T item)
        {
            if (_numberOfElements == _data.Length)
            {
                throw new InvalidOperationException("The Stack is full.");
            }

            // Add the item to the first element in the array
            _data[_numberOfElements + 1] = item;
            _numberOfElements++;

            return _data[_numberOfElements];
        }

        /// <summary>
        /// Retrieves the first (top) element in the Stack.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the Stack is empty.</exception>
        /// <returns>The first (top) element in the Stack.</returns>
        public T Peek()
        {
            if (_numberOfElements == 0)
            {
                throw new InvalidOperationException("The Stack is empty.");
            }

            return _data[0];
        }

        /// <summary>
        /// Gets a 32-bit integer that represents the total number of elements on the Stack.
        /// </summary>
        /// <returns>32-bit integer representing the total number of elements on the Stack.</returns>
        public int Size()
        {
            return _numberOfElements;
        }

        /// <summary>
        /// Empties the Stack of all elements.
        /// </summary>
        public void Clear()
        {
            int length = _data.Length;
            _data = new T[length];
        }

        /// <summary>
        /// Specifies whether the Stack is empty.
        /// </summary>
        /// <returns>Boolean specifying whether the Stack is empty.</returns>
        public bool Empty()
        {
            return _numberOfElements < 1;
        }
    }
}