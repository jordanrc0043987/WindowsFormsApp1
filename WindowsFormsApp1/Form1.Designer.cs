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
            this.Hello = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(60, 56);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(75, 23);
            this.Hello.TabIndex = 0;
            this.Hello.Text = "button1";
            this.Hello.UseVisualStyleBackColor = true;
            this.Hello.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(60, 85);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.Hello);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                                                              ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hello;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

