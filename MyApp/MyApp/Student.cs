using System;

namespace MyApp
{
    public class Student
    {
        public int id { get; init; }
        public string givenName { get; set; }
        public string surname { get; set; }
        public enrollmentStatus status { get; init; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime graduationDate { get; set; }

        public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.status = selectStatus(startDate, endDate, graduationDate);
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;
        }

        public string toString()
        {
            return "#" + id + " - " + givenName + " " + surname + " " + status + " " + startDate + " - " + endDate;
        }

        public enrollmentStatus selectStatus(DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            if (graduationDate < DateTime.Now)
            {
                return enrollmentStatus.Graduated;
            }
            else if (endDate < DateTime.Now)
            {
                return enrollmentStatus.Dropout;
            }
            else if (startDate >= DateTime.Now.AddDays(-14))
            {
                return enrollmentStatus.New;
            }
            else
            {
                return enrollmentStatus.Active;
            }
        }
    }

    public record ImmutableStudent
    {
        public int id { get; init; }
        public string givenName { get; init; }
        public string surname { get; init; }
        public enrollmentStatus status { get; init; }
        public DateTime startDate { get; init; }
        public DateTime endDate { get; init; }
        public DateTime graduationDate { get; init; }

        public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surname = surname;
            this.status = selectStatus(startDate, endDate, graduationDate);
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;
        }

        public string toString()
        {
            return "#" + id + " - " + givenName + " " + surname + " " + status + " " + startDate + " - " + endDate;
        }

        public enrollmentStatus selectStatus(DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            if (graduationDate < DateTime.Now)
            {
                return enrollmentStatus.Graduated;
            }
            else if (endDate < DateTime.Now)
            {
                return enrollmentStatus.Dropout;
            }
            else if (startDate >= DateTime.Now.AddDays(-14))
            {
                return enrollmentStatus.New;
            }
            else
            {
                return enrollmentStatus.Active;
            }
        }
    }
}
public enum enrollmentStatus
{
    New,
    Active,
    Dropout,
    Graduated
}

