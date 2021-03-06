using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
    class MyStack <T>
    {
        Stack<T> stack;

        public MyStack()
        {
            this.stack = new Stack<T>();
        }

        public int Count()
        {
            return stack.Count;
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public void Push(T value)
        {
            stack.Push(value);
        }
    }
}
