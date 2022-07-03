namespace Редактор_расписания
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cabinetsTypes_ListBox = new System.Windows.Forms.ListBox();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.description_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.apply_button = new System.Windows.Forms.Button();
            this.addItem_button = new System.Windows.Forms.Button();
            this.id_Label = new System.Windows.Forms.Label();
            this.id_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editMode_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cabinetsType_ComboBox = new System.Windows.Forms.ComboBox();
            this.CabinetsEditor_panel = new System.Windows.Forms.Panel();
            this.workPlace_Panel = new System.Windows.Forms.Panel();
            this.CabinetsEditor_panel.SuspendLayout();
            this.workPlace_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cabinetsTypes_ListBox
            // 
            this.cabinetsTypes_ListBox.FormattingEnabled = true;
            this.cabinetsTypes_ListBox.Location = new System.Drawing.Point(12, 53);
            this.cabinetsTypes_ListBox.Name = "cabinetsTypes_ListBox";
            this.cabinetsTypes_ListBox.Size = new System.Drawing.Size(224, 368);
            this.cabinetsTypes_ListBox.TabIndex = 0;
            this.cabinetsTypes_ListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(0, 16);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(227, 20);
            this.name_TextBox.TabIndex = 1;
            this.name_TextBox.TextChanged += new System.EventHandler(this.NameChanged);
            this.name_TextBox.Leave += new System.EventHandler(this.name_TextBox_Leave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(-3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Имя";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(-3, 43);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Описание";
            // 
            // description_RichTextBox
            // 
            this.description_RichTextBox.Location = new System.Drawing.Point(0, 59);
            this.description_RichTextBox.Name = "description_RichTextBox";
            this.description_RichTextBox.Size = new System.Drawing.Size(227, 128);
            this.description_RichTextBox.TabIndex = 5;
            this.description_RichTextBox.Text = "";
            this.description_RichTextBox.TextChanged += new System.EventHandler(this.DescriptionChanged);
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(394, 427);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 6;
            this.apply_button.Text = "Применить";
            this.apply_button.UseVisualStyleBackColor = true;
            // 
            // addItem_button
            // 
            this.addItem_button.Location = new System.Drawing.Point(12, 427);
            this.addItem_button.Name = "addItem_button";
            this.addItem_button.Size = new System.Drawing.Size(75, 23);
            this.addItem_button.TabIndex = 7;
            this.addItem_button.Text = "Добавить";
            this.addItem_button.UseVisualStyleBackColor = true;
            this.addItem_button.Click += new System.EventHandler(this.addItem_button_Click);
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Location = new System.Drawing.Point(242, 385);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(18, 13);
            this.id_Label.TabIndex = 9;
            this.id_Label.Text = "ID";
            // 
            // id_TextBox
            // 
            this.id_TextBox.Location = new System.Drawing.Point(242, 401);
            this.id_TextBox.Name = "id_TextBox";
            this.id_TextBox.ReadOnly = true;
            this.id_TextBox.Size = new System.Drawing.Size(227, 20);
            this.id_TextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Редактировать:";
            // 
            // editMode_comboBox
            // 
            this.editMode_comboBox.FormattingEnabled = true;
            this.editMode_comboBox.Items.AddRange(new object[] {
            "Типы кабинетов",
            "Кабинеты",
            "Дисциплины",
            "Преподавателей",
            "Направления подготовки"});
            this.editMode_comboBox.Location = new System.Drawing.Point(102, 6);
            this.editMode_comboBox.Name = "editMode_comboBox";
            this.editMode_comboBox.Size = new System.Drawing.Size(121, 21);
            this.editMode_comboBox.TabIndex = 11;
            this.editMode_comboBox.Text = "Типы кабентов";
            this.editMode_comboBox.SelectedIndexChanged += new System.EventHandler(this.EditModeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип кабинета";
            // 
            // cabinetsType_ComboBox
            // 
            this.cabinetsType_ComboBox.FormattingEnabled = true;
            this.cabinetsType_ComboBox.Location = new System.Drawing.Point(3, 17);
            this.cabinetsType_ComboBox.Name = "cabinetsType_ComboBox";
            this.cabinetsType_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.cabinetsType_ComboBox.TabIndex = 13;
            this.cabinetsType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.cabinetsType_ComboBox_SelectedIndexChanged);
            // 
            // CabinetsEditor_panel
            // 
            this.CabinetsEditor_panel.Controls.Add(this.cabinetsType_ComboBox);
            this.CabinetsEditor_panel.Controls.Add(this.label2);
            this.CabinetsEditor_panel.Location = new System.Drawing.Point(0, 193);
            this.CabinetsEditor_panel.Name = "CabinetsEditor_panel";
            this.CabinetsEditor_panel.Size = new System.Drawing.Size(227, 136);
            this.CabinetsEditor_panel.TabIndex = 14;
            this.CabinetsEditor_panel.Visible = false;
            // 
            // workPlace_Panel
            // 
            this.workPlace_Panel.Controls.Add(this.nameLabel);
            this.workPlace_Panel.Controls.Add(this.CabinetsEditor_panel);
            this.workPlace_Panel.Controls.Add(this.name_TextBox);
            this.workPlace_Panel.Controls.Add(this.descriptionLabel);
            this.workPlace_Panel.Controls.Add(this.description_RichTextBox);
            this.workPlace_Panel.Location = new System.Drawing.Point(241, 53);
            this.workPlace_Panel.Name = "workPlace_Panel";
            this.workPlace_Panel.Size = new System.Drawing.Size(228, 329);
            this.workPlace_Panel.TabIndex = 15;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 462);
            this.Controls.Add(this.workPlace_Panel);
            this.Controls.Add(this.editMode_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_Label);
            this.Controls.Add(this.id_TextBox);
            this.Controls.Add(this.addItem_button);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.cabinetsTypes_ListBox);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.LoadForm);
            this.CabinetsEditor_panel.ResumeLayout(false);
            this.CabinetsEditor_panel.PerformLayout();
            this.workPlace_Panel.ResumeLayout(false);
            this.workPlace_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cabinetsTypes_ListBox;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox description_RichTextBox;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button addItem_button;
        private System.Windows.Forms.Label id_Label;
        private System.Windows.Forms.TextBox id_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox editMode_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cabinetsType_ComboBox;
        private System.Windows.Forms.Panel CabinetsEditor_panel;
        private System.Windows.Forms.Panel workPlace_Panel;
    }
}