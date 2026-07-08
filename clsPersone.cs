using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windosformATM
{
    internal class clsPersone
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Phone { get; set; }


        public clsPersone(string firstname, string lastname, string phone)
        {
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;

        }
        //public string proFirstName
        //{
        //    get { return FirstName; }
        //    set { FirstName = value; }
        //}
        //public string proLastName
        //{
        //    get { return LastName; }
        //    set {LastName = value; }
        //}
        //public string proPhone
        //{
        //    get { return Phone; }
        //    set { Phone = value;
        //}
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
    

