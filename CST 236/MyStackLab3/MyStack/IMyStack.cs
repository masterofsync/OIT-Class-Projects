using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public interface IMyStack<T>
    {

        void Push(T element);

        T Pop();
        T Top();
        int Size();
        void Clear();
    }
}
