namespace CODJUMPER_2_noviembre
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.paneltop1 = new System.Windows.Forms.Panel();
            this.btnMainMinimize = new System.Windows.Forms.Button();
            this.btnMainClose = new System.Windows.Forms.Button();
            this.paneltop2 = new System.Windows.Forms.Panel();
            this.panelcolumn = new System.Windows.Forms.Panel();
            this.panelform1deployable = new System.Windows.Forms.Panel();
            this.btnCustom5 = new System.Windows.Forms.Button();
            this.btnCustom4 = new System.Windows.Forms.Button();
            this.btnCustom3 = new System.Windows.Forms.Button();
            this.btnCustom2 = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnCustom1 = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCoDJumper = new System.Windows.Forms.Button();
            this.btnPromod = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.panelspace = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.paneltop1.SuspendLayout();
            this.panelcolumn.SuspendLayout();
            this.panelform1deployable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop1
            // 
            this.paneltop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.paneltop1.Controls.Add(this.btnMainMinimize);
            this.paneltop1.Controls.Add(this.btnMainClose);
            this.paneltop1.Controls.Add(this.paneltop2);
            this.paneltop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop1.Location = new System.Drawing.Point(0, 0);
            this.paneltop1.Name = "paneltop1";
            this.paneltop1.Size = new System.Drawing.Size(1280, 40);
            this.paneltop1.TabIndex = 0;
            this.paneltop1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop1_MouseDown);
            this.paneltop1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltop1_MouseMove);
            this.paneltop1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneltop1_MouseUp);
            // 
            // btnMainMinimize
            // 
            this.btnMainMinimize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMainMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainMinimize.BackgroundImage")));
            this.btnMainMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnMainMinimize.Location = new System.Drawing.Point(1210, 11);
            this.btnMainMinimize.Name = "btnMainMinimize";
            this.btnMainMinimize.Size = new System.Drawing.Size(26, 26);
            this.btnMainMinimize.TabIndex = 2;
            this.btnMainMinimize.UseVisualStyleBackColor = false;
            this.btnMainMinimize.Click += new System.EventHandler(this.btnMainMinimize_Click);
            // 
            // btnMainClose
            // 
            this.btnMainClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMainClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainClose.BackgroundImage")));
            this.btnMainClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnMainClose.Location = new System.Drawing.Point(1242, 11);
            this.btnMainClose.Name = "btnMainClose";
            this.btnMainClose.Size = new System.Drawing.Size(26, 26);
            this.btnMainClose.TabIndex = 2;
            this.btnMainClose.UseVisualStyleBackColor = false;
            this.btnMainClose.Click += new System.EventHandler(this.btnMainClose_Click);
            // 
            // paneltop2
            // 
            this.paneltop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.paneltop2.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneltop2.Location = new System.Drawing.Point(0, 0);
            this.paneltop2.Name = "paneltop2";
            this.paneltop2.Size = new System.Drawing.Size(190, 40);
            this.paneltop2.TabIndex = 0;
            this.paneltop2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop2_MouseDown);
            this.paneltop2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltop2_MouseMove);
            this.paneltop2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneltop2_MouseUp);
            // 
            // panelcolumn
            // 
            this.panelcolumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelcolumn.Controls.Add(this.panelform1deployable);
            this.panelcolumn.Controls.Add(this.btnInfo);
            this.panelcolumn.Controls.Add(this.btnSettings);
            this.panelcolumn.Controls.Add(this.btnCoDJumper);
            this.panelcolumn.Controls.Add(this.btnPromod);
            this.panelcolumn.Controls.Add(this.btnDefault);
            this.panelcolumn.Controls.Add(this.panelspace);
            this.panelcolumn.Controls.Add(this.pictureBox1);
            this.panelcolumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelcolumn.Location = new System.Drawing.Point(0, 40);
            this.panelcolumn.Name = "panelcolumn";
            this.panelcolumn.Size = new System.Drawing.Size(190, 680);
            this.panelcolumn.TabIndex = 1;
            // 
            // panelform1deployable
            // 
            this.panelform1deployable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelform1deployable.Controls.Add(this.btnCustom5);
            this.panelform1deployable.Controls.Add(this.btnCustom4);
            this.panelform1deployable.Controls.Add(this.btnCustom3);
            this.panelform1deployable.Controls.Add(this.btnCustom2);
            this.panelform1deployable.Controls.Add(this.btnCustom);
            this.panelform1deployable.Controls.Add(this.btnCustom1);
            this.panelform1deployable.Location = new System.Drawing.Point(0, 309);
            this.panelform1deployable.Name = "panelform1deployable";
            this.panelform1deployable.Size = new System.Drawing.Size(190, 240);
            this.panelform1deployable.TabIndex = 4;
            // 
            // btnCustom5
            // 
            this.btnCustom5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnCustom5.FlatAppearance.BorderSize = 0;
            this.btnCustom5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom5.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustom5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCustom5.Location = new System.Drawing.Point(35, 191);
            this.btnCustom5.Name = "btnCustom5";
            this.btnCustom5.Size = new System.Drawing.Size(120, 30);
            this.btnCustom5.TabIndex = 2;
            this.btnCustom5.Text = "5";
            this.btnCustom5.UseVisualStyleBackColor = false;
            this.btnCustom5.Click += new System.EventHandler(this.btnCustom5_Click);
            // 
            // btnCustom4
            // 
            this.btnCustom4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnCustom4.FlatAppearance.BorderSize = 0;
            this.btnCustom4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom4.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustom4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCustom4.Location = new System.Drawing.Point(35, 155);
            this.btnCustom4.Name = "btnCustom4";
            this.btnCustom4.Size = new System.Drawing.Size(120, 30);
            this.btnCustom4.TabIndex = 2;
            this.btnCustom4.Text = "4";
            this.btnCustom4.UseVisualStyleBackColor = false;
            this.btnCustom4.Click += new System.EventHandler(this.btnCustom4_Click);
            // 
            // btnCustom3
            // 
            this.btnCustom3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnCustom3.FlatAppearance.BorderSize = 0;
            this.btnCustom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom3.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustom3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCustom3.Location = new System.Drawing.Point(35, 119);
            this.btnCustom3.Name = "btnCustom3";
            this.btnCustom3.Size = new System.Drawing.Size(120, 30);
            this.btnCustom3.TabIndex = 2;
            this.btnCustom3.Text = "3";
            this.btnCustom3.UseVisualStyleBackColor = false;
            this.btnCustom3.Click += new System.EventHandler(this.btnCustom3_Click);
            // 
            // btnCustom2
            // 
            this.btnCustom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnCustom2.FlatAppearance.BorderSize = 0;
            this.btnCustom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom2.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustom2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCustom2.Location = new System.Drawing.Point(35, 83);
            this.btnCustom2.Name = "btnCustom2";
            this.btnCustom2.Size = new System.Drawing.Size(120, 30);
            this.btnCustom2.TabIndex = 2;
            this.btnCustom2.Text = "2";
            this.btnCustom2.UseVisualStyleBackColor = false;
            this.btnCustom2.Click += new System.EventHandler(this.btnCustom2_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnCustom.FlatAppearance.BorderSize = 0;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCustom.Location = new System.Drawing.Point(15, 6);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(160, 35);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnCustom1
            // 
            this.btnCustom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnCustom1.FlatAppearance.BorderSize = 0;
            this.btnCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom1.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustom1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCustom1.Location = new System.Drawing.Point(35, 47);
            this.btnCustom1.Name = "btnCustom1";
            this.btnCustom1.Size = new System.Drawing.Size(120, 30);
            this.btnCustom1.TabIndex = 2;
            this.btnCustom1.Text = "1";
            this.btnCustom1.UseVisualStyleBackColor = false;
            this.btnCustom1.Click += new System.EventHandler(this.btnCustom1_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(111, 619);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(49, 49);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(30, 619);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(49, 49);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCoDJumper
            // 
            this.btnCoDJumper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnCoDJumper.FlatAppearance.BorderSize = 0;
            this.btnCoDJumper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoDJumper.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCoDJumper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCoDJumper.Location = new System.Drawing.Point(15, 275);
            this.btnCoDJumper.Name = "btnCoDJumper";
            this.btnCoDJumper.Size = new System.Drawing.Size(160, 35);
            this.btnCoDJumper.TabIndex = 2;
            this.btnCoDJumper.Text = "CoD Jumper";
            this.btnCoDJumper.UseVisualStyleBackColor = false;
            this.btnCoDJumper.Click += new System.EventHandler(this.btnCoDJumper_Click);
            // 
            // btnPromod
            // 
            this.btnPromod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnPromod.FlatAppearance.BorderSize = 0;
            this.btnPromod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromod.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPromod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnPromod.Location = new System.Drawing.Point(15, 234);
            this.btnPromod.Name = "btnPromod";
            this.btnPromod.Size = new System.Drawing.Size(160, 35);
            this.btnPromod.TabIndex = 2;
            this.btnPromod.Text = "Promod";
            this.btnPromod.UseVisualStyleBackColor = false;
            this.btnPromod.Click += new System.EventHandler(this.btnPromod_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnDefault.FlatAppearance.BorderSize = 0;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnDefault.Location = new System.Drawing.Point(15, 193);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(160, 35);
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // panelspace
            // 
            this.panelspace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelspace.Location = new System.Drawing.Point(0, 135);
            this.panelspace.Name = "panelspace";
            this.panelspace.Size = new System.Drawing.Size(190, 10);
            this.panelspace.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(196, 43);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1080, 670);
            this.panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelcolumn);
            this.Controls.Add(this.paneltop1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.paneltop1.ResumeLayout(false);
            this.panelcolumn.ResumeLayout(false);
            this.panelform1deployable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel paneltop1;
        private Panel paneltop2;
        private Panel panelcolumn;
        private Panel panelspace;
        private PictureBox pictureBox1;
        private Button btnMainClose;
        private Button btnMainMinimize;
        private Button btnInfo;
        private Button btnSettings;
        private Button btnDefault;
        private Button btnCustom;
        private Button btnCoDJumper;
        private Button btnPromod;
        private Button btnCustom1;
        private Button btnCustom5;
        private Button btnCustom4;
        private Button btnCustom3;
        private Button btnCustom2;
        private Panel panelMain;
        private Panel panelform1deployable;
    }
}