using System;

namespace PersonInfoApp.Models
{
    public class FutureBirthDateException : Exception
    {
        public FutureBirthDateException()
            : base("Date of birth cannot be in the future.")
        { }

        public FutureBirthDateException(string message)
            : base(message)
        { }
    }

    public class TooOldBirthDateException : Exception
    {
        public TooOldBirthDateException()
            : base("Date of birth is too old. We process only alive people :/")
        { }

        public TooOldBirthDateException(string message)
            : base(message)
        { }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException()
            : base("Wrong email address.")
        { }

        public InvalidEmailException(string message)
            : base(message)
        { }
    }
}
