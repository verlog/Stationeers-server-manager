namespace Stationeers_SM
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
            this.SelectSrvDir = new System.Windows.Forms.Button();
            this.SelectSaveDir = new System.Windows.Forms.Button();
            this.lblRunCommand = new System.Windows.Forms.Label();
            this.btnStartSrv = new System.Windows.Forms.Button();
            this.btnStopSrv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chbbatchmode = new System.Windows.Forms.CheckBox();
            this.chbnographics = new System.Windows.Forms.CheckBox();
            this.chbautostart = new System.Windows.Forms.CheckBox();
            this.txtAutosaveinterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGameport = new System.Windows.Forms.TextBox();
            this.txtWorldname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLoadworld = new System.Windows.Forms.CheckBox();
            this.cmbWorldtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClearallinterval = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSrv_dir = new System.Windows.Forms.TextBox();
            this.txtbasedirectory = new System.Windows.Forms.TextBox();
            this.txtRconPas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectSrvDir
            // 
            this.SelectSrvDir.Location = new System.Drawing.Point(393, 12);
            this.SelectSrvDir.Name = "SelectSrvDir";
            this.SelectSrvDir.Size = new System.Drawing.Size(75, 23);
            this.SelectSrvDir.TabIndex = 1;
            this.SelectSrvDir.Text = "Browse";
            this.SelectSrvDir.UseVisualStyleBackColor = true;
            this.SelectSrvDir.Click += new System.EventHandler(this.SelectSrvDir_Click);
            // 
            // SelectSaveDir
            // 
            this.SelectSaveDir.Location = new System.Drawing.Point(393, 41);
            this.SelectSaveDir.Name = "SelectSaveDir";
            this.SelectSaveDir.Size = new System.Drawing.Size(75, 23);
            this.SelectSaveDir.TabIndex = 3;
            this.SelectSaveDir.Text = "Browse";
            this.SelectSaveDir.UseVisualStyleBackColor = true;
            this.SelectSaveDir.Click += new System.EventHandler(this.SelectSaveDir_Click);
            // 
            // lblRunCommand
            // 
            this.lblRunCommand.AutoSize = true;
            this.lblRunCommand.Location = new System.Drawing.Point(9, 418);
            this.lblRunCommand.Name = "lblRunCommand";
            this.lblRunCommand.Size = new System.Drawing.Size(77, 13);
            this.lblRunCommand.TabIndex = 4;
            this.lblRunCommand.Text = "Command Line";
            this.lblRunCommand.Visible = false;
            // 
            // btnStartSrv
            // 
            this.btnStartSrv.Enabled = false;
            this.btnStartSrv.Location = new System.Drawing.Point(11, 434);
            this.btnStartSrv.Name = "btnStartSrv";
            this.btnStartSrv.Size = new System.Drawing.Size(75, 42);
            this.btnStartSrv.TabIndex = 5;
            this.btnStartSrv.Text = "Start";
            this.btnStartSrv.UseVisualStyleBackColor = true;
            this.btnStartSrv.Click += new System.EventHandler(this.btnStartSrv_Click);
            // 
            // btnStopSrv
            // 
            this.btnStopSrv.Enabled = false;
            this.btnStopSrv.Location = new System.Drawing.Point(92, 434);
            this.btnStopSrv.Name = "btnStopSrv";
            this.btnStopSrv.Size = new System.Drawing.Size(75, 42);
            this.btnStopSrv.TabIndex = 6;
            this.btnStopSrv.Text = "Stop";
            this.btnStopSrv.UseVisualStyleBackColor = true;
            this.btnStopSrv.Click += new System.EventHandler(this.btnStopSrv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(459, 149);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // chbbatchmode
            // 
            this.chbbatchmode.AutoSize = true;
            this.chbbatchmode.Location = new System.Drawing.Point(10, 126);
            this.chbbatchmode.Name = "chbbatchmode";
            this.chbbatchmode.Size = new System.Drawing.Size(79, 17);
            this.chbbatchmode.TabIndex = 12;
            this.chbbatchmode.Text = "batchmode";
            this.chbbatchmode.UseVisualStyleBackColor = true;
            // 
            // chbnographics
            // 
            this.chbnographics.AutoSize = true;
            this.chbnographics.Location = new System.Drawing.Point(11, 149);
            this.chbnographics.Name = "chbnographics";
            this.chbnographics.Size = new System.Drawing.Size(78, 17);
            this.chbnographics.TabIndex = 13;
            this.chbnographics.Text = "nographics";
            this.chbnographics.UseVisualStyleBackColor = true;
            // 
            // chbautostart
            // 
            this.chbautostart.AutoSize = true;
            this.chbautostart.Location = new System.Drawing.Point(11, 172);
            this.chbautostart.Name = "chbautostart";
            this.chbautostart.Size = new System.Drawing.Size(67, 17);
            this.chbautostart.TabIndex = 14;
            this.chbautostart.Text = "autostart";
            this.chbautostart.UseVisualStyleBackColor = true;
            // 
            // txtAutosaveinterval
            // 
            this.txtAutosaveinterval.Location = new System.Drawing.Point(400, 101);
            this.txtAutosaveinterval.Name = "txtAutosaveinterval";
            this.txtAutosaveinterval.Size = new System.Drawing.Size(63, 20);
            this.txtAutosaveinterval.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Autosaveinterval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gameport";
            // 
            // txtGameport
            // 
            this.txtGameport.Location = new System.Drawing.Point(400, 177);
            this.txtGameport.Name = "txtGameport";
            this.txtGameport.Size = new System.Drawing.Size(63, 20);
            this.txtGameport.TabIndex = 17;
            // 
            // txtWorldname
            // 
            this.txtWorldname.Location = new System.Drawing.Point(400, 127);
            this.txtWorldname.Name = "txtWorldname";
            this.txtWorldname.Size = new System.Drawing.Size(63, 20);
            this.txtWorldname.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Worldtype";
            // 
            // chkLoadworld
            // 
            this.chkLoadworld.AutoSize = true;
            this.chkLoadworld.Location = new System.Drawing.Point(313, 130);
            this.chkLoadworld.Name = "chkLoadworld";
            this.chkLoadworld.Size = new System.Drawing.Size(75, 17);
            this.chkLoadworld.TabIndex = 23;
            this.chkLoadworld.Text = "Loadworld";
            this.chkLoadworld.UseVisualStyleBackColor = true;
            // 
            // cmbWorldtype
            // 
            this.cmbWorldtype.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmbWorldtype.FormattingEnabled = true;
            this.cmbWorldtype.Items.AddRange(new object[] {
            "Space",
            "Mars",
            "Moon"});
            this.cmbWorldtype.Location = new System.Drawing.Point(400, 150);
            this.cmbWorldtype.Name = "cmbWorldtype";
            this.cmbWorldtype.Size = new System.Drawing.Size(63, 21);
            this.cmbWorldtype.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Servername";
            // 
            // txtServername
            // 
            this.txtServername.Location = new System.Drawing.Point(92, 67);
            this.txtServername.Name = "txtServername";
            this.txtServername.Size = new System.Drawing.Size(112, 20);
            this.txtServername.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Updateport";
            // 
            // txtUpdateport
            // 
            this.txtUpdateport.Location = new System.Drawing.Point(400, 203);
            this.txtUpdateport.Name = "txtUpdateport";
            this.txtUpdateport.Size = new System.Drawing.Size(63, 20);
            this.txtUpdateport.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Clearallinterval";
            // 
            // txtClearallinterval
            // 
            this.txtClearallinterval.Location = new System.Drawing.Point(104, 200);
            this.txtClearallinterval.Name = "txtClearallinterval";
            this.txtClearallinterval.Size = new System.Drawing.Size(63, 20);
            this.txtClearallinterval.TabIndex = 29;
            this.txtClearallinterval.Text = "Clearallinterval";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSrv_dir
            // 
            this.txtSrv_dir.Location = new System.Drawing.Point(12, 12);
            this.txtSrv_dir.Name = "txtSrv_dir";
            this.txtSrv_dir.Size = new System.Drawing.Size(375, 20);
            this.txtSrv_dir.TabIndex = 32;
            // 
            // txtbasedirectory
            // 
            this.txtbasedirectory.Location = new System.Drawing.Point(12, 41);
            this.txtbasedirectory.Name = "txtbasedirectory";
            this.txtbasedirectory.Size = new System.Drawing.Size(375, 20);
            this.txtbasedirectory.TabIndex = 33;
            // 
            // txtRconPas
            // 
            this.txtRconPas.Location = new System.Drawing.Point(92, 93);
            this.txtRconPas.Name = "txtRconPas";
            this.txtRconPas.Size = new System.Drawing.Size(112, 20);
            this.txtRconPas.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "RCON password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 477);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRconPas);
            this.Controls.Add(this.txtbasedirectory);
            this.Controls.Add(this.txtSrv_dir);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClearallinterval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUpdateport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServername);
            this.Controls.Add(this.cmbWorldtype);
            this.Controls.Add(this.chkLoadworld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWorldname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGameport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutosaveinterval);
            this.Controls.Add(this.chbautostart);
            this.Controls.Add(this.chbnographics);
            this.Controls.Add(this.chbbatchmode);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStopSrv);
            this.Controls.Add(this.btnStartSrv);
            this.Controls.Add(this.lblRunCommand);
            this.Controls.Add(this.SelectSaveDir);
            this.Controls.Add(this.SelectSrvDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Stationeers server manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectSrvDir;
        private System.Windows.Forms.Button SelectSaveDir;
        private System.Windows.Forms.Label lblRunCommand;
        private System.Windows.Forms.Button btnStartSrv;
        private System.Windows.Forms.Button btnStopSrv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chbbatchmode;
        private System.Windows.Forms.CheckBox chbnographics;
        private System.Windows.Forms.CheckBox chbautostart;
        private System.Windows.Forms.TextBox txtAutosaveinterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGameport;
        private System.Windows.Forms.TextBox txtWorldname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkLoadworld;
        private System.Windows.Forms.ComboBox cmbWorldtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClearallinterval;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSrv_dir;
        private System.Windows.Forms.TextBox txtbasedirectory;
        private System.Windows.Forms.TextBox txtRconPas;
        private System.Windows.Forms.Label label7;
    }
}

