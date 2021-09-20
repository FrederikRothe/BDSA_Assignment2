using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateStudentOutputToStringFormat()
        {
            Student s = new Student(200,"John","Doe",enrollmentStatus.Active, new DateTime(2020,1,1),new DateTime(2023,1,1),new DateTime());
            
            var expected = "#200 - John Doe Active 01.01.2020 00.00.00 - 01.01.2023 00.00.00";

            var actual  = s.toString();
            Console.WriteLine(actual);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateTwoImmutableStudentAndCheckIfEqual_True()
        {
            ImmutableStudent first = new ImmutableStudent(200,"John","Doe",enrollmentStatus.Active, new DateTime(2020,1,1),new DateTime(2023,1,1),new DateTime());
            
            ImmutableStudent second = new ImmutableStudent(200,"John","Doe",enrollmentStatus.Active, new DateTime(2020,1,1),new DateTime(2023,1,1),new DateTime());

            Assert.True(first == second);
        }

        [Fact]
        public void CreateImmutableStudentAndCheckToString()
        {
            ImmutableStudent first = new ImmutableStudent(200,"John","Doe",enrollmentStatus.Active, new DateTime(2020,1,1),new DateTime(2023,1,1),new DateTime());
            
            var expected = "#200 - John Doe Active 01.01.2020 00.00.00 - 01.01.2023 00.00.00";

            var actual  = first.toString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CompareImmutableStudentAndStudentToString()
        {
            Student first = new Student(200,"John","Doe",enrollmentStatus.Active, new DateTime(2020,1,1),new DateTime(2023,1,1),new DateTime());
            
            ImmutableStudent second = new ImmutableStudent(200,"John","Doe",enrollmentStatus.Active, new DateTime(2020,1,1),new DateTime(2023,1,1),new DateTime());
            
            var expected = "#200 - John Doe Active 01.01.2020 00.00.00 - 01.01.2023 00.00.00";
            
            var actualFromFirst  = first.toString();
            var actualFromSecond  = second.toString();

            Assert.Equal(expected, actualFromFirst);
            Assert.Equal(expected, actualFromSecond);
        }
    }
}
