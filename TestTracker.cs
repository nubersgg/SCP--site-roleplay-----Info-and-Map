using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Scp_Map.SCP_Roleplay;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Scp_Map
{
    public partial class TestTracker : Form
    {
        private string draggedItem;
        private static WebClient client = new WebClient();
        public int RankSelected = 1;
        public int HostSelected = 1;
        public int RoleSelected = 1;
        public string NL = Environment.NewLine;
        public TestTracker()
        {
            Image ClipboardIM = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/Clipboard.png?raw=true")));
            InitializeComponent();
            Image backgroundIM = ImageSingleton.Instance.SharedImage;
            Clipboar_BG.Image = ClipboardIM;
            pictureBox1.Image = backgroundIM;
        }
        private void changed()
        {
        }
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            int index = listBox.IndexFromPoint(e.X, e.Y);

            if (index != ListBox.NoMatches)
            {
                draggedItem = listBox.Items[index].ToString();
                listBox.DoDragDrop(draggedItem, DragDropEffects.Move);
            }
            changed();
        }

        private void ListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            changed();
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            ListBox targetListBox = (ListBox)sender;

            if (draggedItem != null)
            {
                // Remove from the source list
                lstPlayerList.Items.Remove(draggedItem);
                lstDead.Items.Remove(draggedItem);
                lstDangerous.Items.Remove(draggedItem);
                lstCombatative.Items.Remove(draggedItem);
                // Remove from the target list if already present
                if (!targetListBox.Items.Contains(draggedItem))
                {
                    targetListBox.Items.Add(draggedItem);
                }
            }
            changed();
        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string roleString;
            string rankString;
            switch (RoleSelected)
            {
                case 1:
                    roleString = "CD";
                    break;
                case 2:
                    roleString = "MTF";
                    break;
                case 3:
                    roleString = "RRT";
                    break;
                case 4:
                    roleString = "SD";
                    break;
                default:
                    roleString = "Unknown Role";
                    break;
            }

            // Map RankSelected to corresponding strings
            switch (RankSelected)
            {
                case 1:
                    rankString = "I";
                    break;
                case 2:
                    rankString = "II";
                    break;
                case 3:
                    rankString = "III";
                    break;
                case 4:
                    rankString = "IIII";
                    break;
                case 5:
                    rankString = "IIIII";
                    break;
                default:
                    rankString = "Unknown Rank";
                    break;
            }
            string playerName = PlayerNameTB.Text.Trim();

            if (!string.IsNullOrEmpty(playerName))
            {
                string PlayerNameMod = $"{playerName} ({roleString}) [{rankString}]";
                lstPlayerList.Items.Add(PlayerNameMod);
                PlayerNameTB.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid player name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            changed();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPlayerList.SelectedIndex != -1)
            {
                string removedItem = lstPlayerList.SelectedItem.ToString();
                lstPlayerList.Items.Remove(removedItem);

                // Remove from other lists as well
                lstDead.Items.Remove(removedItem);
                lstDangerous.Items.Remove(removedItem);
                lstCombatative.Items.Remove(removedItem);
            }
            else if (lstDead.SelectedIndex != -1)
            {
                string removedItem = lstDead.SelectedItem.ToString();
                lstDead.Items.Remove(removedItem);

                // Remove from other lists as well
                lstPlayerList.Items.Remove(removedItem);
                lstDangerous.Items.Remove(removedItem);
                lstCombatative.Items.Remove(removedItem);
            }
            else if (lstDangerous.SelectedIndex != -1)
            {
                string removedItem = lstDangerous.SelectedItem.ToString();
                lstDangerous.Items.Remove(removedItem);

                // Remove from other lists as well
                lstPlayerList.Items.Remove(removedItem);
                lstDead.Items.Remove(removedItem);
                lstCombatative.Items.Remove(removedItem);
            }
            else if (lstCombatative.SelectedIndex != -1)
            {
                string removedItem = lstCombatative.SelectedItem.ToString();
                lstCombatative.Items.Remove(removedItem);

                // Remove from other lists as well
                lstPlayerList.Items.Remove(removedItem);
                lstDangerous.Items.Remove(removedItem);
                lstDead.Items.Remove(removedItem);
            }
            changed();
        }
        private void lstPlayerList_DragOver(object sender, DragEventArgs e)
        {
            ListBox_DragOver(sender, e);
        }

        private void lstDead_DragOver(object sender, DragEventArgs e)
        {
            ListBox_DragOver(sender, e);
        }

        private void lstDangerous_DragOver(object sender, DragEventArgs e)
        {
            ListBox_DragOver(sender, e);
        }

        private void lstPlayerList_DragDrop(object sender, DragEventArgs e)
        {
            ListBox_DragDrop(sender, e);
        }

        private void lstDead_DragDrop(object sender, DragEventArgs e)
        {
            ListBox_DragDrop(sender, e);
        }

        private void lstDangerous_DragDrop(object sender, DragEventArgs e)
        {
            ListBox_DragDrop(sender, e);
        }

        private void HostTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clipboar_BG_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clipboard_click(object sender, EventArgs e)
        {

        }

        private void lstCombatative_DragDrop(object sender, DragEventArgs e)
        {
            ListBox_DragDrop(sender, e);
        }
        private void lstCombatative_DragOver(object sender, DragEventArgs e)
        {
            ListBox_DragOver(sender, e);
        }
        private void lstDead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeadTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvl1TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Lime;
            lvl2TB.BackColor = Color.Red;
            lvl3TB.BackColor = Color.Red;
            lvl4TB.BackColor = Color.Red;
            lvl5TB.BackColor = Color.Red;
            RankSelected = 1;
        }

        private void lvl2TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Lime;
            lvl3TB.BackColor = Color.Red;
            lvl4TB.BackColor = Color.Red;
            lvl5TB.BackColor = Color.Red;
            RankSelected = 2;
        }

        private void lvl3TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Red;
            lvl3TB.BackColor = Color.Lime;
            lvl4TB.BackColor = Color.Red;
            lvl5TB.BackColor = Color.Red;
            RankSelected = 3;
        }

        private void lvl4TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Red;
            lvl3TB.BackColor = Color.Red;
            lvl4TB.BackColor = Color.Lime;
            lvl5TB.BackColor = Color.Red;
            RankSelected = 4;
        }

        private void lvl5TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Red;
            lvl3TB.BackColor = Color.Red;
            lvl4TB.BackColor = Color.Red;
            lvl5TB.BackColor = Color.Lime;
            RankSelected = 5;
        }

        private void CDbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Lime;
            MTFbtn.BackColor = Color.Red;
            RRTbtn.BackColor = Color.Red;
            SDbtn.BackColor = Color.Red;
            RoleSelected = 1;
        }

        private void MTFbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Red;
            MTFbtn.BackColor = Color.Lime;
            RRTbtn.BackColor = Color.Red;
            SDbtn.BackColor = Color.Red;
            RoleSelected = 2;
        }

        private void RRTbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Red;
            MTFbtn.BackColor = Color.Red;
            RRTbtn.BackColor = Color.Lime;
            SDbtn.BackColor = Color.Red;
            RoleSelected = 3;
        }

        private void SDbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Red;
            MTFbtn.BackColor = Color.Red;
            RRTbtn.BackColor = Color.Red;
            SDbtn.BackColor = Color.Lime;
            RoleSelected = 4;
        }

        private void O5btn_Click(object sender, EventArgs e)
        {
            O5btn.BackColor = Color.Lime;
            SiDbtn.BackColor = Color.Red;
            ScDbtn.BackColor = Color.Red;
            HostSelected = 1;
        }

        private void SiDbtn_Click(object sender, EventArgs e)
        {
            O5btn.BackColor = Color.Red;
            SiDbtn.BackColor = Color.Lime;
            ScDbtn.BackColor = Color.Red;
            HostSelected = 2;
        }

        private void ScDbtn_Click(object sender, EventArgs e)
        {
            O5btn.BackColor = Color.Red;
            SiDbtn.BackColor = Color.Red;
            ScDbtn.BackColor = Color.Lime;
            HostSelected = 3;
        }
    }
}
