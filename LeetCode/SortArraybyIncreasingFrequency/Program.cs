using System;

namespace SortArraybyIncreasingFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int,int>();
            foreach (var n in nums)
            {
                if (!dict.ContainsKey(n))
                    dict.Add(n, 0);
                    
                dict[n]++;
            }
            
            return dict.OrderBy(d => d.Value).ThenByDescending(d => d.Key)
                .SelectMany(d => Enumerable.Repeat(d.Key, d.Value).ToArray()).ToArray();
        }
    }
}
