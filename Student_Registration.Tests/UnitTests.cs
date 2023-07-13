namespace Student_Registration.Tests
{
    public class UnitTests
    {
       

        [Fact]
        public void Should_Return_Correct_Grade_For_Mark()
        {
            // Arrange
            var calculator = new GradeCalculator();
            var mark = 64;

            // Act
            var grade = calculator.Grade(mark);

            // Assert
            Assert.Equal("B+", grade);
        }

        [Fact]
        public void Should_Return_Correct_Point_For_Mark()
        {
            // Arrange
            var calculator = new PointCalculator();
            var mark = 43;

            // Act
            var point = calculator.point(mark);

            // Assert
            Assert.Equal(2, point);
        }
    }

    public class GradeCalculator
    {
        public string Grade(int mark)
        {
            string p = " ";
            if (mark < 25)
            {
                p = "E";
            }
            else if (mark >= 25 && mark < 30)
            {
                p = "D";
            }
            else if (mark >= 30 && mark < 35)
            {
                p = "D+";
            }
            else if (mark >= 35 && mark < 40)
            {
                p = "C-";
            }
            else if (mark >= 40 && mark < 45)
            {
                p = "C";
            }
            else if (mark >= 45 && mark < 50)
            {
                p = "C+";
            }
            else if (mark >= 50 && mark < 55)
            {
                p = "B-";
            }
            else if (mark >= 55 && mark < 60)
            {
                p = "B";
            }
            else if (mark >= 60 && mark < 65)
            {
                p = "B+";
            }
            else if (mark >= 65 && mark < 70)
            {
                p = "A-";
            }
            else if (mark >= 70 && mark < 85)
            {
                p = "A";
            }
            else
            {
                p = "A+";
            }
            return p;
        }
    }

    public class PointCalculator
    {
        public double point(int mark)
        {
            double p = 0;
            if (mark < 25)
            {
                p = 0;
            }
            else if (mark >= 25 && mark < 30)
            {
                p = 1;
            }
            else if (mark >= 30 && mark < 35)
            {
                p = 1.3;
            }
            else if (mark >= 35 && mark < 40)
            {
                p = 1.7;
            }
            else if (mark >= 40 && mark < 45)
            {
                p = 2;
            }
            else if (mark >= 45 && mark < 50)
            {
                p = 2.3;
            }
            else if (mark >= 50 && mark < 55)
            {
                p = 2.7;
            }
            else if (mark >= 55 && mark < 60)
            {
                p = 3;
            }
            else if (mark >= 60 && mark < 65)
            {
                p = 3.3;
            }
            else if (mark >= 65 && mark < 70)
            {
                p = 3.7;
            }
            else
            {
                p = 4;
            }
            return p;
        }



    }
}