using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LabUserControl
{
    [DefaultEvent(nameof(OnTextChanged))]
    public partial class PersonRecordUserControl : UserControl
    {
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;
        public event EventHandler DataSaved;

        public PersonRecordUserControl()
        {
            EditClicked += btnEdit_Click;
            DeleteClicked += btnDelete_Click;
            InitializeComponent();
        }

        private int _id;
        private string _name;
        private string _lastName;
        private string _patronymic;
        private int _age;

        public int Id
        {
            get { return _id; }
            set { _id = value; tbId.Text = value.ToString(); }
        }
        public string MyName
        {
            get { return _name; }
            set { _name = value; tbName.Text = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; tbLastName.Text = value; }
        }
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; tbPatronymic.Text = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; tbAge.Text = value.ToString(); }
        }

        // Кнопки
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (PersonRecordEditDialog personEditDialog = new PersonRecordEditDialog())
            {
                personEditDialog.Id = _id;
                personEditDialog.MyName = _name;
                personEditDialog.LastName = _lastName;
                personEditDialog.Patronymic = _patronymic;
                personEditDialog.Age = _age;

                DataSaved += PersonRecordUserControl_DataSaved;

                if (personEditDialog.ShowDialog() == DialogResult.OK)
                {
                    Id = personEditDialog.Id;
                    MyName = personEditDialog.MyName;
                    LastName = personEditDialog.LastName;
                    Patronymic = personEditDialog.Patronymic;
                    Age = personEditDialog.Age;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Благодаря этому коду пересчитывается количество пользователей
            // Создается экземпляр класса MainForm, которому принадлежит текущий UserControl
            MainForm mainForm = this.FindForm() as MainForm;
            if (mainForm != null)
            {
                mainForm._users.Remove(this);
                mainForm.UpdateMainFormValues();
                this.Parent.Controls.Remove(this);
            }

            /*MainForm mainForm = new MainForm();
            mainForm._users.Remove(this);
            mainForm.UpdateMainFormValues();
            this.Parent.Controls.Remove(this);*/
        }

        private void PersonRecordUserControl_DataSaved(object sender, EventArgs e)
        {
            var personEditDialog = (PersonRecordEditDialog)sender;
            Id = personEditDialog.Id;
            MyName = personEditDialog.MyName;
            LastName = personEditDialog.LastName;
            Patronymic = personEditDialog?.Patronymic;
            Age = personEditDialog.Age;
        }
    }
}
