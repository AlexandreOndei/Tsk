using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class PowSequence
    {
        private int times;

        public PowSequence(int times)
        {
            this.times = times;
        }

        public List<int[]> Get()
        {
            var list = new List<int[]>();
            for (int i = 0; i < times; i++)
            {
                Array sequence = Array.CreateInstance(typeof(int), times - i);
                for (int j = 0; j < sequence.Length; j++)
                {
                    sequence.SetValue(Convert.ToInt32(Math.Pow(j + 1, 2)), j);
                }
                list.Add(sequence.Cast<int>().Reverse().ToArray());
            }
            return list;
        }
    }
}
