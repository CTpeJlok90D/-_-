namespace Редактор_расписания.Scripts
{
    internal abstract class Info
    {
        private string _name;
        private string _description;
        protected DataType _type;

        public string Name => _name;
        public string Description => _description;
        public DataType Type => _type;

        public Info(string name, string descriotion, DataType type)
        {
            _name = name;
            _description = descriotion;
            _type = type;
            s_Storage.AddItem(this);
        }
    }
}
