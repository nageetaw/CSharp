namespace TicTacToe
{
    partial class TicTacToe
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSystem = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelTurns = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblinfo.Location = new System.Drawing.Point(14, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(148, 29);
            this.lblinfo.TabIndex = 9;
            this.lblinfo.Text = "Tic-Tac-Toe";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(795, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUser.Location = new System.Drawing.Point(791, 124);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(53, 20);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "label1";
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSystem.Location = new System.Drawing.Point(791, 185);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(53, 20);
            this.labelSystem.TabIndex = 12;
            this.labelSystem.Text = "label2";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResults.Location = new System.Drawing.Point(581, 281);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(0, 20);
            this.labelResults.TabIndex = 13;
            // 
            // labelTurns
            // 
            this.labelTurns.AutoSize = true;
            this.labelTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTurns.Location = new System.Drawing.Point(733, 457);
            this.labelTurns.Name = "labelTurns";
            this.labelTurns.Size = new System.Drawing.Size(53, 20);
            this.labelTurns.TabIndex = 14;
            this.labelTurns.Text = "label2";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult.Location = new System.Drawing.Point(733, 381);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(53, 20);
            this.labelResult.TabIndex = 15;
            this.labelResult.Text = "label2";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1021, 516);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTurns);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelSystem);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblinfo);
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelTurns;
        private System.Windows.Forms.Label labelResult;
    }
}

