namespace WindowsFormsApp1
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_eletkor = new System.Windows.Forms.Label();
            this.tb_bevitelNev = new System.Windows.Forms.TextBox();
            this.tb_bevitelEletkor = new System.Windows.Forms.TextBox();
            this.tb_udvozles = new System.Windows.Forms.TextBox();
            this.tb_kimenetEletkor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(467, 42);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(6);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(196, 129);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nev.Location = new System.Drawing.Point(66, 63);
            this.lbl_nev.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(53, 24);
            this.lbl_nev.TabIndex = 1;
            this.lbl_nev.Text = "Név:";
            // 
            // lbl_eletkor
            // 
            this.lbl_eletkor.AutoSize = true;
            this.lbl_eletkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_eletkor.Location = new System.Drawing.Point(66, 119);
            this.lbl_eletkor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_eletkor.Name = "lbl_eletkor";
            this.lbl_eletkor.Size = new System.Drawing.Size(81, 24);
            this.lbl_eletkor.TabIndex = 2;
            this.lbl_eletkor.Text = "Életkor:";
            // 
            // tb_bevitelNev
            // 
            this.tb_bevitelNev.Location = new System.Drawing.Point(213, 63);
            this.tb_bevitelNev.Margin = new System.Windows.Forms.Padding(6);
            this.tb_bevitelNev.Name = "tb_bevitelNev";
            this.tb_bevitelNev.Size = new System.Drawing.Size(180, 29);
            this.tb_bevitelNev.TabIndex = 3;
            // 
            // tb_bevitelEletkor
            // 
            this.tb_bevitelEletkor.Location = new System.Drawing.Point(213, 114);
            this.tb_bevitelEletkor.Margin = new System.Windows.Forms.Padding(6);
            this.tb_bevitelEletkor.Name = "tb_bevitelEletkor";
            this.tb_bevitelEletkor.Size = new System.Drawing.Size(180, 29);
            this.tb_bevitelEletkor.TabIndex = 4;
            // 
            // tb_udvozles
            // 
            this.tb_udvozles.Location = new System.Drawing.Point(70, 247);
            this.tb_udvozles.Margin = new System.Windows.Forms.Padding(6);
            this.tb_udvozles.Name = "tb_udvozles";
            this.tb_udvozles.Size = new System.Drawing.Size(593, 29);
            this.tb_udvozles.TabIndex = 5;
            // 
            // tb_kimenetEletkor
            // 
            this.tb_kimenetEletkor.Location = new System.Drawing.Point(70, 288);
            this.tb_kimenetEletkor.Margin = new System.Windows.Forms.Padding(6);
            this.tb_kimenetEletkor.Name = "tb_kimenetEletkor";
            this.tb_kimenetEletkor.Size = new System.Drawing.Size(593, 29);
            this.tb_kimenetEletkor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 365);
            this.Controls.Add(this.tb_kimenetEletkor);
            this.Controls.Add(this.tb_udvozles);
            this.Controls.Add(this.tb_bevitelEletkor);
            this.Controls.Add(this.tb_bevitelNev);
            this.Controls.Add(this.lbl_eletkor);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.btn_OK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_eletkor;
        private System.Windows.Forms.TextBox tb_bevitelNev;
        private System.Windows.Forms.TextBox tb_bevitelEletkor;
        private System.Windows.Forms.TextBox tb_udvozles;
        private System.Windows.Forms.TextBox tb_kimenetEletkor;
    }
}

