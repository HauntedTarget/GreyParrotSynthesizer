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
            cb_hoverTut = new CheckBox();
            l_tip = new Label();
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
            WaveFormDropDown.Location = new Point(49, 38);
            WaveFormDropDown.Name = "WaveFormDropDown";
            WaveFormDropDown.Size = new Size(185, 45);
            WaveFormDropDown.TabIndex = 0;
            WaveFormDropDown.SelectedIndexChanged += WaveFormDropDown_SelectedIndexChanged;
            WaveFormDropDown.MouseMove += OnMouseMove;
            WaveFormDropDown.MouseHover += OnHover;
            WaveFormDropDown.MouseLeave += OnLeave;
            // 
            // PlaySound
            // 
            PlaySound.Anchor = AnchorStyles.None;
            PlaySound.BackColor = Color.Black;
            PlaySound.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            PlaySound.ForeColor = Color.DodgerBlue;
            PlaySound.Location = new Point(49, 145);
            PlaySound.Name = "PlaySound";
            PlaySound.Size = new Size(186, 53);
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
            FrequencyBar.Location = new Point(701, 133);
            FrequencyBar.Maximum = 400;
            FrequencyBar.Minimum = 200;
            FrequencyBar.Name = "FrequencyBar";
            FrequencyBar.Orientation = Orientation.Vertical;
            FrequencyBar.Size = new Size(69, 277);
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
            AmplitudeBar.Location = new Point(529, 133);
            AmplitudeBar.Maximum = 10000;
            AmplitudeBar.Minimum = 1000;
            AmplitudeBar.Name = "AmplitudeBar";
            AmplitudeBar.Orientation = Orientation.Vertical;
            AmplitudeBar.Size = new Size(69, 277);
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
            radioButton1.Location = new Point(17, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(0, 100, 0, 0);
            radioButton1.Size = new Size(21, 20);
            radioButton1.TabIndex = 4;
            radioButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += RadioButton1_Click;
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
            radioButtonGroup.Location = new Point(134, 417);
            radioButtonGroup.Name = "radioButtonGroup";
            radioButtonGroup.Size = new Size(689, 48);
            radioButtonGroup.TabIndex = 6;
            // 
            // radioButton10
            // 
            radioButton10.BackColor = Color.Transparent;
            radioButton10.BackgroundImage = (Image)resources.GetObject("radioButton10.BackgroundImage");
            radioButton10.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton10.Location = new Point(647, 12);
            radioButton10.Name = "radioButton10";
            radioButton10.Padding = new Padding(0, 100, 0, 0);
            radioButton10.Size = new Size(21, 20);
            radioButton10.TabIndex = 13;
            radioButton10.UseVisualStyleBackColor = false;
            radioButton10.Click += RadioButton10_Click;
            // 
            // radioButton9
            // 
            radioButton9.BackColor = Color.Transparent;
            radioButton9.BackgroundImage = (Image)resources.GetObject("radioButton9.BackgroundImage");
            radioButton9.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton9.Location = new Point(577, 12);
            radioButton9.Name = "radioButton9";
            radioButton9.Padding = new Padding(0, 100, 0, 0);
            radioButton9.Size = new Size(21, 20);
            radioButton9.TabIndex = 12;
            radioButton9.UseVisualStyleBackColor = false;
            radioButton9.Click += RadioButton9_Click;
            // 
            // radioButton7
            // 
            radioButton7.BackColor = Color.Transparent;
            radioButton7.BackgroundImage = (Image)resources.GetObject("radioButton7.BackgroundImage");
            radioButton7.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton7.Location = new Point(437, 12);
            radioButton7.Name = "radioButton7";
            radioButton7.Padding = new Padding(0, 100, 0, 0);
            radioButton7.Size = new Size(21, 20);
            radioButton7.TabIndex = 11;
            radioButton7.UseVisualStyleBackColor = false;
            radioButton7.Click += RadioButton7_Click;
            // 
            // radioButton8
            // 
            radioButton8.BackColor = Color.Transparent;
            radioButton8.BackgroundImage = (Image)resources.GetObject("radioButton8.BackgroundImage");
            radioButton8.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton8.Location = new Point(507, 12);
            radioButton8.Name = "radioButton8";
            radioButton8.Padding = new Padding(0, 100, 0, 0);
            radioButton8.Size = new Size(21, 20);
            radioButton8.TabIndex = 10;
            radioButton8.UseVisualStyleBackColor = false;
            radioButton8.Click += RadioButton8_Click;
            // 
            // radioButton6
            // 
            radioButton6.BackColor = Color.Transparent;
            radioButton6.BackgroundImage = (Image)resources.GetObject("radioButton6.BackgroundImage");
            radioButton6.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton6.Location = new Point(367, 12);
            radioButton6.Name = "radioButton6";
            radioButton6.Padding = new Padding(0, 100, 0, 0);
            radioButton6.Size = new Size(21, 20);
            radioButton6.TabIndex = 9;
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.Click += RadioButton6_Click;
            // 
            // radioButton5
            // 
            radioButton5.BackColor = Color.Transparent;
            radioButton5.BackgroundImage = (Image)resources.GetObject("radioButton5.BackgroundImage");
            radioButton5.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton5.Location = new Point(297, 12);
            radioButton5.Name = "radioButton5";
            radioButton5.Padding = new Padding(0, 100, 0, 0);
            radioButton5.Size = new Size(21, 20);
            radioButton5.TabIndex = 8;
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.Click += RadioButton5_Click;
            // 
            // radioButton4
            // 
            radioButton4.BackColor = Color.Transparent;
            radioButton4.BackgroundImage = (Image)resources.GetObject("radioButton4.BackgroundImage");
            radioButton4.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton4.Location = new Point(227, 12);
            radioButton4.Name = "radioButton4";
            radioButton4.Padding = new Padding(0, 100, 0, 0);
            radioButton4.Size = new Size(21, 20);
            radioButton4.TabIndex = 7;
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.Click += RadioButton4_Click;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.Transparent;
            radioButton3.BackgroundImage = (Image)resources.GetObject("radioButton3.BackgroundImage");
            radioButton3.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton3.Location = new Point(157, 12);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(0, 100, 0, 0);
            radioButton3.Size = new Size(21, 20);
            radioButton3.TabIndex = 6;
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.Click += RadioButton3_Click;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = (Image)resources.GetObject("radioButton2.BackgroundImage");
            radioButton2.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton2.ForeColor = Color.Transparent;
            radioButton2.Location = new Point(87, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(0, 100, 0, 0);
            radioButton2.Size = new Size(21, 20);
            radioButton2.TabIndex = 5;
            radioButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += RadioButton2_Click;
            // 
            // frequencyLabel
            // 
            frequencyLabel.Anchor = AnchorStyles.None;
            frequencyLabel.BackColor = Color.Black;
            frequencyLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            frequencyLabel.ForeColor = Color.DodgerBlue;
            frequencyLabel.Location = new Point(649, 92);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new Size(179, 47);
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
            amplitudeLabel.Location = new Point(469, 92);
            amplitudeLabel.Name = "amplitudeLabel";
            amplitudeLabel.Size = new Size(179, 47);
            amplitudeLabel.TabIndex = 8;
            amplitudeLabel.Text = "AMPLITUDE";
            amplitudeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // backgroundColor
            // 
            backgroundColor.Anchor = AnchorStyles.None;
            backgroundColor.BackColor = Color.Black;
            backgroundColor.Location = new Point(469, 92);
            backgroundColor.Name = "backgroundColor";
            backgroundColor.Size = new Size(51, 318);
            backgroundColor.TabIndex = 9;
            backgroundColor.Text = "label2";
            // 
            // backcolor2
            // 
            backcolor2.Anchor = AnchorStyles.None;
            backcolor2.BackColor = Color.Black;
            backcolor2.Location = new Point(601, 92);
            backcolor2.Name = "backcolor2";
            backcolor2.Size = new Size(91, 318);
            backcolor2.TabIndex = 10;
            backcolor2.Text = "label2";
            // 
            // backcolor3
            // 
            backcolor3.Anchor = AnchorStyles.None;
            backcolor3.BackColor = Color.Black;
            backcolor3.Location = new Point(773, 92);
            backcolor3.Name = "backcolor3";
            backcolor3.Size = new Size(51, 318);
            backcolor3.TabIndex = 11;
            backcolor3.Text = "label2";
            // 
            // soundBarLabel
            // 
            soundBarLabel.Anchor = AnchorStyles.None;
            soundBarLabel.BackColor = Color.Black;
            soundBarLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            soundBarLabel.ForeColor = Color.DodgerBlue;
            soundBarLabel.Location = new Point(134, 368);
            soundBarLabel.Name = "soundBarLabel";
            soundBarLabel.Size = new Size(329, 47);
            soundBarLabel.TabIndex = 12;
            soundBarLabel.Text = "SOUND STORAGE";
            soundBarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // outlinecolor
            // 
            outlinecolor.Anchor = AnchorStyles.None;
            outlinecolor.BackColor = Color.DodgerBlue;
            outlinecolor.Location = new Point(459, 83);
            outlinecolor.Name = "outlinecolor";
            outlinecolor.Size = new Size(374, 333);
            outlinecolor.TabIndex = 13;
            // 
            // outlinecolor2
            // 
            outlinecolor2.Anchor = AnchorStyles.None;
            outlinecolor2.BackColor = Color.DodgerBlue;
            outlinecolor2.Location = new Point(126, 362);
            outlinecolor2.Name = "outlinecolor2";
            outlinecolor2.Size = new Size(709, 110);
            outlinecolor2.TabIndex = 14;
            // 
            // saveButtton
            // 
            saveButtton.Anchor = AnchorStyles.None;
            saveButtton.BackColor = Color.Black;
            saveButtton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            saveButtton.ForeColor = Color.DodgerBlue;
            saveButtton.Location = new Point(49, 203);
            saveButtton.Name = "saveButtton";
            saveButtton.Size = new Size(186, 53);
            saveButtton.TabIndex = 15;
            saveButtton.Text = "Save Sound";
            saveButtton.TextAlign = ContentAlignment.TopCenter;
            saveButtton.UseVisualStyleBackColor = false;
            saveButtton.Click += SaveButtton_Click;
            // 
            // deleteSoundButton
            // 
            deleteSoundButton.Anchor = AnchorStyles.None;
            deleteSoundButton.BackColor = Color.Black;
            deleteSoundButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSoundButton.ForeColor = Color.DodgerBlue;
            deleteSoundButton.Location = new Point(49, 263);
            deleteSoundButton.Name = "deleteSoundButton";
            deleteSoundButton.Size = new Size(186, 53);
            deleteSoundButton.TabIndex = 16;
            deleteSoundButton.Text = "Delete Sound";
            deleteSoundButton.TextAlign = ContentAlignment.TopCenter;
            deleteSoundButton.UseVisualStyleBackColor = false;
            // 
            // line1
            // 
            line1.Anchor = AnchorStyles.None;
            line1.BackColor = Color.DodgerBlue;
            line1.Location = new Point(126, 408);
            line1.Name = "line1";
            line1.Size = new Size(340, 5);
            line1.TabIndex = 17;
            // 
            // line2
            // 
            line2.Anchor = AnchorStyles.None;
            line2.BackColor = Color.DodgerBlue;
            line2.Location = new Point(459, 133);
            line2.Name = "line2";
            line2.Size = new Size(374, 7);
            line2.TabIndex = 18;
            // 
            // playSoundStorage
            // 
            playSoundStorage.Anchor = AnchorStyles.None;
            playSoundStorage.BackColor = Color.Black;
            playSoundStorage.BackgroundImage = (Image)resources.GetObject("playSoundStorage.BackgroundImage");
            playSoundStorage.BackgroundImageLayout = ImageLayout.Zoom;
            playSoundStorage.Location = new Point(39, 362);
            playSoundStorage.Name = "playSoundStorage";
            playSoundStorage.Size = new Size(81, 110);
            playSoundStorage.TabIndex = 19;
            playSoundStorage.UseVisualStyleBackColor = false;
            playSoundStorage.Click += PlaySoundStorage_Click;
            // 
            // cb_hoverTut
            // 
            cb_hoverTut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_hoverTut.AutoSize = true;
            cb_hoverTut.Checked = true;
            cb_hoverTut.CheckState = CheckState.Checked;
            cb_hoverTut.Location = new Point(12, 3);
            cb_hoverTut.Name = "cb_hoverTut";
            cb_hoverTut.Size = new Size(131, 29);
            cb_hoverTut.TabIndex = 20;
            cb_hoverTut.Text = "Hover Tips?";
            cb_hoverTut.UseVisualStyleBackColor = true;
            // 
            // l_tip
            // 
            l_tip.Anchor = AnchorStyles.None;
            l_tip.AutoSize = true;
            l_tip.BackColor = SystemColors.ActiveBorder;
            l_tip.BorderStyle = BorderStyle.FixedSingle;
            l_tip.ForeColor = SystemColors.ActiveCaptionText;
            l_tip.Location = new Point(753, 3);
            l_tip.Name = "l_tip";
            l_tip.Size = new Size(106, 27);
            l_tip.TabIndex = 21;
            l_tip.Text = "placeholder";
            l_tip.Visible = false;
            // 
            // MainSythesizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 508);
            Controls.Add(l_tip);
            Controls.Add(cb_hoverTut);
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
            KeyPreview = true;
            Name = "MainSythesizer";
            Text = "Form1";
            KeyPress += OnKeyPress;
            MouseMove += OnMouseMove;
            MouseHover += OnHover;
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
        private CheckBox cb_hoverTut;
        private Label l_tip;
    }
}