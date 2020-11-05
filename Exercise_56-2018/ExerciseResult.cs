using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_56_2018
{
    class ExerciseResult
    {
        public ExerciseResult()
        {
        }

        public ExerciseResult(int id, string studentName, string studentIndex, int points)
        {
            Id = id;
            StudentName = studentName;
            StudentIndex = studentIndex;
            Points = points;
        }

        public int Id { get; private set; }
        public string StudentName { get; private set; }
        public string StudentIndex { get; private set; }
        public int Points { get; private set; }

        public override string ToString()
        {
            return $"{Id} {StudentName} {StudentIndex} {Points}";
        }
    }
}
