namespace GreyParrotSynthesizer
{
    partial class MainSythesizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSythesizer));
            WaveFormDropDown = new ComboBox();
            PlaySound = new Button();
            FrequencyBar = new TrackBar();
            AmplitudeBar = new TrackBar();
            radioButton1 = new RadioButton();
            radioButtonGroup = new Panel();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            frequencyLabel = new Label();
            amplitudeLabel = new Label();
            backgroundColor = new Label();
            backcolor2 = new Label();
            backcolor3 = new Label();
            soundBarLabel = new Label();
            outlinecolor = new Label();
            outlinecolor2 = new Label();
            saveButtton = new Button();
            deleteSoundButton = new Button();
            line1 = new Label();
            line2 = new Label();
            playSoundStorage = new Button();
            ((System.ComponentModel.ISupportInitialize)FrequencyBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmplitudeBar).BeginInit();
            radioButtonGroup.SuspendLayout();
            SuspendLayout();
            // 
            // WaveFormDropDown
            // 
            WaveFormDropDown.Anchor = AnchorStyles.None;
            WaveFormDropDown.BackColor = Color.Black;
            WaveFormDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            WaveFormDropDown.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            WaveFormDropDown.ForeColor = Color.DodgerBlue;
            WaveFormDropDown.FormattingEnabled = true;
            WaveFormDropDown.Location = new Point(34, 23);
            WaveFormDropDown.Margin = new Padding(2);
            WaveFormDropDown.Name = "WaveFormDropDown";
            WaveFormDropDown.Size = new Size(131, 33);
            WaveFormDropDown.TabIndex = 0;
            WaveFormDropDown.SelectedIndexChanged += WaveFormDropDown_SelectedIndexChanged;
            // 
            // PlaySound
            // 
            PlaySound.Anchor = AnchorStyles.None;
            PlaySound.BackColor = Color.Black;
            PlaySound.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            PlaySound.ForeColor = Color.DodgerBlue;
            PlaySound.Location = new Point(34, 87);
            PlaySound.Margin = new Padding(2);
            PlaySound.Name = "PlaySound";
            PlaySound.Size = new Size(130, 32);
            PlaySound.TabIndex = 1;
            PlaySound.Text = "Play Sound";
            PlaySound.TextAlign = ContentAlignment.TopCenter;
            PlaySound.UseVisualStyleBackColor = false;
            PlaySound.Click += PlaySound_Click;
            // 
            // FrequencyBar
            // 
            FrequencyBar.Anchor = AnchorStyles.None;
            FrequencyBar.BackColor = SystemColors.ActiveCaptionText;
            FrequencyBar.Location = new Point(491, 80);
            FrequencyBar.Margin = new Padding(2);
            FrequencyBar.Maximum = 400;
            FrequencyBar.Minimum = 200;
            FrequencyBar.Name = "FrequencyBar";
            FrequencyBar.Orientation = Orientation.Vertical;
            FrequencyBar.Size = new Size(45, 166);
            FrequencyBar.TabIndex = 2;
            FrequencyBar.TickFrequency = 20;
            FrequencyBar.TickStyle = TickStyle.Both;
            FrequencyBar.Value = 200;
            FrequencyBar.Scroll += FrequencyBar_Scroll;
            // 
            // AmplitudeBar
            // 
            AmplitudeBar.Anchor = AnchorStyles.None;
            AmplitudeBar.BackColor = SystemColors.ActiveCaptionText;
            AmplitudeBar.Location = new Point(370, 80);
            AmplitudeBar.Margin = new Padding(2);
            AmplitudeBar.Maximum = 10000;
            AmplitudeBar.Minimum = 1000;
            AmplitudeBar.Name = "AmplitudeBar";
            AmplitudeBar.Orientation = Orientation.Vertical;
            AmplitudeBar.Size = new Size(45, 166);
            AmplitudeBar.TabIndex = 3;
            AmplitudeBar.TickFrequency = 300;
            AmplitudeBar.TickStyle = TickStyle.Both;
            AmplitudeBar.Value = 1000;
            AmplitudeBar.Scroll += AmplitudeBar_Scroll;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.Transparent;
            radioButton1.BackgroundImage = (Image)resources.GetObject("radioButton1.BackgroundImage");
            radioButton1.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton1.ForeColor = Color.Transparent;
            radioButton1.Location = new Point(12, 7);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(0, 60, 0, 0);
            radioButton1.Size = new Size(15, 12);
            radioButton1.TabIndex = 4;
            radioButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButtonGroup
            // 
            radioButtonGroup.Anchor = AnchorStyles.None;
            radioButtonGroup.BackColor = Color.Black;
            radioButtonGroup.BackgroundImageLayout = ImageLayout.None;
            radioButtonGroup.Controls.Add(radioButton10);
            radioButtonGroup.Controls.Add(radioButton9);
            radioButtonGroup.Controls.Add(radioButton7);
            radioButtonGroup.Controls.Add(radioButton8);
            radioButtonGroup.Controls.Add(radioButton6);
            radioButtonGroup.Controls.Add(radioButton5);
            radioButtonGroup.Controls.Add(radioButton4);
            radioButtonGroup.Controls.Add(radioButton3);
            radioButtonGroup.Controls.Add(radioButton2);
            radioButtonGroup.Controls.Add(radioButton1);
            radioButtonGroup.ForeColor = Color.Black;
            radioButtonGroup.Location = new Point(94, 250);
            radioButtonGroup.Margin = new Padding(2);
            radioButtonGroup.Name = "radioButtonGroup";
            radioButtonGroup.Size = new Size(482, 29);
            radioButtonGroup.TabIndex = 6;
            // 
            // radioButton10
            // 
            radioButton10.BackColor = Color.Transparent;
            radioButton10.BackgroundImage = (Image)resources.GetObject("radioButton10.BackgroundImage");
            radioButton10.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton10.Location = new Point(453, 7);
            radioButton10.Margin = new Padding(2);
            radioButton10.Name = "radioButton10";
            radioButton10.Padding = new Padding(0, 60, 0, 0);
            radioButton10.Size = new Size(15, 12);
            radioButton10.TabIndex = 13;
            radioButton10.UseVisualStyleBackColor = false;
            radioButton10.Click += radioButton10_Click;
            // 
            // radioButton9
            // 
            radioButton9.BackColor = Color.Transparent;
            radioButton9.BackgroundImage = (Image)resources.GetObject("radioButton9.BackgroundImage");
            radioButton9.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton9.Location = new Point(404, 7);
            radioButton9.Margin = new Padding(2);
            radioButton9.Name = "radioButton9";
            radioButton9.Padding = new Padding(0, 60, 0, 0);
            radioButton9.Size = new Size(15, 12);
            radioButton9.TabIndex = 12;
            radioButton9.UseVisualStyleBackColor = false;
            radioButton9.Click += radioButton9_Click;
            // 
            // radioButton7
            // 
            radioButton7.BackColor = Color.Transparent;
            radioButton7.BackgroundImage = (Image)resources.GetObject("radioButton7.BackgroundImage");
            radioButton7.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton7.Location = new Point(306, 7);
            radioButton7.Margin = new Padding(2);
            radioButton7.Name = "radioButton7";
            radioButton7.Padding = new Padding(0, 60, 0, 0);
            radioButton7.Size = new Size(15, 12);
            radioButton7.TabIndex = 11;
            radioButton7.UseVisualStyleBackColor = false;
            radioButton7.Click += radioButton7_Click;
            // 
            // radioButton8
            // 
            radioButton8.BackColor = Color.Transparent;
            radioButton8.BackgroundImage = (Image)resources.GetObject("radioButton8.BackgroundImage");
            radioButton8.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton8.Location = new Point(355, 7);
            radioButton8.Margin = new Padding(2);
            radioButton8.Name = "radioButton8";
            radioButton8.Padding = new Padding(0, 60, 0, 0);
            radioButton8.Size = new Size(15, 12);
            radioButton8.TabIndex = 10;
            radioButton8.UseVisualStyleBackColor = false;
            radioButton8.Click += radioButton8_Click;
            // 
            // radioButton6
            // 
            radioButton6.BackColor = Color.Transparent;
            radioButton6.BackgroundImage = (Image)resources.GetObject("radioButton6.BackgroundImage");
            radioButton6.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton6.Location = new Point(257, 7);
            radioButton6.Margin = new Padding(2);
            radioButton6.Name = "radioButton6";
            radioButton6.Padding = new Padding(0, 60, 0, 0);
            radioButton6.Size = new Size(15, 12);
            radioButton6.TabIndex = 9;
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.Click += radioButton6_Click;
            // 
            // radioButton5
            // 
            radioButton5.BackColor = Color.Transparent;
            radioButton5.BackgroundImage = (Image)resources.GetObject("radioButton5.BackgroundImage");
            radioButton5.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton5.Location = new Point(208, 7);
            radioButton5.Margin = new Padding(2);
            radioButton5.Name = "radioButton5";
            radioButton5.Padding = new Padding(0, 60, 0, 0);
            radioButton5.Size = new Size(15, 12);
            radioButton5.TabIndex = 8;
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.Click += radioButton5_Click;
            // 
            // radioButton4
            // 
            radioButton4.BackColor = Color.Transparent;
            radioButton4.BackgroundImage = (Image)resources.GetObject("radioButton4.BackgroundImage");
            radioButton4.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton4.Location = new Point(159, 7);
            radioButton4.Margin = new Padding(2);
            radioButton4.Name = "radioButton4";
            radioButton4.Padding = new Padding(0, 60, 0, 0);
            radioButton4.Size = new Size(15, 12);
            radioButton4.TabIndex = 7;
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.Click += radioButton4_Click;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.Transparent;
            radioButton3.BackgroundImage = (Image)resources.GetObject("radioButton3.BackgroundImage");
            radioButton3.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton3.Location = new Point(110, 7);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(0, 60, 0, 0);
            radioButton3.Size = new Size(15, 12);
            radioButton3.TabIndex = 6;
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.Click += radioButton3_Click;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = (Image)resources.GetObject("radioButton2.BackgroundImage");
            radioButton2.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton2.ForeColor = Color.Transparent;
            radioButton2.Location = new Point(61, 7);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(0, 60, 0, 0);
            radioButton2.Size = new Size(15, 12);
            radioButton2.TabIndex = 5;
            radioButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // frequencyLabel
            // 
            frequencyLabel.Anchor = AnchorStyles.None;
            frequencyLabel.BackColor = Color.Black;
            frequencyLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            frequencyLabel.ForeColor = Color.DodgerBlue;
            frequencyLabel.Location = new Point(454, 55);
            frequencyLabel.Margin = new Padding(2, 0, 2, 0);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new Size(125, 28);
            frequencyLabel.TabIndex = 7;
            frequencyLabel.Text = "FREQUENCY";
            frequencyLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // amplitudeLabel
            // 
            amplitudeLabel.Anchor = AnchorStyles.None;
            amplitudeLabel.BackColor = Color.Black;
            amplitudeLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            amplitudeLabel.ForeColor = Color.DodgerBlue;
            amplitudeLabel.Location = new Point(328, 55);
            amplitudeLabel.Margin = new Padding(2, 0, 2, 0);
            amplitudeLabel.Name = "amplitudeLabel";
            amplitudeLabel.Size = new Size(125, 28);
            amplitudeLabel.TabIndex = 8;
            amplitudeLabel.Text = "AMPLITUDE";
            amplitudeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // backgroundColor
            // 
            backgroundColor.Anchor = AnchorStyles.None;
            backgroundColor.BackColor = Color.Black;
            backgroundColor.Location = new Point(328, 55);
            backgroundColor.Margin = new Padding(2, 0, 2, 0);
            backgroundColor.Name = "backgroundColor";
            backgroundColor.Size = new Size(36, 191);
            backgroundColor.TabIndex = 9;
            backgroundColor.Text = "label2";
            // 
            // backcolor2
            // 
            backcolor2.Anchor = AnchorStyles.None;
            backcolor2.BackColor = Color.Black;
            backcolor2.Location = new Point(421, 55);
            backcolor2.Margin = new Padding(2, 0, 2, 0);
            backcolor2.Name = "backcolor2";
            backcolor2.Size = new Size(64, 191);
            backcolor2.TabIndex = 10;
            backcolor2.Text = "label2";
            // 
            // backcolor3
            // 
            backcolor3.Anchor = AnchorStyles.None;
            backcolor3.BackColor = Color.Black;
            backcolor3.Location = new Point(541, 55);
            backcolor3.Margin = new Padding(2, 0, 2, 0);
            backcolor3.Name = "backcolor3";
            backcolor3.Size = new Size(36, 191);
            backcolor3.TabIndex = 11;
            backcolor3.Text = "label2";
            // 
            // soundBarLabel
            // 
            soundBarLabel.Anchor = AnchorStyles.None;
            soundBarLabel.BackColor = Color.Black;
            soundBarLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            soundBarLabel.ForeColor = Color.DodgerBlue;
            soundBarLabel.Location = new Point(94, 221);
            soundBarLabel.Margin = new Padding(2, 0, 2, 0);
            soundBarLabel.Name = "soundBarLabel";
            soundBarLabel.Size = new Size(230, 28);
            soundBarLabel.TabIndex = 12;
            soundBarLabel.Text = "SOUND STORAGE";
            soundBarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // outlinecolor
            // 
            outlinecolor.Anchor = AnchorStyles.None;
            outlinecolor.BackColor = Color.DodgerBlue;
            outlinecolor.Location = new Point(321, 50);
            outlinecolor.Margin = new Padding(2, 0, 2, 0);
            outlinecolor.Name = "outlinecolor";
            outlinecolor.Size = new Size(262, 200);
            outlinecolor.TabIndex = 13;
            // 
            // outlinecolor2
            // 
            outlinecolor2.Anchor = AnchorStyles.None;
            outlinecolor2.BackColor = Color.DodgerBlue;
            outlinecolor2.Location = new Point(88, 217);
            outlinecolor2.Margin = new Padding(2, 0, 2, 0);
            outlinecolor2.Name = "outlinecolor2";
            outlinecolor2.Size = new Size(496, 66);
            outlinecolor2.TabIndex = 14;
            // 
            // saveButtton
            // 
            saveButtton.Anchor = AnchorStyles.None;
            saveButtton.BackColor = Color.Black;
            saveButtton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            saveButtton.ForeColor = Color.DodgerBlue;
            saveButtton.Location = new Point(34, 122);
            saveButtton.Margin = new Padding(2);
            saveButtton.Name = "saveButtton";
            saveButtton.Size = new Size(130, 32);
            saveButtton.TabIndex = 15;
            saveButtton.Text = "Save Sound";
            saveButtton.TextAlign = ContentAlignment.TopCenter;
            saveButtton.UseVisualStyleBackColor = false;
            saveButtton.Click += saveButtton_Click;
            // 
            // deleteSoundButton
            // 
            deleteSoundButton.Anchor = AnchorStyles.None;
            deleteSoundButton.BackColor = Color.Black;
            deleteSoundButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSoundButton.ForeColor = Color.DodgerBlue;
            deleteSoundButton.Location = new Point(34, 158);
            deleteSoundButton.Margin = new Padding(2);
            deleteSoundButton.Name = "deleteSoundButton";
            deleteSoundButton.Size = new Size(130, 32);
            deleteSoundButton.TabIndex = 16;
            deleteSoundButton.Text = "Delete Sound";
            deleteSoundButton.TextAlign = ContentAlignment.TopCenter;
            deleteSoundButton.UseVisualStyleBackColor = false;
            // 
            // line1
            // 
            line1.Anchor = AnchorStyles.None;
            line1.BackColor = Color.DodgerBlue;
            line1.Location = new Point(88, 245);
            line1.Margin = new Padding(2, 0, 2, 0);
            line1.Name = "line1";
            line1.Size = new Size(238, 3);
            line1.TabIndex = 17;
            // 
            // line2
            // 
            line2.Anchor = AnchorStyles.None;
            line2.BackColor = Color.DodgerBlue;
            line2.Location = new Point(321, 80);
            line2.Margin = new Padding(2, 0, 2, 0);
            line2.Name = "line2";
            line2.Size = new Size(262, 4);
            line2.TabIndex = 18;
            // 
            // playSoundStorage
            // 
            playSoundStorage.Anchor = AnchorStyles.None;
            playSoundStorage.BackColor = Color.Black;
            playSoundStorage.BackgroundImage = (Image)resources.GetObject("playSoundStorage.BackgroundImage");
            playSoundStorage.BackgroundImageLayout = ImageLayout.Zoom;
            playSoundStorage.Location = new Point(27, 217);
            playSoundStorage.Margin = new Padding(2);
            playSoundStorage.Name = "playSoundStorage";
            playSoundStorage.Size = new Size(57, 66);
            playSoundStorage.TabIndex = 19;
            playSoundStorage.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(856, 45);
            label1.Name = "label1";
            label1.Size = new Size(178, 47);
            label1.TabIndex = 20;
            label1.Text = "DURATION";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Black;
            label2.Location = new Point(792, 45);
            label2.Name = "label2";
            label2.Size = new Size(91, 391);
            label2.TabIndex = 21;
            label2.Text = "label2";
            // 
            // durationBar
            // 
            durationBar.Anchor = AnchorStyles.None;
            durationBar.BackColor = SystemColors.ActiveCaptionText;
            durationBar.Location = new Point(889, 95);
            durationBar.Maximum = 400;
            durationBar.Minimum = 200;
            durationBar.Name = "durationBar";
            durationBar.Orientation = Orientation.Vertical;
            durationBar.Size = new Size(69, 277);
            durationBar.TabIndex = 22;
            durationBar.TickFrequency = 20;
            durationBar.TickStyle = TickStyle.Both;
            durationBar.Value = 200;
            durationBar.Scroll += durationBar_Scroll;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Black;
            label3.Location = new Point(964, 45);
            label3.Name = "label3";
            label3.Size = new Size(70, 391);
            label3.TabIndex = 23;
            label3.Text = "label3";
            // 
            // amplitudeDisplay
            // 
            amplitudeDisplay.Anchor = AnchorStyles.None;
            amplitudeDisplay.BackColor = Color.Black;
            amplitudeDisplay.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Bold, GraphicsUnit.Point);
            amplitudeDisplay.ForeColor = Color.DodgerBlue;
            amplitudeDisplay.Location = new Point(530, 375);
            amplitudeDisplay.Name = "amplitudeDisplay";
            amplitudeDisplay.Size = new Size(94, 61);
            amplitudeDisplay.TabIndex = 24;
            amplitudeDisplay.Text = "1000";
            amplitudeDisplay.TextAlign = ContentAlignment.TopCenter;
            // 
            // frequencyValueDisplay
            // 
            frequencyValueDisplay.Anchor = AnchorStyles.None;
            frequencyValueDisplay.BackColor = Color.Black;
            frequencyValueDisplay.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Bold, GraphicsUnit.Point);
            frequencyValueDisplay.ForeColor = Color.DodgerBlue;
            frequencyValueDisplay.Location = new Point(702, 375);
            frequencyValueDisplay.Name = "frequencyValueDisplay";
            frequencyValueDisplay.Size = new Size(94, 61);
            frequencyValueDisplay.TabIndex = 25;
            frequencyValueDisplay.Text = "200";
            frequencyValueDisplay.TextAlign = ContentAlignment.TopCenter;
            // 
            // durationValueDisplay
            // 
            durationValueDisplay.Anchor = AnchorStyles.None;
            durationValueDisplay.BackColor = Color.Black;
            durationValueDisplay.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Bold, GraphicsUnit.Point);
            durationValueDisplay.ForeColor = Color.DodgerBlue;
            durationValueDisplay.Location = new Point(875, 375);
            durationValueDisplay.Name = "durationValueDisplay";
            durationValueDisplay.Size = new Size(94, 61);
            durationValueDisplay.TabIndex = 26;
            durationValueDisplay.Text = "200";
            durationValueDisplay.TextAlign = ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.None;
            exitButton.BackColor = Color.Black;
            exitButton.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = Color.DodgerBlue;
            exitButton.Location = new Point(1073, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(50, 50);
            exitButton.TabIndex = 27;
            exitButton.Text = "?";
            exitButton.TextAlign = ContentAlignment.TopCenter;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MainSythesizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 305);
            Controls.Add(playSoundStorage);
            Controls.Add(line2);
            Controls.Add(line1);
            Controls.Add(deleteSoundButton);
            Controls.Add(saveButtton);
            Controls.Add(soundBarLabel);
            Controls.Add(amplitudeLabel);
            Controls.Add(frequencyLabel);
            Controls.Add(radioButtonGroup);
            Controls.Add(AmplitudeBar);
            Controls.Add(FrequencyBar);
            Controls.Add(PlaySound);
            Controls.Add(WaveFormDropDown);
            Controls.Add(backgroundColor);
            Controls.Add(backcolor2);
            Controls.Add(backcolor3);
            Controls.Add(outlinecolor);
            Controls.Add(outlinecolor2);
            Margin = new Padding(2);
            KeyPreview = true;
            Name = "MainSythesizer";
            Text = "Form1";
            KeyPress += OnKeyPress;
            ((System.ComponentModel.ISupportInitialize)FrequencyBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmplitudeBar).EndInit();
            radioButtonGroup.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox WaveFormDropDown;
        private Button PlaySound;
        private TrackBar FrequencyBar;
        private TrackBar AmplitudeBar;
        private RadioButton radioButton1;
        private Panel radioButtonGroup;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Label frequencyLabel;
        private Label amplitudeLabel;
        private Label backgroundColor;
        private Label backcolor2;
        private Label backcolor3;
        private Label soundBarLabel;
        private Label outlinecolor;
        private Label outlinecolor2;
        private Button saveButtton;
        private Button deleteSoundButton;
        private Label line1;
        private Label line2;
        private Button playSoundStorage;
    }
}