namespace If_and_Else_instrucions_using_WFA_instead_of_WPF
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
            this.button1 = new System.Windows.Forms.Button();
            this.myCheckBox = new System.Windows.Forms.CheckBox();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kliknięcie zmienia etykietę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myCheckBox
            // 
            this.myCheckBox.AutoSize = true;
            this.myCheckBox.Location = new System.Drawing.Point(330, 78);
            this.myCheckBox.Name = "myCheckBox";
            this.myCheckBox.Size = new System.Drawing.Size(139, 17);
            this.myCheckBox.TabIndex = 1;
            this.myCheckBox.Text = "Włącza zmianę etykiety";
            this.myCheckBox.UseVisualStyleBackColor = true;
            // 
            // myLabel
            // 
            this.myLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myLabel.Location = new System.Drawing.Point(72, 200);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(359, 23);
            this.myLabel.TabIndex = 2;
            this.myLabel.Text = "Naciśnij przycisk, aby zmienić tekst";
            this.myLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 257);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myCheckBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox myCheckBox;
        private System.Windows.Forms.Label myLabel;
    }
}

