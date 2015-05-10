namespace Example02
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.setSalaryButton1 = new System.Windows.Forms.Button();
            this.setSalaryButton2 = new System.Windows.Forms.Button();
            this.SalaryTextBox1 = new System.Windows.Forms.TextBox();
            this.BenefitTextBox1 = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.BaseSalaryLabel = new System.Windows.Forms.Label();
            this.BenefitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setSalaryButton1
            // 
            this.setSalaryButton1.Location = new System.Drawing.Point(221, 12);
            this.setSalaryButton1.Name = "setSalaryButton1";
            this.setSalaryButton1.Size = new System.Drawing.Size(91, 23);
            this.setSalaryButton1.TabIndex = 0;
            this.setSalaryButton1.Text = "Calculate1";
            this.setSalaryButton1.UseVisualStyleBackColor = true;
            this.setSalaryButton1.Click += new System.EventHandler(this.setSalaryButton1_Click);
            // 
            // setSalaryButton2
            // 
            this.setSalaryButton2.Location = new System.Drawing.Point(221, 48);
            this.setSalaryButton2.Name = "setSalaryButton2";
            this.setSalaryButton2.Size = new System.Drawing.Size(93, 23);
            this.setSalaryButton2.TabIndex = 1;
            this.setSalaryButton2.Text = "Calculate2";
            this.setSalaryButton2.UseVisualStyleBackColor = true;
            this.setSalaryButton2.Click += new System.EventHandler(this.setSalaryButton2_Click);
            // 
            // SalaryTextBox1
            // 
            this.SalaryTextBox1.Location = new System.Drawing.Point(73, 88);
            this.SalaryTextBox1.Name = "SalaryTextBox1";
            this.SalaryTextBox1.Size = new System.Drawing.Size(100, 22);
            this.SalaryTextBox1.TabIndex = 2;
            // 
            // BenefitTextBox1
            // 
            this.BenefitTextBox1.Location = new System.Drawing.Point(73, 129);
            this.BenefitTextBox1.Name = "BenefitTextBox1";
            this.BenefitTextBox1.Size = new System.Drawing.Size(100, 22);
            this.BenefitTextBox1.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(73, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 4;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(73, 42);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(3, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 16);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "姓名";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(1, 48);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(40, 16);
            this.EmployeeIDLabel.TabIndex = 7;
            this.EmployeeIDLabel.Text = "工號";
            // 
            // BaseSalaryLabel
            // 
            this.BaseSalaryLabel.AutoSize = true;
            this.BaseSalaryLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BaseSalaryLabel.Location = new System.Drawing.Point(0, 88);
            this.BaseSalaryLabel.Name = "BaseSalaryLabel";
            this.BaseSalaryLabel.Size = new System.Drawing.Size(72, 16);
            this.BaseSalaryLabel.TabIndex = 8;
            this.BaseSalaryLabel.Text = "基本底薪";
            // 
            // BenefitLabel
            // 
            this.BenefitLabel.AutoSize = true;
            this.BenefitLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BenefitLabel.Location = new System.Drawing.Point(6, 131);
            this.BenefitLabel.Name = "BenefitLabel";
            this.BenefitLabel.Size = new System.Drawing.Size(40, 16);
            this.BenefitLabel.TabIndex = 9;
            this.BenefitLabel.Text = "獎金";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 163);
            this.Controls.Add(this.BenefitLabel);
            this.Controls.Add(this.BaseSalaryLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BenefitTextBox1);
            this.Controls.Add(this.SalaryTextBox1);
            this.Controls.Add(this.setSalaryButton2);
            this.Controls.Add(this.setSalaryButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setSalaryButton1;
        private System.Windows.Forms.Button setSalaryButton2;
        private System.Windows.Forms.TextBox SalaryTextBox1;
        private System.Windows.Forms.TextBox BenefitTextBox1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label BaseSalaryLabel;
        private System.Windows.Forms.Label BenefitLabel;
    }
}

