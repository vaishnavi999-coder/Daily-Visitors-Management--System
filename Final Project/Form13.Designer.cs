namespace Final_Project
{
    partial class Form13
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
            this.btch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btre = new System.Windows.Forms.Button();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btch
            // 
            this.btch.BackColor = System.Drawing.Color.Transparent;
            this.btch.FlatAppearance.BorderSize = 0;
            this.btch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btch.Location = new System.Drawing.Point(218, 205);
            this.btch.Name = "btch";
            this.btch.Size = new System.Drawing.Size(93, 28);
            this.btch.TabIndex = 11;
            this.btch.Text = "CheckIn";
            this.btch.UseVisualStyleBackColor = false;
            this.btch.Click += new System.EventHandler(this.btch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btre);
            this.panel1.Controls.Add(this.txtcon);
            this.panel1.Controls.Add(this.txtnew);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(29, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 198);
            this.panel1.TabIndex = 10;
            // 
            // btre
            // 
            this.btre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btre.Location = new System.Drawing.Point(196, 124);
            this.btre.Name = "btre";
            this.btre.Size = new System.Drawing.Size(86, 31);
            this.btre.TabIndex = 9;
            this.btre.Text = "RESET";
            this.btre.UseVisualStyleBackColor = false;
            this.btre.Click += new System.EventHandler(this.btre_Click);
            // 
            // txtcon
            // 
            this.txtcon.BackColor = System.Drawing.Color.Linen;
            this.txtcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcon.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon.Location = new System.Drawing.Point(190, 79);
            this.txtcon.MaxLength = 4;
            this.txtcon.Name = "txtcon";
            this.txtcon.PasswordChar = '*';
            this.txtcon.Size = new System.Drawing.Size(100, 18);
            this.txtcon.TabIndex = 8;
            this.txtcon.TextChanged += new System.EventHandler(this.txtcon_TextChanged);
            // 
            // txtnew
            // 
            this.txtnew.BackColor = System.Drawing.Color.Linen;
            this.txtnew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnew.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnew.Location = new System.Drawing.Point(190, 41);
            this.txtnew.MaxLength = 4;
            this.txtnew.Name = "txtnew";
            this.txtnew.PasswordChar = '*';
            this.txtnew.Size = new System.Drawing.Size(100, 18);
            this.txtnew.TabIndex = 7;
            this.txtnew.TextChanged += new System.EventHandler(this.txtnew_TextChanged);
            this.txtnew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnew_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(835, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 30);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtun
            // 
            this.txtun.BackColor = System.Drawing.Color.Linen;
            this.txtun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.Location = new System.Drawing.Point(219, 160);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(100, 18);
            this.txtun.TabIndex = 9;
            this.txtun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtun_KeyDown);
            this.txtun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtun_KeyPress);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Linen;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(219, 114);
            this.txtid.MaxLength = 2;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 18);
            this.txtid.TabIndex = 8;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "UserID";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.forget21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btre;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}