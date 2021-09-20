using System;

namespace MyApp
{
    public class Student
    {
        public int id {get; init;}
        public string givenName {get; set;}
        public string surname {get; set;}
        public enrollmentStatus status {get; init;}
        public DateTime startDate {get; set;}
        public DateTime endDate {get; set;}
        public DateTime graduationDate {get; set;}

        public Student(int id, string givenName, string surname, enrollmentStatus status, DateTime startDate, DateTime endDate, DateTime graduationDate) {
            this.id  = id;
            this.givenName = givenName;
            this.surname = surname;
            this.status = status;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;     
        }
        
        public string toString() {
            return "#" + id + " - " + givenName + " " + surname + " " + status + " " + startDate + " - " + endDate;
        }
    }

    public record ImmutableStudent
    {
        public int id {get; init;}
        public string givenName {get; init;}
        public string surname {get; init;}
        public enrollmentStatus status {get; init;}
        public DateTime startDate {get; init;}
        public DateTime endDate {get; init;}
        public DateTime graduationDate {get; init;}

        public ImmutableStudent(int id, string givenName, string surname, enrollmentStatus status, DateTime startDate, DateTime endDate, DateTime graduationDate) {
            this.id  = id;
            this.givenName = givenName;
            this.surname = surname;
            this.status = status;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;     
        }

        public string toString() {
            return "#" + id + " - " + givenName + " " + surname + " " + status + " " + startDate + " - " + endDate;
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

