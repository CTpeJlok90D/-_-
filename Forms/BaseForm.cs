using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Редактор_расписания.Scripts;

namespace Редактор_расписания
{
    public partial class BaseForm : Form
    {
        protected DataType _correctDataType = DataType.CabinetType;
        private string _objectViewField = "ListBoxName";

        public BaseForm()
        {
            InitializeComponent();
        }

        private void UpdateItemsInListBox()
        {
            Dictionary<Guid, Info> allData = s_Storage.Data[_correctDataType];
            cabinetsTypes_ListBox.Items.Clear();
            foreach (KeyValuePair<Guid, Info> id in allData)
            {
                cabinetsTypes_ListBox.Items.Add(id.Value);
            }
            workPlace_Panel.Enabled = false;
        }
        private void WriteInfo()
        {
            Info SelectedItem = (Info)cabinetsTypes_ListBox.SelectedItem;
            
            name_TextBox.Text = SelectedItem.Name;
            description_RichTextBox.Text = SelectedItem.Description;
            id_TextBox.Text = SelectedItem.Guid.ToString();
            switch (_correctDataType)
            {
                case DataType.CabinetType:
                    break;

                case DataType.Cabinet:
                    cabinetsType_ComboBox.Text = ((Cabinet)SelectedItem).CabinetType.Name;
                    break;
            }
        }
        private void ClearAllPanels()
        {
            CabinetsEditor_panel.Visible = false;
        }
        private void LoadForm(object sender, EventArgs e)
        {
            cabinetsType_ComboBox.DisplayMember = _objectViewField;
            cabinetsTypes_ListBox.DisplayMember = _objectViewField;
            UpdateItemsInListBox();
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cabinetsTypes_ListBox.SelectedIndex >= 0)
            {
                WriteInfo();
            }

            if (cabinetsTypes_ListBox.SelectedIndex >= 0 && ((Info)cabinetsTypes_ListBox.SelectedItem).ReadOnly == false)
            {
                workPlace_Panel.Enabled = true;
            }
            else
            {
                workPlace_Panel.Enabled = false;
            }
        }
        private void NameChanged(object sender, EventArgs e)
        {
            Info SelectedItem = (Info)cabinetsTypes_ListBox.SelectedItem;
            SelectedItem.Name = name_TextBox.Text;
        }
        private void name_TextBox_Leave(object sender, EventArgs e)
        {
            UpdateItemsInListBox();
        }
        private void DescriptionChanged(object sender, EventArgs e)
        {
            Info SelectedItem = (Info)cabinetsTypes_ListBox.SelectedItem;
            SelectedItem.Description = description_RichTextBox.Text;
        }
        private void UpdateCabietTypes()
        {
            cabinetsType_ComboBox.Items.Clear();
            foreach (KeyValuePair<Guid, Info> item in s_Storage.Data[DataType.CabinetType])
            {
                cabinetsType_ComboBox.Items.Add(item.Value);
            }
        }
        private void EditModeChanged(object sender, EventArgs e)
        {
            ClearAllPanels();
            switch (editMode_comboBox.SelectedIndex)
            {
                case 0:
                    _correctDataType = DataType.CabinetType;
                    break;
                case 1:
                    CabinetsEditor_panel.Visible = true;
                    _correctDataType = DataType.Cabinet;
                    UpdateCabietTypes();
                    break;
            }
            UpdateItemsInListBox();
        }
        private void addItem_button_Click(object sender, EventArgs e)
        {
            switch (_correctDataType)
            {
                case DataType.CabinetType:
                    new CabinetType("Новый тип кабинета","Описание отсутствует");
                    break;
                case DataType.Cabinet:
                    new Cabinet("Новый кабинет", "Описание отсутствует", s_Storage.StandartCabinetType);
                    break;
            }
            UpdateItemsInListBox();
        }

        private void cabinetsType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cabinet SelectedItem = (Cabinet)cabinetsTypes_ListBox.SelectedItem;
            SelectedItem.CabinetType = (CabinetType)cabinetsType_ComboBox.SelectedItem;
        }
    }
}
