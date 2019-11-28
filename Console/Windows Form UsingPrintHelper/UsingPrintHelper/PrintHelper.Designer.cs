namespace UsingPrintHelper
{
    partial class PrintHelper
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
            this.BtnPlOk = new System.Windows.Forms.Button();
            this.btplCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPlOk
            // 
            this.BtnPlOk.Location = new System.Drawing.Point(325, 233);
            this.BtnPlOk.Name = "BtnPlOk";
            this.BtnPlOk.Size = new System.Drawing.Size(75, 23);
            this.BtnPlOk.TabIndex = 0;
            this.BtnPlOk.Text = "OK";
            this.BtnPlOk.UseVisualStyleBackColor = true;
            this.BtnPlOk.Click += new System.EventHandler(this.BtnPlOk_Click);
            // 
            // btplCancel
            // 
            this.btplCancel.Location = new System.Drawing.Point(432, 233);
            this.btplCancel.Name = "btplCancel";
            this.btplCancel.Size = new System.Drawing.Size(75, 23);
            this.btplCancel.TabIndex = 1;
            this.btplCancel.Text = "Cancel";
            this.btplCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 22);
            this.textBox1.TabIndex = 3;
            // 
            // PrintHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 274);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btplCancel);
            this.Controls.Add(this.BtnPlOk);
            this.Name = "PrintHelper";
            this.Text = "PrintHelper";
            this.Load += new System.EventHandler(this.PrintHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlOk;
        private System.Windows.Forms.Button btplCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}