using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticApp.Models
{
    class Person
    {
        private string firstname;
        private string middleName;
        private string lastName;

        public Person()
        {

        }
        //public Person(string firstName, string lastName)
        //{
        //    this.firstname = firstname;
        //    this.lastName = lastName;
        //}
        //public Person(string firstName, string middleName, string lastName)
        //{
        //    this.firstname = firstname;
        //    this.middleName = middleName;
        //    this.lastName = lastName;
        //}

        //public string FirstName { set; get; }
        //public string MiddleName { set; get; }
        //public string LastName { set; get; }
        public string GetMyFullName()
        {
            return firstname +" "+ middleName +" "+ lastName;
        }
        public string GetMyReverseName()
        {
            string reverseName = "";
            string fullName = GetMyFullName();
            for (int index =fullName.Length -1; index >=0; index--)
            {
                reverseName += fullName[index];
            }
            return reverseName;
        }        
    }
}
