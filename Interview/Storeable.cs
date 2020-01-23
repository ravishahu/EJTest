using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Storeable <T> : IStoreable<T> 
    {
        private T _t;
        public T Id { get => _t; set => _t=value; }
    }
}
