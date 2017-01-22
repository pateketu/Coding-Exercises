using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Tests
{
    public class BinaryGapTests
    {
        [Fact]
        public void GetBinaryGap()
        {
            BinaryGap binrBinaryGap = new BinaryGap();
           int gap = binrBinaryGap.GetBinaryGap(0);
            Assert.Equal(0,gap);

        }
    }
}
