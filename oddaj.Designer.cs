namespace projekt1
{
    partial class oddaj
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
            this.comboBox_oddaj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_dozaplaty = new System.Windows.Forms.TextBox();
            this.button_oddaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz wypożyczenie do zakończenia";
            // 
            // comboBox_oddaj
            // 
            this.comboBox_oddaj.FormattingEnabled = true;
            this.comboBox_oddaj.Location = new System.Drawing.Point(34, 44);
            this.comboBox_oddaj.Name = "comboBox_oddaj";
            this.comboBox_oddaj.Size = new System.Drawing.Size(494, 24);
            this.comboBox_oddaj.TabIndex = 1;
            this.comboBox_oddaj.SelectedIndexChanged += new System.EventHandler(this.comboBox_oddaj_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zostało do zapłaty:";
            // 
            // textBox_dozaplaty
            // 
            this.textBox_dozaplaty.Location = new System.Drawing.Point(37, 118);
            this.textBox_dozaplaty.Name = "textBox_dozaplaty";
            this.textBox_dozaplaty.Size = new System.Drawing.Size(125, 22);
            this.textBox_dozaplaty.TabIndex = 3;
            // 
            // button_oddaj
            // 
            this.button_oddaj.Location = new System.Drawing.Point(37, 174);
            this.button_oddaj.Name = "button_oddaj";
            this.button_oddaj.Size = new System.Drawing.Size(125, 45);
            this.button_oddaj.TabIndex = 4;
            this.button_oddaj.Text = "Oddaj";
            this.button_oddaj.UseVisualStyleBackColor = true;
            this.button_oddaj.Click += new System.EventHandler(this.button_oddaj_Click);
            // 
            // oddaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 358);
            this.Controls.Add(this.button_oddaj);
            this.Controls.Add(this.textBox_dozaplaty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_oddaj);
            this.Controls.Add(this.label1);
            this.Name = "oddaj";
            this.Text = "oddaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_oddaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_dozaplaty;
        private System.Windows.Forms.Button button_oddaj;
    }
}