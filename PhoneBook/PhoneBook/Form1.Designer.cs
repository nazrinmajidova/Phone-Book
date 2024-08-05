namespace PhoneBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbSavePerson = new GroupBox();
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
            grbSavePerson.Location = new Point(14, 16);
            grbSavePerson.Margin = new Padding(3, 4, 3, 4);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Padding = new Padding(3, 4, 3, 4);
            grbSavePerson.Size = new Size(498, 568);
            grbSavePerson.TabIndex = 0;
            grbSavePerson.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(125, 499);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(280, 61);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(125, 408);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(279, 52);
            txtMail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(125, 309);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(279, 52);
            txtPhone.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(125, 211);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(279, 52);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(126, 112);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(279, 52);
            txtFirstName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 412);
            label4.Name = "label4";
            label4.Size = new Size(99, 46);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 309);
            label3.Name = "label3";
            label3.Size = new Size(129, 46);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 219);
            label2.Name = "label2";
            label2.Size = new Size(119, 46);
            label2.TabIndex = 0;
            label2.Text = "Soyadi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 113);
            label1.Name = "label1";
            label1.Size = new Size(70, 46);
            label1.TabIndex = 0;
            label1.Text = "Adi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 600);
            Controls.Add(grbSavePerson);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Padding = new Padding(23, 80, 23, 27);
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private TextBox txtFirstName;
        private Label label1;
        private Button btnSave;
        private TextBox txtMail;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
