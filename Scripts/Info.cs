using System;

namespace Редактор_расписания.Scripts
{
    internal abstract class Info
    {
        public string Name;
        public string Description;
        protected bool _readOnly;
        private Guid _guid;
        private DataType _type;

        public bool ReadOnly => _readOnly;
        public string ListBoxName => Name;
        public Guid Guid => _guid;
        public DataType Type => _type;

        public Info(string name, string descriotion = "", DataType type = DataType.CabinetType, bool readOnly = false)
        {
            Name = name;
            Description = descriotion;
            _type = type;
            _guid = Guid.NewGuid();
            _readOnly = readOnly;
            s_Storage.AddItem(this);
        }
    }
}
