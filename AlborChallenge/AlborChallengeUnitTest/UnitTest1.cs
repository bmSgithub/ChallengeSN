using AlborChallenge;

namespace AlborChallengeUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestNoShape()
        {
            Assert.Equal("There are no shapes", Shapes.PrintInformation(new List<Shapes>()));
        }

        [Fact]
        public void TestSquare()
        {
            List<Shapes> shapes = new List<Shapes>()
            {
                new Shapes("Square", 4)
            };
            string result = "The area of the square is : 16 and the perimeter is: 16<br/>";
            Assert.Equal(result, Shapes.PrintInformation(shapes));
        }

        [Fact]
        public void TestTwoSquare()
        {
            List<Shapes> shapes = new List<Shapes>()
            {
                new Shapes("Square", 4),
                new Shapes("Square", 5)
            };
            string result = "The area of the square is : 16 and the perimeter is: 16<br/>The area of the square is : 25 and the perimeter is: 20<br/>";
            Assert.Equal(result, Shapes.PrintInformation(shapes));
        }

        [Fact]
        public void TestManyForms()
        {
            List<Shapes> shapes = new List<Shapes>()
            {
                new Shapes("Square", 4),
                new Shapes("Circle", 2),
                new Shapes("Square", 5),
                new Shapes("EquilateralTriangle", 5),
                new Shapes("Circle", 3),
                new Shapes("Circle", 2)
            };
            string result = "The area of the square is : 16 and the perimeter is: 16<br/>The area of the circle is : 3,14 and the perimeter is: 6,28<br/>The area of the square is : 25 and the perimeter is: 20<br/>The area of the triangle is : 10,83 and the perimeter is: 15<br/>The area of the circle is : 7,07 and the perimeter is: 9,42<br/>The area of the circle is : 3,14 and the perimeter is: 6,28<br/>";
            Assert.Equal(result, Shapes.PrintInformation(shapes));
        }
    }
}