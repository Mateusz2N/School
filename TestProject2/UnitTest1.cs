using System;
using Xunit;
using SchoolOffice;

namespace TestProject2
{
    public class UczniowieTests
    {
        [Fact]
        public void Uczniowie_Testing_String()
        {
            var Uczniowie = new Uczniowie();

            Uczniowie.ToString();

            Assert.Equal(Uczniowie, Uczniowie);
        }

    }
}
