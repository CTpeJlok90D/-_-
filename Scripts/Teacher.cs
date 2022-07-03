using System;

namespace Редактор_расписания.Scripts
{
    internal class Teacher : Info
    {
        private bool[] _workweek;

        public bool[] WorkWeek => _workweek;

        public Teacher(string name, string descriotion) : base(name, descriotion, DataType.Teacher)
        {
            _workweek = new bool[] {true,true,true,true,true,false,false};
        }
        public Teacher(string name, string descriotion, bool[] workweek) : base(name, descriotion, DataType.Teacher)
        {
            _workweek = workweek;
        }
    }
}
