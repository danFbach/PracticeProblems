using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Problem4
    {
        public List<int> LongList;

        

        public void RotateToRight()
        {
            LongList = new List<int>();
            LongList.Add(1);
            LongList.Add(2);
            LongList.Add(3);
            LongList.Add(4);
            LongList.Add(5);
            LongList.Add(6);
            LongList.Add(7);
            LongList.Add(8);
            LongList.Add(9);

            int listLength = LongList.Count;

            LongList.Insert(0, listLength);
            LongList.RemoveAt(listLength);

            LongList.Insert(0, listLength);
            LongList.RemoveAt(listLength);

            for(int i = 0;i < listLength;i++)
            {
                LongList[i] += 5;
            }

        }


    }
}
