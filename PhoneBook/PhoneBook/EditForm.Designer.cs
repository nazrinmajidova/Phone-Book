namespace PhoneBook
{
    partial class EditForm
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
            grbSavePerson = new GroupBox();
            button1 = new Button();
            btnSave = new Button();
            txtMail = new TextBox();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbSavePerson.SuspendLayout();
            SuspendLayout();
            // 
            // grbSavePerson
            // 
            grbSavePerson.Controls.Add(button1);
            grbSavePerson.Controls.Add(btnSave);
            grbSavePerson.Controls.Add(txtMail);
            grbSavePerson.Controls.Add(txtPhone);
            grbSavePerson.Controls.Add(txtLastName);
            grbSavePerson.Controls.Add(txtFirstName);
            grbSavePerson.Controls.Add(label4);
            grbSavePerson.Controls.Add(label3);
            grbSavePerson.Controls.Add(label2);
            grbSavePerson.Controls.Add(label1);
            grbSavePerson.Font = new Font("Segoe UI", 20F);
            grbSavePerson.Location = new Point(12, 12);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Size = new Size(529, 426);
            grbSavePerson.TabIndex = 1;
            grbSavePerson.TabStop = false;
            grbSavePerson.Text = "Kisi Duzeltme Formu";
            // 
            // button1
            // 
            button1.Location = new Point(6, 374);
            button1.Name = "button1";
            button1.Size = new Size(82, 46);
            button1.TabIndex = 6;
            button1.Text = "blue";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(109, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(245, 46);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(109, 306);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(245, 43);
            txtMail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(109, 232);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(245, 43);
            txtPhone.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(109, 158);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(245, 43);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(110, 84);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(245, 43);
            txtFirstName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 309);
            label4.Name = "label4";
            label4.Size = new Size(82, 37);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 232);
            label3.Name = "label3";
            label3.Size = new Size(102, 37);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 164);
            label2.Name = "label2";
            label2.Size = new Size(97, 37);
            label2.TabIndex = 0;
            label2.Text = "Soyadi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(57, 37);
            label1.TabIndex = 0;
            label1.Text = "Adi";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(grbSavePerson);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private Button button1;
        private Button btnSave;
        private TextBox txtMail;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}