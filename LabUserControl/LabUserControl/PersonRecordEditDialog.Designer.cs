namespace LabUserControl
{
    partial class PersonRecordEditDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.editTbId = new System.Windows.Forms.TextBox();
            this.editTbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editTbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editTbPatronymic = new System.Windows.Forms.TextBox();
            this.editLblAge = new System.Windows.Forms.Label();
            this.editTbAge = new System.Windows.Forms.TextBox();
            this.editBtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // editTbId
            // 
            this.editTbId.Location = new System.Drawing.Point(16, 30);
            this.editTbId.Name = "editTbId";
            this.editTbId.Size = new System.Drawing.Size(49, 20);
            this.editTbId.TabIndex = 1;
            // 
            // editTbName
            // 
            this.editTbName.Location = new System.Drawing.Point(16, 84);
            this.editTbName.Name = "editTbName";
            this.editTbName.Size = new System.Drawing.Size(100, 20);
            this.editTbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // editTbLastName
            // 
            this.editTbLastName.Location = new System.Drawing.Point(12, 128);
            this.editTbLastName.Name = "editTbLastName";
            this.editTbLastName.Size = new System.Drawing.Size(100, 20);
            this.editTbLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество";
            // 
            // editTbPatronymic
            // 
            this.editTbPatronymic.Location = new System.Drawing.Point(12, 172);
            this.editTbPatronymic.Name = "editTbPatronymic";
            this.editTbPatronymic.Size = new System.Drawing.Size(100, 20);
            this.editTbPatronymic.TabIndex = 6;
            // 
            // editLblAge
            // 
            this.editLblAge.AutoSize = true;
            this.editLblAge.Location = new System.Drawing.Point(9, 203);
            this.editLblAge.Name = "editLblAge";
            this.editLblAge.Size = new System.Drawing.Size(49, 13);
            this.editLblAge.TabIndex = 9;
            this.editLblAge.Text = "Возраст";
            // 
            // editTbAge
            // 
            this.editTbAge.Location = new System.Drawing.Point(12, 219);
            this.editTbAge.Name = "editTbAge";
            this.editTbAge.Size = new System.Drawing.Size(53, 20);
            this.editTbAge.TabIndex = 8;
            // 
            // editBtnSave
            // 
            this.editBtnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editBtnSave.Location = new System.Drawing.Point(41, 254);
            this.editBtnSave.Name = "editBtnSave";
            this.editBtnSave.Size = new System.Drawing.Size(75, 23);
            this.editBtnSave.TabIndex = 10;
            this.editBtnSave.Text = "Сохранить";
            this.editBtnSave.UseVisualStyleBackColor = false;
            this.editBtnSave.Click += new System.EventHandler(this.editBtnSave_Click);
            // 
            // PersonRecordEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(150, 291);
            this.Controls.Add(this.editBtnSave);
            this.Controls.Add(this.editLblAge);
            this.Controls.Add(this.editTbAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editTbPatronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editTbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editTbName);
            this.Controls.Add(this.editTbId);
            this.Controls.Add(this.label1);
            this.Name = "PersonRecordEditDialog";
            this.Text = "PersonRecordEditDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editTbId;
        private System.Windows.Forms.TextBox editTbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editTbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editTbPatronymic;
        private System.Windows.Forms.Label editLblAge;
        private System.Windows.Forms.TextBox editTbAge;
        private System.Windows.Forms.Button editBtnSave;
    }
}