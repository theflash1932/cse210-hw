using System;

namespace Homework
{
    public class MathAssignment : Assignment
    {
        string _textbookSection;
        string _problems;
        public MathAssignment(string name, string topic, string section, string problem)
            : base(name, topic)
        {
            _textbookSection = section;
            _problems = problem;
        }
        public string GetHomeworkList()
        {
            return ("${_textbookSection} {_problems}");
        }
    }
}