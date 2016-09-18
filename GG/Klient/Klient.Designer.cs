namespace Klient
{
    partial class Klient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgObrazek = new System.Windows.Forms.PictureBox();
            this.cmdWyslij = new System.Windows.Forms.Button();
            this.lblKolor = new System.Windows.Forms.Label();
            this.cmdKolor = new System.Windows.Forms.Button();
            this.cmdCzysc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgObrazek);
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 152);
            this.panel1.TabIndex = 0;
            // 
            // imgObrazek
            // 
            this.imgObrazek.Location = new System.Drawing.Point(0, 0);
            this.imgObrazek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgObrazek.Name = "imgObrazek";
            this.imgObrazek.Size = new System.Drawing.Size(532, 151);
            this.imgObrazek.TabIndex = 0;
            this.imgObrazek.TabStop = false;
            this.imgObrazek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.imgObrazek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cmdWyslij
            // 
            this.cmdWyslij.Location = new System.Drawing.Point(568, 97);
            this.cmdWyslij.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdWyslij.Name = "cmdWyslij";
            this.cmdWyslij.Size = new System.Drawing.Size(100, 28);
            this.cmdWyslij.TabIndex = 1;
            this.cmdWyslij.Text = "Wyslij";
            this.cmdWyslij.UseVisualStyleBackColor = true;
            this.cmdWyslij.Click += new System.EventHandler(this.cmdZapisz_Click);
            // 
            // lblKolor
            // 
            this.lblKolor.BackColor = System.Drawing.Color.Black;
            this.lblKolor.Location = new System.Drawing.Point(564, 26);
            this.lblKolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolor.Name = "lblKolor";
            this.lblKolor.Size = new System.Drawing.Size(31, 28);
            this.lblKolor.TabIndex = 2;
            // 
            // cmdKolor
            // 
            this.cmdKolor.Location = new System.Drawing.Point(600, 26);
            this.cmdKolor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdKolor.Name = "cmdKolor";
            this.cmdKolor.Size = new System.Drawing.Size(68, 28);
            this.cmdKolor.TabIndex = 3;
            this.cmdKolor.Text = "Kolor";
            this.cmdKolor.UseVisualStyleBackColor = true;
            this.cmdKolor.Click += new System.EventHandler(this.cmdKolor_Click);
            // 
            // cmdCzysc
            // 
            this.cmdCzysc.Location = new System.Drawing.Point(568, 62);
            this.cmdCzysc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCzysc.Name = "cmdCzysc";
            this.cmdCzysc.Size = new System.Drawing.Size(100, 28);
            this.cmdCzysc.TabIndex = 4;
            this.cmdCzysc.Text = "Czyœæ";
            this.cmdCzysc.UseVisualStyleBackColor = true;
            this.cmdCzysc.Click += new System.EventHandler(this.cmdCzysc_Click);
            // 
            // frmMiniPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(675, 546);
            this.Controls.Add(this.cmdCzysc);
            this.Controls.Add(this.cmdKolor);
            this.Controls.Add(this.lblKolor);
            this.Controls.Add(this.cmdWyslij);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMiniPaint";
            this.Text = "Mini Paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).EndInit();
            this.ResumeLayout(false);

        }
            this.txtOtrzymywane = new System.Windows.Forms.RichTextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdWyslij = new System.Windows.Forms.Button();
            this.txtWysylane = new System.Windows.Forms.RichTextBox();
            this.cmdPolacz = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Polaczenie = new System.ComponentModel.BackgroundWorker();
            this.Odbieranie = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtOtrzymywane
            // 
            this.txtOtrzymywane.BackColor = System.Drawing.SystemColors.Window;
            this.txtOtrzymywane.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOtrzymywane.Location = new System.Drawing.Point(13, 15);
            this.txtOtrzymywane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOtrzymywane.Name = "txtOtrzymywane";
            this.txtOtrzymywane.ReadOnly = true;
            this.txtOtrzymywane.Size = new System.Drawing.Size(317, 146);
            this.txtOtrzymywane.TabIndex = 24;
            this.txtOtrzymywane.Text = "";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.ForeColor = System.Drawing.Color.Black;
            this.txtLog.Location = new System.Drawing.Point(17, 270);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(317, 36);
            this.txtLog.TabIndex = 23;
            this.txtLog.TabStop = false;
            this.txtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Log";
            // 
            // cmdWyslij
            // 
            this.cmdWyslij.Enabled = false;
            this.cmdWyslij.Location = new System.Drawing.Point(395, 192);
            this.cmdWyslij.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdWyslij.Name = "cmdWyslij";
            this.cmdWyslij.Size = new System.Drawing.Size(56, 28);
            this.cmdWyslij.TabIndex = 21;
            this.cmdWyslij.Text = "Wyslij";
            this.cmdWyslij.UseVisualStyleBackColor = true;
            this.cmdWyslij.Click += new System.EventHandler(this.cmdWyslij_Click);
            // 
            // txtWysylane
            // 
            this.txtWysylane.BackColor = System.Drawing.Color.White;
            this.txtWysylane.ForeColor = System.Drawing.Color.Black;
            this.txtWysylane.Location = new System.Drawing.Point(13, 169);
            this.txtWysylane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWysylane.Name = "txtWysylane";
            this.txtWysylane.Size = new System.Drawing.Size(317, 77);
            this.txtWysylane.TabIndex = 20;
            this.txtWysylane.Text = "";
            this.txtWysylane.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWysylane_KeyPress);
            // 
            // cmdPolacz
            // 
            this.cmdPolacz.Location = new System.Drawing.Point(344, 114);
            this.cmdPolacz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdPolacz.Name = "cmdPolacz";
            this.cmdPolacz.Size = new System.Drawing.Size(107, 47);
            this.cmdPolacz.TabIndex = 29;
            this.cmdPolacz.Text = "Po³¹cz";
            this.cmdPolacz.UseVisualStyleBackColor = true;
            this.cmdPolacz.Click += new System.EventHandler(this.cmdPolacz_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(344, 82);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 22);
            this.txtPort.TabIndex = 28;
            this.txtPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nr portu";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(344, 34);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(108, 22);
            this.txtIP.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adres IP";
            // 
            // Polaczenie
            // 
            this.Polaczenie.WorkerSupportsCancellation = true;
            this.Polaczenie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Polaczenie_DoWork);
            // 
            // Odbieranie
            // 
            this.Odbieranie.WorkerSupportsCancellation = true;
            this.Odbieranie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Odbieranie_DoWork);
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(475, 319);
            this.Controls.Add(this.cmdPolacz);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOtrzymywane);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdWyslij);
            this.Controls.Add(this.txtWysylane);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Klient";
            this.Text = "Klient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Klient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOtrzymywane;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdWyslij;
        private System.Windows.Forms.RichTextBox txtWysylane;
        private System.Windows.Forms.Button cmdPolacz;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker Polaczenie;
        private System.ComponentModel.BackgroundWorker Odbieranie;
    }
}

