﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UWW.CS476.Stack
{
    [TestFixture]
    public class StackTest
    {
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop()
        {
            Stack<int> stack = new Stack<int>();
            int item = stack.Pop();
        }
    }
}
