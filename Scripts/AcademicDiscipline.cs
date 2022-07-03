namespace Редактор_расписания.Scripts
{
    internal class AcademicDiscipline : Info
    {
        private CabinetType _requaredCabinetType;
        public AcademicDiscipline(string name, string descriotion, CabinetType requaredCabinetType) : base(name, descriotion, DataType.AcademicDiscipline)
        {
            _requaredCabinetType = requaredCabinetType;
        }   
    }
}
