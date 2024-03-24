using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabUserControl
{
    public partial class MainForm : Form
    {
        // список пользователей
        public List<PersonRecordUserControl> _users = new List<PersonRecordUserControl>();

        #region Элементы управления
        private Button addUserButton = new Button()
        {
            Text = "Добавить",
            Dock = DockStyle.Fill
        };
        //addUserButton.Click += AddUserButton_Click;
        private Label totalUsersLbl = new Label()
        {
            Text = "Всего записей:",
            Anchor = AnchorStyles.Left
        };
        private TextBox totalUsersTB = new TextBox()
        {
            Anchor = AnchorStyles.Left
        };
        private Label sumAgeLbl = new Label()
        {
            Text = "Сумма лет:",
            Anchor = AnchorStyles.Left
        };
        private TextBox sumAgeTB = new TextBox()
        {
            Anchor = AnchorStyles.Left
        };
        private FlowLayoutPanel userPanel = new FlowLayoutPanel()
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = Color.Black
        };
        #endregion

        public MainForm()
        {
            addUserButton.Click += AddUserButton_Click;
            this.Load += MainForm_Load;
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region добавление элементов на MainForm
            var table = new TableLayoutPanel();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 70));

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));

            // Добавление в таблицу кнопки
            table.Controls.Add(addUserButton, 0, 0);
            table.SetRowSpan(addUserButton, 2);

            // Добавление в таблицу textbox'ов и label'ов
            table.Controls.Add(totalUsersLbl, 1, 0);
            table.Controls.Add(totalUsersTB,2,0);

            table.Controls.Add(sumAgeLbl, 1, 1);
            table.Controls.Add(sumAgeTB, 2, 1);

            // Добавление в таблицу Panel
            table.Controls.Add(userPanel, 0, 2);
            table.SetColumnSpan(userPanel, 3);

            table.Dock = DockStyle.Fill;

            UpdateMainFormValues();           

            Controls.Add(table);
            #endregion

            // Подписываю обработчик DeleteClicked для каждого UserControl в списке _users
            foreach (var userControl in _users)
            {
                userControl.DeleteClicked += PersonRecordUserControl_DeleteClicked;
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            // Создание нового UserControl для пользователя
            PersonRecordUserControl prc = new PersonRecordUserControl();
            int count = _users.Count;
            _users.Add(prc);
            prc.BackColor = Color.Green;

            // Добавление prc в панель
            userPanel.Controls.Add(_users[count]);

            UpdateMainFormValues();
            // Пересчет размеров формы
            this.PerformLayout();
        }

        public void UpdateMainFormValues()
        {
            int totalUsers = _users.Count;
            int totalAge = 0;
            foreach (var control in _users)
            {
                totalAge += control.Age;
            }
            //Text = $"Всего записей: {totalUsers}, Сумма лет: {totalAge}";
            totalUsersTB.Text = totalUsers.ToString();
            sumAgeTB.Text = totalAge.ToString();            
        }

        private void PersonRecordUserControl_DeleteClicked(object sender, EventArgs e)
        {
            var userControlToRemove = (PersonRecordUserControl)sender;
            userControlToRemove.DeleteClicked -= PersonRecordUserControl_DeleteClicked;
            userPanel.Controls.Remove(userControlToRemove);
            _users.Remove(userControlToRemove);
            UpdateMainFormValues(); // Обновить значения на MainForm
        }
    }
}
