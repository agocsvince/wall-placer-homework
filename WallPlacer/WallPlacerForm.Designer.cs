
namespace WallPlacer
{
    partial class WallForm
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
            this.startValueX = new System.Windows.Forms.NumericUpDown();
            this.endValueX = new System.Windows.Forms.NumericUpDown();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.startValueY = new System.Windows.Forms.NumericUpDown();
            this.startValueZ = new System.Windows.Forms.NumericUpDown();
            this.endValueY = new System.Windows.Forms.NumericUpDown();
            this.endValueZ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startValueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endValueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startValueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startValueZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endValueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endValueZ)).BeginInit();
            this.SuspendLayout();
            // 
            // startValueX
            // 
            this.startValueX.Location = new System.Drawing.Point(61, 92);
            this.startValueX.Margin = new System.Windows.Forms.Padding(4);
            this.startValueX.Name = "startValueX";
            this.startValueX.Size = new System.Drawing.Size(120, 31);
            this.startValueX.TabIndex = 0;
            this.startValueX.TabStop = false;
            // 
            // endValueX
            // 
            this.endValueX.Location = new System.Drawing.Point(61, 269);
            this.endValueX.Margin = new System.Windows.Forms.Padding(4);
            this.endValueX.Name = "endValueX";
            this.endValueX.Size = new System.Drawing.Size(120, 31);
            this.endValueX.TabIndex = 1;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(56, 28);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(174, 25);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Start Coordinate:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(56, 184);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(167, 25);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "End Coordinate:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(590, 362);
            this.submit.Margin = new System.Windows.Forms.Padding(6);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(150, 44);
            this.submit.TabIndex = 4;
            this.submit.Text = "Place wall";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.PlaceButton_Click);
            // 
            // startValueY
            // 
            this.startValueY.Location = new System.Drawing.Point(257, 92);
            this.startValueY.Name = "startValueY";
            this.startValueY.Size = new System.Drawing.Size(120, 31);
            this.startValueY.TabIndex = 5;
            // 
            // startValueZ
            // 
            this.startValueZ.Location = new System.Drawing.Point(455, 92);
            this.startValueZ.Name = "startValueZ";
            this.startValueZ.Size = new System.Drawing.Size(120, 31);
            this.startValueZ.TabIndex = 6;
            // 
            // endValueY
            // 
            this.endValueY.Location = new System.Drawing.Point(257, 268);
            this.endValueY.Name = "endValueY";
            this.endValueY.Size = new System.Drawing.Size(120, 31);
            this.endValueY.TabIndex = 7;
            // 
            // endValueZ
            // 
            this.endValueZ.Location = new System.Drawing.Point(455, 267);
            this.endValueZ.Name = "endValueZ";
            this.endValueZ.Size = new System.Drawing.Size(120, 31);
            this.endValueZ.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            // 
            // WallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endValueZ);
            this.Controls.Add(this.endValueY);
            this.Controls.Add(this.startValueZ);
            this.Controls.Add(this.startValueY);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endValueX);
            this.Controls.Add(this.startValueX);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WallForm";
            this.Text = "WallForm";
            ((System.ComponentModel.ISupportInitialize)(this.startValueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endValueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startValueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startValueZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endValueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endValueZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown startValueX;
        private System.Windows.Forms.NumericUpDown endValueX;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.NumericUpDown startValueY;
        private System.Windows.Forms.NumericUpDown startValueZ;
        private System.Windows.Forms.NumericUpDown endValueY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown endValueZ;
    }
}