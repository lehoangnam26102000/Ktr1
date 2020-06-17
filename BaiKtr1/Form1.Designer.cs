namespace BaiKtr1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnTinhtoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số a";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(192, 33);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 1;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtKQ
            // 
            this.txtKQ.Cursor = System.Windows.Forms.Cursors.No;
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(192, 241);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(329, 96);
            this.txtKQ.TabIndex = 2;
            this.txtKQ.Text = "";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(192, 89);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(192, 149);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 22);
            this.txtC.TabIndex = 4;
            this.txtC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtC_KeyDown);
            // 
            // btnTinhtoan
            // 
            this.btnTinhtoan.Location = new System.Drawing.Point(422, 68);
            this.btnTinhtoan.Name = "btnTinhtoan";
            this.btnTinhtoan.Size = new System.Drawing.Size(99, 23);
            this.btnTinhtoan.TabIndex = 5;
            this.btnTinhtoan.Text = "Tính toán";
            this.btnTinhtoan.UseVisualStyleBackColor = true;
            this.btnTinhtoan.Click += new System.EventHandler(this.btnTinhtoan_Click);
            //this.btnTinhtoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTinhtoan_KeyDown);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(422, 130);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hệ số b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hệ số c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhtoan);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RichTextBox txtKQ;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnTinhtoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

