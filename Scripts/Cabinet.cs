namespace Редактор_расписания.Scripts
{
    internal class Cabinet : Info
    {
        private CabinetType _cabinetType;

        public CabinetType CabinetType => _cabinetType;

        public Cabinet(string name, string description, CabinetType type) 
            : base(name, description, DataType.Cabinet)
        {
            _cabinetType = type;
        }
    }
}
