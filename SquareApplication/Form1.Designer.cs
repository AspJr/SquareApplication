
namespace SquareApplication
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
            this.btnTrigger = new System.Windows.Forms.Button();
            this.panelBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(88, 277);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnTrigger.TabIndex = 0;
            this.btnTrigger.Text = "Change";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // panelBox
            // 
            this.panelBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBox.Location = new System.Drawing.Point(88, 59);
            this.panelBox.Name = "panelBox";
            this.panelBox.Size = new System.Drawing.Size(417, 199);
            this.panelBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.panelBox);
            this.Controls.Add(this.btnTrigger);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Panel panelBox;
    }
}

