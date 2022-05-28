using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class SnakeForm : Form
    {
        private int[] Xs;
        private int[] Ys;
        private int SnakeScore;
        private char Dir;
        private bool ClassicMode;
        private Random random;
        private List<Panel> TailPanels;

        public SnakeForm()
        {
            InitializeComponent();
        }

        private void SnakeForm_Load(object sender, EventArgs e)
        {
            Xs = new int[] { 10, 52, 94, 136, 178, 220, 262, 304, 346, 388, 430, 472, 514, 556, 598 };
            Ys = new int[] { 10, 52, 94, 136, 178, 220, 262, 304, 346, 388 };
            ClassicMode = true;
            random = new Random();
            TailPanels = new List<Panel>();

            SetUp();
        }

        private void SetUp()
        {
            this.Size = new Size(667, 510);
            Settings.Location = new Point(173, 129);
            LevelPanel.Visible = false;
            GameTypePanel.Visible = false;
            Continue.Enabled = true;

            Continue.Text = "Play";
            SnakeScore = 0;
            Score.Text = "Score : " + SnakeScore;
            SnakeHead.Location = new Point(10, 10);
            SnakeFood.Location = new Point(Xs[random.Next(Xs.Length)], Ys[random.Next(Ys.Length)]);

            if (ClassicMode)
            {
                TopBorder.Visible = false;
                RightBorder.Visible = false;
                DownBorder.Visible = false;
                LeftBorder.Visible = false;
            }
            else
            {
                TopBorder.Visible = true;
                RightBorder.Visible = true;
                DownBorder.Visible = true;
                LeftBorder.Visible = true;
            }

            foreach (var val in TailPanels)
                GamePanel.Controls.Remove(val);

            TailPanels.Clear();
            TailPanels.Add(new Panel());

            GameTimer.Enabled = true;
        }

        private void Snake_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                Dir = 'r';
            else if (e.KeyCode == Keys.Left)
                Dir = 'l';
            else if (e.KeyCode == Keys.Up)
                Dir = 'u';
            else if (e.KeyCode == Keys.Down)
                Dir = 'd';
            else if (e.KeyCode == Keys.D)
                Dir = 'r';
            else if (e.KeyCode == Keys.A)
                Dir = 'l';
            else if (e.KeyCode == Keys.W)
                Dir = 'u';
            else if (e.KeyCode == Keys.S)
                Dir = 'd';
            else if (e.KeyCode == Keys.P)
                Dir = 'p';
        }

        private void SnakeMove()
        {
            if (Dir == 'r')
                SnakeHead.Left += 42;
            else if (Dir == 'l')
                SnakeHead.Left += -42;
            else if (Dir == 'u')
                SnakeHead.Top += -42;
            else if (Dir == 'd')
                SnakeHead.Top += 42;
            else if (Dir == 'p')
                SnakeHead.Top += 0;

            if (ClassicMode)
            {
                if (SnakeHead.Location.X <= -32)
                    SnakeHead.Location = new Point(598, SnakeHead.Location.Y);
                else if (SnakeHead.Location.X >= 640)
                    SnakeHead.Location = new Point(10, SnakeHead.Location.Y);
                else if (SnakeHead.Location.Y <= -32)
                    SnakeHead.Location = new Point(SnakeHead.Location.X, 388);
                else if (SnakeHead.Location.Y >= 430)
                    SnakeHead.Location = new Point(SnakeHead.Location.X, 10);
            }

            TailMove();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            SnakeMove();
            EatCheck();
            GameOver();
        }

        private void TailGenerate()
        {
            Panel TailPanelTemp = new Panel
            {
                Height = 40,
                Width = 40,
                BackColor = Color.Green,
                Location = new Point(-45, -45)
            };
            GamePanel.Controls.Add(TailPanelTemp);
            TailPanels.Add(TailPanelTemp);
        }

        private void TailMove()
        {
            for (int i = SnakeScore; i > 0; i--)
            {
                if (Dir == 'p')
                    break;

                TailPanels[i].Location = TailPanels[i - 1].Location;
            }

            TailPanels[0].Location = SnakeHead.Location;
        }

        private void ScoreChanged()
        {
            Score.Text = "Score : " + SnakeScore++;

            TailGenerate();
        }

        private void FoodGenerate()
        {
            int x = Xs[random.Next(Xs.Length)];
            int y = Ys[random.Next(Ys.Length)];
            SnakeFood.Location = new Point(x, y);

            foreach (Panel panel in TailPanels)
            {
                if (panel.Location == SnakeFood.Location)
                    FoodGenerate();
            }
        }

        private void EatCheck()
        {
            if (SnakeHead.Bounds.IntersectsWith(SnakeFood.Bounds))
            {
                ScoreChanged();
                FoodGenerate();
            }
        }

        private void GameOver()
        {
            for (int i = 1; i < TailPanels.Count; i++)
            {
                if (TailPanels[i].Location == SnakeHead.Location)
                {
                    GameTimer.Enabled = false;
                    Continue.Enabled = false;
                    MessageBox.Show("Hey loser , Play Again?", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Settings.Enabled = true;
                    Settings.Visible = true;
                    Continue.Text = "Continue";
                    Continue.Enabled = false;
                    Dir = 'p';
                }
            }

            if (!ClassicMode)
            {
                if (SnakeHead.Bounds.IntersectsWith(TopBorder.Bounds)
                    || SnakeHead.Bounds.IntersectsWith(DownBorder.Bounds)
                    || SnakeHead.Bounds.IntersectsWith(LeftBorder.Bounds)
                    || SnakeHead.Bounds.IntersectsWith(RightBorder.Bounds))
                {
                    GameTimer.Enabled = false;
                    Continue.Enabled = false;
                    MessageBox.Show("Hey loser , Play Again?", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Settings.Enabled = true;
                    Settings.Visible = true;
                    Continue.Text = "Continue";
                    Continue.Enabled = false;
                    Dir = 'p';
                }
            }
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Settings.Enabled = false;
            Settings.Visible = false;
            GameTimer.Enabled = true;
            Dir = 'p';
        }

        private void SettingsToolStrip_Click(object sender, EventArgs e)
        {
            Settings.Enabled = true;
            Settings.Visible = true;
            GameTimer.Enabled = false;
            Dir = 'p';
            Continue.Text = "Continue";
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            SetUp();
            Dir = 'p';
        }

        private void Level_Click(object sender, EventArgs e)
        {
            LevelPanel.Location = new Point(198, 157);
            LevelPanel.Visible = true;
            Settings.Enabled = false;

            if (GameTimer.Interval == 500)
                SlowRadioButton.Checked = true;
            else if (GameTimer.Interval == 300)
                NormalRadioButton.Checked = true;
            else if (GameTimer.Interval == 100)
                FastRadioButton.Checked = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (SlowRadioButton.Checked)
                GameTimer.Interval = 500;
            else if (NormalRadioButton.Checked)
                GameTimer.Interval = 300;
            else if (FastRadioButton.Checked)
                GameTimer.Interval = 100;

            Settings.Enabled = true;

            SetUp();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LevelPanel.Visible = false;
            Settings.Enabled = true;
        }

        private void GameType_Click(object sender, EventArgs e)
        {
            GameTypePanel.Location = new Point(223, 169);
            GameTypePanel.Visible = true;
            Settings.Enabled = false;

            if (ClassicMode)
                ClassicRadioButton.Checked = true;
            else
                BoxRadioButton.Checked = true;
        }

        private void GameTypeOkButton_Click(object sender, EventArgs e)
        {
            if (ClassicRadioButton.Checked)
                ClassicMode = true;
            else if (BoxRadioButton.Checked)
                ClassicMode = false;

            Settings.Enabled = true;

            SetUp();
        }

        private void TypeBackButton_Click(object sender, EventArgs e)
        {
            GameTypePanel.Visible = false;
            Settings.Enabled = true;
        }

    }
}
