using System.Collections.Generic;
using System;

namespace Редактор_расписания.Scripts
{
    public enum DataType
    {
        CabinetType,
        Cabinet,
        Teacher,
        AcademicDiscipline
    }
    internal static class s_Storage
    {
        static private Dictionary<DataType, Dictionary<Guid,Info>> _data = new Dictionary<DataType, Dictionary<Guid, Info>>()
        {
            [DataType.CabinetType] = new Dictionary<Guid, Info>(),
            [DataType.Cabinet] = new Dictionary<Guid, Info> (),
            [DataType.Teacher] = new Dictionary<Guid, Info> (),
            [DataType.AcademicDiscipline] = new Dictionary<Guid, Info> ()
        };
        static private CabinetType _standartCabinetType = new CabinetType("Обычный", "Обычный кабинет. \nНевозможно изменить.", true);

        static public CabinetType StandartCabinetType => (CabinetType)_standartCabinetType;
        static public Dictionary<DataType, Dictionary<Guid, Info>> Data => _data;

        static public void AddItem(Info newItem)
        {
            _data[newItem.Type].Add(newItem.Guid,newItem);
        }
        static public void RemoveItem(Info removedItem)
        {
            _data[removedItem.Type].Remove(removedItem.Guid);
        }
    }
}
