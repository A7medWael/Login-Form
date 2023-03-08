namespace EmloyeeLogin
{
    partial class Frmalter
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgv_employee = new DataGridView();
            btnexit = new Button();
            btnshow = new Button();
            btnalt = new Button();
            txtid = new TextBox();
            txtnamea = new TextBox();
            txtaddress = new TextBox();
            txtphone = new TextBox();
            txtpassworddd = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgv_employee).BeginInit();
            SuspendLayout();
            // 
            // dgv_employee
            // 
            dgv_employee.AllowDrop = true;
            dgv_employee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_employee.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_employee.Dock = DockStyle.Top;
            dgv_employee.Location = new Point(0, 0);
            dgv_employee.Margin = new Padding(4);
            dgv_employee.Name = "dgv_employee";
            dgv_employee.RowHeadersWidth = 51;
            dgv_employee.RowTemplate.Height = 29;
            dgv_employee.Size = new Size(571, 216);
            dgv_employee.TabIndex = 0;
            dgv_employee.CellContentClick += dgv_employee_CellContentClick;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(13, 313);
            btnexit.Margin = new Padding(4);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(103, 61);
            btnexit.TabIndex = 2;
            btnexit.Text = "Close";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnshow
            // 
            btnshow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnshow.Location = new Point(432, 314);
            btnshow.Margin = new Padding(4);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(99, 61);
            btnshow.TabIndex = 3;
            btnshow.Text = "Show";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // btnalt
            // 
            btnalt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnalt.Location = new Point(227, 316);
            btnalt.Name = "btnalt";
            btnalt.Size = new Size(94, 59);
            btnalt.TabIndex = 4;
            btnalt.Text = "Alter";
            btnalt.UseVisualStyleBackColor = true;
            btnalt.Click += btnalt_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(22, 226);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 31);
            txtid.TabIndex = 5;
            toolTip1.SetToolTip(txtid, "Id");
            // 
            // txtnamea
            // 
            txtnamea.Location = new Point(153, 226);
            txtnamea.Name = "txtnamea";
            txtnamea.Size = new Size(125, 31);
            txtnamea.TabIndex = 6;
            toolTip1.SetToolTip(txtnamea, "name");
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(284, 226);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(125, 31);
            txtaddress.TabIndex = 7;
            toolTip1.SetToolTip(txtaddress, "Address");
            // 
            // txtphone
            // 
            txtphone.Location = new Point(415, 226);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(125, 31);
            txtphone.TabIndex = 8;
            toolTip1.SetToolTip(txtphone, "Phone");
            // 
            // txtpassworddd
            // 
            txtpassworddd.Location = new Point(215, 263);
            txtpassworddd.Name = "txtpassworddd";
            txtpassworddd.Size = new Size(125, 31);
            txtpassworddd.TabIndex = 9;
            toolTip1.SetToolTip(txtpassworddd, "Password");
            // 
            // Frmalter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 384);
            Controls.Add(txtpassworddd);
            Controls.Add(txtphone);
            Controls.Add(txtaddress);
            Controls.Add(txtnamea);
            Controls.Add(txtid);
            Controls.Add(btnalt);
            Controls.Add(btnshow);
            Controls.Add(btnexit);
            Controls.Add(dgv_employee);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Frmalter";
            Text = "Frmalter";
            Load += Frmalter_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_employee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_employee;
        private Button btnexit;
        private Button btnshow;
        private Button btnalt;
        private TextBox txtid;
        private ToolTip toolTip1;
        private TextBox txtnamea;
        private TextBox txtaddress;
        private TextBox txtphone;
        private TextBox txtpassworddd;
    }
}