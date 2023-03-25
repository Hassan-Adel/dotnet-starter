using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace dotnet_task.Tests
{
    public class SampleTeststs
    {
        [Fact]
        public void SampleTest()
        {
            // Arrange
            var value1 = 2;
            var value2 = 3;

            // Act
            var result = value1 + value2;

            // Assert
            Assert.Equal(5, result);
        }
    }
}