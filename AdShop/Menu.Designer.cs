namespace AdShop
{
    partial class Menu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenManager = new System.Windows.Forms.Button();
            this.buttonOpenIndividuals = new System.Windows.Forms.Button();
            this.buttonOpenEntity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenManager
            // 
            this.buttonOpenManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonOpenManager.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonOpenManager.Location = new System.Drawing.Point(7, 31);
            this.buttonOpenManager.Name = "buttonOpenManager";
            this.buttonOpenManager.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenManager.TabIndex = 0;
            this.buttonOpenManager.Text = "Менеджеры";
            this.buttonOpenManager.UseVisualStyleBackColor = false;
            this.buttonOpenManager.Click += new System.EventHandler(this.buttonOpenManager_Click);
            // 
            // buttonOpenIndividuals
            // 
            this.buttonOpenIndividuals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonOpenIndividuals.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonOpenIndividuals.Location = new System.Drawing.Point(7, 85);
            this.buttonOpenIndividuals.Name = "buttonOpenIndividuals";
            this.buttonOpenIndividuals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenIndividuals.TabIndex = 1;
            this.buttonOpenIndividuals.Text = "Физические лица";
            this.buttonOpenIndividuals.UseVisualStyleBackColor = false;
            this.buttonOpenIndividuals.Click += new System.EventHandler(this.buttonOpenIndividuals_Click);
            // 
            // buttonOpenEntity
            // 
            this.buttonOpenEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.buttonOpenEntity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.buttonOpenEntity.Location = new System.Drawing.Point(7, 139);
            this.buttonOpenEntity.Name = "buttonOpenEntity";
            this.buttonOpenEntity.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenEntity.TabIndex = 2;
            this.buttonOpenEntity.Text = "Юридические лица";
            this.buttonOpenEntity.UseVisualStyleBackColor = false;
            this.buttonOpenEntity.Click += new System.EventHandler(this.buttonOpenEntity_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(279, 221);
            this.Controls.Add(this.buttonOpenEntity);
            this.Controls.Add(this.buttonOpenIndividuals);
            this.Controls.Add(this.buttonOpenManager);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenManager;
        private System.Windows.Forms.Button buttonOpenIndividuals;
        private System.Windows.Forms.Button buttonOpenEntity;
    }
}

