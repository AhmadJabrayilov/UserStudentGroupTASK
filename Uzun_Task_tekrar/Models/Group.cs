using System;
using System.Collections.Generic;
using System.Text;

namespace Uzun_Task_tekrar.Models
{
    internal class Group
    {
        public string GroupNo { get; set; }
        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                }
            }
        }
        private Student[] Students = new Student[0];

        public Group(string grouno, int studentLimit)
        {
            GroupNo = grouno;
            StudentLimit = _studentLimit;
        }

        //public bool CheckGroupNo(string groupno)
        //{
        //    bool hasNumber = false;

        //    bool hasUpper = false;

        //    for (int i = 0; i < groupno.Length; i++)
        //    {
        //        if (char.IsUpper(groupno[0]))
        //        {
        //            hasUpper = true;
        //        }
        //        if (char.IsUpper(groupno[1]))
        //        {
        //            hasUpper = true;
        //        }
        //        if (char.IsNumber(groupno[i]))
        //        {
        //            hasNumber = true;
        //        }
        //    }
        //    return true;
        //}

        public void AddStudent(Student student)
        {
            if (Students.Length == StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
        }
        public void GetStudent(int? id)
        {
            foreach (var item in Students)
            {
                if (id == item.Id)
                {
                    item.StudentInfo();
                }
            }

        }
        public Student[] GetAllStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }
            return Students;
        }
    }
}
