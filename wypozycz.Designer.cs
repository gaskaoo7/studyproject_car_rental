namespace projekt1
{
    partial class wypozycz
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
            this.components = new System.ComponentModel.Container();
            this.label_data_wyp = new System.Windows.Forms.Label();
            this.dateTimePicker_wypozycz = new System.Windows.Forms.DateTimePicker();
            this.label_data_odd = new System.Windows.Forms.Label();
            this.dateTimePicker_oddaj = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_samochod = new System.Windows.Forms.ComboBox();
            this.samochodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_klient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2_kwota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2_info = new System.Windows.Forms.TextBox();
            this.button1_wypo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_data_wyp
            // 
            this.label_data_wyp.AutoSize = true;
            this.label_data_wyp.Location = new System.Drawing.Point(29, 22);
            this.label_data_wyp.Name = "label_data_wyp";
            this.label_data_wyp.Size = new System.Drawing.Size(129, 17);
            this.label_data_wyp.TabIndex = 0;
            this.label_data_wyp.Text = "Data wypożyczenia";
            // 
            // dateTimePicker_wypozycz
            // 
            this.dateTimePicker_wypozycz.Location = new System.Drawing.Point(32, 42);
            this.dateTimePicker_wypozycz.Name = "dateTimePicker_wypozycz";
            this.dateTimePicker_wypozycz.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_wypozycz.TabIndex = 1;
            // 
            // label_data_odd
            // 
            this.label_data_odd.AutoSize = true;
            this.label_data_odd.Location = new System.Drawing.Point(32, 90);
            this.label_data_odd.Name = "label_data_odd";
            this.label_data_odd.Size = new System.Drawing.Size(164, 17);
            this.label_data_odd.TabIndex = 2;
            this.label_data_odd.Text = "Planowana data oddania";
            // 
            // dateTimePicker_oddaj
            // 
            this.dateTimePicker_oddaj.Location = new System.Drawing.Point(35, 110);
            this.dateTimePicker_oddaj.Name = "dateTimePicker_oddaj";
            this.dateTimePicker_oddaj.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_oddaj.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Samochód";
            // 
            // comboBox_samochod
            // 
            this.comboBox_samochod.FormattingEnabled = true;
            this.comboBox_samochod.Location = new System.Drawing.Point(32, 172);
            this.comboBox_samochod.Name = "comboBox_samochod";
            this.comboBox_samochod.Size = new System.Drawing.Size(200, 24);
            this.comboBox_samochod.TabIndex = 5;
            this.comboBox_samochod.Text = "wybierz";
            // 
            // samochodyBindingSource
            // 
            this.samochodyBindingSource.DataMember = "samochody";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Klient";
            // 
            // comboBox_klient
            // 
            this.comboBox_klient.FormattingEnabled = true;
            this.comboBox_klient.Location = new System.Drawing.Point(32, 243);
            this.comboBox_klient.Name = "comboBox_klient";
            this.comboBox_klient.Size = new System.Drawing.Size(203, 24);
            this.comboBox_klient.TabIndex = 7;
            this.comboBox_klient.Text = "wybierz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zaliczka";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Do zapłaty (razem)";
            // 
            // textBox2_kwota
            // 
            this.textBox2_kwota.Location = new System.Drawing.Point(32, 380);
            this.textBox2_kwota.Name = "textBox2_kwota";
            this.textBox2_kwota.Size = new System.Drawing.Size(138, 22);
            this.textBox2_kwota.TabIndex = 11;
            this.textBox2_kwota.TextChanged += new System.EventHandler(this.textBox2_kwota_TextChanged);
            this.textBox2_kwota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_kwota_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Informacje dodatkowe";
            // 
            // textBox2_info
            // 
            this.textBox2_info.Location = new System.Drawing.Point(386, 76);
            this.textBox2_info.Multiline = true;
            this.textBox2_info.Name = "textBox2_info";
            this.textBox2_info.Size = new System.Drawing.Size(300, 177);
            this.textBox2_info.TabIndex = 13;
            // 
            // button1_wypo
            // 
            this.button1_wypo.Location = new System.Drawing.Point(416, 331);
            this.button1_wypo.Name = "button1_wypo";
            this.button1_wypo.Size = new System.Drawing.Size(239, 82);
            this.button1_wypo.TabIndex = 14;
            this.button1_wypo.Text = "Wypożycz!";
            this.button1_wypo.UseVisualStyleBackColor = true;
            this.button1_wypo.Click += new System.EventHandler(this.button1_wypo_Click);
            // 
            // wypozycz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 515);
            this.Controls.Add(this.button1_wypo);
            this.Controls.Add(this.textBox2_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2_kwota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_klient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_samochod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_oddaj);
            this.Controls.Add(this.label_data_odd);
            this.Controls.Add(this.dateTimePicker_wypozycz);
            this.Controls.Add(this.label_data_wyp);
            this.Name = "wypozycz";
            this.Text = "wypozycz";
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_data_wyp;
        private System.Windows.Forms.DateTimePicker dateTimePicker_wypozycz;
        private System.Windows.Forms.Label label_data_odd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_oddaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_samochod;
        
        private System.Windows.Forms.BindingSource samochodyBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_klient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2_kwota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2_info;
        private System.Windows.Forms.Button button1_wypo;
    }
}