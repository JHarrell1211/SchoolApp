using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }


        //abstract method, has to be used
        public abstract float ComputeGradeAverage();

        //virtual method
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ", ");
            sb.AppendLine(message);
            return sb.ToString();
        }

    }
}
