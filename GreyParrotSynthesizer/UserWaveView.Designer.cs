namespace GreyParrotSynthesizer
{
    partial class UserWaveView
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
            TestButton = new Button();
            SuspendLayout();
            // 
            // TestButton
            // 
            TestButton.Location = new Point(390, 179);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(112, 34);
            TestButton.TabIndex = 0;
            TestButton.Text = "button1";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += TestButton_Click;
            // 
            // UserWaveView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TestButton);
            Location = new Point(1000, 0);
            Name = "UserWaveView";
            Text = "UserWaveView";
            ResumeLayout(false);
        }

        #endregion

        private Button TestButton;
    }
}