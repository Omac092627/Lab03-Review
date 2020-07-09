using System;
using Xunit;
using static SystemIO.Program;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
     
        
        
            [Fact]
            public void CanReturnZero()
            {
                //arrange
                string input = "This is a string";
                //act
                int outputFromMethod = canReturnInputNumber(input);
                //assert
                Assert.Equal(0, outputFromMethod);
            }

        }
    }

