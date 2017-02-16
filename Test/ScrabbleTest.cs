using Xunit;
using System;
using System.Collections.Generic;
using Scrabble.Objects;

namespace Scrabble
{
    public class ScrabbleTest
    {
        [Fact]
        public void MoveScore_EachLetterEqualsOne_aEquals1()
        {
            //Arrange
            ScrabbleApp testScrabble = new ScrabbleApp();

            //Act
            int testResult = testScrabble.MoveScore("a");

            //Accept
            Assert.Equal(1, testResult);
        }
        [Fact]
        public void MoveScore_EachLetterEqualsOne_aeEquals2()
        {
            //Arrange
            ScrabbleApp testScrabble = new ScrabbleApp();

            //Act
            int testResult = testScrabble.MoveScore("ae");

            //Accept
            Assert.Equal(2, testResult);
        }
        [Fact]
        public void MoveScore_EachLetterTotal_allPossibleEquals33()
        {
            //Arrange
            ScrabbleApp testScrabble = new ScrabbleApp();

            //Act
            int testResult = testScrabble.MoveScore("adbfkjq");

            //Accept
            Assert.Equal(33, testResult);
        }
    }
}
