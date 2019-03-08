namespace InClassAssignment6
{
    partial class DiceRoll
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
            this.btn1_rollDice = new System.Windows.Forms.Button();
            this.label1_a1 = new System.Windows.Forms.Label();
            this.label2_a2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1_rollDice
            // 
            this.btn1_rollDice.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_rollDice.Location = new System.Drawing.Point(12, 82);
            this.btn1_rollDice.Name = "btn1_rollDice";
            this.btn1_rollDice.Size = new System.Drawing.Size(301, 256);
            this.btn1_rollDice.TabIndex = 0;
            this.btn1_rollDice.Text = "Roll Dice";
            this.btn1_rollDice.UseVisualStyleBackColor = true;
            this.btn1_rollDice.Click += new System.EventHandler(this.btn1_rollDice_Click);
            // 
            // label1_a1
            // 
            this.label1_a1.AutoSize = true;
            this.label1_a1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_a1.Location = new System.Drawing.Point(319, 192);
            this.label1_a1.Name = "label1_a1";
            this.label1_a1.Size = new System.Drawing.Size(0, 37);
            this.label1_a1.TabIndex = 1;
            // 
            // label2_a2
            // 
            this.label2_a2.AutoSize = true;
            this.label2_a2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_a2.Location = new System.Drawing.Point(428, 192);
            this.label2_a2.Name = "label2_a2";
            this.label2_a2.Size = new System.Drawing.Size(0, 37);
            this.label2_a2.TabIndex = 2;
            // 
            // DiceRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2_a2);
            this.Controls.Add(this.label1_a1);
            this.Controls.Add(this.btn1_rollDice);
            this.Name = "DiceRoll";
            this.Text = "DiceRoll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1_rollDice;
        private System.Windows.Forms.Label label1_a1;
        private System.Windows.Forms.Label label2_a2;
    }
}

