using System;

namespace StudentAttendance
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public bool HasSixOrMore()
        {
            bool hasSix;
            if (Scores.Length >= 6)
            {
                hasSix = true;
            }
            else
            {
                hasSix = false;
            }
            return hasSix;
   
        
        }
    }
}