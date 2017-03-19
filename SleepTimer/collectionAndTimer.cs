using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepTimer
{
    static class collectionAndTimer
    {
        public static int[] hours = new int[24];
        public static int[] mins = new int[] { 0, 15, 30, 45 };
        static collectionAndTimer()
        {
            for (int i = 0; i < hours.Length; i++)
            {
                hours[i] = i;
            }
        }
    }
}
