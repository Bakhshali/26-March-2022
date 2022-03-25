using System;
using System.Collections.Generic;
using System.Text;

namespace TASK_2_25March
{
    internal class Student
    {
        public string _fullname;
        public string _groupNo;
        public byte Age;



        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (!CheckFullname(value))
                {
                    value = _fullname;
                }
            }
        }


        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (!CheckGroupNo(value))
                {
                    _fullname = value;
                }
            }
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length >= 4)
            {
                bool hasDigit = false;
                bool hasLower = false;

                foreach (char no in groupNo)
                {
                    if (char.IsDigit(no))
                    {
                        hasDigit = true;
                        continue;
                    }
                    if (char.IsLower(no))
                    {
                        hasLower= true;

                    }
                }
                bool result = hasDigit && hasLower;
                return result;
            }
            return false;

        }
        public static bool CheckFullname(string fullname)
        {
            int count = 0;

            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsUpper(fullname[i]) && i == 0)
                {
                    count++;
                }
                else if (char.IsWhiteSpace(fullname[i]))
                {
                    count++;

                    if (char.IsUpper(fullname[i + 1]))
                    {
                        count++;
                    }
                }
            }
            return count == 3 ? true : false;
        }

        public Student(string fulname, string groupno, byte age)
        {
            Fullname = fulname;
            GroupNo = groupno;
            Age = age;
        }
    }
}
