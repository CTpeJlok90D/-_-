namespace Редактор_расписания.Scripts
{
    internal class CabinetType : Info
    {
        public CabinetType(string name, string descriotion, bool readOnly = false) 
            : base(name, descriotion, DataType.CabinetType, readOnly)
        {

        }
    }
}
