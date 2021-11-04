
namespace MinesweeprGUI.ver1
{
    partial class LevelSelect
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
            this.label1 = new System.Windows.Forms.Label();
            this.easyRadioBtn = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.hardRadioBtn = new System.Windows.Forms.RadioButton();
            this.mediumRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Level Please";
            // 
            // easyRadioBtn
            // 
            this.easyRadioBtn.AutoSize = true;
            this.easyRadioBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyRadioBtn.Location = new System.Drawing.Point(116, 186);
            this.easyRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.easyRadioBtn.Name = "easyRadioBtn";
            this.easyRadioBtn.Size = new System.Drawing.Size(68, 27);
            this.easyRadioBtn.TabIndex = 2;
            this.easyRadioBtn.TabStop = true;
            this.easyRadioBtn.Text = "Easy";
            this.easyRadioBtn.UseVisualStyleBackColor = true;
            this.easyRadioBtn.CheckedChanged += new System.EventHandler(this.easyRadioBtn_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(71, 588);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 35);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(414, 588);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(112, 35);
            this.playBtn.TabIndex = 8;
            this.playBtn.Text = "Play Game";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // hardRadioBtn
            // 
            this.hardRadioBtn.AutoSize = true;
            this.hardRadioBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardRadioBtn.Location = new System.Drawing.Point(116, 357);
            this.hardRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hardRadioBtn.Name = "hardRadioBtn";
            this.hardRadioBtn.Size = new System.Drawing.Size(72, 27);
            this.hardRadioBtn.TabIndex = 7;
            this.hardRadioBtn.TabStop = true;
            this.hardRadioBtn.Text = "Hard";
            this.hardRadioBtn.UseVisualStyleBackColor = true;
            this.hardRadioBtn.CheckedChanged += new System.EventHandler(this.hardRadioBtn_CheckedChanged);
            // 
            // mediumRadioBtn
            // 
            this.mediumRadioBtn.AutoSize = true;
            this.mediumRadioBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRadioBtn.Location = new System.Drawing.Point(116, 271);
            this.mediumRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mediumRadioBtn.Name = "mediumRadioBtn";
            this.mediumRadioBtn.Size = new System.Drawing.Size(98, 27);
            this.mediumRadioBtn.TabIndex = 6;
            this.mediumRadioBtn.TabStop = true;
            this.mediumRadioBtn.Text = "Medium";
            this.mediumRadioBtn.UseVisualStyleBackColor = true;
            this.mediumRadioBtn.CheckedChanged += new System.EventHandler(this.mediumRadioBtn_CheckedChanged);
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 653);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.hardRadioBtn);
            this.Controls.Add(this.mediumRadioBtn);
            this.Controls.Add(this.easyRadioBtn);
            this.Controls.Add(this.label1);
            this.Name = "LevelSelect";
            this.Text = "Select a level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton easyRadioBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.RadioButton hardRadioBtn;
        private System.Windows.Forms.RadioButton mediumRadioBtn;
    }
}

