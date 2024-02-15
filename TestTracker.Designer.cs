namespace Scp_Map
{
    partial class TestTracker
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
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lstPlayerList = new System.Windows.Forms.ListBox();
            this.PlayerNameTB = new System.Windows.Forms.TextBox();
            this.lstDead = new System.Windows.Forms.ListBox();
            this.lstDangerous = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PlayersTB = new System.Windows.Forms.TextBox();
            this.ArmedTB = new System.Windows.Forms.TextBox();
            this.DeadTB = new System.Windows.Forms.TextBox();
            this.HostTB = new System.Windows.Forms.TextBox();
            this.ScpTB = new System.Windows.Forms.TextBox();
            this.Clipboard = new System.Windows.Forms.TextBox();
            this.Clipboar_BG = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScpTB_Write = new System.Windows.Forms.TextBox();
            this.HostTB_Write = new System.Windows.Forms.TextBox();
            this.lstCombatative = new System.Windows.Forms.ListBox();
            this.CombatativeTB = new System.Windows.Forms.TextBox();
            this.O5btn = new System.Windows.Forms.Button();
            this.SiDbtn = new System.Windows.Forms.Button();
            this.ScDbtn = new System.Windows.Forms.Button();
            this.CDbtn = new System.Windows.Forms.Button();
            this.MTFbtn = new System.Windows.Forms.Button();
            this.RRTbtn = new System.Windows.Forms.Button();
            this.SDbtn = new System.Windows.Forms.Button();
            this.PlayerAddTBox = new System.Windows.Forms.TextBox();
            this.lvl1TB = new System.Windows.Forms.Button();
            this.lvl2TB = new System.Windows.Forms.Button();
            this.lvl3TB = new System.Windows.Forms.Button();
            this.lvl4TB = new System.Windows.Forms.Button();
            this.lvl5TB = new System.Windows.Forms.Button();
            this.RoleTB = new System.Windows.Forms.TextBox();
            this.RankTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Clipboar_BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(275, 341);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lstPlayerList
            // 
            this.lstPlayerList.AllowDrop = true;
            this.lstPlayerList.FormattingEnabled = true;
            this.lstPlayerList.Location = new System.Drawing.Point(275, 36);
            this.lstPlayerList.Name = "lstPlayerList";
            this.lstPlayerList.Size = new System.Drawing.Size(96, 277);
            this.lstPlayerList.TabIndex = 13;
            this.lstPlayerList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.lstPlayerList.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBox_DragOver);
            this.lstPlayerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // PlayerNameTB
            // 
            this.PlayerNameTB.Location = new System.Drawing.Point(467, 345);
            this.PlayerNameTB.Name = "PlayerNameTB";
            this.PlayerNameTB.Size = new System.Drawing.Size(122, 20);
            this.PlayerNameTB.TabIndex = 14;
            this.PlayerNameTB.TextChanged += new System.EventHandler(this.PlayerNameTB_TextChanged);
            // 
            // lstDead
            // 
            this.lstDead.AllowDrop = true;
            this.lstDead.FormattingEnabled = true;
            this.lstDead.Location = new System.Drawing.Point(692, 36);
            this.lstDead.Name = "lstDead";
            this.lstDead.Size = new System.Drawing.Size(94, 277);
            this.lstDead.TabIndex = 15;
            this.lstDead.SelectedIndexChanged += new System.EventHandler(this.lstDead_SelectedIndexChanged);
            this.lstDead.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.lstDead.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBox_DragOver);
            this.lstDead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lstDangerous
            // 
            this.lstDangerous.AllowDrop = true;
            this.lstDangerous.FormattingEnabled = true;
            this.lstDangerous.Location = new System.Drawing.Point(416, 36);
            this.lstDangerous.Name = "lstDangerous";
            this.lstDangerous.Size = new System.Drawing.Size(98, 277);
            this.lstDangerous.TabIndex = 16;
            this.lstDangerous.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.lstDangerous.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBox_DragOver);
            this.lstDangerous.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(356, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PlayersTB
            // 
            this.PlayersTB.Location = new System.Drawing.Point(275, 4);
            this.PlayersTB.Name = "PlayersTB";
            this.PlayersTB.ReadOnly = true;
            this.PlayersTB.Size = new System.Drawing.Size(96, 20);
            this.PlayersTB.TabIndex = 18;
            this.PlayersTB.Text = "Players";
            // 
            // ArmedTB
            // 
            this.ArmedTB.Location = new System.Drawing.Point(416, 4);
            this.ArmedTB.Name = "ArmedTB";
            this.ArmedTB.ReadOnly = true;
            this.ArmedTB.Size = new System.Drawing.Size(96, 20);
            this.ArmedTB.TabIndex = 19;
            this.ArmedTB.Text = "Armed";
            // 
            // DeadTB
            // 
            this.DeadTB.Location = new System.Drawing.Point(692, 4);
            this.DeadTB.Name = "DeadTB";
            this.DeadTB.ReadOnly = true;
            this.DeadTB.Size = new System.Drawing.Size(96, 20);
            this.DeadTB.TabIndex = 20;
            this.DeadTB.Text = "Dead";
            this.DeadTB.TextChanged += new System.EventHandler(this.DeadTB_TextChanged);
            // 
            // HostTB
            // 
            this.HostTB.Location = new System.Drawing.Point(448, 371);
            this.HostTB.Name = "HostTB";
            this.HostTB.ReadOnly = true;
            this.HostTB.Size = new System.Drawing.Size(33, 20);
            this.HostTB.TabIndex = 21;
            this.HostTB.Text = "Host:";
            this.HostTB.TextChanged += new System.EventHandler(this.HostTB_TextChanged);
            // 
            // ScpTB
            // 
            this.ScpTB.Location = new System.Drawing.Point(448, 399);
            this.ScpTB.Name = "ScpTB";
            this.ScpTB.ReadOnly = true;
            this.ScpTB.Size = new System.Drawing.Size(33, 20);
            this.ScpTB.TabIndex = 22;
            this.ScpTB.Text = "SCP:";
            // 
            // Clipboard
            // 
            this.Clipboard.BackColor = System.Drawing.Color.White;
            this.Clipboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clipboard.Location = new System.Drawing.Point(12, 63);
            this.Clipboard.Multiline = true;
            this.Clipboard.Name = "Clipboard";
            this.Clipboard.ReadOnly = true;
            this.Clipboard.Size = new System.Drawing.Size(244, 356);
            this.Clipboard.TabIndex = 23;
            this.Clipboard.TextChanged += new System.EventHandler(this.Clipboard_click);
            // 
            // Clipboar_BG
            // 
            this.Clipboar_BG.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Clipboar_BG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clipboar_BG.Location = new System.Drawing.Point(-2, -12);
            this.Clipboar_BG.Name = "Clipboar_BG";
            this.Clipboar_BG.Size = new System.Drawing.Size(269, 464);
            this.Clipboar_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Clipboar_BG.TabIndex = 24;
            this.Clipboar_BG.TabStop = false;
            this.Clipboar_BG.Click += new System.EventHandler(this.Clipboar_BG_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-59, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(918, 580);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ScpTB_Write
            // 
            this.ScpTB_Write.Location = new System.Drawing.Point(487, 399);
            this.ScpTB_Write.Name = "ScpTB_Write";
            this.ScpTB_Write.Size = new System.Drawing.Size(128, 20);
            this.ScpTB_Write.TabIndex = 26;
            this.ScpTB_Write.TextChanged += new System.EventHandler(this.ScpTB_Write_TextChanged);
            // 
            // HostTB_Write
            // 
            this.HostTB_Write.Location = new System.Drawing.Point(487, 371);
            this.HostTB_Write.Name = "HostTB_Write";
            this.HostTB_Write.Size = new System.Drawing.Size(128, 20);
            this.HostTB_Write.TabIndex = 27;
            this.HostTB_Write.TextChanged += new System.EventHandler(this.HostTB_Write_TextChanged);
            // 
            // lstCombatative
            // 
            this.lstCombatative.AllowDrop = true;
            this.lstCombatative.FormattingEnabled = true;
            this.lstCombatative.Location = new System.Drawing.Point(554, 36);
            this.lstCombatative.Name = "lstCombatative";
            this.lstCombatative.Size = new System.Drawing.Size(94, 277);
            this.lstCombatative.TabIndex = 28;
            this.lstCombatative.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.lstCombatative.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBox_DragOver);
            this.lstCombatative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // CombatativeTB
            // 
            this.CombatativeTB.Location = new System.Drawing.Point(552, 4);
            this.CombatativeTB.Name = "CombatativeTB";
            this.CombatativeTB.ReadOnly = true;
            this.CombatativeTB.Size = new System.Drawing.Size(96, 20);
            this.CombatativeTB.TabIndex = 29;
            this.CombatativeTB.Text = "Combatative";
            // 
            // O5btn
            // 
            this.O5btn.BackColor = System.Drawing.Color.Lime;
            this.O5btn.Location = new System.Drawing.Point(666, 372);
            this.O5btn.Name = "O5btn";
            this.O5btn.Size = new System.Drawing.Size(38, 19);
            this.O5btn.TabIndex = 30;
            this.O5btn.Text = "O5";
            this.O5btn.UseVisualStyleBackColor = false;
            this.O5btn.Click += new System.EventHandler(this.O5btn_Click);
            // 
            // SiDbtn
            // 
            this.SiDbtn.BackColor = System.Drawing.Color.Red;
            this.SiDbtn.Location = new System.Drawing.Point(710, 372);
            this.SiDbtn.Name = "SiDbtn";
            this.SiDbtn.Size = new System.Drawing.Size(39, 19);
            this.SiDbtn.TabIndex = 31;
            this.SiDbtn.Text = "SiD";
            this.SiDbtn.UseVisualStyleBackColor = false;
            this.SiDbtn.Click += new System.EventHandler(this.SiDbtn_Click);
            // 
            // ScDbtn
            // 
            this.ScDbtn.BackColor = System.Drawing.Color.Red;
            this.ScDbtn.Location = new System.Drawing.Point(755, 372);
            this.ScDbtn.Name = "ScDbtn";
            this.ScDbtn.Size = new System.Drawing.Size(39, 19);
            this.ScDbtn.TabIndex = 32;
            this.ScDbtn.Text = "ScD";
            this.ScDbtn.UseVisualStyleBackColor = false;
            this.ScDbtn.Click += new System.EventHandler(this.ScDbtn_Click);
            // 
            // CDbtn
            // 
            this.CDbtn.BackColor = System.Drawing.Color.Lime;
            this.CDbtn.Location = new System.Drawing.Point(646, 345);
            this.CDbtn.Name = "CDbtn";
            this.CDbtn.Size = new System.Drawing.Size(32, 19);
            this.CDbtn.TabIndex = 33;
            this.CDbtn.Text = "CD";
            this.CDbtn.UseVisualStyleBackColor = false;
            this.CDbtn.Click += new System.EventHandler(this.CDbtn_Click);
            // 
            // MTFbtn
            // 
            this.MTFbtn.BackColor = System.Drawing.Color.Red;
            this.MTFbtn.Location = new System.Drawing.Point(680, 346);
            this.MTFbtn.Name = "MTFbtn";
            this.MTFbtn.Size = new System.Drawing.Size(38, 19);
            this.MTFbtn.TabIndex = 34;
            this.MTFbtn.Text = "MTF";
            this.MTFbtn.UseVisualStyleBackColor = false;
            this.MTFbtn.Click += new System.EventHandler(this.MTFbtn_Click);
            // 
            // RRTbtn
            // 
            this.RRTbtn.BackColor = System.Drawing.Color.Red;
            this.RRTbtn.Location = new System.Drawing.Point(721, 346);
            this.RRTbtn.Name = "RRTbtn";
            this.RRTbtn.Size = new System.Drawing.Size(38, 19);
            this.RRTbtn.TabIndex = 35;
            this.RRTbtn.Text = "RRT";
            this.RRTbtn.UseVisualStyleBackColor = false;
            this.RRTbtn.Click += new System.EventHandler(this.RRTbtn_Click);
            // 
            // SDbtn
            // 
            this.SDbtn.BackColor = System.Drawing.Color.Red;
            this.SDbtn.Location = new System.Drawing.Point(761, 346);
            this.SDbtn.Name = "SDbtn";
            this.SDbtn.Size = new System.Drawing.Size(36, 19);
            this.SDbtn.TabIndex = 36;
            this.SDbtn.Text = "SD";
            this.SDbtn.UseVisualStyleBackColor = false;
            this.SDbtn.Click += new System.EventHandler(this.SDbtn_Click);
            // 
            // PlayerAddTBox
            // 
            this.PlayerAddTBox.Location = new System.Drawing.Point(487, 319);
            this.PlayerAddTBox.Name = "PlayerAddTBox";
            this.PlayerAddTBox.ReadOnly = true;
            this.PlayerAddTBox.Size = new System.Drawing.Size(96, 20);
            this.PlayerAddTBox.TabIndex = 37;
            this.PlayerAddTBox.Text = "Add players";
            // 
            // lvl1TB
            // 
            this.lvl1TB.BackColor = System.Drawing.Color.Lime;
            this.lvl1TB.Location = new System.Drawing.Point(646, 319);
            this.lvl1TB.Name = "lvl1TB";
            this.lvl1TB.Size = new System.Drawing.Size(26, 19);
            this.lvl1TB.TabIndex = 38;
            this.lvl1TB.Text = "1";
            this.lvl1TB.UseVisualStyleBackColor = false;
            this.lvl1TB.Click += new System.EventHandler(this.lvl1TB_Click);
            // 
            // lvl2TB
            // 
            this.lvl2TB.BackColor = System.Drawing.Color.Red;
            this.lvl2TB.Location = new System.Drawing.Point(678, 319);
            this.lvl2TB.Name = "lvl2TB";
            this.lvl2TB.Size = new System.Drawing.Size(26, 19);
            this.lvl2TB.TabIndex = 39;
            this.lvl2TB.Text = "2";
            this.lvl2TB.UseVisualStyleBackColor = false;
            this.lvl2TB.Click += new System.EventHandler(this.lvl2TB_Click);
            // 
            // lvl3TB
            // 
            this.lvl3TB.BackColor = System.Drawing.Color.Red;
            this.lvl3TB.Location = new System.Drawing.Point(710, 320);
            this.lvl3TB.Name = "lvl3TB";
            this.lvl3TB.Size = new System.Drawing.Size(26, 19);
            this.lvl3TB.TabIndex = 40;
            this.lvl3TB.Text = "3";
            this.lvl3TB.UseVisualStyleBackColor = false;
            this.lvl3TB.Click += new System.EventHandler(this.lvl3TB_Click);
            // 
            // lvl4TB
            // 
            this.lvl4TB.BackColor = System.Drawing.Color.Red;
            this.lvl4TB.Location = new System.Drawing.Point(739, 320);
            this.lvl4TB.Name = "lvl4TB";
            this.lvl4TB.Size = new System.Drawing.Size(26, 19);
            this.lvl4TB.TabIndex = 41;
            this.lvl4TB.Text = "4";
            this.lvl4TB.UseVisualStyleBackColor = false;
            this.lvl4TB.Click += new System.EventHandler(this.lvl4TB_Click);
            // 
            // lvl5TB
            // 
            this.lvl5TB.BackColor = System.Drawing.Color.Red;
            this.lvl5TB.Location = new System.Drawing.Point(771, 319);
            this.lvl5TB.Name = "lvl5TB";
            this.lvl5TB.Size = new System.Drawing.Size(26, 19);
            this.lvl5TB.TabIndex = 42;
            this.lvl5TB.Text = "5";
            this.lvl5TB.UseVisualStyleBackColor = false;
            this.lvl5TB.Click += new System.EventHandler(this.lvl5TB_Click);
            // 
            // RoleTB
            // 
            this.RoleTB.Location = new System.Drawing.Point(606, 344);
            this.RoleTB.Name = "RoleTB";
            this.RoleTB.ReadOnly = true;
            this.RoleTB.Size = new System.Drawing.Size(34, 20);
            this.RoleTB.TabIndex = 43;
            this.RoleTB.Text = "Role";
            // 
            // RankTB
            // 
            this.RankTB.Location = new System.Drawing.Point(606, 318);
            this.RankTB.Name = "RankTB";
            this.RankTB.ReadOnly = true;
            this.RankTB.Size = new System.Drawing.Size(34, 20);
            this.RankTB.TabIndex = 44;
            this.RankTB.Text = "Rank";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(620, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(47, 18);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "HostRole";
            // 
            // TestTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RankTB);
            this.Controls.Add(this.RoleTB);
            this.Controls.Add(this.lvl5TB);
            this.Controls.Add(this.lvl4TB);
            this.Controls.Add(this.lvl3TB);
            this.Controls.Add(this.lvl2TB);
            this.Controls.Add(this.lvl1TB);
            this.Controls.Add(this.PlayerAddTBox);
            this.Controls.Add(this.SDbtn);
            this.Controls.Add(this.RRTbtn);
            this.Controls.Add(this.MTFbtn);
            this.Controls.Add(this.CDbtn);
            this.Controls.Add(this.ScDbtn);
            this.Controls.Add(this.SiDbtn);
            this.Controls.Add(this.O5btn);
            this.Controls.Add(this.CombatativeTB);
            this.Controls.Add(this.lstCombatative);
            this.Controls.Add(this.Clipboard);
            this.Controls.Add(this.Clipboar_BG);
            this.Controls.Add(this.HostTB_Write);
            this.Controls.Add(this.ScpTB_Write);
            this.Controls.Add(this.ScpTB);
            this.Controls.Add(this.HostTB);
            this.Controls.Add(this.DeadTB);
            this.Controls.Add(this.ArmedTB);
            this.Controls.Add(this.PlayersTB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstDangerous);
            this.Controls.Add(this.lstDead);
            this.Controls.Add(this.PlayerNameTB);
            this.Controls.Add(this.lstPlayerList);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TestTracker";
            this.Text = "TestTracker";
            ((System.ComponentModel.ISupportInitialize)(this.Clipboar_BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox PlayerNameTB;
        private System.Windows.Forms.ListBox lstDead;
        private System.Windows.Forms.ListBox lstDangerous;
        private System.Windows.Forms.ListBox lstPlayerList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox PlayersTB;
        private System.Windows.Forms.TextBox ArmedTB;
        private System.Windows.Forms.TextBox DeadTB;
        private System.Windows.Forms.TextBox HostTB;
        private System.Windows.Forms.TextBox ScpTB;
        private System.Windows.Forms.TextBox Clipboard;
        private System.Windows.Forms.PictureBox Clipboar_BG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ScpTB_Write;
        private System.Windows.Forms.TextBox HostTB_Write;
        private System.Windows.Forms.ListBox lstCombatative;
        private System.Windows.Forms.TextBox CombatativeTB;
        private System.Windows.Forms.Button O5btn;
        private System.Windows.Forms.Button SiDbtn;
        private System.Windows.Forms.Button ScDbtn;
        private System.Windows.Forms.Button CDbtn;
        private System.Windows.Forms.Button MTFbtn;
        private System.Windows.Forms.Button RRTbtn;
        private System.Windows.Forms.Button SDbtn;
        private System.Windows.Forms.TextBox PlayerAddTBox;
        private System.Windows.Forms.Button lvl1TB;
        private System.Windows.Forms.Button lvl2TB;
        private System.Windows.Forms.Button lvl3TB;
        private System.Windows.Forms.Button lvl4TB;
        private System.Windows.Forms.Button lvl5TB;
        private System.Windows.Forms.TextBox RoleTB;
        private System.Windows.Forms.TextBox RankTB;
        private System.Windows.Forms.TextBox textBox1;
    }
}