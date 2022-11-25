using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingObjectsWorksheet
{
    internal class Quiz
    {
        //public string StudentName { get; set; }
        private string _studentName;

        private int _total;
        private int _mark;
        private int _weight;

        public string StudentName
        {
            get
            {
                return _studentName;
            }
            set
            {
                // Validate that the new value is not an empty string or a string with only whitespaces (space, tab)
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("StudentName is required");
                }
                // Validate that the new value contains at minimum 3 characters in length
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException("StudentName must contain at minimum 3 characters");
                }
                _studentName = value.Trim();
            }
        }

        public int Total
        {
            get => _total;
            set => _total = value;
        }
        public int Mark
        {
            get => _mark;
            set => _mark = value;
        }
        public int Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public Quiz(int Mark, int Total, int Weight, string StudentName)
        {
            this.Mark = Mark;
            this.Total = Total;
            this.Weight = Weight;
            this.StudentName = StudentName;
        }

        public double GetPercentage()
        {
            // return ((double) Mark / Total) * 100;
            return ((double) _mark / _total) * 100;
        }
    }
}
