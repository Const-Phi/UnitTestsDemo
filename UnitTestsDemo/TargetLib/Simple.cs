using System.Linq;

namespace TargetLib
{
    public class Simple
    {
        public int Add(int first, int second) => first + second;

        internal int Mul(int first, int second) => first * second;

        public object Test(int count)
        {
            var result = Enumerable.Range(0, count)
                .Select(x => new { Input = x, Output = x * x })
                .ToList();

            return result;
        }
    }
}
