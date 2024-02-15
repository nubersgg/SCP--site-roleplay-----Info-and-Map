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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
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
            string HostRole = "";
            string ScpTBSelected="";
            var playerNames = lstPlayerList.Items.Cast<string>();
            string CDs = string.Join(NL, playerNames);
            var ComplayerNames = lstCombatative.Items.Cast<string>();
            string Combatatives = string.Join(NL, ComplayerNames);
            var dangerousPlayers = lstDangerous.Items.Cast<string>();
            string armedPlayers = string.Join(NL, dangerousPlayers.Select(player => $"{player}[Armed]"));
            switch (ScpTB_Write.Text)
            {
                case "999":ScpTBSelected = "The Tickle Monster"; break;
                case "1193": ScpTBSelected = "Buried Giant"; break;
                case "860": ScpTBSelected = "Blue Key"; break;
                case "120": ScpTBSelected = "Teleporting Paddling Pool"; break;
                case "1499": ScpTBSelected = "The Gas Mask"; break;
                case "714": ScpTBSelected = "Jade Ring"; break;
                case "914": ScpTBSelected = "Refinary Machine"; break;
                case "498": ScpTBSelected = "ll Minute Snooze"; break;
                case "207": ScpTBSelected = "Cola Bottles\r\n"; break;
                case "330": ScpTBSelected = "Bowl Of Candy"; break;
                case "1025": ScpTBSelected = "Encyclopaedia Of Diseases"; break;
                case "517": ScpTBSelected = "Grammie Knows"; break;
                case "148": ScpTBSelected = "The TeleKill Alloy"; break;
                case "178": ScpTBSelected = "3D Glasses"; break;
                case "1139": ScpTBSelected = "The Broken Tongue"; break;
                case "087": ScpTBSelected = "The Stairwell"; break;
                case "224": ScpTBSelected = "Grandfather Clock"; break;
                case "902": ScpTBSelected = "The Final Countdown"; break;
                case "403": ScpTBSelected = "Escalating Lighter"; break;
                case "1162": ScpTBSelected = "Hole in a Wall"; break;
                case "701": ScpTBSelected = "Hanged KIng's Tragedy"; break;
                case "008": ScpTBSelected = "The Virus"; break;
                case "173": ScpTBSelected = "The Sculpture"; break;
                case "093": ScpTBSelected = "Red Sea Object\r\n"; break;
                case "2059": ScpTBSelected = "Wall Of Flesh"; break;
                case "035": ScpTBSelected = "The Mask"; break;
                case "409": ScpTBSelected = "The Crystal"; break;
                case "2521": ScpTBSelected = "●●I●●●●●I●●I●"; break;
                case "049": ScpTBSelected = "The Plague Doctor"; break;
                case "017": ScpTBSelected = "The Shadow Child"; break;
                case "2006": ScpTBSelected = "Too Spooky"; break;
                case "939": ScpTBSelected = "With Many Voices"; break;
                case "457": ScpTBSelected = "The Burning Man"; break;
                case "096": ScpTBSelected = "Shy Guy"; break;
                case "106": ScpTBSelected = "Old Man"; break;
                case "076": ScpTBSelected = "Able"; break;
                default:ScpTBSelected = "N/A";break;
            }
            switch (HostSelected)
            {
                case 1:HostRole ="Overseer";break;
                case 2:HostRole ="SiD";break;
                case 3:HostRole ="ScD"; break;
                default:HostRole = "N/A";break;
            }
            Clipboard.Text = $"SCP: {ScpTBSelected}{NL}{NL}CD:{NL}{CDs}{NL}{armedPlayers}{NL}{NL}Combatative:{NL}{Combatatives}{NL}{NL}Host: {HostTB_Write.Text}[{HostRole}]";

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
                lstPlayerList.Items.Remove(draggedItem);
                lstDead.Items.Remove(draggedItem);
                lstDangerous.Items.Remove(draggedItem);
                lstCombatative.Items.Remove(draggedItem);
                if (!targetListBox.Items.Contains(draggedItem))
                {
                    targetListBox.Items.Add(draggedItem);
                }
            }
            changed();
        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string roleString = "";
            string rankString = "";
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
            if (RoleSelected != 1)
            {
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
            }
            string playerName = PlayerNameTB.Text.Trim();
            if (!string.IsNullOrEmpty(playerName))
            {
                string PlayerNameMod = $"{playerName} ({roleString})";
                if (RoleSelected != 1)
                {
                    PlayerNameMod += $"[{rankString}]";
                }

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

                lstDead.Items.Remove(removedItem);
                lstDangerous.Items.Remove(removedItem);
                lstCombatative.Items.Remove(removedItem);
            }
            else if (lstDead.SelectedIndex != -1)
            {
                string removedItem = lstDead.SelectedItem.ToString();
                lstDead.Items.Remove(removedItem);

                lstPlayerList.Items.Remove(removedItem);
                lstDangerous.Items.Remove(removedItem);
                lstCombatative.Items.Remove(removedItem);
            }
            else if (lstDangerous.SelectedIndex != -1)
            {
                string removedItem = lstDangerous.SelectedItem.ToString();
                lstDangerous.Items.Remove(removedItem);

                lstPlayerList.Items.Remove(removedItem);
                lstDead.Items.Remove(removedItem);
                lstCombatative.Items.Remove(removedItem);
            }
            else if (lstCombatative.SelectedIndex != -1)
            {
                string removedItem = lstCombatative.SelectedItem.ToString();
                lstCombatative.Items.Remove(removedItem);

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
            changed();
        }

        private void lvl2TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Lime;
            lvl3TB.BackColor = Color.Red;
            lvl4TB.BackColor = Color.Red;
            lvl5TB.BackColor = Color.Red;
            RankSelected = 2;
            changed();
        }

        private void lvl3TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Red;
            lvl3TB.BackColor = Color.Lime;
            lvl4TB.BackColor = Color.Red;
            lvl5TB.BackColor = Color.Red;
            RankSelected = 3;
            changed();
        }

        private void lvl4TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Red;
            lvl3TB.BackColor = Color.Red;
            lvl4TB.BackColor = Color.Lime;
            lvl5TB.BackColor = Color.Red;
            RankSelected = 4;
            changed();
        }

        private void lvl5TB_Click(object sender, EventArgs e)
        {
            lvl1TB.BackColor = Color.Red;
            lvl2TB.BackColor = Color.Red;
            lvl3TB.BackColor = Color.Red;
            lvl4TB.BackColor = Color.Red;
            lvl5TB.BackColor = Color.Lime;
            RankSelected = 5;
            changed();
        }

        private void CDbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Lime;
            MTFbtn.BackColor = Color.Red;
            RRTbtn.BackColor = Color.Red;
            SDbtn.BackColor = Color.Red;
            RoleSelected = 1;
            changed();
        }

        private void MTFbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Red;
            MTFbtn.BackColor = Color.Lime;
            RRTbtn.BackColor = Color.Red;
            SDbtn.BackColor = Color.Red;
            RoleSelected = 2;
            changed();
        }

        private void RRTbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Red;
            MTFbtn.BackColor = Color.Red;
            RRTbtn.BackColor = Color.Lime;
            SDbtn.BackColor = Color.Red;
            RoleSelected = 3;
            changed();
        }

        private void SDbtn_Click(object sender, EventArgs e)
        {
            CDbtn.BackColor = Color.Red;
            MTFbtn.BackColor = Color.Red;
            RRTbtn.BackColor = Color.Red;
            SDbtn.BackColor = Color.Lime;
            RoleSelected = 4;
            changed();
        }

        private void O5btn_Click(object sender, EventArgs e)
        {
            O5btn.BackColor = Color.Lime;
            SiDbtn.BackColor = Color.Red;
            ScDbtn.BackColor = Color.Red;
            HostSelected = 1;
            changed();
        }

        private void SiDbtn_Click(object sender, EventArgs e)
        {
            O5btn.BackColor = Color.Red;
            SiDbtn.BackColor = Color.Lime;
            ScDbtn.BackColor = Color.Red;
            HostSelected = 2;
            changed();
        }

        private void ScDbtn_Click(object sender, EventArgs e)
        {
            O5btn.BackColor = Color.Red;
            SiDbtn.BackColor = Color.Red;
            ScDbtn.BackColor = Color.Lime;
            HostSelected = 3;
            changed();
        }

        private void HostTB_Write_TextChanged(object sender, EventArgs e)
        {
            changed();
        }

        private void ScpTB_Write_TextChanged(object sender, EventArgs e)
        {
            changed();
        }
    }
}