namespace Редактор_расписания.Scripts
{
    internal class Cabinet : Info
    {
        public CabinetType CabinetType;

        public Cabinet(string name, string description, CabinetType type, bool readOnly = false) 
            : base(name, description, DataType.Cabinet, readOnly)
        {
            CabinetType = type;
        }
    }
}
