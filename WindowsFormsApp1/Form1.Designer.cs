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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FnameTB = new System.Windows.Forms.TextBox();
            this.LnameTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.UnameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // FnameTB
            // 
            this.FnameTB.Location = new System.Drawing.Point(204, 53);
            this.FnameTB.Name = "FnameTB";
            this.FnameTB.Size = new System.Drawing.Size(152, 22);
            this.FnameTB.TabIndex = 4;
            this.FnameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LnameTB
            // 
            this.LnameTB.Location = new System.Drawing.Point(204, 97);
            this.LnameTB.Name = "LnameTB";
            this.LnameTB.Size = new System.Drawing.Size(152, 22);
            this.LnameTB.TabIndex = 5;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(204, 135);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(152, 22);
            this.PhoneTB.TabIndex = 6;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(204, 170);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(152, 22);
            this.AddressTB.TabIndex = 7;
            this.AddressTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(78, 225);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(84, 35);
            this.SaveBTN.TabIndex = 8;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(401, 225);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(86, 35);
            this.UpdateBTN.TabIndex = 9;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(743, 225);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(79, 35);
            this.DeleteBTN.TabIndex = 10;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(78, 288);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(744, 183);
            this.DGV.TabIndex = 12;
            // 
            // UnameTB
            // 
            this.UnameTB.Location = new System.Drawing.Point(669, 100);
            this.UnameTB.Name = "UnameTB";
            this.UnameTB.Size = new System.Drawing.Size(152, 22);
            this.UnameTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "UserName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(886, 501);
            this.Controls.Add(this.UnameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.LnameTB);
            this.Controls.Add(this.FnameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FnameTB;
        private System.Windows.Forms.TextBox LnameTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox UnameTB;
        private System.Windows.Forms.Label label5;
    }
}

