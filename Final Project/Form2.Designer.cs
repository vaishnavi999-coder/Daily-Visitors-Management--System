namespace Final_Project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfam = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtall = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btup = new System.Windows.Forms.Button();
            this.btde = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Family Details\r\n";
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.Color.Transparent;
            this.btback.FlatAppearance.BorderSize = 0;
            this.btback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btback.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btback.Location = new System.Drawing.Point(838, 425);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(43, 34);
            this.btback.TabIndex = 15;
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Family ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "No.Of.Family Members";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monthly Allowance";
            // 
            // txtfam
            // 
            this.txtfam.BackColor = System.Drawing.Color.Linen;
            this.txtfam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfam.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfam.Location = new System.Drawing.Point(195, 75);
            this.txtfam.MaxLength = 5;
            this.txtfam.Name = "txtfam";
            this.txtfam.Size = new System.Drawing.Size(162, 18);
            this.txtfam.TabIndex = 6;
            this.txtfam.WordWrap = false;
            this.txtfam.TextChanged += new System.EventHandler(this.txtfam_TextChanged);
            this.txtfam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfam_KeyDown);
            this.txtfam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfam_KeyPress);
            // 
            // txtno
            // 
            this.txtno.BackColor = System.Drawing.Color.Linen;
            this.txtno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtno.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(195, 209);
            this.txtno.MaxLength = 2;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(86, 18);
            this.txtno.TabIndex = 9;
            this.txtno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtno_KeyDown);
            this.txtno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtno_KeyPress);
            // 
            // txtall
            // 
            this.txtall.BackColor = System.Drawing.Color.Linen;
            this.txtall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtall.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtall.Location = new System.Drawing.Point(195, 255);
            this.txtall.MaxLength = 8;
            this.txtall.Name = "txtall";
            this.txtall.Size = new System.Drawing.Size(137, 18);
            this.txtall.TabIndex = 10;
            this.txtall.TextChanged += new System.EventHandler(this.txtall_TextChanged);
            this.txtall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtall_KeyPress);
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.Transparent;
            this.btsave.FlatAppearance.BorderSize = 0;
            this.btsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsave.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Linen;
            this.btsave.Location = new System.Drawing.Point(16, 316);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(112, 42);
            this.btsave.TabIndex = 11;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.Transparent;
            this.btadd.FlatAppearance.BorderSize = 0;
            this.btadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.Linen;
            this.btadd.Location = new System.Drawing.Point(221, 316);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(111, 42);
            this.btadd.TabIndex = 12;
            this.btadd.Text = "Add ";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btup
            // 
            this.btup.BackColor = System.Drawing.Color.Transparent;
            this.btup.FlatAppearance.BorderSize = 0;
            this.btup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btup.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btup.ForeColor = System.Drawing.Color.Linen;
            this.btup.Location = new System.Drawing.Point(16, 382);
            this.btup.Name = "btup";
            this.btup.Size = new System.Drawing.Size(111, 42);
            this.btup.TabIndex = 13;
            this.btup.Text = "Update";
            this.btup.UseVisualStyleBackColor = false;
            this.btup.Click += new System.EventHandler(this.btup_Click);
            // 
            // btde
            // 
            this.btde.BackColor = System.Drawing.Color.Transparent;
            this.btde.FlatAppearance.BorderSize = 0;
            this.btde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btde.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btde.ForeColor = System.Drawing.Color.Linen;
            this.btde.Location = new System.Drawing.Point(221, 383);
            this.btde.Name = "btde";
            this.btde.Size = new System.Drawing.Size(111, 42);
            this.btde.TabIndex = 14;
            this.btde.Text = "Delete";
            this.btde.UseVisualStyleBackColor = false;
            this.btde.Click += new System.EventHandler(this.btde_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 241);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address";
            // 
            // txtadd
            // 
            this.txtadd.BackColor = System.Drawing.Color.Linen;
            this.txtadd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.Location = new System.Drawing.Point(195, 160);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(100, 18);
            this.txtadd.TabIndex = 21;
            this.txtadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtadd_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Linen;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(727, 135);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(145, 29);
            this.txtsearch.TabIndex = 23;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(195, 116);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 23);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Permanent";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(337, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 23);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Temporary";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.familydetails;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btde);
            this.Controls.Add(this.btup);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txtall);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtfam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfam;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtall;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btup;
        private System.Windows.Forms.Button btde;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}