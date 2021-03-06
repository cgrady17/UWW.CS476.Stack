// <copyright file="StackTTest.cs">Copyright © Connor P Grady 2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UWW.CS476.Stack;

namespace UWW.CS476.Stack.Tests
{
    /// <summary>This class contains parameterized unit tests for Stack`1</summary>
    [PexClass(typeof(Stack<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StackTTest
    {
        /// <summary>Test stub for Clear()</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void ClearTest<T>([PexAssumeUnderTest]Stack<T> target)
        {
            target.Clear();
            PexAssert.IsTrue(target.Empty());
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public Stack<T> ConstructorTest<T>()
        {
            Stack<T> target = new Stack<T>();
            PexAssert.IsNotNull(target);
            return target;
            
        }

        /// <summary>Test stub for .ctor(Int32)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public Stack<T> ConstructorTest01<T>(int capacity)
        {
            Stack<T> target = new Stack<T>(capacity);
            PexAssert.IsNotNull(target);
            return target;
        }

        /// <summary>Test stub for Empty()</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public bool EmptyTest<T>([PexAssumeUnderTest]Stack<T> target)
        {
            bool result = target.Empty();
            return result;
            // TODO: add assertions to method StackTTest.EmptyTest(Stack`1<!!0>)
        }

        /// <summary>Test stub for Peek()</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public T PeekTest<T>([PexAssumeUnderTest]Stack<T> target)
        {
            T result = target.Peek();
            return result;
            // TODO: add assertions to method StackTTest.PeekTest(Stack`1<!!0>)
        }

        /// <summary>Test stub for Pop()</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public T PopTest<T>([PexAssumeUnderTest]Stack<T> target)
        {
            T result = target.Pop();
            return result;
            // TODO: add assertions to method StackTTest.PopTest(Stack`1<!!0>)
        }

        /// <summary>Test stub for Push(!0)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public T PushTest<T>([PexAssumeUnderTest]Stack<T> target, T item)
        {
            T result = target.Push(item);
            return result;
            // TODO: add assertions to method StackTTest.PushTest(Stack`1<!!0>, !!0)
        }

        /// <summary>Test stub for Size()</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public int SizeTest<T>([PexAssumeUnderTest]Stack<T> target)
        {
            int result = target.Size();
            return result;
            // TODO: add assertions to method StackTTest.SizeTest(Stack`1<!!0>)
        }
    }
}
