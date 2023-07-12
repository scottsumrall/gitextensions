namespace GitUI.CommandsDialogs
{
    partial class FormCleanupRepository
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
            if (disposing && (components is not null))
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
            Preview = new Button();
            AddPath = new Button();
            Cleanup = new Button();
            _NO_TRANSLATE_Close = new Button();
            groupBox1 = new GroupBox();
            RemoveIgnored = new RadioButton();
            RemoveNonIgnored = new RadioButton();
            RemoveAll = new RadioButton();
            RemoveDirectories = new CheckBox();
            PreviewOutput = new TextBox();
            label1 = new Label();
            textBoxPaths = new TextBox();
            checkBoxPathFilter = new CheckBox();
            textBoxExcludePaths = new TextBox();
            checkBoxExcludePathFilter = new CheckBox();
            AddExcludePath = new Button();
            labelPathHintExclude = new Label();
            labelPathHintInclude = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Preview
            // 
            Preview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Preview.Image = Properties.Images.Preview;
            Preview.ImageAlign = ContentAlignment.MiddleLeft;
            Preview.Location = new Point(50, 394);
            Preview.Name = "Preview";
            Preview.Size = new Size(120, 25);
            Preview.TabIndex = 0;
            Preview.Text = "Preview";
            Preview.UseVisualStyleBackColor = true;
            Preview.Click += Preview_Click;
            // 
            // AddPath
            // 
            AddPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddPath.ImageAlign = ContentAlignment.MiddleLeft;
            AddPath.Location = new Point(302, 139);
            AddPath.Name = "AddPath";
            AddPath.Size = new Size(120, 25);
            AddPath.TabIndex = 0;
            AddPath.Text = "Add a path...";
            AddPath.UseVisualStyleBackColor = true;
            AddPath.Click += AddPath_Click;
            // 
            // Cleanup
            // 
            Cleanup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cleanup.Image = Properties.Images.CleanupRepo;
            Cleanup.ImageAlign = ContentAlignment.MiddleLeft;
            Cleanup.Location = new Point(176, 394);
            Cleanup.Name = "Cleanup";
            Cleanup.Size = new Size(120, 25);
            Cleanup.TabIndex = 1;
            Cleanup.Text = "Cleanup";
            Cleanup.UseVisualStyleBackColor = true;
            Cleanup.Click += Cleanup_Click;
            // 
            // _NO_TRANSLATE_Close
            // 
            _NO_TRANSLATE_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _NO_TRANSLATE_Close.DialogResult = DialogResult.OK;
            _NO_TRANSLATE_Close.Location = new Point(302, 394);
            _NO_TRANSLATE_Close.Name = "_NO_TRANSLATE_Close";
            _NO_TRANSLATE_Close.Size = new Size(120, 25);
            _NO_TRANSLATE_Close.TabIndex = 2;
            _NO_TRANSLATE_Close.Text = "Close";
            _NO_TRANSLATE_Close.UseVisualStyleBackColor = true;
            _NO_TRANSLATE_Close.Click += Close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(RemoveIgnored);
            groupBox1.Controls.Add(RemoveNonIgnored);
            groupBox1.Controls.Add(RemoveAll);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Remove untracked files from working directory";
            // 
            // RemoveIgnored
            // 
            RemoveIgnored.AutoSize = true;
            RemoveIgnored.Location = new Point(7, 67);
            RemoveIgnored.Name = "RemoveIgnored";
            RemoveIgnored.Size = new Size(218, 19);
            RemoveIgnored.TabIndex = 2;
            RemoveIgnored.Text = "Remove only ignored untracked files";
            RemoveIgnored.UseVisualStyleBackColor = true;
            // 
            // RemoveNonIgnored
            // 
            RemoveNonIgnored.AutoSize = true;
            RemoveNonIgnored.Location = new Point(7, 43);
            RemoveNonIgnored.Name = "RemoveNonIgnored";
            RemoveNonIgnored.Size = new Size(244, 19);
            RemoveNonIgnored.TabIndex = 1;
            RemoveNonIgnored.Text = "Remove only non-ignored untracked files";
            RemoveNonIgnored.UseVisualStyleBackColor = true;
            // 
            // RemoveAll
            // 
            RemoveAll.AutoSize = true;
            RemoveAll.Checked = true;
            RemoveAll.Location = new Point(7, 20);
            RemoveAll.Name = "RemoveAll";
            RemoveAll.Size = new Size(163, 19);
            RemoveAll.TabIndex = 0;
            RemoveAll.TabStop = true;
            RemoveAll.Text = "Remove all untracked files";
            RemoveAll.UseVisualStyleBackColor = true;
            // 
            // RemoveDirectories
            // 
            RemoveDirectories.AutoSize = true;
            RemoveDirectories.Checked = true;
            RemoveDirectories.CheckState = CheckState.Checked;
            RemoveDirectories.Location = new Point(19, 119);
            RemoveDirectories.Name = "RemoveDirectories";
            RemoveDirectories.Size = new Size(183, 19);
            RemoveDirectories.TabIndex = 4;
            RemoveDirectories.Text = "Remove untracked directories";
            RemoveDirectories.UseVisualStyleBackColor = true;
            // 
            // PreviewOutput
            // 
            PreviewOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PreviewOutput.Location = new Point(11, 456);
            PreviewOutput.Multiline = true;
            PreviewOutput.Name = "PreviewOutput";
            PreviewOutput.ScrollBars = ScrollBars.Both;
            PreviewOutput.Size = new Size(410, 93);
            PreviewOutput.TabIndex = 5;
            PreviewOutput.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 438);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "Log:";
            // 
            // textBoxPaths
            // 
            textBoxPaths.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPaths.Location = new Point(48, 169);
            textBoxPaths.Multiline = true;
            textBoxPaths.Name = "textBoxPaths";
            textBoxPaths.ScrollBars = ScrollBars.Vertical;
            textBoxPaths.Size = new Size(374, 63);
            textBoxPaths.TabIndex = 1;
            // 
            // checkBoxPathFilter
            // 
            checkBoxPathFilter.AutoSize = true;
            checkBoxPathFilter.Location = new Point(19, 144);
            checkBoxPathFilter.Name = "checkBoxPathFilter";
            checkBoxPathFilter.Size = new Size(200, 19);
            checkBoxPathFilter.TabIndex = 0;
            checkBoxPathFilter.Text = "Affect the following path(s) only:";
            checkBoxPathFilter.UseVisualStyleBackColor = true;
            checkBoxPathFilter.CheckedChanged += checkBoxPathFilter_CheckedChanged;
            // 
            // textBoxExcludePaths
            // 
            textBoxExcludePaths.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxExcludePaths.Location = new Point(48, 290);
            textBoxExcludePaths.Multiline = true;
            textBoxExcludePaths.Name = "textBoxExcludePaths";
            textBoxExcludePaths.ScrollBars = ScrollBars.Vertical;
            textBoxExcludePaths.Size = new Size(374, 63);
            textBoxExcludePaths.TabIndex = 10;
            // 
            // checkBoxExcludePathFilter
            // 
            checkBoxExcludePathFilter.AutoSize = true;
            checkBoxExcludePathFilter.Location = new Point(19, 265);
            checkBoxExcludePathFilter.Name = "checkBoxExcludePathFilter";
            checkBoxExcludePathFilter.Size = new Size(183, 19);
            checkBoxExcludePathFilter.TabIndex = 8;
            checkBoxExcludePathFilter.Text = "Exclude the following path(s):";
            checkBoxExcludePathFilter.UseVisualStyleBackColor = true;
            checkBoxExcludePathFilter.CheckedChanged += checkBoxExcludePathFilter_CheckedChanged;
            // 
            // AddExcludePath
            // 
            AddExcludePath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddExcludePath.ImageAlign = ContentAlignment.MiddleLeft;
            AddExcludePath.Location = new Point(302, 260);
            AddExcludePath.Name = "AddExcludePath";
            AddExcludePath.Size = new Size(120, 25);
            AddExcludePath.TabIndex = 9;
            AddExcludePath.Text = "Add a path...";
            AddExcludePath.UseVisualStyleBackColor = true;
            // 
            // labelPathHintExclude
            // 
            labelPathHintExclude.AutoSize = true;
            labelPathHintExclude.Location = new Point(50, 357);
            labelPathHintExclude.Name = "labelPathHintExclude";
            labelPathHintExclude.Size = new Size(104, 15);
            labelPathHintExclude.TabIndex = 11;
            labelPathHintExclude.Text = "(one path per line)";
            // 
            // labelPathHintInclude
            // 
            labelPathHintInclude.AutoSize = true;
            labelPathHintInclude.Location = new Point(50, 235);
            labelPathHintInclude.Name = "labelPathHintInclude";
            labelPathHintInclude.Size = new Size(104, 15);
            labelPathHintInclude.TabIndex = 12;
            labelPathHintInclude.Text = "(one path per line)";
            // 
            // FormCleanupRepository
            // 
            AcceptButton = AddPath;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = _NO_TRANSLATE_Close;
            ClientSize = new Size(434, 561);
            Controls.Add(labelPathHintInclude);
            Controls.Add(labelPathHintExclude);
            Controls.Add(textBoxExcludePaths);
            Controls.Add(checkBoxExcludePathFilter);
            Controls.Add(AddExcludePath);
            Controls.Add(textBoxPaths);
            Controls.Add(checkBoxPathFilter);
            Controls.Add(label1);
            Controls.Add(PreviewOutput);
            Controls.Add(RemoveDirectories);
            Controls.Add(groupBox1);
            Controls.Add(_NO_TRANSLATE_Close);
            Controls.Add(Cleanup);
            Controls.Add(Preview);
            Controls.Add(AddPath);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(450, 600);
            Name = "FormCleanupRepository";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clean working directory";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Preview;
        private Button AddPath;
        private Button Cleanup;
        private Button _NO_TRANSLATE_Close;
        private GroupBox groupBox1;
        private RadioButton RemoveIgnored;
        private RadioButton RemoveNonIgnored;
        private RadioButton RemoveAll;
        private CheckBox RemoveDirectories;
        private TextBox PreviewOutput;
        private Label label1;
        private TextBox textBoxPaths;
        private CheckBox checkBoxPathFilter;
        private TextBox textBoxExcludePaths;
        private CheckBox checkBoxExcludePathFilter;
        private Button AddExcludePath;
        private Label labelPathHintExclude;
        private Label labelPathHintInclude;
    }
}
