namespace LabUserControl
{
    partial class PersonRecordUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lvlAge = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(38, 4);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(98, 4);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(56, 13);
            this.lblSecondName.TabIndex = 2;
            this.lblSecondName.Text = "Фамилия";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(185, 4);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(54, 13);
            this.lblPatronymic.TabIndex = 3;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lvlAge
            // 
            this.lvlAge.AutoSize = true;
            this.lvlAge.Location = new System.Drawing.Point(268, 4);
            this.lvlAge.Name = "lvlAge";
            this.lvlAge.Size = new System.Drawing.Size(49, 13);
            this.lvlAge.TabIndex = 4;
            this.lvlAge.Text = "Возраст";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(481, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(481, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(3, 33);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(30, 20);
            this.tbId.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(41, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(54, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(101, 33);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(81, 20);
            this.tbLastName.TabIndex = 9;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(188, 33);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(73, 20);
            this.tbPatronymic.TabIndex = 10;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(267, 33);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(73, 20);
            this.tbAge.TabIndex = 11;
            // 
            // PersonRecordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvlAge);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblId);
            this.Name = "PersonRecordUserControl";
            this.Size = new System.Drawing.Size(569, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lvlAge;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbAge;
    }
}
