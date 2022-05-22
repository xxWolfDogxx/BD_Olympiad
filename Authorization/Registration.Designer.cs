
namespace BD_Olympiad
{
    partial class Registration
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfileEnum = new System.Windows.Forms.ComboBox();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.RegisrButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон:";
            // 
            // ProfileEnum
            // 
            this.ProfileEnum.CausesValidation = false;
            this.ProfileEnum.DisplayMember = "Организатор";
            this.ProfileEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfileEnum.Font = new System.Drawing.Font("Times New Roman", 14.26415F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ProfileEnum.Items.AddRange(new object[] {
            "Организатор",
            "Участник"});
            this.ProfileEnum.Location = new System.Drawing.Point(23, 67);
            this.ProfileEnum.Name = "ProfileEnum";
            this.ProfileEnum.Size = new System.Drawing.Size(451, 32);
            this.ProfileEnum.Sorted = true;
            this.ProfileEnum.TabIndex = 7;
            this.ProfileEnum.Tag = "1";
            this.ProfileEnum.ValueMember = "Организатор";
            // 
            // FullNameBox
            // 
            this.FullNameBox.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FullNameBox.Location = new System.Drawing.Point(151, 123);
            this.FullNameBox.Multiline = true;
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(323, 32);
            this.FullNameBox.TabIndex = 8;
            this.FullNameBox.Enter += new System.EventHandler(this.FullNameBox_Enter);
            this.FullNameBox.Leave += new System.EventHandler(this.FullNameBox_Leave);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirth.Location = new System.Drawing.Point(253, 184);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(221, 32);
            this.DateOfBirth.TabIndex = 9;
            this.DateOfBirth.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
            // 
            // RegisrButton
            // 
            this.RegisrButton.Font = new System.Drawing.Font("Times New Roman", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisrButton.Location = new System.Drawing.Point(99, 433);
            this.RegisrButton.Name = "RegisrButton";
            this.RegisrButton.Size = new System.Drawing.Size(292, 48);
            this.RegisrButton.TabIndex = 13;
            this.RegisrButton.Text = "Зарегистрироваться";
            this.RegisrButton.UseVisualStyleBackColor = true;
            this.RegisrButton.Click += new System.EventHandler(this.RegisrButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.Location = new System.Drawing.Point(151, 369);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(323, 32);
            this.PasswordBox.TabIndex = 16;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            this.PasswordBox.Leave += new System.EventHandler(this.PasswordBox_Leave);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneBox.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneBox.Location = new System.Drawing.Point(151, 316);
            this.PhoneBox.Mask = "+7(999) 000-00-00";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(323, 32);
            this.PhoneBox.TabIndex = 17;
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.Location = new System.Drawing.Point(151, 245);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(323, 32);
            this.EmailBox.TabIndex = 18;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(486, 493);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisrButton);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.ProfileEnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация | DB_Olympiad";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProfileEnum;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Button RegisrButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.MaskedTextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
    }
}