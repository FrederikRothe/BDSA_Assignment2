using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Student s = new Student(200,"John","Doe",enrollmentStatus.Active, new DateTime(2020,1,1),new DateTime(2023,1,1),new DateTime());
            
            var expected = "#" + s.id + " - " + s.givenName + " " + s.surname + " " + s.status + " " + s.startDate + " - " + s.endDate;
            
            var actual  = s.toString();

            Assert.Equal(expected, actual);
        }
    }
}
