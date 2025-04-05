using System;
namespace Homework
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string _studentName, string _topic,string _textbookSection, string _problems) : base(_studentName,_topic)
        {
            this._textbookSection = _textbookSection;
            this._problems = _problems;
        }
        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}