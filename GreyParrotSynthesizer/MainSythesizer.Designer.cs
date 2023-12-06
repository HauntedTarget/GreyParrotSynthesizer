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
            soundBarLabel = new Label();
            outlinecolor = new Label();
            outlinecolor2 = new Label();
            saveButtton = new Button();
            deleteSoundButton = new Button();
            line1 = new Label();
            playSoundStorage = new Button();
            label1 = new Label();
            label2 = new Label();
            durationBar = new TrackBar();
            label3 = new Label();
            amplitudeDisplay = new Label();
            frequencyValueDisplay = new Label();
            durationValueDisplay = new Label();
            cb_hoverTut = new CheckBox();
            l_tip = new Label();
            label4 = new Label();
            FileNameLabel = new Label();
            FileNameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FrequencyBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmplitudeBar).BeginInit();
            radioButtonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)durationBar).BeginInit();
            SuspendLayout();
            // 
            // WaveFormDropDown
            // 
            WaveFormDropDown.BackColor = Color.Black;
            WaveFormDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            WaveFormDropDown.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            WaveFormDropDown.ForeColor = Color.DodgerBlue;
            WaveFormDropDown.FormattingEnabled = true;
            WaveFormDropDown.Location = new Point(123, 133);
            WaveFormDropDown.Margin = new Padding(4, 5, 4, 5);
            WaveFormDropDown.Name = "WaveFormDropDown";
            WaveFormDropDown.Size = new Size(185, 45);
            WaveFormDropDown.TabIndex = 0;
            WaveFormDropDown.SelectedIndexChanged += WaveFormDropDown_SelectedIndexChanged;
            WaveFormDropDown.MouseLeave += OnLeave;
            WaveFormDropDown.MouseHover += OnHover;
            WaveFormDropDown.MouseMove += OnMouseMove;
            // 
            // PlaySound
            // 
            PlaySound.BackColor = Color.Black;
            PlaySound.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            PlaySound.ForeColor = Color.DodgerBlue;
            PlaySound.Location = new Point(123, 310);
            PlaySound.Name = "PlaySound";
            PlaySound.Size = new Size(186, 53);
            PlaySound.TabIndex = 1;
            PlaySound.Text = "Play Sound";
            PlaySound.TextAlign = ContentAlignment.TopCenter;
            PlaySound.UseVisualStyleBackColor = false;
            PlaySound.Click += PlaySound_Click;
            PlaySound.MouseLeave += OnLeave;
            PlaySound.MouseHover += OnHover;
            PlaySound.MouseMove += OnMouseMove;
            // 
            // FrequencyBar
            // 
            FrequencyBar.BackColor = SystemColors.ActiveCaptionText;
            FrequencyBar.Location = new Point(1021, 137);
            FrequencyBar.Maximum = 400;
            FrequencyBar.Minimum = 200;
            FrequencyBar.Name = "FrequencyBar";
            FrequencyBar.Orientation = Orientation.Vertical;
            FrequencyBar.Size = new Size(69, 513);
            FrequencyBar.TabIndex = 2;
            FrequencyBar.TickFrequency = 20;
            FrequencyBar.TickStyle = TickStyle.Both;
            FrequencyBar.Value = 200;
            FrequencyBar.Scroll += FrequencyBar_Scroll;
            FrequencyBar.MouseLeave += OnLeave;
            FrequencyBar.MouseHover += OnHover;
            FrequencyBar.MouseMove += OnMouseMove;
            // 
            // AmplitudeBar
            // 
            AmplitudeBar.BackColor = SystemColors.ActiveCaptionText;
            AmplitudeBar.Location = new Point(777, 133);
            AmplitudeBar.Margin = new Padding(4, 5, 4, 5);
            AmplitudeBar.Maximum = 10000;
            AmplitudeBar.Minimum = 1000;
            AmplitudeBar.Name = "AmplitudeBar";
            AmplitudeBar.Orientation = Orientation.Vertical;
            AmplitudeBar.Size = new Size(69, 517);
            AmplitudeBar.TabIndex = 3;
            AmplitudeBar.TickFrequency = 300;
            AmplitudeBar.TickStyle = TickStyle.Both;
            AmplitudeBar.Value = 1000;
            AmplitudeBar.Scroll += AmplitudeBar_Scroll;
            AmplitudeBar.MouseLeave += OnLeave;
            AmplitudeBar.MouseHover += OnHover;
            AmplitudeBar.MouseMove += OnMouseMove;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.Transparent;
            radioButton1.BackgroundImage = (Image)resources.GetObject("radioButton1.BackgroundImage");
            radioButton1.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton1.ForeColor = Color.Transparent;
            radioButton1.Location = new Point(17, 17);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(0, 167, 0, 0);
            radioButton1.Size = new Size(36, 42);
            radioButton1.TabIndex = 4;
            radioButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += RadioButton1_Click;
            radioButton1.MouseLeave += OnLeave;
            radioButton1.MouseHover += OnHover;
            radioButton1.MouseMove += OnMouseMove;
            // 
            // radioButtonGroup
            // 
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
            radioButtonGroup.Location = new Point(246, 763);
            radioButtonGroup.Margin = new Padding(4, 5, 4, 5);
            radioButtonGroup.Name = "radioButtonGroup";
            radioButtonGroup.Size = new Size(1219, 80);
            radioButtonGroup.TabIndex = 6;
            radioButtonGroup.MouseLeave += OnLeave;
            radioButtonGroup.MouseHover += OnHover;
            radioButtonGroup.MouseMove += OnMouseMove;
            // 
            // radioButton10
            // 
            radioButton10.BackColor = Color.Transparent;
            radioButton10.BackgroundImage = (Image)resources.GetObject("radioButton10.BackgroundImage");
            radioButton10.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton10.Location = new Point(1160, 17);
            radioButton10.Margin = new Padding(4, 5, 4, 5);
            radioButton10.Name = "radioButton10";
            radioButton10.Padding = new Padding(0, 167, 0, 0);
            radioButton10.Size = new Size(36, 42);
            radioButton10.TabIndex = 13;
            radioButton10.UseVisualStyleBackColor = false;
            radioButton10.Click += RadioButton10_Click;
            radioButton10.MouseLeave += OnLeave;
            radioButton10.MouseHover += OnHover;
            radioButton10.MouseMove += OnMouseMove;
            // 
            // radioButton9
            // 
            radioButton9.BackColor = Color.Transparent;
            radioButton9.BackgroundImage = (Image)resources.GetObject("radioButton9.BackgroundImage");
            radioButton9.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton9.Location = new Point(1046, 17);
            radioButton9.Margin = new Padding(4, 5, 4, 5);
            radioButton9.Name = "radioButton9";
            radioButton9.Padding = new Padding(0, 167, 0, 0);
            radioButton9.Size = new Size(36, 42);
            radioButton9.TabIndex = 12;
            radioButton9.UseVisualStyleBackColor = false;
            radioButton9.Click += RadioButton9_Click;
            radioButton9.MouseLeave += OnLeave;
            radioButton9.MouseHover += OnHover;
            radioButton9.MouseMove += OnMouseMove;
            // 
            // radioButton7
            // 
            radioButton7.BackColor = Color.Transparent;
            radioButton7.BackgroundImage = (Image)resources.GetObject("radioButton7.BackgroundImage");
            radioButton7.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton7.Location = new Point(789, 17);
            radioButton7.Margin = new Padding(4, 5, 4, 5);
            radioButton7.Name = "radioButton7";
            radioButton7.Padding = new Padding(0, 167, 0, 0);
            radioButton7.Size = new Size(36, 42);
            radioButton7.TabIndex = 11;
            radioButton7.UseVisualStyleBackColor = false;
            radioButton7.Click += RadioButton7_Click;
            radioButton7.MouseLeave += OnLeave;
            radioButton7.MouseHover += OnHover;
            radioButton7.MouseMove += OnMouseMove;
            // 
            // radioButton8
            // 
            radioButton8.BackColor = Color.Transparent;
            radioButton8.BackgroundImage = (Image)resources.GetObject("radioButton8.BackgroundImage");
            radioButton8.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton8.Location = new Point(917, 17);
            radioButton8.Margin = new Padding(4, 5, 4, 5);
            radioButton8.Name = "radioButton8";
            radioButton8.Padding = new Padding(0, 167, 0, 0);
            radioButton8.Size = new Size(36, 42);
            radioButton8.TabIndex = 10;
            radioButton8.UseVisualStyleBackColor = false;
            radioButton8.Click += RadioButton8_Click;
            radioButton8.MouseLeave += OnLeave;
            radioButton8.MouseHover += OnHover;
            radioButton8.MouseMove += OnMouseMove;
            // 
            // radioButton6
            // 
            radioButton6.BackColor = Color.Transparent;
            radioButton6.BackgroundImage = (Image)resources.GetObject("radioButton6.BackgroundImage");
            radioButton6.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton6.Location = new Point(660, 17);
            radioButton6.Margin = new Padding(4, 5, 4, 5);
            radioButton6.Name = "radioButton6";
            radioButton6.Padding = new Padding(0, 167, 0, 0);
            radioButton6.Size = new Size(36, 42);
            radioButton6.TabIndex = 9;
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.Click += RadioButton6_Click;
            radioButton6.MouseLeave += OnLeave;
            radioButton6.MouseHover += OnHover;
            radioButton6.MouseMove += OnMouseMove;
            // 
            // radioButton5
            // 
            radioButton5.BackColor = Color.Transparent;
            radioButton5.BackgroundImage = (Image)resources.GetObject("radioButton5.BackgroundImage");
            radioButton5.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton5.Location = new Point(531, 17);
            radioButton5.Margin = new Padding(4, 5, 4, 5);
            radioButton5.Name = "radioButton5";
            radioButton5.Padding = new Padding(0, 167, 0, 0);
            radioButton5.Size = new Size(36, 42);
            radioButton5.TabIndex = 8;
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.Click += RadioButton5_Click;
            radioButton5.MouseLeave += OnLeave;
            radioButton5.MouseHover += OnHover;
            radioButton5.MouseMove += OnMouseMove;
            // 
            // radioButton4
            // 
            radioButton4.BackColor = Color.Transparent;
            radioButton4.BackgroundImage = (Image)resources.GetObject("radioButton4.BackgroundImage");
            radioButton4.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton4.Location = new Point(403, 17);
            radioButton4.Margin = new Padding(4, 5, 4, 5);
            radioButton4.Name = "radioButton4";
            radioButton4.Padding = new Padding(0, 167, 0, 0);
            radioButton4.Size = new Size(36, 42);
            radioButton4.TabIndex = 7;
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.Click += RadioButton4_Click;
            radioButton4.MouseLeave += OnLeave;
            radioButton4.MouseHover += OnHover;
            radioButton4.MouseMove += OnMouseMove;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.Transparent;
            radioButton3.BackgroundImage = (Image)resources.GetObject("radioButton3.BackgroundImage");
            radioButton3.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton3.Location = new Point(274, 17);
            radioButton3.Margin = new Padding(4, 5, 4, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(0, 167, 0, 0);
            radioButton3.Size = new Size(36, 42);
            radioButton3.TabIndex = 6;
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.Click += RadioButton3_Click;
            radioButton3.MouseLeave += OnLeave;
            radioButton3.MouseHover += OnHover;
            radioButton3.MouseMove += OnMouseMove;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = (Image)resources.GetObject("radioButton2.BackgroundImage");
            radioButton2.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton2.ForeColor = Color.Transparent;
            radioButton2.Location = new Point(146, 17);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(0, 167, 0, 0);
            radioButton2.Size = new Size(36, 42);
            radioButton2.TabIndex = 5;
            radioButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += RadioButton2_Click;
            radioButton2.MouseLeave += OnLeave;
            radioButton2.MouseHover += OnHover;
            radioButton2.MouseMove += OnMouseMove;
            // 
            // frequencyLabel
            // 
            frequencyLabel.BackColor = Color.Black;
            frequencyLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            frequencyLabel.ForeColor = Color.DodgerBlue;
            frequencyLabel.Location = new Point(947, 98);
            frequencyLabel.Margin = new Padding(4, 0, 4, 0);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new Size(251, 47);
            frequencyLabel.TabIndex = 7;
            frequencyLabel.Text = "FREQUENCY";
            frequencyLabel.TextAlign = ContentAlignment.TopCenter;
            frequencyLabel.MouseLeave += OnLeave;
            frequencyLabel.MouseHover += OnHover;
            frequencyLabel.MouseMove += OnMouseMove;
            // 
            // amplitudeLabel
            // 
            amplitudeLabel.BackColor = Color.Black;
            amplitudeLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            amplitudeLabel.ForeColor = Color.DodgerBlue;
            amplitudeLabel.Location = new Point(684, 98);
            amplitudeLabel.Margin = new Padding(4, 0, 4, 0);
            amplitudeLabel.Name = "amplitudeLabel";
            amplitudeLabel.Size = new Size(234, 47);
            amplitudeLabel.TabIndex = 8;
            amplitudeLabel.Text = "AMPLITUDE";
            amplitudeLabel.TextAlign = ContentAlignment.TopCenter;
            amplitudeLabel.MouseLeave += OnLeave;
            amplitudeLabel.MouseHover += OnHover;
            amplitudeLabel.MouseMove += OnMouseMove;
            // 
            // backgroundColor
            // 
            backgroundColor.BackColor = Color.Black;
            backgroundColor.Location = new Point(684, 98);
            backgroundColor.Margin = new Padding(4, 0, 4, 0);
            backgroundColor.Name = "backgroundColor";
            backgroundColor.Size = new Size(86, 652);
            backgroundColor.TabIndex = 9;
            backgroundColor.Text = "label2";
            backgroundColor.MouseLeave += OnLeave;
            backgroundColor.MouseHover += OnHover;
            backgroundColor.MouseMove += OnMouseMove;
            // 
            // backcolor2
            // 
            backcolor2.BackColor = Color.Black;
            backcolor2.Location = new Point(854, 98);
            backcolor2.Margin = new Padding(4, 0, 4, 0);
            backcolor2.Name = "backcolor2";
            backcolor2.Size = new Size(161, 652);
            backcolor2.TabIndex = 10;
            backcolor2.Text = "label2";
            backcolor2.MouseLeave += OnLeave;
            backcolor2.MouseHover += OnHover;
            backcolor2.MouseMove += OnMouseMove;
            // 
            // soundBarLabel
            // 
            soundBarLabel.BackColor = Color.Black;
            soundBarLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            soundBarLabel.ForeColor = Color.DodgerBlue;
            soundBarLabel.Location = new Point(247, 683);
            soundBarLabel.Margin = new Padding(4, 0, 4, 0);
            soundBarLabel.Name = "soundBarLabel";
            soundBarLabel.Size = new Size(473, 67);
            soundBarLabel.TabIndex = 12;
            soundBarLabel.Text = "SOUND STORAGE";
            soundBarLabel.TextAlign = ContentAlignment.TopCenter;
            soundBarLabel.MouseLeave += OnLeave;
            soundBarLabel.MouseHover += OnHover;
            soundBarLabel.MouseMove += OnMouseMove;
            // 
            // outlinecolor
            // 
            outlinecolor.BackColor = Color.White;
            outlinecolor.Location = new Point(670, 83);
            outlinecolor.Margin = new Padding(4, 0, 4, 0);
            outlinecolor.Name = "outlinecolor";
            outlinecolor.Size = new Size(803, 678);
            outlinecolor.TabIndex = 13;
            outlinecolor.MouseLeave += OnLeave;
            outlinecolor.MouseHover += OnHover;
            outlinecolor.MouseMove += OnMouseMove;
            // 
            // outlinecolor2
            // 
            outlinecolor2.BackColor = Color.White;
            outlinecolor2.Location = new Point(234, 672);
            outlinecolor2.Margin = new Padding(4, 0, 4, 0);
            outlinecolor2.Name = "outlinecolor2";
            outlinecolor2.Size = new Size(1239, 183);
            outlinecolor2.TabIndex = 14;
            outlinecolor2.MouseLeave += OnLeave;
            outlinecolor2.MouseHover += OnHover;
            outlinecolor2.MouseMove += OnMouseMove;
            // 
            // saveButtton
            // 
            saveButtton.BackColor = Color.Black;
            saveButtton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            saveButtton.ForeColor = Color.DodgerBlue;
            saveButtton.Location = new Point(123, 408);
            saveButtton.Margin = new Padding(4, 5, 4, 5);
            saveButtton.Name = "saveButtton";
            saveButtton.Size = new Size(186, 53);
            saveButtton.TabIndex = 15;
            saveButtton.Text = "Save Sound";
            saveButtton.TextAlign = ContentAlignment.TopCenter;
            saveButtton.UseVisualStyleBackColor = false;
            saveButtton.Click += SaveButtton_Click;
            saveButtton.MouseLeave += OnLeave;
            saveButtton.MouseHover += OnHover;
            saveButtton.MouseMove += OnMouseMove;
            // 
            // deleteSoundButton
            // 
            deleteSoundButton.BackColor = Color.Black;
            deleteSoundButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSoundButton.ForeColor = Color.DodgerBlue;
            deleteSoundButton.Location = new Point(123, 507);
            deleteSoundButton.Margin = new Padding(4, 5, 4, 5);
            deleteSoundButton.Name = "deleteSoundButton";
            deleteSoundButton.Size = new Size(186, 53);
            deleteSoundButton.TabIndex = 16;
            deleteSoundButton.Text = "Delete Sound";
            deleteSoundButton.TextAlign = ContentAlignment.TopCenter;
            deleteSoundButton.UseVisualStyleBackColor = false;
            deleteSoundButton.MouseLeave += OnLeave;
            deleteSoundButton.MouseHover += OnHover;
            deleteSoundButton.MouseMove += OnMouseMove;
            // 
            // line1
            // 
            line1.BackColor = Color.White;
            line1.Location = new Point(234, 750);
            line1.Margin = new Padding(4, 0, 4, 0);
            line1.Name = "line1";
            line1.Size = new Size(340, 5);
            line1.TabIndex = 17;
            line1.MouseLeave += OnLeave;
            line1.MouseHover += OnHover;
            line1.MouseMove += OnMouseMove;
            // 
            // playSoundStorage
            // 
            playSoundStorage.BackColor = Color.Black;
            playSoundStorage.BackgroundImage = (Image)resources.GetObject("playSoundStorage.BackgroundImage");
            playSoundStorage.BackgroundImageLayout = ImageLayout.Zoom;
            playSoundStorage.Location = new Point(110, 672);
            playSoundStorage.Margin = new Padding(4, 5, 4, 5);
            playSoundStorage.Name = "playSoundStorage";
            playSoundStorage.Size = new Size(81, 110);
            playSoundStorage.TabIndex = 19;
            playSoundStorage.UseVisualStyleBackColor = false;
            playSoundStorage.Click += PlaySoundStorage_Click;
            playSoundStorage.MouseLeave += OnLeave;
            playSoundStorage.MouseHover += OnHover;
            playSoundStorage.MouseMove += OnMouseMove;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(1189, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 78);
            label1.TabIndex = 20;
            label1.Text = "DURATION";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseLeave += OnLeave;
            label1.MouseHover += OnHover;
            label1.MouseMove += OnMouseMove;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(1099, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 652);
            label2.TabIndex = 21;
            label2.Text = "label2";
            label2.MouseLeave += OnLeave;
            label2.MouseHover += OnHover;
            label2.MouseMove += OnMouseMove;
            // 
            // durationBar
            // 
            durationBar.BackColor = SystemColors.ActiveCaptionText;
            durationBar.Location = new Point(1271, 137);
            durationBar.Margin = new Padding(4, 5, 4, 5);
            durationBar.Maximum = 100;
            durationBar.Name = "durationBar";
            durationBar.Orientation = Orientation.Vertical;
            durationBar.Size = new Size(69, 513);
            durationBar.TabIndex = 22;
            durationBar.TickStyle = TickStyle.Both;
            durationBar.Value = 10;
            durationBar.Scroll += durationBar_Scroll;
            durationBar.MouseLeave += OnLeave;
            durationBar.MouseHover += OnHover;
            durationBar.MouseMove += OnMouseMove;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(1349, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 652);
            label3.TabIndex = 23;
            label3.Text = "label3";
            label3.MouseLeave += OnLeave;
            label3.MouseHover += OnHover;
            label3.MouseMove += OnMouseMove;
            // 
            // amplitudeDisplay
            // 
            amplitudeDisplay.BackColor = Color.Black;
            amplitudeDisplay.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            amplitudeDisplay.ForeColor = Color.DodgerBlue;
            amplitudeDisplay.Location = new Point(744, 648);
            amplitudeDisplay.Margin = new Padding(4, 0, 4, 0);
            amplitudeDisplay.Name = "amplitudeDisplay";
            amplitudeDisplay.Size = new Size(134, 102);
            amplitudeDisplay.TabIndex = 24;
            amplitudeDisplay.Text = "1000";
            amplitudeDisplay.TextAlign = ContentAlignment.TopCenter;
            amplitudeDisplay.MouseLeave += OnLeave;
            amplitudeDisplay.MouseHover += OnHover;
            amplitudeDisplay.MouseMove += OnMouseMove;
            // 
            // frequencyValueDisplay
            // 
            frequencyValueDisplay.BackColor = Color.Black;
            frequencyValueDisplay.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            frequencyValueDisplay.ForeColor = Color.DodgerBlue;
            frequencyValueDisplay.Location = new Point(990, 648);
            frequencyValueDisplay.Margin = new Padding(4, 0, 4, 0);
            frequencyValueDisplay.Name = "frequencyValueDisplay";
            frequencyValueDisplay.Size = new Size(134, 102);
            frequencyValueDisplay.TabIndex = 25;
            frequencyValueDisplay.Text = "200";
            frequencyValueDisplay.TextAlign = ContentAlignment.TopCenter;
            frequencyValueDisplay.MouseLeave += OnLeave;
            frequencyValueDisplay.MouseHover += OnHover;
            frequencyValueDisplay.MouseMove += OnMouseMove;
            // 
            // durationValueDisplay
            // 
            durationValueDisplay.BackColor = Color.Black;
            durationValueDisplay.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            durationValueDisplay.ForeColor = Color.DodgerBlue;
            durationValueDisplay.Location = new Point(1237, 648);
            durationValueDisplay.Margin = new Padding(4, 0, 4, 0);
            durationValueDisplay.Name = "durationValueDisplay";
            durationValueDisplay.Size = new Size(134, 102);
            durationValueDisplay.TabIndex = 26;
            durationValueDisplay.Text = "1";
            durationValueDisplay.TextAlign = ContentAlignment.TopCenter;
            durationValueDisplay.MouseLeave += OnLeave;
            durationValueDisplay.MouseHover += OnHover;
            durationValueDisplay.MouseMove += OnMouseMove;
            // 
            // cb_hoverTut
            // 
            cb_hoverTut.AutoSize = true;
            cb_hoverTut.BackColor = SystemColors.ActiveCaptionText;
            cb_hoverTut.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cb_hoverTut.ForeColor = SystemColors.MenuHighlight;
            cb_hoverTut.Location = new Point(17, 18);
            cb_hoverTut.Margin = new Padding(4, 5, 4, 5);
            cb_hoverTut.Name = "cb_hoverTut";
            cb_hoverTut.Padding = new Padding(14, 3, 0, 5);
            cb_hoverTut.Size = new Size(156, 40);
            cb_hoverTut.TabIndex = 28;
            cb_hoverTut.Text = "Hover Text";
            cb_hoverTut.TextAlign = ContentAlignment.MiddleCenter;
            cb_hoverTut.UseVisualStyleBackColor = false;
            cb_hoverTut.MouseLeave += OnLeave;
            cb_hoverTut.MouseHover += OnHover;
            cb_hoverTut.MouseMove += OnMouseMove;
            // 
            // l_tip
            // 
            l_tip.Anchor = AnchorStyles.None;
            l_tip.AutoSize = true;
            l_tip.BackColor = SystemColors.ActiveBorder;
            l_tip.BorderStyle = BorderStyle.FixedSingle;
            l_tip.Font = new Font("Segoe UI Historic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            l_tip.Location = new Point(1731, -266);
            l_tip.Margin = new Padding(4, 0, 4, 0);
            l_tip.Name = "l_tip";
            l_tip.Size = new Size(119, 30);
            l_tip.TabIndex = 29;
            l_tip.Text = "PlaceHolder";
            l_tip.Visible = false;
            l_tip.MouseLeave += OnLeave;
            l_tip.MouseHover += OnHover;
            l_tip.MouseMove += OnMouseMove;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(11, 13);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 51);
            label4.TabIndex = 0;
            label4.MouseLeave += OnLeave;
            label4.MouseHover += OnHover;
            label4.MouseMove += OnMouseMove;
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameLabel.Location = new Point(123, 229);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(181, 32);
            FileNameLabel.TabIndex = 30;
            FileNameLabel.Text = "Insert FileName";
            // 
            // FileNameBox
            // 
            FileNameBox.Location = new Point(123, 195);
            FileNameBox.Name = "FileNameBox";
            FileNameBox.Size = new Size(186, 31);
            FileNameBox.TabIndex = 31;
            // 
            // MainSythesizer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1559, 919);
            Controls.Add(FileNameBox);
            Controls.Add(FileNameLabel);
            Controls.Add(l_tip);
            Controls.Add(cb_hoverTut);
            Controls.Add(durationValueDisplay);
            Controls.Add(frequencyValueDisplay);
            Controls.Add(amplitudeDisplay);
            Controls.Add(label1);
            Controls.Add(frequencyLabel);
            Controls.Add(label3);
            Controls.Add(durationBar);
            Controls.Add(label2);
            Controls.Add(playSoundStorage);
            Controls.Add(line1);
            Controls.Add(deleteSoundButton);
            Controls.Add(saveButtton);
            Controls.Add(soundBarLabel);
            Controls.Add(amplitudeLabel);
            Controls.Add(radioButtonGroup);
            Controls.Add(AmplitudeBar);
            Controls.Add(FrequencyBar);
            Controls.Add(PlaySound);
            Controls.Add(WaveFormDropDown);
            Controls.Add(backgroundColor);
            Controls.Add(backcolor2);
            Controls.Add(outlinecolor);
            Controls.Add(outlinecolor2);
            Controls.Add(label4);
            KeyPreview = true;
            Name = "MainSythesizer";
            Text = "Main Synthesizer";
            KeyPress += OnKeyPress;
            MouseHover += OnHover;
            MouseMove += OnMouseMove;
            ((System.ComponentModel.ISupportInitialize)FrequencyBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmplitudeBar).EndInit();
            radioButtonGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)durationBar).EndInit();
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
        private Label soundBarLabel;
        private Label outlinecolor;
        private Label outlinecolor2;
        private Button saveButtton;
        private Button deleteSoundButton;
        private Label line1;
        private Button playSoundStorage;
        private Label label1;
        private Label label2;
        private TrackBar durationBar;
        private Label label3;
        private Label amplitudeDisplay;
        private Label frequencyValueDisplay;
        private Label durationValueDisplay;
        private CheckBox cb_hoverTut;
        private Label l_tip;
        private Label label4;
        private Label FileNameLabel;
        private TextBox FileNameBox;
    }
}