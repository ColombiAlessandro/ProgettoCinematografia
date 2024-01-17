namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.preData = new System.Windows.Forms.Button();
            this.dopoData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.annullaFiltri = new System.Windows.Forms.Button();
            this.attoriMorti = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.preDataReg = new System.Windows.Forms.Button();
            this.dopoDataReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.annullaFiltriReg = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.filmBox = new System.Windows.Forms.TextBox();
            this.filmFiltro = new System.Windows.Forms.Button();
            this.attoreFiltro = new System.Windows.Forms.Button();
            this.attoreBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.unFilm = new System.Windows.Forms.Button();
            this.nessunFilm = new System.Windows.Forms.Button();
            this.piuDiFilm = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 581);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Film";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(281, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "Visualizza film con durata maggiore di 2h";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Filtra";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inserisci cognome regista";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(600, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(281, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Annulla filtri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Visualizza film con durata minore di 2h";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserisci genere";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filtra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(588, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.preData);
            this.tabPage2.Controls.Add(this.dopoData);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.annullaFiltri);
            this.tabPage2.Controls.Add(this.attoriMorti);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attori";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // preData
            // 
            this.preData.Location = new System.Drawing.Point(600, 297);
            this.preData.Name = "preData";
            this.preData.Size = new System.Drawing.Size(281, 44);
            this.preData.TabIndex = 7;
            this.preData.Text = "Visualizza attori nati prima la data inserita";
            this.preData.UseVisualStyleBackColor = true;
            this.preData.Click += new System.EventHandler(this.preData_Click);
            // 
            // dopoData
            // 
            this.dopoData.Location = new System.Drawing.Point(600, 247);
            this.dopoData.Name = "dopoData";
            this.dopoData.Size = new System.Drawing.Size(281, 44);
            this.dopoData.TabIndex = 6;
            this.dopoData.Text = "Visualizza attori nati dopo la data inserita";
            this.dopoData.UseVisualStyleBackColor = true;
            this.dopoData.Click += new System.EventHandler(this.dopoData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data di nascita";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(606, 73);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // annullaFiltri
            // 
            this.annullaFiltri.Location = new System.Drawing.Point(600, 347);
            this.annullaFiltri.Name = "annullaFiltri";
            this.annullaFiltri.Size = new System.Drawing.Size(281, 44);
            this.annullaFiltri.TabIndex = 3;
            this.annullaFiltri.Text = "Annulla filtri";
            this.annullaFiltri.UseVisualStyleBackColor = true;
            this.annullaFiltri.Click += new System.EventHandler(this.annullaFiltri_Click);
            // 
            // attoriMorti
            // 
            this.attoriMorti.Location = new System.Drawing.Point(600, 6);
            this.attoriMorti.Name = "attoriMorti";
            this.attoriMorti.Size = new System.Drawing.Size(281, 44);
            this.attoriMorti.TabIndex = 2;
            this.attoriMorti.Text = "Visualizza attori morti";
            this.attoriMorti.UseVisualStyleBackColor = true;
            this.attoriMorti.Click += new System.EventHandler(this.attoriMorti_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(588, 368);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.preDataReg);
            this.tabPage3.Controls.Add(this.dopoDataReg);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.monthCalendar2);
            this.tabPage3.Controls.Add(this.annullaFiltriReg);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(887, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // preDataReg
            // 
            this.preDataReg.Location = new System.Drawing.Point(597, 293);
            this.preDataReg.Name = "preDataReg";
            this.preDataReg.Size = new System.Drawing.Size(281, 44);
            this.preDataReg.TabIndex = 11;
            this.preDataReg.Text = "Visualizza registi nati prima la data inserita";
            this.preDataReg.UseVisualStyleBackColor = true;
            this.preDataReg.Click += new System.EventHandler(this.preDataReg_Click);
            // 
            // dopoDataReg
            // 
            this.dopoDataReg.Location = new System.Drawing.Point(597, 243);
            this.dopoDataReg.Name = "dopoDataReg";
            this.dopoDataReg.Size = new System.Drawing.Size(281, 44);
            this.dopoDataReg.TabIndex = 10;
            this.dopoDataReg.Text = "Visualizza registi nati dopo la data inserita";
            this.dopoDataReg.UseVisualStyleBackColor = true;
            this.dopoDataReg.Click += new System.EventHandler(this.dopoDataReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data di nascita";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(603, 69);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 8;
            // 
            // annullaFiltriReg
            // 
            this.annullaFiltriReg.Location = new System.Drawing.Point(597, 343);
            this.annullaFiltriReg.Name = "annullaFiltriReg";
            this.annullaFiltriReg.Size = new System.Drawing.Size(281, 44);
            this.annullaFiltriReg.TabIndex = 4;
            this.annullaFiltriReg.Text = "Annulla filtri";
            this.annullaFiltriReg.UseVisualStyleBackColor = true;
            this.annullaFiltriReg.Click += new System.EventHandler(this.annullaFiltriReg_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(597, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(287, 44);
            this.button6.TabIndex = 3;
            this.button6.Text = "Visualizza registi morti";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(588, 368);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.attoreFiltro);
            this.tabPage4.Controls.Add(this.attoreBox);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.filmFiltro);
            this.tabPage4.Controls.Add(this.filmBox);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.unFilm);
            this.tabPage4.Controls.Add(this.nessunFilm);
            this.tabPage4.Controls.Add(this.piuDiFilm);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(887, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Partecipazioni";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(588, 368);
            this.dataGridView4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome film";
            // 
            // filmBox
            // 
            this.filmBox.Location = new System.Drawing.Point(600, 173);
            this.filmBox.Name = "filmBox";
            this.filmBox.Size = new System.Drawing.Size(284, 20);
            this.filmBox.TabIndex = 6;
            // 
            // filmFiltro
            // 
            this.filmFiltro.Location = new System.Drawing.Point(597, 199);
            this.filmFiltro.Name = "filmFiltro";
            this.filmFiltro.Size = new System.Drawing.Size(287, 27);
            this.filmFiltro.TabIndex = 7;
            this.filmFiltro.Text = "Filtra in base al film";
            this.filmFiltro.UseVisualStyleBackColor = true;
            this.filmFiltro.Click += new System.EventHandler(this.filmFiltro_Click);
            // 
            // attoreFiltro
            // 
            this.attoreFiltro.Location = new System.Drawing.Point(597, 281);
            this.attoreFiltro.Name = "attoreFiltro";
            this.attoreFiltro.Size = new System.Drawing.Size(287, 27);
            this.attoreFiltro.TabIndex = 10;
            this.attoreFiltro.Text = "Filtra in base al film";
            this.attoreFiltro.UseVisualStyleBackColor = true;
            this.attoreFiltro.Click += new System.EventHandler(this.attoreFiltro_Click);
            // 
            // attoreBox
            // 
            this.attoreBox.Location = new System.Drawing.Point(600, 255);
            this.attoreBox.Name = "attoreBox";
            this.attoreBox.Size = new System.Drawing.Size(284, 20);
            this.attoreBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cognome attore";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(597, 325);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(287, 46);
            this.button7.TabIndex = 11;
            this.button7.Text = "Annulla filtri";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // unFilm
            // 
            this.unFilm.Location = new System.Drawing.Point(597, 107);
            this.unFilm.Name = "unFilm";
            this.unFilm.Size = new System.Drawing.Size(287, 46);
            this.unFilm.TabIndex = 4;
            this.unFilm.Text = "Visualizza attori che appaiono solo in un film";
            this.unFilm.UseVisualStyleBackColor = true;
            this.unFilm.Click += new System.EventHandler(this.unFilm_Click);
            // 
            // nessunFilm
            // 
            this.nessunFilm.Location = new System.Drawing.Point(597, 55);
            this.nessunFilm.Name = "nessunFilm";
            this.nessunFilm.Size = new System.Drawing.Size(287, 46);
            this.nessunFilm.TabIndex = 3;
            this.nessunFilm.Text = "Visualizza attori che appaiono in nessun film";
            this.nessunFilm.UseVisualStyleBackColor = true;
            this.nessunFilm.Click += new System.EventHandler(this.nessunFilm_Click);
            // 
            // piuDiFilm
            // 
            this.piuDiFilm.Location = new System.Drawing.Point(597, 3);
            this.piuDiFilm.Name = "piuDiFilm";
            this.piuDiFilm.Size = new System.Drawing.Size(287, 46);
            this.piuDiFilm.TabIndex = 2;
            this.piuDiFilm.Text = "Visualizza attori che appaiono in più di un film";
            this.piuDiFilm.UseVisualStyleBackColor = true;
            this.piuDiFilm.Click += new System.EventHandler(this.piuDiFilm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 605);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button preData;
        private System.Windows.Forms.Button dopoData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button annullaFiltri;
        private System.Windows.Forms.Button attoriMorti;
        private System.Windows.Forms.Button annullaFiltriReg;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button preDataReg;
        private System.Windows.Forms.Button dopoDataReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button attoreFiltro;
        private System.Windows.Forms.TextBox attoreBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filmFiltro;
        private System.Windows.Forms.TextBox filmBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button unFilm;
        private System.Windows.Forms.Button nessunFilm;
        private System.Windows.Forms.Button piuDiFilm;
    }
}

