namespace ExampleCICD.Test
{
    public class AdderTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(0, 123, 123)]
        [InlineData(-5, -4, -9)]
        public void Test1(int x, int y, int expectedResult)
        {
            var adder = new Adder();
            int result = adder.Add(x, y);

            Assert.True(result == expectedResult);
        }
    }
}