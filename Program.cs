namespace UserRegistrationProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            RegexValidation regexValidation = new RegexValidation();

           // bool validResult1 = regexValidation.ValidateFirstName();

           //bool validResult2 = regexValidation.ValidateLastName();

           // bool validResult3 = regexValidation.ValidateEmail();

          //  bool validResult4 = regexValidation.ValidateMobilenumber();

            bool validResult5 = regexValidation.ValidatePassword();

           // Console.WriteLine("firstname"+ " " +validResult1);

            //Console.WriteLine("lastname" + " " + validResult2);

           // Console.WriteLine("Email" + " " + validResult3);

           //Console.WriteLine("mobileNumber" + " " + validResult4);

            Console.WriteLine("password" + " " + validResult5);

        }
    }
}
