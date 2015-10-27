using System;
using System.Runtime.Remoting.Messaging;

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
        private readonly int _capacity;

        /// <summary>
        /// Initializes a new instance of <c>Stack</c> with the default capacity.
        /// </summary>
        public Stack()
        {
            _data = new T[DefaultSize];
            _capacity = DefaultSize;
        }

        /// <summary>
        /// Initializes a new instance of <c>Stack</c> with the specified capacity.
        /// </summary>
        /// <param name="capacity">The number of elements to allow in the Stack.</param>
        public Stack(int capacity)
        {
            _data = new T[capacity];
            _capacity = capacity;
        }

        /// <summary>
        /// Removes and returns the top element in the Stack.
        /// </summary>
        /// <exception cref="EmptyStackException">Thrown when the Stack is empty.</exception>
        /// <returns>The top element in the Stack.</returns>
        public T Pop()
        {
            if (_numberOfElements == 0)
            {
                throw new EmptyStackException("The Stack is empty.");
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
        /// <exception cref="FullStackException">Thrown when the Stack is full.</exception>
        /// <returns>The element that was added to the Stack.</returns>
        public T Push(T item)
        {
            if (_numberOfElements == _data.Length)
            {
                throw new FullStackException("The Stack is full.");
            }

            // Add the item to the first element in the array
            _data[_numberOfElements + 1] = item;
            _numberOfElements++;

            return _data[_numberOfElements];
        }

        /// <summary>
        /// Retrieves the top element in the Stack.
        /// </summary>
        /// <exception cref="EmptyStackException">Thrown when the Stack is empty.</exception>
        /// <returns>The top element in the Stack.</returns>
        public T Peek()
        {
            if (_numberOfElements == 0)
            {
                throw new EmptyStackException("The Stack is empty.");
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
            _data = new T[_capacity];
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

    /// <summary>
    /// Exception representing a condition where a Stack is empty.
    /// </summary>
    public class EmptyStackException : Exception
    {
        public EmptyStackException()
        {
            
        }

        public EmptyStackException(string message)
            : base(message)
        {
            
        }
    }

    /// <summary>
    /// Exception representing a condition where a Stack is full.
    /// </summary>
    public class FullStackException : Exception
    {
        public FullStackException()
        {
            
        }

        public FullStackException(string message)
            : base(message)
        {
            
        }
    }
}