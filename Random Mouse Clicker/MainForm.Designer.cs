namespace Random_Mouse_Clicker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonDrawArea = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxClickEvery = new System.Windows.Forms.ComboBox();
            this.numericClickEveryMin = new System.Windows.Forms.NumericUpDown();
            this.radioEndManually = new System.Windows.Forms.RadioButton();
            this.radioEndAutomatically = new System.Windows.Forms.RadioButton();
            this.groupBoxDuration = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMouseMovement = new System.Windows.Forms.GroupBox();
            this.radioInstant = new System.Windows.Forms.RadioButton();
            this.radioFast = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.radioSlow = new System.Windows.Forms.RadioButton();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.labelOf = new System.Windows.Forms.Label();
            this.comboBoxDividedAreas = new System.Windows.Forms.ComboBox();
            this.labelClickEachTimes = new System.Windows.Forms.Label();
            this.labelClickEachArea = new System.Windows.Forms.Label();
            this.numericClickEachArea = new System.Windows.Forms.NumericUpDown();
            this.numericDivideIntoEqualAreas = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDivideInto = new System.Windows.Forms.CheckBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.groupBoxClickEvery = new System.Windows.Forms.GroupBox();
            this.numericClickEveryMax = new System.Windows.Forms.NumericUpDown();
            this.linkLabelCustomize = new System.Windows.Forms.LinkLabel();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.labelCannotBeChanged = new System.Windows.Forms.Label();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.labelWidthHeight = new System.Windows.Forms.Label();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.labelPreviewInstructions = new System.Windows.Forms.Label();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericClickEveryMin)).BeginInit();
            this.groupBoxMouseMovement.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericClickEachArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDivideIntoEqualAreas)).BeginInit();
            this.groupBoxClickEvery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericClickEveryMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.tabPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDrawArea
            // 
            this.buttonDrawArea.Location = new System.Drawing.Point(140, 20);
            this.buttonDrawArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDrawArea.Name = "buttonDrawArea";
            this.buttonDrawArea.Size = new System.Drawing.Size(165, 28);
            this.buttonDrawArea.TabIndex = 0;
            this.buttonDrawArea.Text = "Draw clicking area";
            this.toolTip1.SetToolTip(this.buttonDrawArea, "Draw the area to click within");
            this.buttonDrawArea.UseVisualStyleBackColor = true;
            this.buttonDrawArea.Click += new System.EventHandler(this.drawAreaButton_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(173, 308);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 28);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.toolTip1.SetToolTip(this.buttonStart, "Begin clicking");
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startButton_Click);
            // 
            // comboBoxClickEvery
            // 
            this.comboBoxClickEvery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClickEvery.DropDownWidth = 75;
            this.comboBoxClickEvery.FormattingEnabled = true;
            this.comboBoxClickEvery.Items.AddRange(new object[] {
            "millisecond(s)",
            "second(s)",
            "minute(s)",
            "hour(s)",
            "day(s)"});
            this.comboBoxClickEvery.Location = new System.Drawing.Point(116, 63);
            this.comboBoxClickEvery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxClickEvery.Name = "comboBoxClickEvery";
            this.comboBoxClickEvery.Size = new System.Drawing.Size(123, 24);
            this.comboBoxClickEvery.TabIndex = 4;
            // 
            // numericClickEveryMin
            // 
            this.numericClickEveryMin.Location = new System.Drawing.Point(20, 28);
            this.numericClickEveryMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericClickEveryMin.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.numericClickEveryMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericClickEveryMin.Name = "numericClickEveryMin";
            this.numericClickEveryMin.Size = new System.Drawing.Size(133, 22);
            this.numericClickEveryMin.TabIndex = 5;
            this.numericClickEveryMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericClickEveryMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioEndManually
            // 
            this.radioEndManually.AutoSize = true;
            this.radioEndManually.Checked = true;
            this.radioEndManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEndManually.Location = new System.Drawing.Point(57, 167);
            this.radioEndManually.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioEndManually.Name = "radioEndManually";
            this.radioEndManually.Size = new System.Drawing.Size(158, 38);
            this.radioEndManually.TabIndex = 8;
            this.radioEndManually.TabStop = true;
            this.radioEndManually.Text = "End manually\r\n(CTRL+WIN+ESC)";
            this.toolTip1.SetToolTip(this.radioEndManually, "Stop the program manually");
            this.radioEndManually.UseVisualStyleBackColor = true;
            this.radioEndManually.CheckedChanged += new System.EventHandler(this.endManuallyRadio_CheckedChanged);
            // 
            // radioEndAutomatically
            // 
            this.radioEndAutomatically.AutoSize = true;
            this.radioEndAutomatically.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEndAutomatically.Location = new System.Drawing.Point(235, 176);
            this.radioEndAutomatically.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioEndAutomatically.Name = "radioEndAutomatically";
            this.radioEndAutomatically.Size = new System.Drawing.Size(157, 21);
            this.radioEndAutomatically.TabIndex = 9;
            this.radioEndAutomatically.Text = "End automatically";
            this.toolTip1.SetToolTip(this.radioEndAutomatically, "Stop the program when finished");
            this.radioEndAutomatically.UseVisualStyleBackColor = true;
            this.radioEndAutomatically.CheckedChanged += new System.EventHandler(this.endAutomaticallyRadio_CheckedChanged);
            // 
            // groupBoxDuration
            // 
            this.groupBoxDuration.Enabled = false;
            this.groupBoxDuration.Location = new System.Drawing.Point(39, 226);
            this.groupBoxDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDuration.Name = "groupBoxDuration";
            this.groupBoxDuration.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDuration.Size = new System.Drawing.Size(364, 71);
            this.groupBoxDuration.TabIndex = 10;
            this.groupBoxDuration.TabStop = false;
            this.groupBoxDuration.Text = "Duration";
            this.toolTip1.SetToolTip(this.groupBoxDuration, "How long to run the program for");
            // 
            // groupBoxMouseMovement
            // 
            this.groupBoxMouseMovement.Controls.Add(this.radioInstant);
            this.groupBoxMouseMovement.Controls.Add(this.radioFast);
            this.groupBoxMouseMovement.Controls.Add(this.radioNormal);
            this.groupBoxMouseMovement.Controls.Add(this.radioSlow);
            this.groupBoxMouseMovement.Location = new System.Drawing.Point(17, 230);
            this.groupBoxMouseMovement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMouseMovement.Name = "groupBoxMouseMovement";
            this.groupBoxMouseMovement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMouseMovement.Size = new System.Drawing.Size(399, 96);
            this.groupBoxMouseMovement.TabIndex = 3;
            this.groupBoxMouseMovement.TabStop = false;
            this.groupBoxMouseMovement.Text = "Mouse movement";
            this.toolTip1.SetToolTip(this.groupBoxMouseMovement, "Set the mouse movement speed");
            // 
            // radioInstant
            // 
            this.radioInstant.AutoSize = true;
            this.radioInstant.Location = new System.Drawing.Point(283, 44);
            this.radioInstant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioInstant.Name = "radioInstant";
            this.radioInstant.Size = new System.Drawing.Size(71, 21);
            this.radioInstant.TabIndex = 3;
            this.radioInstant.Text = "Instant";
            this.radioInstant.UseVisualStyleBackColor = true;
            // 
            // radioFast
            // 
            this.radioFast.AutoSize = true;
            this.radioFast.Location = new System.Drawing.Point(205, 44);
            this.radioFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFast.Name = "radioFast";
            this.radioFast.Size = new System.Drawing.Size(56, 21);
            this.radioFast.TabIndex = 2;
            this.radioFast.Text = "Fast";
            this.radioFast.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Checked = true;
            this.radioNormal.Location = new System.Drawing.Point(115, 44);
            this.radioNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(74, 21);
            this.radioNormal.TabIndex = 1;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "Normal";
            this.radioNormal.UseVisualStyleBackColor = true;
            // 
            // radioSlow
            // 
            this.radioSlow.AutoSize = true;
            this.radioSlow.Location = new System.Drawing.Point(35, 44);
            this.radioSlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSlow.Name = "radioSlow";
            this.radioSlow.Size = new System.Drawing.Size(58, 21);
            this.radioSlow.TabIndex = 0;
            this.radioSlow.Text = "Slow";
            this.radioSlow.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.labelOf);
            this.groupBoxOptions.Controls.Add(this.comboBoxDividedAreas);
            this.groupBoxOptions.Controls.Add(this.labelClickEachTimes);
            this.groupBoxOptions.Controls.Add(this.labelClickEachArea);
            this.groupBoxOptions.Controls.Add(this.numericClickEachArea);
            this.groupBoxOptions.Controls.Add(this.numericDivideIntoEqualAreas);
            this.groupBoxOptions.Controls.Add(this.checkBoxDivideInto);
            this.groupBoxOptions.Location = new System.Drawing.Point(17, 55);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOptions.Size = new System.Drawing.Size(399, 159);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            this.toolTip1.SetToolTip(this.groupBoxOptions, "Divide your drawn area into sub-areas");
            // 
            // labelOf
            // 
            this.labelOf.AutoSize = true;
            this.labelOf.Enabled = false;
            this.labelOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOf.Location = new System.Drawing.Point(125, 76);
            this.labelOf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOf.Name = "labelOf";
            this.labelOf.Size = new System.Drawing.Size(22, 17);
            this.labelOf.TabIndex = 13;
            this.labelOf.Text = "of";
            this.toolTip1.SetToolTip(this.labelOf, "Set the time between clicks");
            // 
            // comboBoxDividedAreas
            // 
            this.comboBoxDividedAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDividedAreas.Enabled = false;
            this.comboBoxDividedAreas.FormattingEnabled = true;
            this.comboBoxDividedAreas.Location = new System.Drawing.Point(157, 73);
            this.comboBoxDividedAreas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDividedAreas.Name = "comboBoxDividedAreas";
            this.comboBoxDividedAreas.Size = new System.Drawing.Size(115, 24);
            this.comboBoxDividedAreas.TabIndex = 12;
            // 
            // labelClickEachTimes
            // 
            this.labelClickEachTimes.AutoSize = true;
            this.labelClickEachTimes.Enabled = false;
            this.labelClickEachTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickEachTimes.Location = new System.Drawing.Point(279, 113);
            this.labelClickEachTimes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClickEachTimes.Name = "labelClickEachTimes";
            this.labelClickEachTimes.Size = new System.Drawing.Size(58, 17);
            this.labelClickEachTimes.TabIndex = 11;
            this.labelClickEachTimes.Text = "time(s)";
            this.toolTip1.SetToolTip(this.labelClickEachTimes, "Set the time between clicks");
            // 
            // labelClickEachArea
            // 
            this.labelClickEachArea.AutoSize = true;
            this.labelClickEachArea.Enabled = false;
            this.labelClickEachArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickEachArea.Location = new System.Drawing.Point(21, 113);
            this.labelClickEachArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClickEachArea.Name = "labelClickEachArea";
            this.labelClickEachArea.Size = new System.Drawing.Size(120, 17);
            this.labelClickEachArea.TabIndex = 10;
            this.labelClickEachArea.Text = "Click each area";
            this.toolTip1.SetToolTip(this.labelClickEachArea, "Set the time between clicks");
            // 
            // numericClickEachArea
            // 
            this.numericClickEachArea.Enabled = false;
            this.numericClickEachArea.Location = new System.Drawing.Point(157, 111);
            this.numericClickEachArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericClickEachArea.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.numericClickEachArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericClickEachArea.Name = "numericClickEachArea";
            this.numericClickEachArea.Size = new System.Drawing.Size(116, 22);
            this.numericClickEachArea.TabIndex = 9;
            this.numericClickEachArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericClickEachArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericClickEachArea.ValueChanged += new System.EventHandler(this.numericClickEachArea_ValueChanged);
            // 
            // numericDivideIntoEqualAreas
            // 
            this.numericDivideIntoEqualAreas.Enabled = false;
            this.numericDivideIntoEqualAreas.Location = new System.Drawing.Point(157, 37);
            this.numericDivideIntoEqualAreas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericDivideIntoEqualAreas.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.numericDivideIntoEqualAreas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericDivideIntoEqualAreas.Name = "numericDivideIntoEqualAreas";
            this.numericDivideIntoEqualAreas.Size = new System.Drawing.Size(116, 22);
            this.numericDivideIntoEqualAreas.TabIndex = 6;
            this.numericDivideIntoEqualAreas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericDivideIntoEqualAreas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericDivideIntoEqualAreas.ValueChanged += new System.EventHandler(this.numericDivideIntoEqualAreas_ValueChanged);
            // 
            // checkBoxDivideInto
            // 
            this.checkBoxDivideInto.AutoSize = true;
            this.checkBoxDivideInto.Enabled = false;
            this.checkBoxDivideInto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDivideInto.Location = new System.Drawing.Point(35, 37);
            this.checkBoxDivideInto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDivideInto.Name = "checkBoxDivideInto";
            this.checkBoxDivideInto.Size = new System.Drawing.Size(328, 21);
            this.checkBoxDivideInto.TabIndex = 1;
            this.checkBoxDivideInto.Text = "Divide into                           equal areas";
            this.checkBoxDivideInto.UseVisualStyleBackColor = true;
            this.checkBoxDivideInto.CheckedChanged += new System.EventHandler(this.divideIntoEqualAreasCheckbox_CheckedChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(165, 31);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(22, 17);
            this.labelTo.TabIndex = 17;
            this.labelTo.Text = "to";
            this.toolTip1.SetToolTip(this.labelTo, "Set the time between clicks");
            // 
            // groupBoxClickEvery
            // 
            this.groupBoxClickEvery.Controls.Add(this.labelTo);
            this.groupBoxClickEvery.Controls.Add(this.numericClickEveryMin);
            this.groupBoxClickEvery.Controls.Add(this.numericClickEveryMax);
            this.groupBoxClickEvery.Controls.Add(this.comboBoxClickEvery);
            this.groupBoxClickEvery.Location = new System.Drawing.Point(39, 53);
            this.groupBoxClickEvery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClickEvery.Name = "groupBoxClickEvery";
            this.groupBoxClickEvery.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClickEvery.Size = new System.Drawing.Size(364, 106);
            this.groupBoxClickEvery.TabIndex = 18;
            this.groupBoxClickEvery.TabStop = false;
            this.groupBoxClickEvery.Text = "Click every";
            this.toolTip1.SetToolTip(this.groupBoxClickEvery, "How frequently to click");
            // 
            // numericClickEveryMax
            // 
            this.numericClickEveryMax.Location = new System.Drawing.Point(208, 28);
            this.numericClickEveryMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericClickEveryMax.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.numericClickEveryMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericClickEveryMax.Name = "numericClickEveryMax";
            this.numericClickEveryMax.Size = new System.Drawing.Size(133, 22);
            this.numericClickEveryMax.TabIndex = 16;
            this.numericClickEveryMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericClickEveryMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // linkLabelCustomize
            // 
            this.linkLabelCustomize.AutoSize = true;
            this.linkLabelCustomize.Location = new System.Drawing.Point(296, 332);
            this.linkLabelCustomize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelCustomize.Name = "linkLabelCustomize";
            this.linkLabelCustomize.Size = new System.Drawing.Size(126, 17);
            this.linkLabelCustomize.TabIndex = 4;
            this.linkLabelCustomize.TabStop = true;
            this.linkLabelCustomize.Text = "Customize settings";
            this.toolTip1.SetToolTip(this.linkLabelCustomize, "Change the program settings");
            this.linkLabelCustomize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCustomize_LinkClicked);
            // 
            // numericDuration
            // 
            this.numericDuration.Enabled = false;
            this.numericDuration.Location = new System.Drawing.Point(83, 254);
            this.numericDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericDuration.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.numericDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(133, 22);
            this.numericDuration.TabIndex = 12;
            this.numericDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDuration.DropDownWidth = 75;
            this.comboBoxDuration.Enabled = false;
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "click(s)",
            "millisecond(s)",
            "second(s)",
            "minute(s)",
            "hour(s)",
            "day(s)"});
            this.comboBoxDuration.Location = new System.Drawing.Point(236, 252);
            this.comboBoxDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(123, 24);
            this.comboBoxDuration.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasic);
            this.tabControl1.Controls.Add(this.tabAdvanced);
            this.tabControl1.Controls.Add(this.tabPreview);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 384);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.groupBoxClickEvery);
            this.tabBasic.Controls.Add(this.labelCannotBeChanged);
            this.tabBasic.Controls.Add(this.buttonDrawArea);
            this.tabBasic.Controls.Add(this.buttonStart);
            this.tabBasic.Controls.Add(this.numericDuration);
            this.tabBasic.Controls.Add(this.comboBoxDuration);
            this.tabBasic.Controls.Add(this.groupBoxDuration);
            this.tabBasic.Controls.Add(this.radioEndAutomatically);
            this.tabBasic.Controls.Add(this.radioEndManually);
            this.tabBasic.Location = new System.Drawing.Point(4, 25);
            this.tabBasic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBasic.Size = new System.Drawing.Size(437, 355);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // labelCannotBeChanged
            // 
            this.labelCannotBeChanged.AutoSize = true;
            this.labelCannotBeChanged.ForeColor = System.Drawing.Color.Red;
            this.labelCannotBeChanged.Location = new System.Drawing.Point(24, 206);
            this.labelCannotBeChanged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCannotBeChanged.Name = "labelCannotBeChanged";
            this.labelCannotBeChanged.Size = new System.Drawing.Size(389, 17);
            this.labelCannotBeChanged.TabIndex = 14;
            this.labelCannotBeChanged.Text = "Cannot be changed due to choosing to divide into sub-areas";
            this.labelCannotBeChanged.Visible = false;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.linkLabelCustomize);
            this.tabAdvanced.Controls.Add(this.groupBoxMouseMovement);
            this.tabAdvanced.Controls.Add(this.groupBoxOptions);
            this.tabAdvanced.Controls.Add(this.labelWidthHeight);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 25);
            this.tabAdvanced.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdvanced.Size = new System.Drawing.Size(437, 355);
            this.tabAdvanced.TabIndex = 1;
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // labelWidthHeight
            // 
            this.labelWidthHeight.AutoSize = true;
            this.labelWidthHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidthHeight.Location = new System.Drawing.Point(14, 15);
            this.labelWidthHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWidthHeight.Name = "labelWidthHeight";
            this.labelWidthHeight.Size = new System.Drawing.Size(224, 36);
            this.labelWidthHeight.TabIndex = 0;
            this.labelWidthHeight.Text = "Draw an area in the first tab to \r\nview width and height information";
            this.labelWidthHeight.Click += new System.EventHandler(this.labelWidthHeight_Click);
            // 
            // tabPreview
            // 
            this.tabPreview.Controls.Add(this.labelPreviewInstructions);
            this.tabPreview.Controls.Add(this.previewPictureBox);
            this.tabPreview.Location = new System.Drawing.Point(4, 25);
            this.tabPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Size = new System.Drawing.Size(437, 355);
            this.tabPreview.TabIndex = 2;
            this.tabPreview.Text = "Preview";
            this.tabPreview.UseVisualStyleBackColor = true;
            // 
            // labelPreviewInstructions
            // 
            this.labelPreviewInstructions.AutoSize = true;
            this.labelPreviewInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreviewInstructions.Location = new System.Drawing.Point(85, 145);
            this.labelPreviewInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreviewInstructions.Name = "labelPreviewInstructions";
            this.labelPreviewInstructions.Size = new System.Drawing.Size(249, 36);
            this.labelPreviewInstructions.TabIndex = 1;
            this.labelPreviewInstructions.Text = "Draw an area in the first tab to \r\nview a preview of what will be clicked";
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(437, 355);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            this.previewPictureBox.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Random Mouse Clicker";
            this.notifyIcon.Visible = true;
            // 
            // notifyMenu
            // 
            this.notifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(103, 28);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(102, 24);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(445, 384);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Random Mouse Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericClickEveryMin)).EndInit();
            this.groupBoxMouseMovement.ResumeLayout(false);
            this.groupBoxMouseMovement.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericClickEachArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDivideIntoEqualAreas)).EndInit();
            this.groupBoxClickEvery.ResumeLayout(false);
            this.groupBoxClickEvery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericClickEveryMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.tabBasic.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            this.tabPreview.ResumeLayout(false);
            this.tabPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawArea;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxClickEvery;
        private System.Windows.Forms.NumericUpDown numericClickEveryMin;
        private System.Windows.Forms.RadioButton radioEndManually;
        private System.Windows.Forms.RadioButton radioEndAutomatically;
        private System.Windows.Forms.GroupBox groupBoxDuration;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.Label labelWidthHeight;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.NumericUpDown numericDivideIntoEqualAreas;
        private System.Windows.Forms.CheckBox checkBoxDivideInto;
        private System.Windows.Forms.NumericUpDown numericClickEachArea;
        private System.Windows.Forms.Label labelCannotBeChanged;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.GroupBox groupBoxMouseMovement;
        private System.Windows.Forms.RadioButton radioInstant;
        private System.Windows.Forms.RadioButton radioFast;
        private System.Windows.Forms.RadioButton radioNormal;
        private System.Windows.Forms.RadioButton radioSlow;
        private System.Windows.Forms.Label labelPreviewInstructions;
        private System.Windows.Forms.NumericUpDown numericClickEveryMax;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelClickEachTimes;
        private System.Windows.Forms.Label labelClickEachArea;
        private System.Windows.Forms.ComboBox comboBoxDividedAreas;
        private System.Windows.Forms.Label labelOf;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.LinkLabel linkLabelCustomize;
        private System.Windows.Forms.GroupBox groupBoxClickEvery;
    }
}

