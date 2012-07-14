namespace Zinsrechner2010
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_DruckenAlles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_Beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_Anfangskapital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbox_ZinsCHF2 = new System.Windows.Forms.TextBox();
            this.txtbox_ZinsProzent2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_Endkapital2 = new System.Windows.Forms.TextBox();
            this.txtbox_Anfangskapital2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Zinsfussberechnung = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_ZinsCHF3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Anfangskapital3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_ZinsProzent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolstrip_Beenden});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menü";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_DruckenAlles,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItem1.Text = "Drucken...";
            // 
            // toolstrip_DruckenAlles
            // 
            this.toolstrip_DruckenAlles.Name = "toolstrip_DruckenAlles";
            this.toolstrip_DruckenAlles.Size = new System.Drawing.Size(181, 22);
            this.toolstrip_DruckenAlles.Text = "Alles";
            this.toolstrip_DruckenAlles.Click += new System.EventHandler(this.toolstrip_DruckenAlles_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem3.Text = "Zinsberechnung";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem4.Text = "Kapitalberechnung";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem5.Text = "Zinsfussberechnung";
            // 
            // toolstrip_Beenden
            // 
            this.toolstrip_Beenden.Name = "toolstrip_Beenden";
            this.toolstrip_Beenden.Size = new System.Drawing.Size(127, 22);
            this.toolstrip_Beenden.Text = "Beenden";
            this.toolstrip_Beenden.Click += new System.EventHandler(this.toolstrip_Beenden_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtbox_Anfangskapital);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(218, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kapitalberechnung";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Zins";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(73, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zinssatz in %";
            // 
            // txtbox_Anfangskapital
            // 
            this.txtbox_Anfangskapital.Enabled = false;
            this.txtbox_Anfangskapital.Location = new System.Drawing.Point(94, 96);
            this.txtbox_Anfangskapital.Name = "txtbox_Anfangskapital";
            this.txtbox_Anfangskapital.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Anfangskapital.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Anfangskapital";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbox_ZinsCHF2);
            this.groupBox3.Controls.Add(this.txtbox_ZinsProzent2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtbox_Endkapital2);
            this.groupBox3.Controls.Add(this.txtbox_Anfangskapital2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 158);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zinsberechnung";
            // 
            // txtbox_ZinsCHF2
            // 
            this.txtbox_ZinsCHF2.Enabled = false;
            this.txtbox_ZinsCHF2.Location = new System.Drawing.Point(94, 121);
            this.txtbox_ZinsCHF2.Name = "txtbox_ZinsCHF2";
            this.txtbox_ZinsCHF2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ZinsCHF2.TabIndex = 11;
            // 
            // txtbox_ZinsProzent2
            // 
            this.txtbox_ZinsProzent2.Location = new System.Drawing.Point(94, 47);
            this.txtbox_ZinsProzent2.Name = "txtbox_ZinsProzent2";
            this.txtbox_ZinsProzent2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ZinsProzent2.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 124);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(28, 14);
            this.label12.TabIndex = 9;
            this.label12.Text = "Zins";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 50);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(73, 14);
            this.label13.TabIndex = 8;
            this.label13.Text = "Zinssatz in %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 7;
            this.label9.Text = "Endkapital";
            // 
            // txtbox_Endkapital2
            // 
            this.txtbox_Endkapital2.Enabled = false;
            this.txtbox_Endkapital2.Location = new System.Drawing.Point(94, 95);
            this.txtbox_Endkapital2.Name = "txtbox_Endkapital2";
            this.txtbox_Endkapital2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Endkapital2.TabIndex = 6;
            // 
            // txtbox_Anfangskapital2
            // 
            this.txtbox_Anfangskapital2.Location = new System.Drawing.Point(94, 21);
            this.txtbox_Anfangskapital2.Name = "txtbox_Anfangskapital2";
            this.txtbox_Anfangskapital2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Anfangskapital2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 24);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(79, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "Anfangskapital";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Zinsrechner";
            // 
            // btn_Zinsfussberechnung
            // 
            this.btn_Zinsfussberechnung.Location = new System.Drawing.Point(466, 234);
            this.btn_Zinsfussberechnung.Name = "btn_Zinsfussberechnung";
            this.btn_Zinsfussberechnung.Size = new System.Drawing.Size(127, 23);
            this.btn_Zinsfussberechnung.TabIndex = 5;
            this.btn_Zinsfussberechnung.Text = "Zinsfussberechnung";
            this.btn_Zinsfussberechnung.UseVisualStyleBackColor = true;
            this.btn_Zinsfussberechnung.Click += new System.EventHandler(this.btn_Rechnen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kapitalberechnung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zinsberechnung";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Drucken";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.DocumentName = "Zinsberechnung";
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_ZinsCHF3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbox_Anfangskapital3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbox_ZinsProzent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(424, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zinsfussberechnung";
            // 
            // txtbox_ZinsCHF3
            // 
            this.txtbox_ZinsCHF3.Location = new System.Drawing.Point(94, 46);
            this.txtbox_ZinsCHF3.Name = "txtbox_ZinsCHF3";
            this.txtbox_ZinsCHF3.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ZinsCHF3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Zins";
            // 
            // txtbox_Anfangskapital3
            // 
            this.txtbox_Anfangskapital3.Location = new System.Drawing.Point(94, 20);
            this.txtbox_Anfangskapital3.Name = "txtbox_Anfangskapital3";
            this.txtbox_Anfangskapital3.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Anfangskapital3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Anfangskapital";
            // 
            // txtbox_ZinsProzent
            // 
            this.txtbox_ZinsProzent.Enabled = false;
            this.txtbox_ZinsProzent.Location = new System.Drawing.Point(94, 96);
            this.txtbox_ZinsProzent.Name = "txtbox_ZinsProzent";
            this.txtbox_ZinsProzent.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ZinsProzent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zinssatz in %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Zinsfussberechnung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbox_Anfangskapital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Zinsfussberechnung;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_DruckenAlles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_Beenden;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbox_ZinsCHF2;
        private System.Windows.Forms.TextBox txtbox_ZinsProzent2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_Endkapital2;
        private System.Windows.Forms.TextBox txtbox_Anfangskapital2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbox_ZinsCHF3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_Anfangskapital3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_ZinsProzent;
        private System.Windows.Forms.Label label1;
    }
}

