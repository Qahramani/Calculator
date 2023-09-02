namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenLabel = new System.Windows.Forms.Label();
            this.number1Button = new System.Windows.Forms.Button();
            this.number2Button = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.number3Button = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.number6Button = new System.Windows.Forms.Button();
            this.number5Button = new System.Windows.Forms.Button();
            this.number4Button = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.number0Button = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.multipleButton = new System.Windows.Forms.Button();
            this.number9Button = new System.Windows.Forms.Button();
            this.number8Button = new System.Windows.Forms.Button();
            this.number7Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screenLabel
            // 
            this.screenLabel.BackColor = System.Drawing.Color.White;
            this.screenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenLabel.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenLabel.Location = new System.Drawing.Point(12, 22);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(401, 125);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Tag = "";
            this.screenLabel.Text = "0";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // number1Button
            // 
            this.number1Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1Button.Location = new System.Drawing.Point(12, 150);
            this.number1Button.Name = "number1Button";
            this.number1Button.Size = new System.Drawing.Size(95, 95);
            this.number1Button.TabIndex = 1;
            this.number1Button.Text = "1";
            this.number1Button.UseVisualStyleBackColor = false;
            this.number1Button.Click += new System.EventHandler(this.number1Button_Click);
            // 
            // number2Button
            // 
            this.number2Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2Button.Location = new System.Drawing.Point(113, 150);
            this.number2Button.Name = "number2Button";
            this.number2Button.Size = new System.Drawing.Size(95, 95);
            this.number2Button.TabIndex = 2;
            this.number2Button.Text = "2";
            this.number2Button.UseVisualStyleBackColor = false;
            this.number2Button.Click += new System.EventHandler(this.number2Button_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.RosyBrown;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(318, 150);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(95, 95);
            this.plusButton.TabIndex = 4;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // number3Button
            // 
            this.number3Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3Button.Location = new System.Drawing.Point(217, 150);
            this.number3Button.Name = "number3Button";
            this.number3Button.Size = new System.Drawing.Size(95, 95);
            this.number3Button.TabIndex = 3;
            this.number3Button.Text = "3";
            this.number3Button.UseVisualStyleBackColor = false;
            this.number3Button.Click += new System.EventHandler(this.number3Button_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.RosyBrown;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(318, 251);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(95, 95);
            this.minusButton.TabIndex = 8;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // number6Button
            // 
            this.number6Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6Button.Location = new System.Drawing.Point(217, 251);
            this.number6Button.Name = "number6Button";
            this.number6Button.Size = new System.Drawing.Size(95, 95);
            this.number6Button.TabIndex = 7;
            this.number6Button.Text = "6";
            this.number6Button.UseVisualStyleBackColor = false;
            this.number6Button.Click += new System.EventHandler(this.number6Button_Click);
            // 
            // number5Button
            // 
            this.number5Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5Button.Location = new System.Drawing.Point(113, 251);
            this.number5Button.Name = "number5Button";
            this.number5Button.Size = new System.Drawing.Size(95, 95);
            this.number5Button.TabIndex = 6;
            this.number5Button.Text = "5";
            this.number5Button.UseVisualStyleBackColor = false;
            this.number5Button.Click += new System.EventHandler(this.number5Button_Click);
            // 
            // number4Button
            // 
            this.number4Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4Button.Location = new System.Drawing.Point(12, 251);
            this.number4Button.Name = "number4Button";
            this.number4Button.Size = new System.Drawing.Size(95, 95);
            this.number4Button.TabIndex = 5;
            this.number4Button.Text = "4";
            this.number4Button.UseVisualStyleBackColor = false;
            this.number4Button.Click += new System.EventHandler(this.number4Button_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.RosyBrown;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(318, 437);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(95, 95);
            this.divideButton.TabIndex = 16;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.RosyBrown;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(217, 437);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(95, 95);
            this.equalButton.TabIndex = 15;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // number0Button
            // 
            this.number0Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0Button.Location = new System.Drawing.Point(113, 437);
            this.number0Button.Name = "number0Button";
            this.number0Button.Size = new System.Drawing.Size(95, 95);
            this.number0Button.TabIndex = 14;
            this.number0Button.Text = "0";
            this.number0Button.UseVisualStyleBackColor = false;
            this.number0Button.Click += new System.EventHandler(this.number0Button_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.Color.Beige;
            this.cleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cleanButton.Location = new System.Drawing.Point(12, 437);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(95, 95);
            this.cleanButton.TabIndex = 13;
            this.cleanButton.Text = "C";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // multipleButton
            // 
            this.multipleButton.BackColor = System.Drawing.Color.RosyBrown;
            this.multipleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multipleButton.Location = new System.Drawing.Point(318, 336);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(95, 95);
            this.multipleButton.TabIndex = 12;
            this.multipleButton.Text = "x";
            this.multipleButton.UseVisualStyleBackColor = false;
            this.multipleButton.Click += new System.EventHandler(this.multipleButton_Click);
            // 
            // number9Button
            // 
            this.number9Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9Button.Location = new System.Drawing.Point(217, 336);
            this.number9Button.Name = "number9Button";
            this.number9Button.Size = new System.Drawing.Size(95, 95);
            this.number9Button.TabIndex = 11;
            this.number9Button.Text = "9";
            this.number9Button.UseVisualStyleBackColor = false;
            this.number9Button.Click += new System.EventHandler(this.number9Button_Click);
            // 
            // number8Button
            // 
            this.number8Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8Button.Location = new System.Drawing.Point(113, 336);
            this.number8Button.Name = "number8Button";
            this.number8Button.Size = new System.Drawing.Size(95, 95);
            this.number8Button.TabIndex = 10;
            this.number8Button.Text = "8";
            this.number8Button.UseVisualStyleBackColor = false;
            this.number8Button.Click += new System.EventHandler(this.number8Button_Click);
            // 
            // number7Button
            // 
            this.number7Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.number7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7Button.Location = new System.Drawing.Point(12, 336);
            this.number7Button.Name = "number7Button";
            this.number7Button.Size = new System.Drawing.Size(95, 95);
            this.number7Button.TabIndex = 9;
            this.number7Button.Text = "7";
            this.number7Button.UseVisualStyleBackColor = false;
            this.number7Button.Click += new System.EventHandler(this.number7Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(433, 557);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.number0Button);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.multipleButton);
            this.Controls.Add(this.number9Button);
            this.Controls.Add(this.number8Button);
            this.Controls.Add(this.number7Button);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.number6Button);
            this.Controls.Add(this.number5Button);
            this.Controls.Add(this.number4Button);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.number3Button);
            this.Controls.Add(this.number2Button);
            this.Controls.Add(this.number1Button);
            this.Controls.Add(this.screenLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Button number1Button;
        private System.Windows.Forms.Button number2Button;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button number3Button;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button number6Button;
        private System.Windows.Forms.Button number5Button;
        private System.Windows.Forms.Button number4Button;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button number0Button;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button multipleButton;
        private System.Windows.Forms.Button number9Button;
        private System.Windows.Forms.Button number8Button;
        private System.Windows.Forms.Button number7Button;
    }
}

