﻿using Eight.Kyuu.Added;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightKyu.Test.AddedTest
{
    public class NameOnBillboardTest
    {
        [Fact]

        public void ShouldReturnName()
        {
            var Actual = "Jeong-Ho Aristotelis";
            var expected = 600;

            var result = NameOnBillboard.Billboard(Actual);

            Assert.Equal(expected, result);

        }
    }
}
