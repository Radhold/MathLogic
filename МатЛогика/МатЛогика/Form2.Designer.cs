namespace МатЛогика
{
    partial class Form2
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
            this.ageLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.genLabel = new System.Windows.Forms.Label();
            this.fem = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.genPanel = new System.Windows.Forms.Panel();
            this.agePanel = new System.Windows.Forms.Panel();
            this.heightPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.sympPanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sympLabel = new System.Windows.Forms.Label();
            this.genPanel.SuspendLayout();
            this.agePanel.SuspendLayout();
            this.heightPanel.SuspendLayout();
            this.sympPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.ageLabel.Location = new System.Drawing.Point(3, 12);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(209, 25);
            this.ageLabel.TabIndex = 0;
            this.ageLabel.Text = "1) Выберите возраст";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.genLabel.Location = new System.Drawing.Point(4, 11);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(215, 25);
            this.genLabel.TabIndex = 2;
            this.genLabel.Text = "2) Выберите ваш пол";
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.fem.Location = new System.Drawing.Point(32, 74);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(115, 29);
            this.fem.TabIndex = 1;
            this.fem.TabStop = true;
            this.fem.Text = "Женский";
            this.fem.UseVisualStyleBackColor = true;
            this.fem.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.male.Location = new System.Drawing.Point(32, 39);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(119, 29);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Мужской";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(32, 43);
            this.maskedTextBox1.Mask = "000.0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(57, 33);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // genPanel
            // 
            this.genPanel.Controls.Add(this.genLabel);
            this.genPanel.Controls.Add(this.fem);
            this.genPanel.Controls.Add(this.male);
            this.genPanel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genPanel.Location = new System.Drawing.Point(12, 129);
            this.genPanel.Name = "genPanel";
            this.genPanel.Size = new System.Drawing.Size(257, 116);
            this.genPanel.TabIndex = 5;
            this.genPanel.Visible = false;
            // 
            // agePanel
            // 
            this.agePanel.Controls.Add(this.ageLabel);
            this.agePanel.Controls.Add(this.comboBox1);
            this.agePanel.Location = new System.Drawing.Point(12, 12);
            this.agePanel.Name = "agePanel";
            this.agePanel.Size = new System.Drawing.Size(257, 81);
            this.agePanel.TabIndex = 6;
            // 
            // heightPanel
            // 
            this.heightPanel.Controls.Add(this.button1);
            this.heightPanel.Controls.Add(this.heightLabel);
            this.heightPanel.Controls.Add(this.maskedTextBox1);
            this.heightPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightPanel.Location = new System.Drawing.Point(12, 286);
            this.heightPanel.Name = "heightPanel";
            this.heightPanel.Size = new System.Drawing.Size(257, 142);
            this.heightPanel.TabIndex = 7;
            this.heightPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.button1.Location = new System.Drawing.Point(32, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Нажмите, чтобы продолжить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.heightLabel.Location = new System.Drawing.Point(6, 15);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(206, 25);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "3) Введите ваш рост";
            // 
            // sympPanel
            // 
            this.sympPanel.Controls.Add(this.comboBox2);
            this.sympPanel.Controls.Add(this.sympLabel);
            this.sympPanel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sympPanel.Location = new System.Drawing.Point(305, 12);
            this.sympPanel.Name = "sympPanel";
            this.sympPanel.Size = new System.Drawing.Size(432, 416);
            this.sympPanel.TabIndex = 8;
            this.sympPanel.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            ""});
            this.comboBox2.Location = new System.Drawing.Point(27, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(326, 33);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // sympLabel
            // 
            this.sympLabel.AutoSize = true;
            this.sympLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(227)))));
            this.sympLabel.Location = new System.Drawing.Point(3, 12);
            this.sympLabel.Name = "sympLabel";
            this.sympLabel.Size = new System.Drawing.Size(235, 25);
            this.sympLabel.TabIndex = 0;
            this.sympLabel.Text = "4) Выберите симптомы";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 448);
            this.Controls.Add(this.sympPanel);
            this.Controls.Add(this.heightPanel);
            this.Controls.Add(this.agePanel);
            this.Controls.Add(this.genPanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.genPanel.ResumeLayout(false);
            this.genPanel.PerformLayout();
            this.agePanel.ResumeLayout(false);
            this.agePanel.PerformLayout();
            this.heightPanel.ResumeLayout(false);
            this.heightPanel.PerformLayout();
            this.sympPanel.ResumeLayout(false);
            this.sympPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel genPanel;
        private System.Windows.Forms.Panel agePanel;
        private System.Windows.Forms.Panel heightPanel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Panel sympPanel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label sympLabel;
        private System.Windows.Forms.Button button1;
    }
}