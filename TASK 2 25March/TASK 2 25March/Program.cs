using System;

namespace TASK_2_25March
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string groupNo;
            string fullname;
            

            do
            {

                Console.WriteLine("Please Enter GroupNo \n");

                groupNo = Console.ReadLine();

            } while (!CheckGroupNo(groupNo));

            do
            {
                Console.WriteLine("Please Enter Fullname \n");

                fullname = Console.ReadLine();

            } while (!CheckFullname(fullname));

            
            

        }



        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length <=
                4)
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
                        hasLower = true;

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
    }

    
    
}


