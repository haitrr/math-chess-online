namespace MathChessOnline
{
    partial class Main
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
            this.gameBoardPanel = new MathChessOnline.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.BackColor = System.Drawing.SystemColors.Control;
            this.gameBoardPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.gameBoardPanel.Location = new System.Drawing.Point(10, 30);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.Size = new System.Drawing.Size(451, 551);
            this.gameBoardPanel.TabIndex = 0;
            this.gameBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paintGameBoard);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.gameBoardPanel);
            this.Name = "Main";
            this.Text = "Math Chess Online";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferedPanel gameBoardPanel;
    }
}

