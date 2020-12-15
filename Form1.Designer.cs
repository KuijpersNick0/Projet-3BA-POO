namespace PrjtInfoBA3_2
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreer = new System.Windows.Forms.TextBox();
            this.txtProduction = new System.Windows.Forms.TextBox();
            this.txtCoutProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPol = new System.Windows.Forms.TextBox();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoCentrale = new System.Windows.Forms.RadioButton();
            this.rdoConso = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConsomation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lstInfo2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Production";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cout Production";
            // 
            // txtCreer
            // 
            this.txtCreer.Location = new System.Drawing.Point(156, 93);
            this.txtCreer.Name = "txtCreer";
            this.txtCreer.Size = new System.Drawing.Size(159, 22);
            this.txtCreer.TabIndex = 3;
            // 
            // txtProduction
            // 
            this.txtProduction.Location = new System.Drawing.Point(156, 121);
            this.txtProduction.Name = "txtProduction";
            this.txtProduction.Size = new System.Drawing.Size(159, 22);
            this.txtProduction.TabIndex = 4;
            // 
            // txtCoutProd
            // 
            this.txtCoutProd.Location = new System.Drawing.Point(156, 153);
            this.txtCoutProd.Name = "txtCoutProd";
            this.txtCoutProd.Size = new System.Drawing.Size(159, 22);
            this.txtCoutProd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Polution";
            // 
            // txtPol
            // 
            this.txtPol.Location = new System.Drawing.Point(156, 185);
            this.txtPol.Name = "txtPol";
            this.txtPol.Size = new System.Drawing.Size(159, 22);
            this.txtPol.TabIndex = 7;
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 16;
            this.lstInfo.Location = new System.Drawing.Point(39, 261);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(498, 164);
            this.lstInfo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAjouter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Connexion";
            // 
            // rdoCentrale
            // 
            this.rdoCentrale.AutoSize = true;
            this.rdoCentrale.Checked = true;
            this.rdoCentrale.Location = new System.Drawing.Point(39, 13);
            this.rdoCentrale.Name = "rdoCentrale";
            this.rdoCentrale.Size = new System.Drawing.Size(82, 21);
            this.rdoCentrale.TabIndex = 12;
            this.rdoCentrale.TabStop = true;
            this.rdoCentrale.Text = "Centrale";
            this.rdoCentrale.UseVisualStyleBackColor = true;
            this.rdoCentrale.CheckedChanged += new System.EventHandler(this.rdoCentrale_CheckedChanged);
            // 
            // rdoConso
            // 
            this.rdoConso.AutoSize = true;
            this.rdoConso.Location = new System.Drawing.Point(156, 13);
            this.rdoConso.Name = "rdoConso";
            this.rdoConso.Size = new System.Drawing.Size(113, 21);
            this.rdoConso.TabIndex = 13;
            this.rdoConso.Text = "Consomateur";
            this.rdoConso.UseVisualStyleBackColor = true;
            this.rdoConso.CheckedChanged += new System.EventHandler(this.rdoConso_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Consomation";
            // 
            // txtConsomation
            // 
            this.txtConsomation.Location = new System.Drawing.Point(593, 93);
            this.txtConsomation.Name = "txtConsomation";
            this.txtConsomation.Size = new System.Drawing.Size(159, 22);
            this.txtConsomation.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(593, 121);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(159, 22);
            this.txtNom.TabIndex = 17;
            // 
            // lstInfo2
            // 
            this.lstInfo2.FormattingEnabled = true;
            this.lstInfo2.ItemHeight = 16;
            this.lstInfo2.Location = new System.Drawing.Point(561, 261);
            this.lstInfo2.Name = "lstInfo2";
            this.lstInfo2.Size = new System.Drawing.Size(498, 164);
            this.lstInfo2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 570);
            this.Controls.Add(this.lstInfo2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtConsomation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdoConso);
            this.Controls.Add(this.rdoCentrale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.txtPol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoutProd);
            this.Controls.Add(this.txtProduction);
            this.Controls.Add(this.txtCreer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreer;
        private System.Windows.Forms.TextBox txtProduction;
        private System.Windows.Forms.TextBox txtCoutProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPol;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoCentrale;
        private System.Windows.Forms.RadioButton rdoConso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConsomation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ListBox lstInfo2;
    }
}

