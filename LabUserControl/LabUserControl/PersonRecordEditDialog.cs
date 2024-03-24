using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LabUserControl
{
    public partial class PersonRecordEditDialog : Form
    {
        public event EventHandler DataSaved;
        public MainForm MainForm;

        private int _id;
        private string _name;
        private string _lastName;
        private string _patronymic;
        private int _age;

        public int Id
        {
            get { return _id; }
            set { _id = value; editTbId.Text = value.ToString(); }
        }
        public string MyName
        {
            get { return _name; }
            set { _name = value; editTbName.Text = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; editTbLastName.Text = value; }
        }
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; editTbPatronymic.Text = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; editTbAge.Text = value.ToString(); }
        }
        public PersonRecordEditDialog()
        {
            InitializeComponent();
        }

        private void editBtnSave_Click(object sender, EventArgs e)
        {
            Id = int.Parse(editTbId.Text);
            MyName = editTbName.Text;
            LastName = editTbLastName.Text;
            Patronymic = editTbPatronymic.Text;
            Age = int.Parse(editTbAge.Text);

            DataSaved?.Invoke(this, EventArgs.Empty);

            MainForm mainForm = new MainForm();
            mainForm.UpdateMainFormValues();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void PersonRecordEditDialog_DataSaved(object sender, EventArgs e)
        {

        }
    }
}
