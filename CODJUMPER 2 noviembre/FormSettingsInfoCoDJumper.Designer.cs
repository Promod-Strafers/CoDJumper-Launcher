namespace CODJUMPER_2_noviembre
{
    partial class FormSettingsInfoCoDJumper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettingsInfoCoDJumper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldevmapmode = new System.Windows.Forms.Label();
            this.lblcfgname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnaccept);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbldevmapmode);
            this.panel1.Controls.Add(this.lblcfgname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 230);
            this.panel1.TabIndex = 2;
            // 
            // btnaccept
            // 
            this.btnaccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaccept.BackgroundImage")));
            this.btnaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccept.Location = new System.Drawing.Point(216, 170);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(48, 48);
            this.btnaccept.TabIndex = 1;
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(52, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Devmap mode:";
            // 
            // lbldevmapmode
            // 
            this.lbldevmapmode.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldevmapmode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lbldevmapmode.Location = new System.Drawing.Point(238, 115);
            this.lbldevmapmode.Name = "lbldevmapmode";
            this.lbldevmapmode.Size = new System.Drawing.Size(229, 30);
            this.lbldevmapmode.TabIndex = 0;
            // 
            // lblcfgname
            // 
            this.lblcfgname.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcfgname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblcfgname.Location = new System.Drawing.Point(238, 75);
            this.lblcfgname.Name = "lblcfgname";
            this.lblcfgname.Size = new System.Drawing.Size(229, 30);
            this.lblcfgname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(5, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Config file name:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CoDJumper Settings Info";
            // 
            // FormSettingsInfoCoDJumper
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettingsInfoCoDJumper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnaccept;
        private Label label3;
        private Label lbldevmapmode;
        private Label lblcfgname;
        private Label label2;
        private Label label1;
    }
}