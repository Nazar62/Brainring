namespace BrainringPC
{
    partial class settings
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
            textBoxMaxTime = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxMaxTime
            // 
            textBoxMaxTime.Location = new Point(12, 27);
            textBoxMaxTime.Name = "textBoxMaxTime";
            textBoxMaxTime.Size = new Size(154, 23);
            textBoxMaxTime.TabIndex = 0;
            textBoxMaxTime.TextChanged += textBoxMaxTime_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 1;
            label1.Text = "Час спрацювання таймера в секундах";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 109);
            Controls.Add(label1);
            Controls.Add(textBoxMaxTime);
            Name = "settings";
            Text = "settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMaxTime;
        private Label label1;
    }
}