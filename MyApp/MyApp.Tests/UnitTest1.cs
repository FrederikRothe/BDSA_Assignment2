using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateStudentOutputToStringFormat()
        {
            Student s = new Student(200, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), new DateTime(2023, 1, 1));

            var expected = "#200 - John Doe Active 01.01.2020 00.00.00 - 01.01.2023 00.00.00";

            var actual = s.toString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateStudentAndCheckEnrollmentStatus_New()
        {
            Student s = new Student(200, "John", "Doe", DateTime.Now.AddDays(-10), new DateTime(2023, 1, 1), new DateTime(2023, 1, 1));

            var expected = "#200 - John Doe New " + DateTime.Now.AddDays(-10) + " - 01.01.2023 00.00.00";

            var actual = s.toString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateStudentAndCheckEnrollmentStatus_Dropout()
        {
            Student s = new Student(200, "John", "Doe", new DateTime(2020, 1, 1), DateTime.Now.AddDays(-10), new DateTime(2023, 1, 1));

            var expected = "#200 - John Doe Dropout 01.01.2020 00.00.00 - " + DateTime.Now.AddDays(-10);

            var actual = s.toString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateStudentAndCheckEnrollmentStatus_Graduated()
        {
            Student s = new Student(200, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), DateTime.Now.AddDays(-10));

            var expected = "#200 - John Doe Graduated 01.01.2020 00.00.00 - 01.01.2023 00.00.00";

            var actual = s.toString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateTwoImmutableStudentAndCheckIfEqual_True()
        {
            ImmutableStudent first = new ImmutableStudent(200, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), new DateTime(2023, 1, 1));

            ImmutableStudent second = new ImmutableStudent(200, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), new DateTime(2023, 1, 1));

            Assert.True(first == second);
        }

        [Fact]
        public void CreateImmutableStudentAndCheckToString()
        {
            ImmutableStudent first = new ImmutableStudent(200, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), new DateTime(2023, 1, 1));

            var expected = "#200 - John Doe Active 01.01.2020 00.00.00 - 01.01.2023 00.00.00";

            var actual = first.toString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareImmutableStudentAndStudentToString()
        {
            Student first = new Student(200, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), new DateTime(2023, 1, 1));

            ImmutableStudent second = new ImmutableStudent(200, "John", "Doe", new DateTime(2020, 1, 1), new DateTime(2023, 1, 1), new DateTime(2023, 1, 1));

            var expected = "#200 - John Doe Active 01.01.2020 00.00.00 - 01.01.2023 00.00.00";

            var actualFromFirst = first.toString();
            var actualFromSecond = second.toString();

            Assert.Equal(expected, actualFromFirst);
            Assert.Equal(expected, actualFromSecond);
        }
    }
}
