using System;
using Xunit;
using Transform;
using System.Collections.Generic;
using System.Linq;

namespace Transform.Tests
{
    public class TransformNumbers
    {
        [Fact]
        public void ShouldSquareTheNumbers()
        {
            int[] numbers = new int[] { 1, 2, 3, 5 };
            int[] doubled = numbers.Map(x => x * 2).ToArray();
            int[] expected = new int[] { 2, 4, 6, 10 };
            Assert.Equal(doubled, expected);
        }
    }
}
