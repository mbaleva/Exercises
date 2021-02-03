using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(Stack<string> elements)
        {
            while (elements.Count!=0)
            {
                this.Push(elements.Pop());
            }
        }
    }
}
