using System;
using Xunit;
using AnagramNS;

namespace AnagramTestsNS
{
    public class AnagramTests
    {
        [Theory]
        [InlineData("seven", "neves")]
        [InlineData("1dr2ow3\n", "1wo2rd3\n")]
        [InlineData("", "")]
        [InlineData("first second third", "tsrif dnoces driht")]
        [InlineData(" 1 first  se2cond  third!    3 ", " 1 tsrif  dn2oces  driht!    3 ")]
        public void CanReverseString(string input, string expected)
        {
            var actual = Anagram.Reverse(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Reverse_WithNull()
        {
            //act
            Action act = () => Anagram.Reverse(null);
            //assert
            ArgumentException exception = Assert.Throws<ArgumentNullException>(act);
            Assert.Contains(Anagram.IsNullMessage, exception.Message);
        }
    }
}
