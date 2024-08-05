namespace PhoneBook
{
    partial class MainForm
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
            btnAdd = new Button();
            btnList = new Button();
            btnFind = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Peru;
            btnAdd.Location = new Point(23, 83);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(203, 291);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Kisi Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.LightSalmon;
            btnList.Location = new Point(232, 232);
            btnList.Name = "btnList";
            btnList.Size = new Size(160, 142);
            btnList.TabIndex = 1;
            btnList.Text = "Kisi Listesi";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Coral;
            btnFind.Location = new Point(232, 83);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(160, 143);
            btnFind.TabIndex = 2;
            btnFind.Text = "Kisi Arama";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 404);
            Controls.Add(btnFind);
            Controls.Add(btnList);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "Telefon Rehberi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnList;
        private Button btnFind;
    }
}