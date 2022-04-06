using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class MyList<T>
    {
        public T[] nums;
        public MyList()
        {
            nums = new T[0];
        }
        public T this[int index]
        {
            get { return nums[index]; }
            set
            {
                nums[index] = value;
            }
        }

        internal void Resize(ref int[] numbers, int v)
        {
            throw new NotImplementedException();
        }

        private int[] _arr;
        private int _count;

        public int Capacity { get; set; }
        public int Count { get { return _count}  }

    }
}
