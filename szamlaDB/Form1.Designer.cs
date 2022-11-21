namespace szamlaDB
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
            this.szamlaList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nyitasPicker = new System.Windows.Forms.DateTimePicker();
            this.egysegarCont = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.idCont = new System.Windows.Forms.NumericUpDown();
            this.nameCont = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCont)).BeginInit();
            this.SuspendLayout();
            // 
            // szamlaList
            // 
            this.szamlaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.szamlaList.Dock = System.Windows.Forms.DockStyle.Left;
            this.szamlaList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamlaList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.szamlaList.FormattingEnabled = true;
            this.szamlaList.ItemHeight = 18;
            this.szamlaList.Location = new System.Drawing.Point(0, 0);
            this.szamlaList.Name = "szamlaList";
            this.szamlaList.Size = new System.Drawing.Size(326, 291);
            this.szamlaList.TabIndex = 0;
            this.szamlaList.SelectedIndexChanged += new System.EventHandler(this.szamlaList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nyitasPicker);
            this.groupBox1.Controls.Add(this.egysegarCont);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Modify);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.idCont);
            this.groupBox1.Controls.Add(this.nameCont);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.groupBox1.Location = new System.Drawing.Point(326, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok";
            // 
            // nyitasPicker
            // 
            this.nyitasPicker.Location = new System.Drawing.Point(115, 130);
            this.nyitasPicker.Name = "nyitasPicker";
            this.nyitasPicker.Size = new System.Drawing.Size(200, 20);
            this.nyitasPicker.TabIndex = 13;
            // 
            // egysegarCont
            // 
            this.egysegarCont.Location = new System.Drawing.Point(115, 92);
            this.egysegarCont.Name = "egysegarCont";
            this.egysegarCont.Size = new System.Drawing.Size(100, 20);
            this.egysegarCont.TabIndex = 12;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(126, 243);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Törlés";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Modify
            // 
            this.Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify.ForeColor = System.Drawing.Color.White;
            this.Modify.Location = new System.Drawing.Point(126, 214);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(75, 23);
            this.Modify.TabIndex = 10;
            this.Modify.Text = "Módosítás";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(126, 185);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Új adat";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // idCont
            // 
            this.idCont.Location = new System.Drawing.Point(115, 16);
            this.idCont.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.idCont.Name = "idCont";
            this.idCont.Size = new System.Drawing.Size(75, 20);
            this.idCont.TabIndex = 8;
            // 
            // nameCont
            // 
            this.nameCont.Location = new System.Drawing.Point(115, 54);
            this.nameCont.Name = "nameCont";
            this.nameCont.Size = new System.Drawing.Size(100, 20);
            this.nameCont.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(44, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "nyitás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "egyenleg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tulaj neve:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(652, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.szamlaList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox szamlaList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.NumericUpDown idCont;
        private System.Windows.Forms.TextBox nameCont;
        private System.Windows.Forms.TextBox egysegarCont;
        private System.Windows.Forms.DateTimePicker nyitasPicker;
    }
}

