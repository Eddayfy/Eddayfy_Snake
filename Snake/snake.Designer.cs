namespace Snake
{
    partial class snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snake));
            this.panel11 = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.DownBorder = new System.Windows.Forms.Panel();
            this.TopBorder = new System.Windows.Forms.Panel();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.LeftBorder = new System.Windows.Forms.Panel();
            this.GameTypePanel = new System.Windows.Forms.Panel();
            this.BoxRadioButton = new System.Windows.Forms.RadioButton();
            this.ClassicRadioButton = new System.Windows.Forms.RadioButton();
            this.GameTypeOkButton = new System.Windows.Forms.Button();
            this.TypeBackButton = new System.Windows.Forms.Button();
            this.LevelPanel = new System.Windows.Forms.Panel();
            this.FastRadioButton = new System.Windows.Forms.RadioButton();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.SlowRadioButton = new System.Windows.Forms.RadioButton();
            this.LevelOkButton = new System.Windows.Forms.Button();
            this.LevelBackButton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Panel();
            this.GameType = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.SnakeHead = new System.Windows.Forms.Panel();
            this.SnakeFood = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.SettingsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewGameToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Score = new System.Windows.Forms.ToolStripLabel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel11.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.GameTypePanel.SuspendLayout();
            this.LevelPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.GamePanel);
            this.panel11.Controls.Add(this.toolStrip);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(647, 467);
            this.panel11.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GamePanel.Controls.Add(this.DownBorder);
            this.GamePanel.Controls.Add(this.TopBorder);
            this.GamePanel.Controls.Add(this.RightBorder);
            this.GamePanel.Controls.Add(this.LeftBorder);
            this.GamePanel.Controls.Add(this.GameTypePanel);
            this.GamePanel.Controls.Add(this.LevelPanel);
            this.GamePanel.Controls.Add(this.Settings);
            this.GamePanel.Controls.Add(this.SnakeHead);
            this.GamePanel.Controls.Add(this.SnakeFood);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 28);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(647, 439);
            this.GamePanel.TabIndex = 1;
            // 
            // DownBorder
            // 
            this.DownBorder.BackColor = System.Drawing.Color.Black;
            this.DownBorder.Location = new System.Drawing.Point(0, 433);
            this.DownBorder.Name = "DownBorder";
            this.DownBorder.Size = new System.Drawing.Size(644, 10);
            this.DownBorder.TabIndex = 32;
            this.DownBorder.Visible = false;
            // 
            // TopBorder
            // 
            this.TopBorder.BackColor = System.Drawing.Color.Black;
            this.TopBorder.Location = new System.Drawing.Point(3, -5);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(644, 10);
            this.TopBorder.TabIndex = 31;
            this.TopBorder.Visible = false;
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.Black;
            this.RightBorder.Location = new System.Drawing.Point(641, 0);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(10, 442);
            this.RightBorder.TabIndex = 30;
            this.RightBorder.Visible = false;
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.Black;
            this.LeftBorder.Location = new System.Drawing.Point(-4, -3);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(10, 442);
            this.LeftBorder.TabIndex = 29;
            this.LeftBorder.Visible = false;
            // 
            // GameTypePanel
            // 
            this.GameTypePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GameTypePanel.Controls.Add(this.BoxRadioButton);
            this.GameTypePanel.Controls.Add(this.ClassicRadioButton);
            this.GameTypePanel.Controls.Add(this.GameTypeOkButton);
            this.GameTypePanel.Controls.Add(this.TypeBackButton);
            this.GameTypePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTypePanel.Location = new System.Drawing.Point(214, 277);
            this.GameTypePanel.Name = "GameTypePanel";
            this.GameTypePanel.Size = new System.Drawing.Size(200, 100);
            this.GameTypePanel.TabIndex = 28;
            // 
            // BoxRadioButton
            // 
            this.BoxRadioButton.AutoSize = true;
            this.BoxRadioButton.Location = new System.Drawing.Point(119, 16);
            this.BoxRadioButton.Name = "BoxRadioButton";
            this.BoxRadioButton.Size = new System.Drawing.Size(49, 20);
            this.BoxRadioButton.TabIndex = 4;
            this.BoxRadioButton.TabStop = true;
            this.BoxRadioButton.Text = "Box";
            this.BoxRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClassicRadioButton
            // 
            this.ClassicRadioButton.AutoSize = true;
            this.ClassicRadioButton.Location = new System.Drawing.Point(33, 16);
            this.ClassicRadioButton.Name = "ClassicRadioButton";
            this.ClassicRadioButton.Size = new System.Drawing.Size(70, 20);
            this.ClassicRadioButton.TabIndex = 4;
            this.ClassicRadioButton.TabStop = true;
            this.ClassicRadioButton.Text = "Classic";
            this.ClassicRadioButton.UseVisualStyleBackColor = true;
            // 
            // GameTypeOkButton
            // 
            this.GameTypeOkButton.Location = new System.Drawing.Point(17, 61);
            this.GameTypeOkButton.Name = "GameTypeOkButton";
            this.GameTypeOkButton.Size = new System.Drawing.Size(80, 30);
            this.GameTypeOkButton.TabIndex = 3;
            this.GameTypeOkButton.Text = "Ok";
            this.GameTypeOkButton.UseVisualStyleBackColor = true;
            this.GameTypeOkButton.Click += new System.EventHandler(this.GameTypeOkButton_Click);
            // 
            // TypeBackButton
            // 
            this.TypeBackButton.Location = new System.Drawing.Point(103, 61);
            this.TypeBackButton.Name = "TypeBackButton";
            this.TypeBackButton.Size = new System.Drawing.Size(80, 30);
            this.TypeBackButton.TabIndex = 2;
            this.TypeBackButton.Text = "Back";
            this.TypeBackButton.UseVisualStyleBackColor = true;
            this.TypeBackButton.Click += new System.EventHandler(this.TypeBackButton_Click);
            // 
            // LevelPanel
            // 
            this.LevelPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LevelPanel.Controls.Add(this.FastRadioButton);
            this.LevelPanel.Controls.Add(this.NormalRadioButton);
            this.LevelPanel.Controls.Add(this.SlowRadioButton);
            this.LevelPanel.Controls.Add(this.LevelOkButton);
            this.LevelPanel.Controls.Add(this.LevelBackButton);
            this.LevelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelPanel.Location = new System.Drawing.Point(359, 76);
            this.LevelPanel.Name = "LevelPanel";
            this.LevelPanel.Size = new System.Drawing.Size(250, 125);
            this.LevelPanel.TabIndex = 27;
            // 
            // FastRadioButton
            // 
            this.FastRadioButton.AutoSize = true;
            this.FastRadioButton.Location = new System.Drawing.Point(172, 19);
            this.FastRadioButton.Name = "FastRadioButton";
            this.FastRadioButton.Size = new System.Drawing.Size(52, 20);
            this.FastRadioButton.TabIndex = 4;
            this.FastRadioButton.TabStop = true;
            this.FastRadioButton.Text = "Fast";
            this.FastRadioButton.UseVisualStyleBackColor = true;
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(94, 19);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(70, 20);
            this.NormalRadioButton.TabIndex = 4;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "Normal";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // SlowRadioButton
            // 
            this.SlowRadioButton.AutoSize = true;
            this.SlowRadioButton.Location = new System.Drawing.Point(26, 19);
            this.SlowRadioButton.Name = "SlowRadioButton";
            this.SlowRadioButton.Size = new System.Drawing.Size(55, 20);
            this.SlowRadioButton.TabIndex = 4;
            this.SlowRadioButton.TabStop = true;
            this.SlowRadioButton.Text = "Slow";
            this.SlowRadioButton.UseVisualStyleBackColor = true;
            // 
            // LevelOkButton
            // 
            this.LevelOkButton.Location = new System.Drawing.Point(22, 74);
            this.LevelOkButton.Name = "LevelOkButton";
            this.LevelOkButton.Size = new System.Drawing.Size(100, 30);
            this.LevelOkButton.TabIndex = 3;
            this.LevelOkButton.Text = "Ok";
            this.LevelOkButton.UseVisualStyleBackColor = true;
            this.LevelOkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // LevelBackButton
            // 
            this.LevelBackButton.Location = new System.Drawing.Point(128, 74);
            this.LevelBackButton.Name = "LevelBackButton";
            this.LevelBackButton.Size = new System.Drawing.Size(100, 30);
            this.LevelBackButton.TabIndex = 2;
            this.LevelBackButton.Text = "Back";
            this.LevelBackButton.UseVisualStyleBackColor = true;
            this.LevelBackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Settings.Controls.Add(this.GameType);
            this.Settings.Controls.Add(this.Level);
            this.Settings.Controls.Add(this.NewGame);
            this.Settings.Controls.Add(this.Continue);
            this.Settings.Location = new System.Drawing.Point(10, 56);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(300, 180);
            this.Settings.TabIndex = 26;
            // 
            // GameType
            // 
            this.GameType.Location = new System.Drawing.Point(50, 128);
            this.GameType.Name = "GameType";
            this.GameType.Size = new System.Drawing.Size(200, 30);
            this.GameType.TabIndex = 3;
            this.GameType.Text = "Game Type";
            this.GameType.UseVisualStyleBackColor = true;
            this.GameType.Click += new System.EventHandler(this.GameType_Click);
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(50, 92);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(200, 30);
            this.Level.TabIndex = 2;
            this.Level.Text = "Level";
            this.Level.UseVisualStyleBackColor = true;
            this.Level.Click += new System.EventHandler(this.Level_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(50, 56);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(200, 30);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(50, 20);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(200, 30);
            this.Continue.TabIndex = 0;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // SnakeHead
            // 
            this.SnakeHead.BackColor = System.Drawing.Color.DarkRed;
            this.SnakeHead.Location = new System.Drawing.Point(10, 10);
            this.SnakeHead.Name = "SnakeHead";
            this.SnakeHead.Size = new System.Drawing.Size(40, 40);
            this.SnakeHead.TabIndex = 15;
            // 
            // SnakeFood
            // 
            this.SnakeFood.BackColor = System.Drawing.Color.OrangeRed;
            this.SnakeFood.Location = new System.Drawing.Point(52, 10);
            this.SnakeFood.Name = "SnakeFood";
            this.SnakeFood.Size = new System.Drawing.Size(40, 40);
            this.SnakeFood.TabIndex = 25;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStrip,
            this.toolStripSeparator1,
            this.NewGameToolStrip,
            this.toolStripSeparator2,
            this.Score});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(647, 28);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // SettingsToolStrip
            // 
            this.SettingsToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SettingsToolStrip.Image")));
            this.SettingsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsToolStrip.Name = "SettingsToolStrip";
            this.SettingsToolStrip.Size = new System.Drawing.Size(23, 25);
            this.SettingsToolStrip.Text = "Settings";
            this.SettingsToolStrip.Click += new System.EventHandler(this.SettingsToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // NewGameToolStrip
            // 
            this.NewGameToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewGameToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("NewGameToolStrip.Image")));
            this.NewGameToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewGameToolStrip.Name = "NewGameToolStrip";
            this.NewGameToolStrip.Size = new System.Drawing.Size(23, 25);
            this.NewGameToolStrip.Text = "New Game";
            this.NewGameToolStrip.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(85, 25);
            this.Score.Text = "Score : ";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 300;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 467);
            this.Controls.Add(this.panel11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_Game_KeyDown);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GameTypePanel.ResumeLayout(false);
            this.GameTypePanel.PerformLayout();
            this.LevelPanel.ResumeLayout(false);
            this.LevelPanel.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton SettingsToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NewGameToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel Score;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel SnakeHead;
        private System.Windows.Forms.Panel SnakeFood;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Button GameType;
        private System.Windows.Forms.Button Level;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Panel LevelPanel;
        private System.Windows.Forms.RadioButton FastRadioButton;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton SlowRadioButton;
        private System.Windows.Forms.Button LevelOkButton;
        private System.Windows.Forms.Button LevelBackButton;
        private System.Windows.Forms.Panel GameTypePanel;
        private System.Windows.Forms.RadioButton BoxRadioButton;
        private System.Windows.Forms.RadioButton ClassicRadioButton;
        private System.Windows.Forms.Button GameTypeOkButton;
        private System.Windows.Forms.Button TypeBackButton;
        private System.Windows.Forms.Panel DownBorder;
        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Panel RightBorder;
        private System.Windows.Forms.Panel LeftBorder;
    }
}