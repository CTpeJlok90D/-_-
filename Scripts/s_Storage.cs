using System.Collections.Generic;
using System;

namespace Редактор_расписания.Scripts
{
    internal enum DataType
    {
        CabinetType,
        Cabinet
    }
    internal static class s_Storage
    {
        static private List<Cabinet> _cabinets = new List<Cabinet>();
        static private Dictionary<DataType, List<Info>> _data = new Dictionary<DataType, List<Info>>()
        {
            [DataType.CabinetType] = new List<Info>(),
            [DataType.Cabinet] = new List<Info>()
        };

        static public void AddItem(Info newItem)
        {
            if (HaveIt(newItem))
            {
                throw new Exception("This name is already used");
            }
            _data[newItem.Type].Add(newItem);
        }
        static public void RemoveItem(Info removedItem)
        {
            _data[removedItem.Type].Remove(removedItem);
        }
        static public List<Info> GetData(DataType type)
        {
            return _data[type];
        }
        static public Info GetItemByName(string name, DataType type)
        {
            foreach (var item in _data[type])
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        static public bool HaveIt(Info newItem)
        {
            return GetItemByName(newItem.Name, newItem.Type) != null;
        }
    }
}
