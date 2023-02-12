using Momentum.Math.Extensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests.Runtime.Momentum.Math.Extensions
{
    public struct NormalizeBetweenArguments
    {
        public float[] values;
        public float min;
        public float max;
        public float expected;
    }

    public class FloatExtensionsTest
    {
        [Test]
        public void TestNormalizeBetween([ValueSource("NormalizeBetweenProvider")] in NormalizeBetweenArguments args)
        {
            foreach (var value in args.values) {
                var result = value.NormalizeBetween(args.min, args.max);

                Assert.AreEqual(args.expected, result);
            }
        }

        public static IEnumerable<NormalizeBetweenArguments> NormalizeBetweenProvider()
        {
            return new NormalizeBetweenArguments[] {
                new NormalizeBetweenArguments {
                    values = new float[] { -26.0f, -16.0f, -6.0f, 4.0f, 14.0f, 24.0f },
                    min = 0.0f,
                    max = 10.0f,
                    expected = 4.0f
                },
                new NormalizeBetweenArguments {
                    values = new float[] { -26.0f, -16.0f, -6.0f, 4.0f, 14.0f, 24.0f },
                    min = 3.0f,
                    max = 13.0f,
                    expected = 4.0f
                },
                new NormalizeBetweenArguments {
                    values = new float[] { -26.0f, -16.0f, -6.0f, 4.0f, 14.0f, 24.0f },
                    min = -5.0f,
                    max = 5.0f,
                    expected = 4.0f
                },
                new NormalizeBetweenArguments {
                    values = new float[] { -26.0f, -16.0f, -6.0f, 4.0f, 14.0f, 24.0f },
                    min = -15.0f,
                    max = -5.0f,
                    expected = -6.0f
                },
                new NormalizeBetweenArguments {
                    values = new float[] { -26.0f, -16.0f, -6.0f, 4.0f, 14.0f, 24.0f },
                    min = -10.0f,
                    max = 0.0f,
                    expected = -6.0f
                }
            };
        }
    }
}
