using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AccountRegistration
{

    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);


    class StudentInfoClass
    {

        public static string FirstName, LastName, MiddleName, Address, Program = " ";
        public static long Age, ContactNo, StudentNo = 0;

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }

        public static string GetLastName(string LastName)
        {
            return LastName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }

        public static string GetAddress(string Address)
        {
            return Address;
        }

        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }

        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }

        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }


    }
}
