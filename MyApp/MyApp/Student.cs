using System;

namespace MyApp
{
    class Student
    {
        int id;
        string givenName;
        string surname;
        enrollmentStatus status;
        DateTime startDate, endDate, graduationDate;
    }
}

enum enrollmentStatus
{
    New,
    Active,
    Dropout,
    Graduated
}