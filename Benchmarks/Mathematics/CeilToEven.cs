using BenchmarkDotNet.Attributes;

namespace Benchmarks.Mathematics
{
    public class CeilToEven
    {
        [ParamsSource(nameof(ValueParameters))]
        public int Value { get; set; }

        public IEnumerable<int> ValueParameters => Enumerable.Range(1, 5);

        [Benchmark(Baseline = true)]
        public int IfModuloTwoIsOneAddOne()
        {
            if (Value % 2 == 1) return Value + 1;

            return Value;
        }

        [Benchmark]
        public int IfBitIsSetAddOne()
        {
            if ((Value & 1) == 1) return Value + 1;

            return Value;
        }

        [Benchmark]
        public int NoBranch()
        {
            return Value + (Value & 1);
        }
    }
}
