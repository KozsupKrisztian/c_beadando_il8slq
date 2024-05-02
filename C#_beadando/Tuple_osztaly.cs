using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__beadando
{
    internal class Tuple_osztaly
    {

        private List<Tuple<string, int, bool, double>> tuples;

        public Tuple_osztaly()
        {
            tuples = new List<Tuple<string, int, bool, double>>();
        }

        public int Count => tuples.Count;

        public void FillData()
        {
            // Feltöltés a példa kedvéért
            for (int i = 0; i < 20; i++)
            {
                tuples.Add(new Tuple<string, int, bool, double>($"Item {i}", i, i % 2 == 0, i * 1.5));
            }
        }

        public Tuple<string, int, bool, double> GetFirstTupleValues()
        {
            return tuples[0];
        }

        public Tuple<string, int, bool, double> GetLastTupleValues()
        {
            return tuples[tuples.Count - 1];
        }

        public bool GetThirdElementOfSecondTuple()
        {
            return tuples[1].Item3;
        }

        public bool ContainsItem(string item)
        {
            foreach (var tuple in tuples)
            {
                if (tuple.Item1 == item)
                    return true;
            }
            return false;
        }

        public double GetMaxValue()
        {
            double max = double.MinValue;
            foreach (var tuple in tuples)
            {
                if (tuple.Item4 > max)
                    max = tuple.Item4;
            }
            return max;
        }

        public Tuple<string, int, bool, double> this[int index]
        {
            get { return tuples[index]; }
            set { tuples[index] = value; }
        }

        public void ProcessTuple<T1, T2, T3, T4>(Tuple<T1, T2, T3, T4> tuple)
        {
            Console.WriteLine($"Tuple item 1: {tuple.Item1}");
            Console.WriteLine($"Tuple item 2: {tuple.Item2}");
            Console.WriteLine($"Tuple item 2: {tuple.Item3}");
            Console.WriteLine($"Tuple item 2: {tuple.Item4}");
        }

    }
}

