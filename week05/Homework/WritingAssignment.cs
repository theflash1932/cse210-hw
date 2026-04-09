using System;

namespace Homework
{
    public class WritingAssignment : Assignment
    {
        string _title;
        public WritingAssignment(string name, string topic, string section, string problem, string title)
            : base(name, topic)
        {
            _title = title;
        }
        public string GetWritingInformation()
        {
            return _title;
        }
    }
}