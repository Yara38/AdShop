namespace AdShop
{
    partial class FormIndividuals
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewIndividuals = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.First = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Middl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emaile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelinn = new System.Windows.Forms.Label();
            this.textBoxinn = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonDel.Location = new System.Drawing.Point(546, 425);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 36);
            this.buttonDel.TabIndex = 38;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonEdit.Location = new System.Drawing.Point(452, 425);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 36);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonAdd.Location = new System.Drawing.Point(358, 425);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 36);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewIndividuals
            // 
            this.listViewIndividuals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.inn,
            this.First,
            this.Middl,
            this.LastNam,
            this.Gender,
            this.Emaile,
            this.Manage});
            this.listViewIndividuals.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.listViewIndividuals.FullRowSelect = true;
            this.listViewIndividuals.GridLines = true;
            this.listViewIndividuals.HideSelection = false;
            this.listViewIndividuals.Location = new System.Drawing.Point(11, 219);
            this.listViewIndividuals.MultiSelect = false;
            this.listViewIndividuals.Name = "listViewIndividuals";
            this.listViewIndividuals.Size = new System.Drawing.Size(620, 192);
            this.listViewIndividuals.TabIndex = 35;
            this.listViewIndividuals.UseCompatibleStateImageBehavior = false;
            this.listViewIndividuals.View = System.Windows.Forms.View.Details;
            this.listViewIndividuals.SelectedIndexChanged += new System.EventHandler(this.listViewIndividuals_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 36;
            // 
            // inn
            // 
            this.inn.Text = "ИНН";
            this.inn.Width = 41;
            // 
            // First
            // 
            this.First.Text = "Имя";
            // 
            // Middl
            // 
            this.Middl.Text = "Отчество";
            this.Middl.Width = 85;
            // 
            // LastNam
            // 
            this.LastNam.Text = "Фамилия";
            this.LastNam.Width = 84;
            // 
            // Gender
            // 
            this.Gender.Text = "Пол";
            // 
            // Emaile
            // 
            this.Emaile.Text = "Почта";
            // 
            // Manage
            // 
            this.Manage.Text = "Менеджер";
            this.Manage.Width = 107;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelEmail.Location = new System.Drawing.Point(378, 9);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 18);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "Почта";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelLastName.Location = new System.Drawing.Point(8, 159);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 18);
            this.labelLastName.TabIndex = 33;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelMiddleName.Location = new System.Drawing.Point(8, 109);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(66, 18);
            this.labelMiddleName.TabIndex = 32;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelFirstName.Location = new System.Drawing.Point(12, 59);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 18);
            this.labelFirstName.TabIndex = 31;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(377, 30);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(177, 26);
            this.textBoxEmail.TabIndex = 30;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBoxLastName.Location = new System.Drawing.Point(11, 180);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(177, 26);
            this.textBoxLastName.TabIndex = 29;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.textBoxMiddleName.Location = new System.Drawing.Point(11, 130);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(177, 26);
            this.textBoxMiddleName.TabIndex = 28;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(11, 80);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(177, 26);
            this.textBoxFirstName.TabIndex = 27;
            // 
            // labelinn
            // 
            this.labelinn.AutoSize = true;
            this.labelinn.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelinn.Location = new System.Drawing.Point(12, 9);
            this.labelinn.Name = "labelinn";
            this.labelinn.Size = new System.Drawing.Size(36, 18);
            this.labelinn.TabIndex = 41;
            this.labelinn.Text = "ИНН";
            // 
            // textBoxinn
            // 
            this.textBoxinn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxinn.Location = new System.Drawing.Point(11, 30);
            this.textBoxinn.Name = "textBoxinn";
            this.textBoxinn.Size = new System.Drawing.Size(177, 26);
            this.textBoxinn.TabIndex = 40;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(194, 30);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(177, 26);
            this.comboBoxGender.TabIndex = 43;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelGender.Location = new System.Drawing.Point(195, 9);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(33, 18);
            this.labelGender.TabIndex = 42;
            this.labelGender.Text = "Пол";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(194, 80);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(177, 26);
            this.comboBoxManager.TabIndex = 45;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelManager.Location = new System.Drawing.Point(195, 59);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(78, 18);
            this.labelManager.TabIndex = 44;
            this.labelManager.Text = "Менеджер";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdShop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FormIndividuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(643, 471);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelinn);
            this.Controls.Add(this.textBoxinn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewIndividuals);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "FormIndividuals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Физические лица";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewIndividuals;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelinn;
        private System.Windows.Forms.TextBox textBoxinn;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.ColumnHeader inn;
        private System.Windows.Forms.ColumnHeader First;
        private System.Windows.Forms.ColumnHeader Middl;
        private System.Windows.Forms.ColumnHeader LastNam;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Emaile;
        private System.Windows.Forms.ColumnHeader Manage;
    }
}