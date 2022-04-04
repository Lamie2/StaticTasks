
using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTask2
{
    class Student
    {
        
        public byte Age { get; set; }

        string _fullname;

        string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }                                
            }
        }

        public string Fullname
        {
            get => _fullname;
            set
            {
                if (CheckFullname(value))
                {
                    _fullname = value;
                }
            }
        }

        internal static bool CheckGroupNo(Student student1)
        {
            throw new NotImplementedException();
        }

        internal static bool CheckFullname(object fullName)
        {
            throw new NotImplementedException();
        }

        public static bool CheckFullname(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Contains(" "))
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int index = name.IndexOf(' ');
                    if (char.IsUpper(name[0]) && char.IsUpper(name[index+1]))
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("Fullname Formati, ad +bosluq+soyad seklinde olmalidir ");
            return false;
           
        }


        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1]) &&
                        char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]))
            {
                return true;
            }
            Console.WriteLine("GroupNo memberi ardicil olarag bir boyuk herf ve 3 regemli bir natural ededden ibaret olmalidir");
            return false;
            
        }


    }
}
