using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
   public class Student : Person
    {
        public enum GradeLevels { Freshmen, Sophmore, Junior, Senoir}
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidental");
            return sb.ToString();
        }
    }
}
