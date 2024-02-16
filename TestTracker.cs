using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
        public int Clipboard_Slide = 0;
        public string NL = Environment.NewLine;
        public TestTracker()
        {
            Image ClipboardIM = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/Clipboard.png?raw=true")));
            InitializeComponent();
            Image backgroundIM = ImageSingleton.Instance.SharedImage;
            Clipboar_BG.Image = ClipboardIM;
            pictureBox1.Image = backgroundIM;
            Clipboar_BG.BackgroundImage = backgroundIM;
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
            var DeadNames = lstDead.Items.Cast<string>();
            string Dead = string.Join(NL, DeadNames);
            PageTB.Text = $"Page {Clipboard_Slide+1}";
            switch (HostSelected)
            {
                case 1: HostRole = "Overseer"; break;
                case 2: HostRole = "SiD"; break;
                case 3: HostRole = "ScD"; break;
                default: HostRole = "N/A"; break;
            }
            switch (ScpTB_Write.Text)
            {
                case "999":ScpTBSelected = "SCP The Tickle Monster[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Bring to its containment with food" + NL + "Class-D limit: IIII" + NL + "Level required: Level-II" + NL + "Alias: The Tickle Monster" + NL + "location: CON-I" + NL + "" + NL + "Host: "+HostTB_Write.Text+ "["+ HostRole+"]"+NL+NL+"Test logs: "; break;
                case "1193": ScpTBSelected= "SCP: Buried Giant[Test[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Always contained" + NL + "Class-D limit: III" + NL + "Level required: Level-II" + NL + "Alias: Buried Giant" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "860": ScpTBSelected = "SCP: Blue Key[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Can't breach" + NL + "Class-D limit: III" + NL + "Level required: Level-I" + NL + "Alias: Blue Key" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "120": ScpTBSelected = "SCP: Teleporting Paddling Pool[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Can't breach" + NL + "Class-D limit: IIII" + NL + "Level required: Level-N/A" + NL + "Alias: Teleporting Paddling Pool" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "1499": ScpTBSelected ="SCP: The Gas Mask[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Can't breach" + NL + "Must: I combatative Required" + NL + "Class-D limit: III" + NL + "Level required: Level-I" + NL + "Alias: The Gas Mask" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "714": ScpTBSelected = "SCP: Jade Ring[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Eliminate" + NL + "Must: I combatative Required" + NL + "Class-D limit: I" + NL + "Level required: Level-II" + NL + "Alias: Jade Ring" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "914": ScpTBSelected = "SCP: Refinary Machine[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Can't breach" + NL + "Class-D limit: I" + NL + "Level required: Level-I" + NL + "Alias: Refinary Machine" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "498": ScpTBSelected = "SCP: ll Minute Snooze[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: unknown" + NL + "Must: I combatative Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-I" + NL + "Alias: ll Minute Snooze" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "207": ScpTBSelected = "SCP: Cola Bottles[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Eliminate" + NL + "Must: I combatative Required" + NL + "Class-D limit: I" + NL + "Level required: Level-I" + NL + "Alias: Cola Bottles" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "330": ScpTBSelected = "SCP: Bowl Of Candy[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Eliminate" + NL + "Must: I combatative Required" + NL + "Class-D limit: II" + NL + "Level required: Level-II" + NL + "Alias: Bowl Of Candy" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "1025": ScpTBSelected = "SCP: Encyclopaedia Of Diseases[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: Eliminate" + NL + "Must: II combatatives Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-I" + NL + "Alias: Encyclopaedia Of Diseases" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "517": ScpTBSelected = "SCP: Grammie Knows[Test]" + NL + "" + NL + "Threat Level: safe" + NL + "Recontainment method: unknown" + NL + "Must: II combatatives Required" + NL + "Class-D limit: II" + NL + "Level required: Level-I" + NL + "Alias: Grammie Knows" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "148": ScpTBSelected = "SCP: The TeleKill Alloy[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Eliminate" + NL + "Must: I combatative Required" + NL + "Class-D limit: III" + NL + "Level required: Level-I" + NL + "Alias: The TeleKill Alloy" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "178": ScpTBSelected = "SCP: 3D Glasses[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Eliminate" + NL + "Must: I combatative Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-II" + NL + "Alias: 3D Glasses" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "1139": ScpTBSelected = "SCP: The Broken Tongue[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Eliminate" + NL + "Must: I comatative Required and terminate affected class-D" + NL + "Class-D limit: IIII" + NL + "Level required: Level-II" + NL + "Alias: The Broken Tongue" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "087": ScpTBSelected = "SCP: The Stairwell[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Can't breach" + NL + "Must: II combatatives Required and give radio to class D" + NL + "Class-D limit: IIIIII" + NL + "Level required: Level-I" + NL + "Alias: The Stairwell" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "224": ScpTBSelected = "SCP: Grandfather Clock[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Eliminate" + NL + "Class-D limit: IIII" + NL + "Level required: Level-I" + NL + "Alias: Grandfather Clock" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "902": ScpTBSelected = "SCP: The Final Countdown[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Can't breach" + NL + "Must: II combatives Required" + NL + "Class-D limit: 2" + NL + "Level required: Level-I" + NL + "Alias: The Final Countdown" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "403": ScpTBSelected = "SCP Escalating Lighter[Test]" + NL + "" + NL + "Threat Level: Safe" + NL + "Recontainment method: Eliminate" + NL + "Must: Zero or more combatatives" + NL + "Class-D limit: III" + "Level required: Level-I" + NL + "Alias: Escalating Lighter" + NL + "location: CON-I" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "1162": ScpTBSelected = "SCP: Hole in a Wall[Test]" + NL + "" + NL + "Threat Level: Safe" + NL + "Recontainment method: Can't breach" + NL + "Must: II combatives Required and terminate armed class-D" + NL + "Class-D limit: IIII" + NL + "Level required: Level-II" + NL + "Alias: Hole in a Wall" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "701": ScpTBSelected = "SCP: Hanged KIng's Tragedy[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Eliminate" + NL + "Must: II combatives Required and terminate affected class-D" + NL + "Class-D limit: IIIII" + NL + "Level required: Level-IIII" + NL + "Alias: Hanged KIng's Tragedy" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "008": ScpTBSelected = "SCP: The Virus[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Eliminate" + NL + "Must: IIII combatives Required and terminate infected" + NL + "Class-D limit: IIIIII" + NL + "Level required: Level-III" + NL + "Alias: The Virus" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: ";break;
                case "173": ScpTBSelected = "SCP: The Sculpture[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Put him in a special cage" + NL + "Must: III combatives Required" + NL + "Class-D limit: IIIIII" + NL + "Level required: Level-II" + NL + "Alias: The Sculpture" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "093": ScpTBSelected = "SCP: Red Sea Object[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Can't breach" + NL + "Must: II combatives Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-IIII" + NL + "Alias: Red Sea Object" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "2059": ScpTBSelected = "SCP: Wall Of Flesh[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Can't breach" + NL + "Must: II combatives Required and give radio to class-D" + NL + "Class-D limit: IIIII" + NL + "Level required: Level-III" + NL + "Alias: Wall Of Flesh" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "035": ScpTBSelected = "SCP: The Mask[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Eliminate" + NL + "Must: II combatives Required and terminate affected" + NL + "Class-D limit: IIII" + NL + "Level required: Level-III" + NL + "Alias: The Mask" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "409": ScpTBSelected = "SCP: The Crystal[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Eliminate" + NL + "Must: IIII combatives Required" + NL + "Class-D limit: IIIII" + NL + "Level required: Level-III" + NL + "Alias: The Crystal" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "2521": ScpTBSelected = "SCP ●●I●●●●●I●●I●[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Eliminate" + NL + "Must: II combatives Required" + NL + "Class-D limit: III" + NL + "Level required: Level-II" + NL + "Alias: ●●I●●●●●I●●I●" + NL + "location: CON-II" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "049": ScpTBSelected = "SCP: The Plague Doctor[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Eliminate" + NL + "Must: III combatives Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-IIII" + NL + "Alias: The Plague Doctor" + NL + "location: CON-X" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "017": ScpTBSelected = "SCP: The Shadow Child[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: UV light" + NL + "Must: IIII combatives Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-IIII" + NL + "Alias: The Shadow Child" + NL + "location: CON-X" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "2006": ScpTBSelected = "SCP: Too Spooky[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Leash" + NL + "Must: II combatives Required" + NL + "Class-D limit: IIIIII" + NL + "Level required: Level-IIII" + NL + "Alias: Too Spooky" + NL + "location: CON-X" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "939": ScpTBSelected = "SCP: With Many Voices[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Eliminate" + NL + "Must: IIII combatives Required and II MTF/RRT Required" + NL + "Class-D limit: IIIIIIIIII" + NL + "Level required: Level-IIII" + NL + "Alias: With Many Voices" + NL + "location: CON-X" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "457": ScpTBSelected = "SCP: The Burning Man[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Water Gun" + NL + "Must: II combatives Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-IIII" + NL + "Alias: The Burning Man" + NL + "location: CON-X" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "096": ScpTBSelected = "SCP: Shy Guy[Test]" + NL + "" + NL + "Threat Level: Euclid" + NL + "Recontainment method: Bag" + NL + "Must: III combatives Required and MTF/RRT Required" + NL + "Class-D limit: INF" + NL + "Level required: Level-IIII" + NL + "Alias: Shy Guy" + NL + "location: Lower CON-X" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "106": ScpTBSelected = "SCP: Old Man[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Femur breaker" + NL + "IIII MTF/RRT Required" + NL + "Class-D limit: IIII" + NL + "Level required: Level-IIII" + NL + "Alias: Old Man" + NL + "location: Lower CON-X" + NL + "" + NL + "Host: " + HostTB_Write.Text + "[" + HostRole + "]" + NL + NL + "Test logs: "; break;
                case "076": ScpTBSelected = "SCP: Able[Test]" + NL + "" + NL + "Threat Level: Keter" + NL + "Recontainment method: Eliminate" + NL + "No testing" + NL + "Class-D limit: N/A" + NL + "" + NL + "Logs:";break;
                default:ScpTBSelected = "N/A";break;
            }
            switch (Clipboard_Slide)
            {
                case 0:Clipboard.Text=$"{ScpTBSelected}";break;
                case 1:Clipboard.Text=$"CD:{NL}{CDs}{NL}{armedPlayers}";break;
                case 2:Clipboard.Text = $"Combatative:{NL}{Combatatives}";break;
                case 3:Clipboard.Text = $"Dead:{NL}{Dead}";break;
                default:Clipboard.Clear();break;
            }

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
                if (!targetListBox.Items.Contains(draggedItem)){targetListBox.Items.Add(draggedItem);}
            }
            changed();
        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string roleString = "";
            string rankString = "";
            switch (RoleSelected)
            {
                case 1:roleString = "CD";break;
                case 2:roleString = "MTF";break;
                case 3:roleString = "RRT";break;
                case 4:roleString = "SD";break;
                default:roleString = "Unknown Role";break;
            }
            if (RoleSelected != 1)
            {
                switch (RankSelected)
                {
                    case 1:rankString = "I";break;
                    case 2:rankString = "II";break;
                    case 3:rankString = "III";break;
                    case 4:rankString = "IIII";break;
                    case 5:rankString = "IIIII";break;
                    default:rankString = "Unknown Rank";break;
                }
            }
            string playerName = PlayerNameTB.Text.Trim();
            if (!string.IsNullOrEmpty(playerName))
            {
                string PlayerNameMod = $"{playerName} ({roleString})";
                if (RoleSelected != 1){PlayerNameMod += $"[{rankString}]";}
                lstPlayerList.Items.Add(PlayerNameMod);
                PlayerNameTB.Clear();
            }
            else{MessageBox.Show("Please enter a valid player name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Clipboard_Slide <= 2){Clipboard_Slide++;}
            changed();
        }
    private void btnPrev_Click(object sender, EventArgs e)
        {
            if(Clipboard_Slide >= 1){Clipboard_Slide--;}
            changed();
        }
    }
}