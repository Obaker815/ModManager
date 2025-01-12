using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModManager
{
    public partial class FormModManager : Form
    {
        public static FormModManager activeMain;
        public string ActiveGame;
        public string ActiveProfile;
        public int numFiles = 0;

        public FormModManager()
        {
            InitializeComponent();

            activeMain = this;
            FileManager.UpdatePaths();
            FileManager.GetGames();
        }

        public void AddNewFile(string Path)
        {
            int index = numFiles;
            numFiles++;

            string name = Path;
            if (name.EndsWith(@"\"))
            {
                name = name.Remove(name.Length - 2, 1);
            }

            for (int i = name.Length - 1; i > 0; i--)
            {
                if (name[i] == '\\')
                {
                    name = name.Remove(0, i + 1);
                    break;
                }
            }

            panMods.Controls.Add(new Panel());
            Panel panel = (Panel)panMods.Controls[index];

            panel.BackColor = Color.Gray;

            panel.Width = panMods.Width - (panMods.Margin.Left + panMods.Margin.Right);
            panel.Height = 50;
            panel.Left = panMods.Margin.Left;
            panel.Top = panMods.Margin.Top + (panel.Height + panMods.Margin.Top) * index;

            panel.Controls.Add(new Label());
            Label txt = (Label)panel.Controls[0];

            txt.AutoSize = true;
            txt.Text = name;
            txt.Top = panel.Height / 2 - txt.Height / 2;
        }

        public ComboBox _cbGames
        {
            get { return cbGames; }
        }
        public ComboBox _cbProfiles
        {
            get { return cbProfiles; }
        }
        public Panel _panMods
        {
            get { return panMods; }
        }

        private void cbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveGame = cbGames.Text;
            FileManager.GetProfiles();
        }

        private void cbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveProfile = cbProfiles.Text;
            FileManager.GetMods();
            btnAddMod.Enabled = true;
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            ofdAddMod.ShowDialog();
        }

        private void ofdAddMod_FileOk(object sender, CancelEventArgs e)
        {
            FileManager.AddMod(ofdAddMod.FileName);
        }
    }
}
