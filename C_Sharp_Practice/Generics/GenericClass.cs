using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericClass<T>
    {
        private T data;

        public GenericClass(T val) 
        { 
            data = val;
        }

        public T GetData()
        {
            return data;
        }
    }
}
