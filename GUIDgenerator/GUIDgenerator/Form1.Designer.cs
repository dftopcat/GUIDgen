namespace GUIDgenerator
{
    partial class GUIDgen
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
            this.generateButton = new System.Windows.Forms.Button();
            this.GUIDtext = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.BraceCheckBox = new System.Windows.Forms.CheckBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.CapitalizedCheckBox = new System.Windows.Forms.CheckBox();
            this.hyphensCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(12, 12);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(306, 137);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate GUID";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // GUIDtext
            // 
            this.GUIDtext.AutoSize = true;
            this.GUIDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIDtext.Location = new System.Drawing.Point(12, 152);
            this.GUIDtext.Name = "GUIDtext";
            this.GUIDtext.Size = new System.Drawing.Size(0, 32);
            this.GUIDtext.TabIndex = 1;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Location = new System.Drawing.Point(324, 12);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(331, 137);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // BraceCheckBox
            // 
            this.BraceCheckBox.AutoSize = true;
            this.BraceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BraceCheckBox.Location = new System.Drawing.Point(12, 236);
            this.BraceCheckBox.Name = "BraceCheckBox";
            this.BraceCheckBox.Size = new System.Drawing.Size(132, 33);
            this.BraceCheckBox.TabIndex = 3;
            this.BraceCheckBox.Text = "Braces{}";
            this.BraceCheckBox.UseVisualStyleBackColor = true;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(519, 236);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(136, 33);
            this.infoButton.TabIndex = 5;
            this.infoButton.Text = "Information";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // CapitalizedCheckBox
            // 
            this.CapitalizedCheckBox.AutoSize = true;
            this.CapitalizedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitalizedCheckBox.Location = new System.Drawing.Point(150, 236);
            this.CapitalizedCheckBox.Name = "CapitalizedCheckBox";
            this.CapitalizedCheckBox.Size = new System.Drawing.Size(190, 33);
            this.CapitalizedCheckBox.TabIndex = 4;
            this.CapitalizedCheckBox.Text = "CAPTIALIZED";
            this.CapitalizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // hyphensCheckBox
            // 
            this.hyphensCheckBox.AutoSize = true;
            this.hyphensCheckBox.Checked = true;
            this.hyphensCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hyphensCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyphensCheckBox.Location = new System.Drawing.Point(346, 234);
            this.hyphensCheckBox.Name = "hyphensCheckBox";
            this.hyphensCheckBox.Size = new System.Drawing.Size(133, 33);
            this.hyphensCheckBox.TabIndex = 6;
            this.hyphensCheckBox.Text = "Hyphens";
            this.hyphensCheckBox.UseVisualStyleBackColor = true;
            // 
            // GUIDgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 281);
            this.Controls.Add(this.hyphensCheckBox);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.CapitalizedCheckBox);
            this.Controls.Add(this.BraceCheckBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.GUIDtext);
            this.Controls.Add(this.generateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUIDgen";
            this.Text = "GUID Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label GUIDtext;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.CheckBox BraceCheckBox;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.CheckBox CapitalizedCheckBox;
        private System.Windows.Forms.CheckBox hyphensCheckBox;
    }
}

