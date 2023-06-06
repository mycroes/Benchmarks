using BenchmarkDotNet.Attributes;
using System.Runtime.InteropServices;

namespace Benchmarks.Conversion
{
    public class Conversions
    {
        private WithExplicit withExplicit = new() { First = 1, Second = 2 };
        private WithImplicit withImplicit = new() { First = 1, Second = 2 };
        private WithFactory withFactory = new() {First = 1, Second = 2 };

        [Benchmark]
        public int FromExplicit()
        {
            return (int)withExplicit;
        }

        [Benchmark]
        public int FromImplicit()
        {
            return withImplicit;
        }

        [Benchmark]
        public int FromFactory()
        {
            return WithFactory.FromWithFactory(withFactory);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct WithExplicit
        {
            public byte First;
            public byte Second;

            public static explicit operator int(WithExplicit value)
            {
                return value.First + value.Second;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct WithImplicit
        {
            public byte First;
            public byte Second;

            public static implicit operator int(WithImplicit value)
            {
                return value.First + value.Second;
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct WithFactory
        {
            public byte First;
            public byte Second;

            public static int FromWithFactory(WithFactory value)
            {
                return value.First + value.Second;
            }
        }
    }
}
