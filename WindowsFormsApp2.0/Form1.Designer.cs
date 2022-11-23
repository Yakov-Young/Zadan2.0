
namespace WindowsFormsApp2._0
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Преобразовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox1.Location = new System.Drawing.Point(118, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(78, 98);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(200, 20);
            this.textBoxC.TabIndex = 3;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(24, 101);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(48, 13);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "Common";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(21, 131);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(51, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "Botanical";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(40, 157);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(32, 13);
            this.labelZ.TabIndex = 6;
            this.labelZ.Text = "Zone";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Location = new System.Drawing.Point(42, 183);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(30, 13);
            this.labelL.TabIndex = 7;
            this.labelL.Text = "Light";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(41, 209);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(31, 13);
            this.labelP.TabIndex = 8;
            this.labelP.Text = "Plant";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(16, 232);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 13);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "Availability";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(78, 128);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(200, 20);
            this.textBoxB.TabIndex = 10;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(78, 154);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(200, 20);
            this.textBoxZ.TabIndex = 11;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(78, 180);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(200, 20);
            this.textBoxL.TabIndex = 12;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(78, 206);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(200, 20);
            this.textBoxP.TabIndex = 13;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(78, 232);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(200, 20);
            this.textBoxA.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 287);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxA;
    }
}

