namespace EmloyeeLogin
{
    partial class Frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlog = new Button();
            btnclose = new Button();
            txtpassword = new TextBox();
            txtname = new TextBox();
            lblpassword = new Label();
            lblname = new Label();
            lblwelcom = new Label();
            SuspendLayout();
            // 
            // btnlog
            // 
            btnlog.BackColor = SystemColors.ControlLightLight;
            btnlog.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnlog.Location = new Point(658, 394);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(117, 52);
            btnlog.TabIndex = 13;
            btnlog.Text = "Login";
            btnlog.UseVisualStyleBackColor = false;
            btnlog.Click += btnlog_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = SystemColors.HighlightText;
            btnclose.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnclose.ForeColor = SystemColors.ActiveCaptionText;
            btnclose.ImageAlign = ContentAlignment.BottomCenter;
            btnclose.Location = new Point(14, 394);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(117, 52);
            btnclose.TabIndex = 12;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(306, 225);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(267, 30);
            txtpassword.TabIndex = 11;
            // 
            // txtname
            // 
            txtname.Location = new Point(306, 175);
            txtname.Name = "txtname";
            txtname.Size = new Size(267, 30);
            txtname.TabIndex = 10;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblpassword.Location = new Point(162, 225);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(122, 27);
            lblpassword.TabIndex = 9;
            lblpassword.Text = "Password";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblname.Location = new Point(213, 171);
            lblname.Name = "lblname";
            lblname.Size = new Size(77, 27);
            lblname.TabIndex = 8;
            lblname.Text = "Name";
            // 
            // lblwelcom
            // 
            lblwelcom.AutoSize = true;
            lblwelcom.Font = new Font("Algerian", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblwelcom.Location = new Point(274, 24);
            lblwelcom.Name = "lblwelcom";
            lblwelcom.Size = new Size(145, 31);
            lblwelcom.TabIndex = 7;
            lblwelcom.Text = "Welcome";
            lblwelcom.TextAlign = ContentAlignment.TopCenter;
            lblwelcom.Click += lblwelcom_Click;
            // 
            // Frmlogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(789, 460);
            Controls.Add(btnlog);
            Controls.Add(btnclose);
            Controls.Add(txtpassword);
            Controls.Add(txtname);
            Controls.Add(lblpassword);
            Controls.Add(lblname);
            Controls.Add(lblwelcom);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Frmlogin";
            Text = "Login Form";
            Load += Frmlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlog;
        private Button btnclose;
        private TextBox txtpassword;
        private TextBox txtname;
        private Label lblpassword;
        private Label lblname;
        private Label lblwelcom;
    }
}