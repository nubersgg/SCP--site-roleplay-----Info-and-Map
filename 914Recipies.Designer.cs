using System;

namespace Scp_Map
{
    partial class _914Recipies
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
            this.sourceComboBox = new System.Windows.Forms.ComboBox();
            this.targetComboBox = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.generatePathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.Location = new System.Drawing.Point(240, 96);
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(121, 28);
            this.sourceComboBox.TabIndex = 0;
            // 
            // targetComboBox
            // 
            this.targetComboBox.FormattingEnabled = true;
            this.targetComboBox.Location = new System.Drawing.Point(419, 96);
            this.targetComboBox.Name = "targetComboBox";
            this.targetComboBox.Size = new System.Drawing.Size(121, 28);
            this.targetComboBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(290, 169);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(204, 26);
            this.resultLabel.TabIndex = 2;
            // 
            // generatePathButton
            // 
            this.generatePathButton.Location = new System.Drawing.Point(350, 130);
            this.generatePathButton.Name = "generatePathButton";
            this.generatePathButton.Size = new System.Drawing.Size(75, 33);
            this.generatePathButton.TabIndex = 3;
            this.generatePathButton.Text = "button1";
            this.generatePathButton.UseVisualStyleBackColor = true;
            // 
            // _914Recipies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generatePathButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.targetComboBox);
            this.Controls.Add(this.sourceComboBox);
            this.Name = "_914Recipies";
            this.Text = "914Recipies";
            this.Load += new System.EventHandler(this._914Recipies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        private void _914Recipies_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.ComboBox sourceComboBox;
        private System.Windows.Forms.ComboBox targetComboBox;
        private System.Windows.Forms.TextBox resultLabel;
        private System.Windows.Forms.Button generatePathButton;
    }
}