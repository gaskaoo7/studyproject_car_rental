namespace projekt1
{
    partial class edytuj_rez
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox_edytuj = new System.Windows.Forms.CheckBox();
            this.button_usun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_klient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_auto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_wypoz = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1_zapiszedycje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz rezerwacje do usunięcia lub edycji";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(412, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // checkBox_edytuj
            // 
            this.checkBox_edytuj.AutoSize = true;
            this.checkBox_edytuj.Location = new System.Drawing.Point(16, 107);
            this.checkBox_edytuj.Name = "checkBox_edytuj";
            this.checkBox_edytuj.Size = new System.Drawing.Size(147, 21);
            this.checkBox_edytuj.TabIndex = 2;
            this.checkBox_edytuj.Text = "Chcesz edytowac?";
            this.checkBox_edytuj.UseVisualStyleBackColor = true;
            this.checkBox_edytuj.CheckStateChanged += new System.EventHandler(this.checkBox_edytuj_CheckStateChanged);
            // 
            // button_usun
            // 
            this.button_usun.Location = new System.Drawing.Point(232, 94);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(173, 44);
            this.button_usun.TabIndex = 3;
            this.button_usun.Text = "Usuń rezerwacje";
            this.button_usun.UseVisualStyleBackColor = true;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Klient";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_klient
            // 
            this.comboBox_klient.Enabled = false;
            this.comboBox_klient.FormattingEnabled = true;
            this.comboBox_klient.Location = new System.Drawing.Point(13, 190);
            this.comboBox_klient.Name = "comboBox_klient";
            this.comboBox_klient.Size = new System.Drawing.Size(262, 24);
            this.comboBox_klient.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Samochód";
            // 
            // comboBox_auto
            // 
            this.comboBox_auto.Enabled = false;
            this.comboBox_auto.FormattingEnabled = true;
            this.comboBox_auto.Location = new System.Drawing.Point(13, 260);
            this.comboBox_auto.Name = "comboBox_auto";
            this.comboBox_auto.Size = new System.Drawing.Size(262, 24);
            this.comboBox_auto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Planowana data wypożyczenia";
            // 
            // dateTimePicker_wypoz
            // 
            this.dateTimePicker_wypoz.Enabled = false;
            this.dateTimePicker_wypoz.Location = new System.Drawing.Point(13, 326);
            this.dateTimePicker_wypoz.Name = "dateTimePicker_wypoz";
            this.dateTimePicker_wypoz.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_wypoz.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data rezerwacji (data edycji)";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(13, 400);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // button1_zapiszedycje
            // 
            this.button1_zapiszedycje.Enabled = false;
            this.button1_zapiszedycje.Location = new System.Drawing.Point(232, 446);
            this.button1_zapiszedycje.Name = "button1_zapiszedycje";
            this.button1_zapiszedycje.Size = new System.Drawing.Size(174, 60);
            this.button1_zapiszedycje.TabIndex = 12;
            this.button1_zapiszedycje.Text = "Zapisz zmiany";
            this.button1_zapiszedycje.UseVisualStyleBackColor = true;
            this.button1_zapiszedycje.Click += new System.EventHandler(this.button1_zapiszedycje_Click);
            // 
            // edytuj_rez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 548);
            this.Controls.Add(this.button1_zapiszedycje);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_wypoz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_auto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_klient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_usun);
            this.Controls.Add(this.checkBox_edytuj);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "edytuj_rez";
            this.Text = "edytuj_rez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox_edytuj;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_klient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_auto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_wypoz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1_zapiszedycje;
    }
}