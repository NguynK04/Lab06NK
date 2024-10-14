namespace GUI
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
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(25, 25);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(81, 16);
            this.lblMSV.TabIndex = 0;
            this.lblMSV.Text = "Ma sinh vien";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(25, 56);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(46, 16);
            this.lblHoten.TabIndex = 1;
            this.lblHoten.Text = "Ho ten";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(25, 85);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 2;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(25, 117);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(99, 16);
            this.lblDiemTB.TabIndex = 3;
            this.lblDiemTB.Text = "Diem trung binh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 365);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(25, 146);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(81, 16);
            this.lblAnh.TabIndex = 5;
            this.lblAnh.Text = "Anh dai dien";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(140, 22);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(121, 22);
            this.txtMSV.TabIndex = 6;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(140, 49);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(121, 22);
            this.txtHoten.TabIndex = 7;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(140, 111);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(121, 22);
            this.txtDiemTB.TabIndex = 8;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "N\'Công nghệ thông tin\'",
            "N\'Ngành ngôn ngữ Anh\'",
            "N\'Marketing\'"});
            this.cmbKhoa.Location = new System.Drawing.Point(140, 77);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbKhoa.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 132);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(44, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Add ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(226, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(903, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Chua DK chuyen nganh";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.txtDiemTB);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.lblAnh);
            this.groupBox1.Controls.Add(this.lblDiemTB);
            this.groupBox1.Controls.Add(this.lblKhoa);
            this.groupBox1.Controls.Add(this.lblHoten);
            this.groupBox1.Controls.Add(this.lblMSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 350);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin sinh vien";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(125, 321);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(144, 293);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(100, 22);
            this.txtAnh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Chuc nang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(426, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quan ly sinh vien";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Quan ly sinh vien";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
    }
}

