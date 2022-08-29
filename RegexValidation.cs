using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public  class RegexValidation
    {
       
         // public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z}{3}$";
       
        
        //   public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z}{3}$";

       


        //public static string EMAIL_REGEX = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$";



        //public static string MOBILENUMBER_REGEX = "^[91][0-9]{10}$";


        public static string PASSWORD_REGEX = "^[A-Za-z0-9]{8}$";


        //public bool ValidateFirstName()
        //{
        //    return Regex.IsMatch("Teju", FIRST_NAME_REGEX);
        //}

        //public bool ValidateLasttName()

        //{
        //    return Regex.IsMatch("Mate", LAST_NAME_REGEX);
        // }


        // public bool ValidateEmail()
        //{
        //    return Regex.IsMatch("jyotidhage10@gmail.com", EMAIL_REGEX);
        // }



        // public bool ValidateMobilenumber()
        //{
        //    return Regex.IsMatch("919673683178", MOBILENUMBER_REGEX);
        //}

        public bool ValidatePassword()
        {
            return Regex.IsMatch("Aradhy@1", PASSWORD_REGEX);
        }


//    }
//}
