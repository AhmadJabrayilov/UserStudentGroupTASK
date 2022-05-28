using System;
using System.Collections.Generic;
using System.Text;

namespace Uzun_Task_tekrar.Models
{
    internal class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }
        private int _point;
        public int Point
        {
            get { return _point; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }

        public Student(string fullname,int point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id} / Fullname: {Fullname}");
        }

    }
}
