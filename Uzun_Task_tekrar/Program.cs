using System;
using Uzun_Task_tekrar.Models;

namespace Uzun_Task_tekrar
{
    internal class Program
    {
        public static bool CheckGroupNo(string groupno)
        {
            bool hasNumber = false;

            bool hasUpper = false;

            for (int i = 0; i < groupno.Length; i++)
            {
                if (char.IsUpper(groupno[0]))
                {
                    hasUpper = true;
                }
                if (char.IsUpper(groupno[1]))
                {
                    hasUpper = true;
                }
                if (char.IsNumber(groupno[i]))
                {
                    hasNumber = true;
                }
                else
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {

            Group group = null;
            string groupno;
            int studentLimit;

            Console.WriteLine("Input Fullname");
            string usFname = Console.ReadLine();

            Console.WriteLine("input Email");
            string usEmail = Console.ReadLine();

            User user1 = new User(usFname, usEmail);


            Console.WriteLine("select");
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Create new group");

            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    user1.ShowInfo();
                    break;
                case 2:
                    {
                        Console.WriteLine("Create new group");
                        do
                        {
                            Console.WriteLine("input group no");
                            groupno = Console.ReadLine();

                            Console.WriteLine("input student limit ");
                            studentLimit = int.Parse(Console.ReadLine());

                            Group group1 = new Group(groupno, studentLimit);

                        } while (!CheckGroupNo(groupno));

                    }
                    break;
            }
        }
    }
}
