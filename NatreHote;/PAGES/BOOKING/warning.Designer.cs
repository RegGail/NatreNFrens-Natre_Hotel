namespace NatreHote_.PAGES.BOOKING
{
    partial class warning
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sPanel1 = new buttons.SPanel();
            this.button1 = new buttons.button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.sPanel1.BorderColor = System.Drawing.Color.Maroon;
            this.sPanel1.BorderRadius = 20;
            this.sPanel1.BorderSize = 3;
            this.sPanel1.Controls.Add(this.button1);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(-2, -2);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(745, 398);
            this.sPanel1.TabIndex = 0;
            this.sPanel1.TextColor = System.Drawing.Color.White;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderRadius = 12;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(258, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "RETURN TO TRANSACTION";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(59, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "You have not yet entered the amount \r\nneeded to proceed with the transaction, \r\np" +
    "lease do so before trying to confirm.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 33.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "ERROR!";
            // 
            // warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sPanel1);
            this.Name = "warning";
            this.Size = new System.Drawing.Size(743, 396);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private buttons.SPanel sPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private buttons.button button1;
    }
}
