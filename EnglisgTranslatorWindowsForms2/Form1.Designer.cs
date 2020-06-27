namespace EnglisgTranslatorWindowsForms2
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
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.txtDestLang = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lblCorection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(12, 12);
            this.txtSrc.Multiline = true;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(776, 189);
            this.txtSrc.TabIndex = 0;
            // 
            // txtDestLang
            // 
            this.txtDestLang.Location = new System.Drawing.Point(12, 243);
            this.txtDestLang.Multiline = true;
            this.txtDestLang.Name = "txtDestLang";
            this.txtDestLang.Size = new System.Drawing.Size(776, 195);
            this.txtDestLang.TabIndex = 1;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(12, 207);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(118, 30);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lblCorection
            // 
            this.lblCorection.AutoSize = true;
            this.lblCorection.BackColor = System.Drawing.SystemColors.Window;
            this.lblCorection.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCorection.Location = new System.Drawing.Point(23, 173);
            this.lblCorection.Name = "lblCorection";
            this.lblCorection.Size = new System.Drawing.Size(0, 17);
            this.lblCorection.TabIndex = 3;
            this.lblCorection.Click += new System.EventHandler(this.lblCorection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCorection);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtDestLang);
            this.Controls.Add(this.txtSrc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.TextBox txtDestLang;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label lblCorection;
    }
}

