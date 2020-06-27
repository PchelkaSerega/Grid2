namespace ArcGrid
{
    partial class formMain
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
            this.lblExit = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.gridMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(365, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 24);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(12, 45);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(96, 24);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Размер:";
            // 
            // tbSize
            // 
            this.tbSize.BackColor = System.Drawing.Color.Black;
            this.tbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSize.ForeColor = System.Drawing.Color.White;
            this.tbSize.Location = new System.Drawing.Point(114, 45);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(103, 26);
            this.tbSize.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Black;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuild.ForeColor = System.Drawing.Color.White;
            this.btnBuild.Location = new System.Drawing.Point(223, 42);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(165, 30);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // gridMain
            // 
            this.gridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMain.BackgroundColor = System.Drawing.Color.Black;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.ColumnHeadersVisible = false;
            this.gridMain.GridColor = System.Drawing.Color.Black;
            this.gridMain.Location = new System.Drawing.Point(16, 78);
            this.gridMain.Name = "gridMain";
            this.gridMain.RowHeadersVisible = false;
            this.gridMain.Size = new System.Drawing.Size(372, 310);
            this.gridMain.TabIndex = 4;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.gridMain);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblExit);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.DataGridView gridMain;
    }
}

