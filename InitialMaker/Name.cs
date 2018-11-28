using System;

namespace InitialMaker
{
    public struct Name
    {
        //private variables
        private string _firstName;
        private string _middleName;
        private string _lastName;

        //constructor sets first, middle, and last to private variables
        public Name(string first, string middle, string last)
        {
            this._firstName = first;
            this._middleName = middle;
            this._lastName = last;
        }

        //first name property
        public string FirstName
        {
            get => _firstName;
            set
            {
                FirstName = _firstName;
            }
        }

        //middle name property
        public string MiddleName
        {
            get => _middleName;
            set
            {
                MiddleName = _middleName;
            }
        }

        //last name property
        public string LastName
        {
            get => _lastName;
            set
            {
                LastName = _lastName;
            }
        }

        //override ToString() to determine format that we want to display the name and initials
        public override string ToString()
        {
            return (String.Format("{0} {1} {2}", _firstName, _middleName, _lastName));
        }

        //create user initials from first letter of first middle and last name
        public string Initials()
        {
            return (String.Format("{0}{1}{2}", _firstName.Substring(0, 1),
                _middleName.Substring(0, 1), _lastName.Substring(0, 1)));
        }
    }
}
