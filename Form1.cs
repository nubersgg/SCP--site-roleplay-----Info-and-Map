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
namespace Scp_Map
{
    public partial class SCP_Roleplay : Form
    {
        private static WebClient client = new WebClient();
        Image backgroundIM = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/Background.png?raw=true")));
        Image MapIM = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/Map.png?raw=true")));
        Image ClipboardIM = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/Clipboard.png?raw=true")));
        Image SCP_999 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_999.png?raw=true")));
        Image SCP_3250 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_3250.png?raw=true")));
        Image SCP_1193 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_1193.png?raw=true")));
        Image SCP_860 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_860.png?raw=true")));
        Image SCP_120 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_120.png?raw=true")));
        Image SCP_1499 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_1499.png?raw=true")));
        Image SCP_714 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_714.png?raw=true")));
        Image SCP_914 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_914.png?raw=true")));
        Image SCP_207 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_207.png?raw=true")));
        Image SCP_330 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_330.png?raw=true")));
        Image SCP_1025 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_1025.png?raw=true")));
        Image SCP_517 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_517.png?raw=true")));
        Image SCP_148 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_148.png?raw=true")));
        Image SCP_178 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_178.png?raw=true")));
        Image SCP_498 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_498.png?raw=true")));
        Image SCP_1139 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_1139.png?raw=true")));
        Image SCP_087 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_087.png?raw=true")));
        Image SCP_224 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_224.png?raw=true")));
        Image SCP_902 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_902.png?raw=true")));
        Image SCP_1162 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_1162.png?raw=true")));
        Image SCP_701 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_701.png?raw=true")));
        Image SCP_008 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_008.png?raw=true")));
        Image SCP_2059 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_2059.png?raw=true")));
        Image SCP_198 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_198.png?raw=true")));
        Image SCP_173 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_173.png?raw=true")));
        Image SCP_093 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_093.png?raw=true")));
        Image SCP_035 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_035.png?raw=true")));
        Image SCP_409 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_409.png?raw=true")));
        Image SCP_049 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_049.png?raw=true")));
        Image SCP_017 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_017.png?raw=true")));
        Image SCP_2006 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_2006.png?raw=true")));
        Image SCP_457 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_457.png?raw=true")));
        Image SCP_939 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_939.png?raw=true")));
        Image SCP_076 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_076.png?raw=true")));
        Image SCP_096 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_096.png?raw=true")));
        Image SCP_106 = Image.FromStream(new System.IO.MemoryStream(client.DownloadData("https://github.com/nubersgg/SCP--site-roleplay-----Info-and-Map/blob/master/Images/SCP_106.png?raw=true")));
        string newLine = Environment.NewLine;

        public SCP_Roleplay()
        {
            InitializeComponent();
            InitializeImages();
        }
        public void InitializeImages()
        {
            pictureBox1.Image = backgroundIM;
            Map_Picture_Box.Image = MapIM;
            Clipboar_BG.Image = ClipboardIM;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SCP_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SCP_Info_Group_Box.Visible = true;
            SCP_Info_Group_Box.Enabled = true;
        }

        private void Exit_SCP_Info_Group_Box_button_Click(object sender, EventArgs e)
        {
            SCP_Info_Group_Box.Visible = false;
            SCP_Info_Group_Box.Enabled = false;
        }

        private void Con_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Con1Scp = new string[] {  "SCP 999",  "SCP 3250",  "SCP 1193",  "SCP 860", "SCP 120","SCP 1499", "SCP 714", "SCP 316", "SCP 914", "SCP 498", "SCP 207", "SCP 330", "SCP 1025", "SCP 517", "SCP 148", "SCP 178", "SCP 1139", "SCP 087", "SCP 224", "SCP 902"};
            string[] Con2Scp = new string[] { "SCP 1162", "SCP 701", "SCP 008","SCP 2059","SCP 198","SCP 173","SCP 093","SCP 035","SCP 409"};
            string[] ConXScp = new string[] { "SCP 049","SCP 017","SCP 2006", "SCP 939", "SCP 457",};
            string[] ConLXScp = new string[] { "SCP 096","SCP 106","SCP 076", "SCP 610"};
            if (Con_Selector.Text == "CON 1")
            {
                Scp_Selector.Items.Clear();
                Scp_Selector.Text = "SCP";
                Scp_Selector.Items.AddRange(Con1Scp);
            }
            if (Con_Selector.Text == "CON 2")
            {
                Scp_Selector.Items.Clear();
                Scp_Selector.Text = "SCP";
                Scp_Selector.Items.AddRange(Con2Scp);
            };
            if (Con_Selector.Text == "CON X")
            {
                Scp_Selector.Items.Clear();
                Scp_Selector.Text = "SCP";
                Scp_Selector.Items.AddRange(ConXScp);
            };
            if (Con_Selector.Text == "CON X Lower")
            {
                Scp_Selector.Items.Clear();
                Scp_Selector.Text = "SCP";
                Scp_Selector.Items.AddRange(ConLXScp);
            };
            if (Scp_Selector.Text == "SCP")
            {
                Scp_Number.Text = "No SCP selected";
                SCP_Info_Box.Text = "";
                SCP_Rule_Box.Text = "";
                Clipboard.Text = "";
            }
            else
            {
                Scp_Number.Text = Scp_Selector.Text;
                SCP_Info_Box.Text = "";
                SCP_Rule_Box.Text = "";
                Clipboard.Text = "";
                SCP_Picture_Box.Dispose();
            };
        }
        private void Scp_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Scp_Selector.Text == "SCP")
            {
                Scp_Number.Text = "No SCP selected";
            }
            else

            {
                Scp_Number.Text = Scp_Selector.Text;
                if (Scp_Selector.Text == "SCP 999")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-999 is allowed to freely roam the facility should it desire to, but otherwise must stay in its pen either between 8PM-9PM for sleeping, or during emergency lockdowns for its own safety. Subject is not allowed out of its pen at night or off facility grounds at any time. Pen is to be kept clean and food replaced twice daily. All personnel are allowed inside SCP-999’s holding area, but only if they are not assigned to other tasks at the time, or if they are on break. Subject is to be played with when bored and spoken to in a calm, non-threatening tone."+newLine+""+newLine+ "Description: SCP-999 appears to be a large, amorphous, gelatinous mass of translucent orange slime, weighing about 54 kg (120 lbs) with a consistency similar to that of peanut butter. Subject’s size and shape is easily malleable and can change shape at will, though when at rest, SCP-999 becomes a rounded, oblate dome roughly 2 meters wide and 1 meter in height. The surface of SCP-999 consists of a thin, transparent membrane similar to that of an animal cell roughly .5 cm thick, and is highly elastic, allowing SCP-999 to flatten portions of its body up to 2 cm thin. This surface is also hydrophobic, although SCP-999 can willfully absorb liquids (see Addendum SCP-999-A). The rest of SCP-999's body is filled with a viscous orange substance of unknown chemical makeup, though it is capable of digesting organic materials with ease.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Subject is to be played with when bored and spoken to in a calm, non-threatening tone.");
                    Clipboard.Text = ("SCP The Tickle Monster" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Class-D limit: IIII" +newLine+"Level required: Level-II"+newLine+"Alias: The Tickle Monster"+newLine+"location: CON-I"+ newLine + "Logs:");
                    SCP_999_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_999;
                }
                else
                {
                    SCP_999_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 3250")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: A sample of the original Kentucky Fried Chicken Eleven Secret Herbs and Spices is to be kept in a standard Safe-Class item locker in Site-88. A digital copy of the recipe is available on the Site-88 database. Widespread reproduction of SCP-3250's effects has been made impossible due to the exclusive rights of Kentucky Fried Chicken to market and sell chicken flavoured with its trademark secret recipe, as well as the acquisition of the ██████████ Family Plantation through a Foundation front and the subsequent monopoly established on the ██████████-variety peppercorn."+newLine+""+newLine+ "Description: SCP-3250 is a perceptual anomaly affecting individuals who have consumed pressure-cooked fried chicken seasoned with Kentucky Fried Chicken's proprietary Eleven Secret Herbs and Spices. For a period of time after consumption, people affected by the anomaly will perceive depictions of Jesus Christ as being altered to resemble American businessman and restauranteur Colonel Harland David Sanders, clad in his trademark white suit and bolo tie. Altered depictions will be of similar art style to the original. All manner of visual depictions are affected, including secular depictions.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Public knowledge of the substitution of Kentucky Fried Chicken's secret Eleven Secret Herbs and Spices recipe is to be suppressed");
                    Clipboard.Text = ("SCP: Eleven Secret Herbs and Spices" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Class-D limit: III" + newLine + "Level required: Level-I" + newLine + "Alias: Eleven Secret Herbs and Spices" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_3250_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_3250;
                }
                else
                {
                    SCP_3250_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 1193")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: The borehole containing SCP-1193-01 is to be capped with a tungsten steel grate containing a locking 2.5cm endoscopy aperture. At 48-hour intervals, the borehole is to be endoscopically inspected to a depth of 4km for further manifestations of SCP-1193-01. Seismographic monitoring devices are posted at 2, 7, and 11 kilometer depths alongside the SCP-1193-01 borehole. Seismic readings consistent with subterranean movement are to be reported immediately to Site Director Iqbal. In the event of subterranean containment breach, containment staff are to execute Protocol 473a, severing SCP-1193-01 below the fifth elbow and backfilling remaining portions of the borehole with pressurized concrete." + newLine + "" + newLine + "Description: SCP-1193-01 is a genetically normal human arm of unusual length, located in a drainage pipe inside the basement of a telephone switching station in Scottsdale, Arizona. Ten centimeters below the drainage grate, the arm terminates in an unremarkable human hand of indeterminate gender. Upon initial examination, the arm was believed to extend through the drainage pipe to a depth of 35 meters. Subsequent endoscopic investigation demonstrated that the arm extends to at least a depth of 71 kilometers, passing without apparent difficulty through the Mohorovičić discontinuity and the upper mantle, with regularly spaced elbows every four kilometers. Elbows below a depth of 26 kilometers are slightly retroflexed to accommodate a nine-degree southward bend in the drainage borehole. Continued endoscopic investigation into the SCP-1193-01 borehole is suspended due to presently-intractable engineering constraints.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "The basement containing SCP-1193 is to be monitored at all times by a Foundation interrogator. SCP - 1193 - 02 is to be answered on or before the third ring; interrogator should attempt to elicit self-directed responses from SCP - 1193 - 01.Responses which implicate size, body plan, location, or further manifestations are to be recorded in Document SCP-1193 - 2 - LTR.");
                    Clipboard.Text = ("SCP: Buried Giant" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Class-D limit: III" + newLine + "Level required: Level-II" + newLine + "Alias: Buried Giant" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_1193_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_1193;
                }
                else
                {
                    SCP_1193_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 860")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-860 is to be contained in a small wooden box in a vault at Sector-██. By itself, the object is inert, and no further containment procedures are needed."+newLine+""+newLine+ "Description: SCP-860 is a dark blue key of unremarkable shape. At seemingly random intervals of time, a series of numbers, later found to be UTM coordinates, will appear on the key's blade. In the time SCP-860 has spent under containment, the numbers have changed three times, giving the coordinates for ██████ (Germany), ██████ (England), and Site-██."+newLine+ "SCP-860 can fit in any door lock that requires a key located in the area of the given coordinates, and will function identically to the correct key for that lock. SCP-860 only works on door locks, and only if they are attached to a door; it will not work on any other type of locking device.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Must get permission from high level site director");
                    Clipboard.Text = ("SCP: Blue Key" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Class-D limit: III" + newLine + "Level required: Level-I" + newLine + "Alias: Blue Key" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_860_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_860;
                }
                else
                {
                    SCP_860_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 120")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: Due to its importance to the Foundation, SCP-120 is to be kept under video surveillance and armed guard at all times. Any personnel attempting to utilize the item without authorisation are to be terminated immediately. All personnel wishing to use the item are required to submit a filled copy of the application form (Document #120-23) to facility operators."+newLine+""+newLine+ "Description: SCP-120 appears to be a small child’s paddling pool, pastel pink in colouration, with an inner diameter of approximately 2.5 metres and inner height of 0.3 metres. The pool appears to have been fabricated from common Earth plastics but has shown itself to be indestructible by any attempted means (see research report #120-32 for a full summary). The pool’s structure and response to pressure are typical for such a pool (it will flex when pressure is applied and is soft to the touch) but has amazing tensile strength and cannot be permanently stretched or ripped.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "SCP-120 is to be kept under video surveillance and armed guard at all times. Any personnel attempting to utilize the item without authorisation are to be terminated immediately.");
                    Clipboard.Text = ("SCP: Teleporting Paddling Pool" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-N/A" + newLine + "Alias: Teleporting Paddling Pool" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_120_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_120;
                }
                else
                {
                    SCP_120_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 1499")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-1499 is to be kept in a locked box guarded by two agents at all times. Testing involving SCP-1499 requires the authorization of Level 4 personnel is to be discontinued indefinitely. Test subjects are to wear a small full-duplex two-way radio underneath SCP-1499 to maintain contact with researchers. Testing is no longer to be carried out by D-Class personnel due to the risk of losing SCP-1499. Should test subjects enter any sort of danger, they are to remove SCP-1499 immediately."+newLine+""+newLine+ "Description: SCP-1499 is a Soviet GP-5 gas mask. A seal test performed on the object suggests that the object retains its original functionality. The anomalous effects of SCP-1499 activate when a human places SCP-1499 on their head. Approximately one second after SCP-1499 is fully secured on the subject's head, the subject vanishes from view, and is no longer detectable. The subject reports no feeling of motion at this time. Testing has revealed that two-way radios remain capable of both receiving and transmitting despite the subject being undetectable. Upon wearing SCP-1499, test subjects report completely different surroundings than they were in prior to wearing SCP-1499. Subjects have reported that it appears barren and inhospitable, with tall black towers filling the area. Subjects have also sighted entities in this landscape. These entities, designated SCP-1499-1, have been described as tall, nude humanoids with dark skin that have a thick coat of an unknown viscous substance. Instances of SCP-1499-1 also have large amounts of eyes and mouths covering their body. Upon removing SCP-1499 from their head, subjects reappear in the same location they were in when they put it on. For more information, see.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Should test subjects enter any sort of danger, they are to remove SCP-1499 immediately.");
                    Clipboard.Text = ("SCP: The Gas Mask" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Must: I combatative Required" + newLine + "Class-D limit: III" + newLine + "Level required: Level-I" + newLine + "Alias: The Gas Mask" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_1499_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_1499;
                }
                else
                {
                    SCP_1499_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 714")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-714 is to be stored in a reinforced, high-security locker that is to be accessible only to Level 4+ personnel, due to several incidents of misuse."+newLine+""+newLine+ "Description: Seemingly nothing more than a green jade ring, SCP-714 has been shown to be able to expand and contract to perfectly fit the finger of anyone who touches it, though this is the least important of its properties. SCP-714 only changes size when touched by a 'new' subject.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "L4+ personnel can only open the locker");
                    Clipboard.Text = ("SCP: Jad Ring" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Must: I combatative Required") + newLine + "Class-D limit: I" + newLine + "Level required: Level-II" + newLine + "Alias: Jad Ring" + newLine + "location: CON-I" + newLine + "Logs:";
                    SCP_714_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_714;
                }
                else
                {
                    SCP_714_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 316")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "THE DOOR TO IT IS GONE");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "THE DOOR TO IT IS GONE");
                    Clipboard.Text = ("SCP: Melancholy Lamp" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatatives Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-1" + newLine + "Alias: Melancholy Lamp" + newLine + "location: CON-N/A" + newLine + "Logs:");
                };
                if (Scp_Selector.Text == "SCP 914")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: Only personnel who submit a formal request and receive approval from site command may operate 914. SCP-914 is to be kept in research cell 109-B with two guard personnel on duty at all times. Any researchers entering 109-B are to be accompanied by at least one guard for the entirety of testing. A full list of tests to be carried out must be given to all guard personnel on duty; any deviation from this list will result in termination of testing, forcible removal of personnel from 109-B, and formal discipline at site command’s discretion."+newLine+""+newLine+ "Description: SCP-914 is a large clockwork device weighing several tons and covering an area of eighteen square meters, consisting of screw drives, belts, pulleys, gears, springs and other clockwork. It is incredibly complex, consisting of over eight million moving parts comprised mostly of tin and copper, with some wooden and cloth items observed. Observation and probing have showed no electronic assemblies or any form of power other than the “Mainspring” under the “Selection Panel”. Two large booths 3mx2.1mx2.1m (10ftx7ftx7ft) are connected via copper tubes to the main body of SCP-914, labeled “Intake” and “Output”. Between them is a copper panel with a large knob with a small arrow attached. The words Rough, Coarse, 1:1, Fine, and Very Fine are positioned at points around the knob. Below the knob is a large “key” that winds the “mainspring”.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "WARNING: At this time, no testing of biological matter is allowed. Refer to document 109-B:117. Applying the “Rough” setting to explosive materials is not advised.");
                    Clipboard.Text = ("SCP: Refinary Machine" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Class-D limit: I" + newLine + "Level required: Level-I" + newLine + "Alias: Refinary Machine" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_914_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_914;
                }
                else
                {
                    SCP_914_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text== "SCP 498")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info"+newLine+""+newLine + "Special Containment Procedures: SCP-498 is to be contained within a sound-proof bunker beneath Site ██, with a minimum of two attending Foundation Security Officers, properly equipped with noise-canceling headphones in addition to standard-issue equipment. The bunker is to be sound-proofed to noise-cancel a minimum of 95% of outgoing sound waves." +newLine+ "" +newLine+ "Description: SCP-498 appears to be a Koway Brand RT-800 electronic alarm clock with yellow LED display, set to the U.S. Central Time Zone. When heard by a subject, the alarm has been seen to induce a state of increased alertness until reset. This effect prevents restful sleep in SCP-498's vicinity, although micro-naps are possible. Other than the snooze button and the display, none of the other functions on the device appear operational. Notably, the device continues to display time and require resetting even while not connected to a power source. Attempts to dismantle SCP-498 have not been successful in preventing it from activating, nor have they determined how it operates without an obvious power source.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules"+newLine+""+newLine+ "A minimum of two attending Foundation Security Officers, properly equipped with noise-canceling headphones in addition to standard-issue equipment.");
                    Clipboard.Text = ("SCP: 11 Minute Snooze" + newLine + "" + newLine + "Threat Level: safe" +newLine+ "Recontainment method: unknown" + newLine + "Must: I combatative Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-I" + newLine + "Alias: 11 Minute Snooze" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_498_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_498;
                }
                else
                {
                    SCP_498_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 207")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-207 is to be stored in a waterproofed locking metal container measuring 1 m x 0.5 m x 0.5 m. The key is to be issued to the current head researcher of the Site's bio-containment area. SCP-207 is to be retained inside this area at all times, and all personnel entering the area should be checked for any food or drink items, in addition to any other searches required. Any staff seen ingesting SCP-207-1 are to be retained for future study, with all Foundation clearance levels removed."+newLine+""+newLine+ "Description: SCP-207 refers to a crate containing 24 Coca-Cola brand cola drinks. The bottles are designated SCP-207-A to -X. SCP-207-B is currently the active bottle for testing, and no other bottles are to be opened without authorisation from two Level 4 researchers. All bottles have been clearly labelled to aid identification. The liquid held inside these has been confirmed to be identical across all of SCP-207, and should not be ingested outside of supervised testing. The liquid has been classified as SCP-207-1, and is to be treated as a Class 2 chemical hazard. SCP-207-1 does not appear to alter with age; however, the active testing bottle should have its protective cover kept on outside of removing liquid for testing.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "All vending machines in the Site are to only dispense clear carbonated beverages; any variation from transparent is to be investigated immediately.");
                    Clipboard.Text = ("SCP: Cola Bottles" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Must: I combatative Required" + newLine + "Class-D limit: I" + newLine + "Level required: Level-I" + newLine + "Alias: Cola Bottles" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_207_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_207;
                }
                else
                {
                    SCP_207_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 330")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: Considering recent incidents, SCP-330 is to be kept in secure storage until further notice. Level 2 Clearance is required for access to SCP-330 or its contents. All direct experimentation of SCP-330 is to be conducted using Class D personnel with no genetic history of diabetes. No more than two (2) samples are to be removed from SCP-330 at any time, except during exposure testing."+newLine+""+newLine+ "Description: SCP-330 appears to be a small round stainless steel bowl filled with a variable amount of individually wrapped pieces of candy. Taped to the side of the bowl is a handwritten note, reading “take no more than two, please!!” Attempts to remove the note have met with failure, as have attempts to hide or obscure it. Testers have noted finding it impossible to avoid reading the note, and those who approach it from an opposite angle are aware of this request.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Level 2 Clearance is required for access to SCP-330 or its contents");
                    Clipboard.Text = ("SCP: Bowl Of Candy" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Must: I combatative Required" + newLine + "Class-D limit: II" + newLine + "Level required: Level-II" + newLine + "Alias: Bowl Of Candy" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_330_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_330;
                }
                else
                {
                    SCP_330_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 1025")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "pecial Containment Procedures: Due to its potential as a bioweapon capable of destroying all life on Earth, SCP-1025 is to be kept in an isolated underground vault secured by no fewer than 10 armed guards, to be rotated twice weekly and checked for compromise by infectious agents. The vault should be armed with a thermite mine to be detonated at the first sign of containment breach."+newLine+""+newLine+ "Description: SCP-1025 is a hardcover book, approximately 1,500 pages long. The front cover and spine feature the title The Encyclopedia of Common Diseases. The publisher's page indicates the book was printed in 19██ by █████ Press. No other copies of a book with that title and publisher have been found, and no record of the publisher exists. Readers of the book seem to exhibit symptoms of any disease they read about. The effect can take between █ and ██ hours to manifest. ");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Revision: SCP-1025 is to be kept in a passcode-secured locker. Further research requires O5 approval.");
                    Clipboard.Text = ("SCP: Encyclopaedia Of Diseases" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatatives Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-I" + newLine + "Alias: Encyclopaedia Of Diseases" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_1025_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_1025;
                }
                else
                {
                    SCP_1025_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 517")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-517 is to be kept secured within Containment Locker 51164 in Site-66, facing away from the doorway. A thick sheet is to be draped over the item at all times. Testing is currently prohibited, as the nature of the manifestation invariably causes a low-level containment breach. If SCP-517-01 is triggered, personnel are instructed to report to their immediate superior to enact Protocol 517-001."+newLine+""+newLine+ "Description: SCP-517 is a fortune-telling machine. Item stands approximately 2 meters tall, containing a mechanical puppet and an electric candle within a glass and wooden case. Examination has shown an internal layout consistent with similar machines. On the top panels the words Grandmother Predictions are painted on built-in signage. The puppet within is in the shape of an elderly woman, with a white blouse and a blue shawl. Item's power cord has been severed approximately 15 centimeters from its base; it appears to have been inexpertly separated from its original power source. No reaction occurs if a coin is inserted into the slot.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "As of Incident 517-1997-M, SCP-517 is to be kept in a dedicated cell at all times. An opaque black sheet is to be kept bound around the object at all times. As of 08/25/1997 (classified), no more testing is to be conducted on SCP-517 without Site Director's approval.");
                    Clipboard.Text = ("SCP: Grammie Knows" + newLine + "" + newLine + "Threat Level: safe" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatatives Required" + newLine + "Class-D limit: II" + newLine + "Level required: Level-I" + newLine + "Alias: Grammie Knows" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_517_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_517;
                }
                else
                {
                    SCP_517_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 148")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP - 148 is to be stored as 120 cast ingots, each of which weighs approximately 10 kg at time of writing.Ingots of SCP - 148 may not be housed at the same site as any SCP(due to the potential for unforeseen interactions) ; otherwise, said ingots should be distributed equally among acceptable Foundation facilities. The mass of each contained ingot of SCP-148 must be measured and reported monthly.Under no circumstances should any SCP with mind-affecting or extrasensory properties come into contact with SCP-148.In the event of such contact, the immediate area must be evacuated and the affected sample of SCP-148 detonated remotely."+newLine+""+newLine+ "Description: SCP-148 is a metallic substance, composed of a variety of known and unknown elements. The total mass of SCP-148 on hand is approximately 1.1 1.2 tonnes. SCP-148 has a gray-green color with a bluish tinge and oxidizes readily in the presence of water. SCP-148 has a melting transition point of approximately 4500°C and a boiling transition point of approximately 9000°C. SCP-148 has a density of 6.20 g/cm3 6.76 g/cm3 and qualifies as HRC 39 in a Rockwell hardness test. It exhibits material properties, such as strength, ductility, and workability, similar to platinum.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Personnel are not to be assigned to SCP-148 for a period of time longer than three weeks. Any personnel assigned to SCP-148 are to be given regular psychological evaluations.");
                    Clipboard.Text = ("SCP: The TeleKill Alloy" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: I combatative Required" + newLine + "Class-D limit: III" + newLine + "Level required: Level-I" + newLine + "Alias: The TeleKill Alloy" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_148_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_148;
                }
                else
                {
                    SCP_148_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 178")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-178 is to be stored in a Class 3 Anomalous Object Container guarded by no fewer than two (2) armed personnel with Level 3 clearance when not undergoing testing. Item is to be removed from containment only with the written permission of personnel with Level 4 clearance or higher. Following Incident #178-14-Alpha all tests are to be monitored remotely and the presence of all personnel apart from test subjects in the testing area during experimentation is expressly prohibited."+newLine+""+newLine+ "Description: SCP-178 is a pair of white stereoscopic (“3-D”) glasses with a rectangular white cardboard frame and lenses of transparent blue and red (left and right lenses, respectively) plastic. The item exhibits no unusual physical properties apart from a slight discoloration of the cardboard consistent with age. When worn, the wearer begins perceiving large bipedal entities in addition to its ordinary surroundings. Entities reportedly exhibit a docile and occasionally curious behavior (reports include entities leaning over the shoulder of persons working and observing them with interest), with one exception. Any attempt by the wearer or any other personnel (see Incident Report #178-14-Alpha) to directly interact with the entities results in severe lacerations suddenly appearing on persons involved. The appearance of lacerations is rapid and continues until the moment the wearer expires. The pattern of lacerations is always consistent with being slashed with three (3) parallel, tapered sharp objects of lengths varying between 14.2 and 27.4 cm and maximum thickness varying between 2.9 and 8.1 cm. Recording and measuring devices used during testing failed to detect any anomalies, including while lacerations were appearing on subject(s). Subjects do not report hearing any sounds emanating from the entities. Long-term observation of subjects exposed to the item reveals no lasting effects. Stereoscopic images viewed through the item appear three-dimensional.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Addendum #3: Personnel with Level 4 Clearance are urged to read Incident Report #178-14-Alpha. Reading Incident Report #178-14-Alpha is mandatory for all personnel with Level 4 Clearance or higher overseeing or approving experiments with the item."+newLine+""+newLine+"WARNING: Failure to comply with Addendum #3 is grounds for disciplinary measures.");
                    Clipboard.Text = ("SCP: 3D Glasses" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: I combatative Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-II" + newLine + "Alias: 3D Glasses" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_178_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_178;
                }
                else
                {
                    SCP_178_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 1139")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: By authorization of O5, object is housed at Research Area 39. Following Incident 1139-1, object moved to Research Area (classified). When not being used for testing, object is to be enclosed in a seventy-five (75) by twenty (20) by twenty (20) centimeter block of rubber, molded into two pieces, with a Faraday cage surrounding the block, placed on a static-free workbench. The containment room for the object shall be made of unreinforced concrete (minimum thickness of three (3) meters) and shall be illuminated at all times by gas lamps. The humidity level shall remain between 70% and 80% at all times."+newLine+""+newLine+ "Description: SCP-1139 consists of a metallic grey rectangular block, roughly twenty (20) centimeters high and five (5) centimeters square at its base. The overall density of the object is roughly double that of iron, and the object is denser near the top. The object has thus far proved impervious to both deterioration and damage, making a determination of the object's age impossible. The sides are patterned with square protrusions in an unrecognized pattern, which can be confirmed by touch. Viewers of the pattern or of photos of the pattern observe the protrusions as block letters in a language they are familiar with, but this is merely a visual illusion. No subject has reported any subsequent change in the appearance of the letters. On the bottom of the object, there are four (4) 1 mm x 5 mm crevices, each coated in a copper-colored substance. No new effect has been observed through the manipulation of or application of electricity directly to the crevices.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Research Area (classified) shall remain equipped with two lightning rods at all times, neither of which shall be grounded within 200 meters of SCP-1139.");
                    Clipboard.Text = ("SCP: The Broken Tongue" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: I comatative Required and terminate affected class-D" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-II" + newLine + "Alias: The Broken Tongue" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_1139_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_1139;
                }
                else
                {
                    SCP_1139_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 087")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-087 is located on the campus of [REDACTED]. The doorway leading to SCP-087 is constructed of reinforced steel with an electro-release lock mechanism. It has been disguised to resemble a janitorial closet consistent with the design of the building. The lock mechanism on the doorknob will not release unless (classified) volts are applied in conjunction with counter-clockwise rotation of the key. The inside of the door is lined with 6 centimeters of industrial foam padding." + newLine+""+newLine+ "Description: SCP-087 is an unlit platform staircase. Stairs descend on a 38 degree angle for 13 steps before reaching a semicircular platform of approximately 3 meters in diameter. Descent direction rotates 180 degrees at each platform. The design of SCP-087 limits subjects to a visual range of approximately 1.5 flights. A light source is required for any subjects exploring SCP-087, as there are no lighting fixtures or windows present. Lighting sources brighter than 75 watts have shown to be ineffective, as SCP-087 seems to absorb excess light.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Due to the results of the final exploration (see Document 087-IV), no personnel are permitted access to SCP-087.");
                    Clipboard.Text = ("SCP: The Stairwell"+newLine+"" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatatives Required and give radio to class D" + newLine + "Class-D limit: IIIIII" + newLine + "Level required: Level-I" + newLine + "Alias: The Stairwell" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_087_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_087;
                }
                else
                {
                    SCP_087_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 224")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: Item SCP-224 is to be stored in a soundproof enclosure with acoustic destructive interference nodes. Nodes must be replaced on a weekly basis by remote means due to the erratic nature of SCP-224’s effect; non Class-D personnel are not to enter the enclosure. Additionally, SCP-224’s enclosure must be kept free from moisture to avoid rapid oxidation."+newLine+""+newLine+ "Description: SCP-224 is a wooden grandfather clock, accented with a black lacquer and gold leaf. Markings, remotely observed, date its origin at the end of the 19th century. Though internal examination of its components has been done, the density and construction of its gears make method of function impossible to interpret. The hands of the clock do not move with any known consistency, though the tendency seems to be generally clockwise. Additionally, chimes occur at non-regular intervals, ranging from approximately one minute to several months. To further complicate matters, the numbers on the clock also have a tendency to move and shift, though they generally retain ascending order.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "In the event that the clock begins to chime, all personnel must evacuate the area, and the location should be secured following procedure Zeit 77.");
                    Clipboard.Text = ("SCP: Grandfather Clock"+newLine+"" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-I" + newLine + "Alias: Grandfather Clock" + newLine + "location: CON-I" + newLine + "Logs:");
                    SCP_224_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_224;
                }
                else
                {
                    SCP_224_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 902")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-902 has been relegated to Arctic Base Theta-12, the only SCP to be contained at this site. The site is to be staffed by a team of fifty security personnel. At this time, no research is to be done on SCP-902. Knowledge of SCP-902 beyond its number is to be limited to level three staff and lower. It is imperative that only a limited number of Senior Staff know of the existence of SCP-902. Only one O5 is allowed to know about SCP-902 at any time."+newLine+""+newLine+ "Description: SCP-902 is a box roughly the size of an adult human head. It measures 30 cm x 15 cm x 19 cm. It appears to be an ammunition box of a type used roughly thirty years ago, despite this item having been in Foundation custody for roughly sixty years. SCP-902 is made of lead. The composition of the item inside SCP-902 is unknown. SCP-902 emits what has been described as a 'ticking' sound, and anyone who hears this sound becomes convinced that the item is counting down. When opened, the box appears empty. However, the ticking remains, the object continues counting down. Anyone who becomes aware of SCP-902, whether through personal interaction, or by reading this report, becomes convinced that whatever is in the box is horribly dangerous, and needs to be destroyed as soon as it finishes counting down, and not before. Staff exposed to SCP-902 will typically continue to attempt to open and then close the box, trying to find the object inside.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "In the event of a security breach from inside Arctic Base Theta-12, the onsite hydrogen bomb is to be detonated remotely. SCP-902 must be guarded at all times against premature destruction.");
                    Clipboard.Text = ("SCP: The Final Countdown" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" +newLine+ "Must: II combatives Required" + newLine + "Class-D limit: 2" + newLine + "Level required: Level-I" + newLine + "Alias: The Final Countdown" + newLine + "location: CON-I" + newLine+"Logs:");
                    SCP_902_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_902;
                }
                else
                {
                    SCP_902_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 1162")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-1162's exterior has been painted to camouflage with its surroundings in an effort to deter future detection. Due to its remote location and relative harmlessness, as well as the inherent ease in misinformation, containment efforts required are minimal."+newLine+""+newLine+ "Description: SCP-1162 is a three-bedroom, two-bath suburban house located in Vastitas Borealis, the largest lowland region of Mars. It does not have a visible lawn, surrounding street, or other obvious signs of permanence. SCP-1162 resembles a standard suburban American home and is, along with its contents, anomalously resistant to damage, as the inhospitable conditions on Mars' surface would have quickly destroyed a nonanomalous structure of similar make.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "No personnel shall not go in the hole");
                    Clipboard.Text = ("SCP: Hole in a Wall" + newLine + "" + newLine + "Threat Level: Safe" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatives Required and terminate armed class-D" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-II" + newLine + "Alias: Hole in a Wall" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_1162_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_1162;
                }
                else
                {
                    SCP_1162_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 701")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: All materials relating to SCP-701 are to be kept in a triple-locked archive at Storage Site-(classified). These items currently consist of: the two (2) currently extant copies of the 1640 quarto; twenty-seven (27) copies of the 1965 trade paperback edition; ten (10) copies of a 1971 hardcover printing; twenty-one (21) floppy diskettes, consisting of data seized from raids on [EXPUNGED]; one (1) S-VHS video cassette tape (classified); and one (1) steel knife of unknown origin (classified). At no time are any of these items to be removed from the room. Access to the area is to be heavily monitored; absolutely no personnel whatsoever is to be granted access to the archive without the express, in-person permission of Drs. (classified)." + newLine+""+newLine+ "Description: SCP-701, The Hanged King's Tragedy, is a Caroline-era revenge tragedy in five acts. Performances of the play are associated with sudden psychotic and suicidal behavior among both observers and participants, as well as the manifestation of a mysterious figure, classified as SCP-701-1. Historical estimates place the number of lives claimed by the play at between (classified) and (classified) over the past three hundred years.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "No personnel shall not be in the room with 701");
                    Clipboard.Text = ("SCP: Hanged KIng's Tragedy" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatives Required and terminate affected class-D" + newLine + "Class-D limit: IIIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: Hanged KIng's Tragedy" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_701_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_701;
                }
                else
                {
                    SCP_701_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 008")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-008 samples have been deemed Class V extreme biological hazards, and all related protocols apply. Incineration and irradiation measures will be deployed in the event of political or military action which may result in the facility being dismantled; a power failure; or zero communications from operatives or outside channels during any given eight hour period."+newLine+""+newLine+ "Description: SCP-008 is a complex prion, samples of which are stored in each of the known G2 sites. Research into SCP-008 is highly classified and primarily aimed at preventing research which may lead to the synthesis of SCP-008 in the distant future. Traits of the SCP-008 prion include: "+newLine+"100 % infectiousness."+newLine+" 100 % lethality. "+newLine+"Transmission through exposed mucous membranes and all bodily fluids."+newLine+" Not airborne or waterborne.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "terminate infected class-D and personnel");
                    Clipboard.Text = ("SCP: The Virus" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: IIII combatives Required and terminate infected" + newLine + "Class-D limit: IIIIII" + newLine + "Level required: Level-III" + newLine + "Alias: The Virus" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_008_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_008;
                }
                else
                {
                    SCP_008_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 2059")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-2059 is to be contained within a modified containment area designed for Class-IV Hostile Amorphous Entities. The unit must comprise a shaft, 40m deep and 15m in diameter, composed of high-gloss steel plating. This plating is to be replaced as need be to maintain a fine polish throughout. The opening of this shaft is to be covered with a shock-proof plexiglass plate that can be removed remotely. Additionally, the containment unit is to be equipped with necessary video and audio surveillance equipment, as well as a speaker system in order to facilitate communication with SCP-2059-1."+newLine+""+newLine+ "Description: SCP-2059 is an autonomous and sentient mass of flesh, bones and organs. The entire mass is seemingly dominated by a large yellow sensory organ that does not correspond to that of any known species. The organ resembles an eye in composition, but further study has shown that it is capable of detecting infrared radiation. SCP-2059 appears capable of rearranging itself at will, but normally it follows a usual composition: the exterior is smooth flesh covering a grid of bones that protect vital organs and brain tissue in the center of the mass. SCP-2059 does not require extraneous sustenance. Any living creature touching SCP-2059 will be absorbed into its mass, but keratinous material (skin, hair and nails) is discarded. At the time of writing, SCP-2059 consists of:");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "No personnel is allowed into scp-2059");
                    Clipboard.Text = ("SCP: Wall Of Flesh" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatives Required and give radio to class-D" + newLine + "Class-D limit: IIIII" + newLine + "Level required: Level-III" + newLine + "Alias: Wall Of Flesh" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_2059_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_2059;
                }
                else
                {
                    SCP_2059_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 198")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-198 is located in a secure room of Site-(classified) with armed guards posted outside to prevent any unauthorized access. SCP-198 is to be stored under 24-hour video surveillance in a sealed and locked case (0.5 m x 0.5 m x 0.5 m) and the key kept in a secured location accessible only to those personnel with Level 3 clearance and above. Under no circumstances are any Foundation personnel to handle SCP-198. All handling of SCP-198 is to be done via remote robotic means or by D-class test subjects only." + newLine+""+newLine+ "Description: SCP-198 has taken numerous forms since coming into Foundation possession in (classified). Since acquisition, SCP-198 has been observed to have had dozens of different forms including a Styrofoam cup, (classified) brand glass beer bottle, (classified) and (classified) brand aluminum soda cans, an oversized shot glass that read “One Tequila, Two Tequila, Three Tequila, Floor”, a plastic water bottle with a █████ label partially peeled off, and [DATA EXPUNGED]. These forms always appear partially filled with the expected liquid a vessel of that type would contain.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Any deviations in weight will indicate a breach and Site Supervisors must immediately enact Containment Protocol 198 detailed below.");
                    Clipboard.Text = ("SCP: The Coffee Mug" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: I combative Required" + newLine + "Class-D limit: III" + newLine + "Level required: Level-III" + newLine + "Alias: The Coffee Mug" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_198_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_198;
                }
                else
                {
                    SCP_198_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 173")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: Item SCP-173 is to be kept in a locked container at all times. When personnel must enter SCP-173's container, no fewer than 3 may enter at any time and the door is to be relocked behind them. At all times, two persons must maintain direct eye contact with SCP-173 until all personnel have vacated and relocked the container."+newLine+""+newLine+ "Description: Moved to Site-19 1993. Origin is as of yet unknown. It is constructed from concrete and rebar with traces of Krylon brand spray paint. SCP-173 is animate and extremely hostile. The object cannot move while within a direct line of sight. Line of sight must not be broken at any time with SCP-173. Personnel assigned to enter container are instructed to alert one another before blinking. Object is reported to attack by snapping the neck at the base of the skull, or by strangulation. In the event of an attack, personnel are to observe Class 4 hazardous object containment procedures.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "All personeel must look at scp 173");
                    Clipboard.Text = ("SCP: The Sculpture" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: III combatives Required" + newLine + "Class-D limit: IIIIII" + newLine + "Level required: Level-II" + newLine + "Alias: The Sculpture" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_173_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_173;
                }
                else
                {
                    SCP_173_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 093")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: See testing document SCP-093-T1 for outline of testing conditions. SCP-093 must remain on a mirror at all times and under video surveillance. Admittance into the area of SCP-093's containment must be authorized only with proper video recording and subject retrieval procedures in place. Any attempt to use SCP-093 outside of an approved test will be dealt with severely, up to and including termination."+newLine+""+newLine+ "Description: SCP-093 is a primarily red disc carved from a stone composite resembling cinnabar, with circular engravings and unknown symbols carved at 0.5 cm depth around the entire object. Deeper cuts are present on SCP-093 with a depth of 1 to 1.5 cm. SCP-093 is 7.62 cm in diameter and fits comfortably into most palms without abrasion. SCP-093 will change hue when held by a living individual. The colors taken by SCP-093 are still being researched to establish a link. Current belief holds that the changes depend upon regrets carried by the holder.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Any attempt to use SCP-093 outside of an approved test will be dealt with severely, up to and including termination.");
                    Clipboard.Text = ("SCP: Red Sea Object" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatives Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: Red Sea Object" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_093_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_093;
                }
                else
                {
                    SCP_093_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 035")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-035 is to be kept within a hermetically sealed glass case, no fewer than 10 centimeters (4 inches) thick. This case is to be contained within a steel, iron and lead-shielded room at all times. Doors are to be triple-locked at all times, with the exception of allowing personnel in or out. No fewer than two (2) armed guards are to be posted at any time. Guards must remain outside at all times and are not allowed within the containment room under any circumstances. A trained psychologist is to remain on site at all times. Research personnel are not to touch SCP-035 at any time. SCP-035 must be moved to a new sealed case every two (2) weeks. The previous case must be disposed of via SCP-101, as it shows no adverse reactions to SCP-035's “corruption”. Anyone who comes into contact with SCP-035 when it is in possession of a host is to be given an immediate psychological evaluation."+newLine+""+newLine+ "Description: SCP-035 appears to be a white porcelain comedy mask, although, at times, it will change to tragedy. In these events, all existing visual records, such as photographs, video footage, even illustrations, of SCP-035 automatically change to reflect its new appearance. A highly corrosive and degenerative viscous liquid constantly seeps from the eye and mouth holes of SCP-035. Anything coming into contact with this substance slowly decays over a period of time, depending on the material, until it has decayed completely into a pool of the original contaminant. Glass seems to react the slowest to the effects of the item, hence the construction choice of its immediate container. Living organisms that come into contact with the substance react much the same way, with no chance of recovery. Origin of the liquid is unknown. Liquid is only visible from the front, and does not emerge or is even visible from the other side.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "To test scp 035 you will need clearance from O5 cause of its potential danger");
                    Clipboard.Text = ("SCP: The Mask" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: Kill SCP" + newLine + "Must: II combatives Required and terminate affected" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-III" + newLine + "Alias: The Mask" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_035_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_035;
                }
                else
                {
                    SCP_035_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 409")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: No physical contact may be made with SCP-409 for any reason. Anything making physical contact with SCP-409 must be contained in quarantine immediately, along with any materials used in the transport of the subject. SCP-409 must be kept in a granite case at all times. Any transportation of SCP-409 must be done in a sealed granite container. Residue from SCP-409's effect are to be sealed in granite containers along with any tools used to transport residue into containers."+newLine+""+newLine+ "Description: SCP-409 resembles a large quartz crystal approximately 1.5m (5ft) tall and 0.6m (2ft) wide. Any objects coming in contact with SCP-409 will begin to crystallize after three hours. This effect will occur in any material other than granite. The crystallization will spread by approximately 2.5cm (1in) per minute, and will convert the entire object or organism, inside and out. Subjects report this effect to be extremely painful, and similar to frostbite. After complete crystallization, the object will begin to make snapping and creaking noises for approximately twenty minutes, before bursting into thousands of fragments with great force.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "No personnel can stand in a 4 meter radius of any affected class-d or scp-409");
                    Clipboard.Text = ("SCP: The Crystal" +newLine+""+ newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" + newLine + "Must: IIII combatives Required" + newLine + "Class-D limit: IIIII" + newLine + "Level required: Level-III" + newLine + "Alias: The Crystal" + newLine + "location: CON-II" + newLine + "Logs:");
                    SCP_409_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_409;
                }
                else
                {
                    SCP_409_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 049")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-049 is contained within a Standard Secure Humanoid Containment Cell in Research Sector-02 at Site-19. SCP-049 must be sedated before any attempts to transport it. During transport, SCP-049 must be secured within a Class III Humanoid Restriction Harness (including a locking collar and extension restraints) and monitored by no fewer than two armed guards. While SCP-049 is generally cooperative with most Foundation personnel, outbursts or sudden changes in behaviour are to be met with elevated force. Under no circumstances should any personnel come into direct contact with SCP-049 during these outbursts.In the event SCP-049 becomes aggressive, the application of lavender (L.multifida) has been shown to produce a calming effect on the entity.Once calmed, SCP-049 generally becomes compliant, and will return to containment with little resistance."+newLine+""+newLine+ "Description: SCP-049 is a humanoid entity, roughly 1.9 meters in height, which bears the appearance of a medieval plague doctor. While SCP-049 appears to be wearing the thick robes and the ceramic mask indicative of that profession, the garments instead seem to have grown out of SCP-049's body over time1, and are now nearly indistinguishable from whatever form is beneath them. X-rays indicate that despite this, SCP-049 does have a humanoid skeletal structure beneath its outer layer.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "No personeel can touch or stand in a 3meter radius to scp-049 cause of instant transformation into his so called cured");
                    Clipboard.Text = ("SCP: The Plague Doctor" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: III combatives Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: The Plague Doctor" + newLine + "location: CON-X" + newLine + "Logs:");
                    SCP_049_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_049;
                }
                else
                {
                    SCP_049_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 017")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-017 is contained in an acrylic glass cage, 100 cm by 50 cm by 50 cm, centrally suspended in a concrete room measuring 6 m by 6 m by 4 m. Attached to the walls, ceiling, and floor of the room are high-intensity arc lamp spotlights pointed directly at the acrylic cage, to ensure that SCP-017 is constantly exposed to light from every angle. Personnel assigned to the SCP-017 control room are to monitor the functionality of the spotlights and the emergency generator system and call for maintenance immediately upon knowledge of a burnt-out lamp or an issue with the generator."+newLine+""+newLine+ "Description: SCP-017 is a humanoid figure approximately 80 centimeters in height, anatomically similar to a small child, but with no discernible identifying features. SCP-017 seems to be composed of a shadowy, smoke-like shroud. No attempt to find any object beneath the shroud has been successful, but the possibility has not been ruled out.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "The only circumstance under which personnel are allowed entrance is to replace lamps. Personnel entering the room are required to wear the designated full-body reflective suits, and must be cautioned not to step in front of functional spotlights.");
                    Clipboard.Text = ("SCP: The Shadow Child" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" + newLine + "Must: IIII combatives Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: The Shadow Child" + newLine + "location: CON-X" + newLine + "Logs:");
                    SCP_017_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_017;
                }
                else
                {
                    SCP_017_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 2006")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-2006 is to be contained at Site 118 in an airtight containment cell. SCP-2006 must be constantly monitored for changes in form, which are to be noted immediately. All personnel coming into contact with SCP-2006 are required to enroll in an acting course with a focus on expressing fear and surprise."+newLine+""+newLine+ "Description: SCP-2006 is an anomalous spherical entity roughly 50 centimeters in diameter when in its default state. SCP-2006's stated goal is to cause feelings of fear and/or horror in as many humans as possible. To accomplish this purpose, SCP-2006 possesses the ability to change its shape, mass, volume, density, chemical structure, and voice to any form that it desires. Currently, there is no known way to damage SCP-2006. The extent of its shape-shifting abilities is unknown, and is currently thought to be unlimited.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Every month, SCP-2006 is to be shown at least one new extremely low-quality horror or science fiction movie containing horror elements. All interaction with SCP-2006 must confirm that SCP-2006 continues to believe that said works demonstrate a superb grasp of horror.");
                    Clipboard.Text = ("SCP: Too Spooky" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatives Required" + newLine + "Class-D limit: IIIIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: Too Spooky" + newLine + "location: CON-X" + newLine + "Logs:");
                    SCP_2006_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_2006;
                }
                else
                {
                    SCP_2006_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 939")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-939-1, -3, -19, -53, -89, -96, -98, -99, and -109 are kept in Cell 1163-A or 1163-B, 10 m x 10 m x 3 m containment chambers within Armed Bio-Containment Area-14. Both cells are environmentally regulated and negatively pressurized, with walls constructed of reinforced concrete. Access to these cells is regulated by an outer decontamination chamber and inner gas-tight steel security doors. Observation windows are constructed of laminated ballistics glass 10 cm in thickness protected by a 100kV electrified mesh. Humidity is maintained at 100% at a temperature of 16° C. Specimens are monitored at all times via infrared cameras. Level Four authorization is required to access SCP-939, their containment areas, or the observation chambers."+newLine+""+newLine+ "Description: SCP-939 are endothermic, pack-based predators which display atrophy of various systems similar to troglobitic organisms. The skins of SCP-939 are highly permeable to moisture and translucent red, owing to a compound chemically similar to hemoglobin. SCP-939 average 2.2 meters tall standing upright and weigh an average of 250 kg, though weight is highly variable. Each of their four limbs end in three-fingered claws with a fourth, opposable digit, and are covered in setae which considerably augment climbing ability. Their heads are elongated, devoid of even vestigial eyes or eye sockets, and contain no brain casing. The jaws of SCP-939 are lined with red, faintly luminescent fang-like teeth, similar to those belonging to specimens of the genus Chauliodus, up to 6 cm in length, and encircled by heat-sensitive pit organs. Eye spots, sensitive to light and dark, run the length of their spined dorsal ridges. These spines may be up to 16 cm long and are believed to be sensitive to changes in air pressure and flow.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Level C Hazmat gear is to be worn by personnel during interactions with SCP-939 specimens and in any areas which SCP-939 have been known to inhabit. Afterward, standard decontamination procedures are to be observed by all personnel involved to ensure no secondary spread of amnestic agents occurs.");
                    Clipboard.Text = ("SCP: With Many Voices" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" + newLine + "Must: IIII combatives Required and II MTF/RRT Required" + newLine + "Class-D limit: IIIIIIIIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: With Many Voices" + newLine + "location: CON-X" + newLine + "Logs:");
                    SCP_939_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_939;
                }
                else
                {
                    SCP_939_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 457")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-457 is to be kept in a 5m x 5m chamber with no less than 22.9cm (9in) of cumulative fireproofing via various materials (asbestos cement, perlite boards) upon all surfaces and a blast-proof observation window with emergency blast shielding installed. The opening to the chamber must consist of at least two temperature-controlled and airtight chambers that may be sealed in case of emergency. SCP-457's chamber should be kept at high humidity with a drainage system installed in the floor, as well as a misting sprinkler system installed and running constantly, and emergency hoses capable of at least 2.1 MPa (300 psi) of water pressure. SCP-457 is allowed a small structure upon the wall of its chamber that remains water-free, but only allows for minimal protection and preservation of form."+newLine+""+newLine+ "Description: For all points and purposes, SCP-457 appears to be a sentient being composed of flame. SCP-457's actual composition is unknown, and has proven to be invisible and undetectable by any known means, but is shaped out by the flames it produces, often assuming a human-like form if given sufficient fuel to assume that size. SCP-457's most rudimentary form appears to be that of a single flame, comparable in size to that of a matchstick. In this form, SCP-457 possesses only the simplest of directives and shows no signs of being unusual compared to any other flame beyond a penchant for suddenly flickering to burn human hands, and the ability to 'jump' to more flammable materials or other flames, which it then assimilates into its total form.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "All personnel entering SCP-457's chamber should be wearing at least Class-A temperature-controlled, flame-retardant sealed suits, and enter in groups of three, with two members equipped with high-grade blast shields and emergency fire extinguishers. Personnel should only enter SCP-457's chamber in order to supply SCP-457 with its daily allotment of fuel material, or to examine and repair any damage to the chamber or sprinkler systems.");
                    Clipboard.Text = ("SCP: The Burning Man" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" + newLine + "Must: II combatives Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: The Burning Man" + newLine + "location: CON-X" + newLine + "Logs:");
                    SCP_457_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_457;
                }
                else
                {
                    SCP_457_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 096")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: SCP-096 is to be contained in its cell, a 5 m x 5 m x 5 m airtight steel cube, at all times. Weekly checks for any cracks or holes are mandatory. There are to be absolutely no video surveillance or optical tools of any kind inside SCP-096's cell. Security personnel will use pre-installed pressure sensors and laser detectors to ensure SCP-096's presence inside the cell."+newLine+""+newLine+ "Description: SCP-096 is a humanoid creature measuring approximately 2.38 meters in height. Subject shows very little muscle mass, with preliminary analysis of body mass suggesting mild malnutrition. Arms are grossly out of proportion with the rest of the subject's body, with an approximate length of 1.5 meters each. Skin is mostly devoid of pigmentation, with no sign of any body hair.SCP - 096's jaw can open to four (4) times the norm of an average human. Other facial features remain similar to an average human, with the exception of the eyes, which are also devoid of pigmentation. It is not yet known whether SCP-096 is blind or not. It shows no signs of any higher brain functions, and is not considered to be sapient.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Any and all photos, video, or recordings of SCP-096's likeness are strictly forbidden without approval from Dr. (classified) and O5-(classified).");
                    Clipboard.Text = ("SCP: Shy Guy" + newLine + "" + newLine + "Threat Level: Euclid" + newLine + "Recontainment method: unknown" + newLine + "Must: III combatives Required and MTF/RRT Required" + newLine + "Class-D limit: INF" + newLine + "Level required: Level-IIII" + newLine + "Alias: Shy Guy" + newLine + "location: Lower CON-X" + newLine + "Logs:");
                    SCP_096_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_096;
                }
                else
                {
                    SCP_096_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 106")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "Special Containment Procedures: No physical interaction with SCP-106 is allowed at any time. All physical interaction must be approved by no less than a two-thirds vote from O5-Command. Any such interaction must be undertaken in AR-II maximum security sites, after a general non-essential staff evacuation. All staff (Research, Security, Class D, etc.) are to remain at least sixty meters away from the containment cell at all times, except in the event of breach events."+newLine+""+newLine+ "Description: SCP-106 appears to be an elderly humanoid, with a general appearance of advanced decomposition. This appearance may vary, but the “rotting” quality is observed in all forms. SCP-106 is not exceptionally agile, and will remain motionless for days at a time, waiting for prey. SCP-106 is also capable of scaling any vertical surface and can remain suspended upside down indefinitely. When attacking, SCP-106 will attempt to incapacitate prey by damaging major organs, muscle groups, or tendons, then pull disabled prey into its pocket dimension. SCP-106 appears to prefer human prey items in the 10-25 years of age bracket.");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "Any corrosion observed on any containment cell surfaces, staff members, or other site locations within two hundred meters of SCP-106 are to be reported to Site Security immediately. Any objects or personnel lost to SCP-106 are to be deemed missing/KIA. No recovery attempts are to be made under any circumstances.");
                    Clipboard.Text = ("SCP: Old Man" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" + newLine + "IIII MTF/RRT Required" + newLine + "Class-D limit: IIII" + newLine + "Level required: Level-IIII" + newLine + "Alias: Old Man" + newLine + "location: Lower CON-X" + newLine + "Logs:");
                    SCP_106_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_106;
                }
                else
                {
                    SCP_106_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 076")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "NO TESTING");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "NO TESTING");
                    Clipboard.Text = ("SCP: Able" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: kill SCP" + newLine + "No testing" + newLine + "Class-D limit: N/A" + newLine + "Logs:");
                    SCP_076_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_076;
                }
                else
                {
                    SCP_076_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
                if (Scp_Selector.Text == "SCP 610")
                {
                    SCP_Info_Box.Text = (Scp_Selector.Text + " " + "info" + newLine + "" + newLine + "NO TESTING");
                    SCP_Rule_Box.Text = (Scp_Selector.Text + " " + "Rules" + newLine + "" + newLine + "NO TESTING");
                    Clipboard.Text = ("SCP 610" + newLine + "" + newLine + "Threat Level: Keter" + newLine + "Recontainment method: unknown" + newLine + "No testing" + newLine + "Class-D limit: N/A" +newLine + "Logs:");
                    SCP_610_Button.BackColor = Color.FromArgb(255, 0, 0);
                    SCP_Picture_Box.Image = SCP_096;
                }
                else
                {
                    SCP_610_Button.BackColor = Color.FromArgb(0, 255, 0);
                };
            };
        }

        private void Scp_number_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SCP_Info_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void SCP_Rule_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void SCP_Picture_Box_Click(object sender, EventArgs e)
        {

        }

        private void Clipboard_Bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clipboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void SCP_148_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 148";
        }

        private void SCP_178_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 178";
        }

        private void SCP_714_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 714";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 1139";
        }

        private void SCP_207_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 207";
        }

        private void SCP_330_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 330";
        }

        private void SCP_999_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 999";
        }

        private void SCP_1025_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 1025";
        }

        private void SCP_224_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 224";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 860";
        }

        private void SCP_517_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 517";
        }

        private void SCP_3250_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 3250";
        }

        private void SCP_1193_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 1193";
        }

        private void SCP_498_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 498";
        }

        private void SCP_1162_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 1162";
        }

        private void SCP_409_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 409";
        }

        private void SCP_093_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 093";
        }

        private void SCP_173_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 173";
        }

        private void SCP_035_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 035";
        }

        private void SCP_087_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 087";
        }

        private void SCP_102_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 120";
        }

        private void SCP_701_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 701";
        }

        private void SCP_2059_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 2059";
        }

        private void SCP_106_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X Lower";
            Scp_Selector.Text = "SCP 106";
        }

        private void SCP_457_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X";
            Scp_Selector.Text = "SCP 457";
        }

        private void SCP_636_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X";
            Scp_Selector.Text = "SCP 939";
        }

        private void SCP_2008_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X";
            Scp_Selector.Text = "SCP 2006";
        }

        private void SCP_017_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X";
            Scp_Selector.Text = "SCP 017";
        }

        private void SCP_096_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X Lower";
            Scp_Selector.Text = "SCP 096";
        }

        private void SCP_610_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X Lower";
            Scp_Selector.Text = "SCP 610";
        }

    private void SCP_076_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X Lower";
            Scp_Selector.Text = "SCP 076";
        }

        private void SCP_008_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 008";
        }

        private void SCP_902_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 902";
        }

        private void SCP_049_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con X";
            Scp_Selector.Text = "SCP 049";
        }

        private void SCP_914_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 914";
        }

        private void SCP_1499_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 1";
            Scp_Selector.Text = "SCP 1499";
        }

        private void SCP_198_Button_Click(object sender, EventArgs e)
        {
            Con_Selector.Text = "Con 2";
            Scp_Selector.Text = "SCP 198";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(Search_box.Text=="3250"||Search_box.Text=="1193"|| Search_box.Text == "860" || Search_box.Text == "999" || Search_box.Text == "120" || Search_box.Text == "1499" || Search_box.Text == "714" || Search_box.Text == "316" || Search_box.Text == "914" || Search_box.Text == "498" || Search_box.Text == "207" || Search_box.Text == "330" || Search_box.Text == "1025" || Search_box.Text == "517" || Search_box.Text == "148" || Search_box.Text == "178" || Search_box.Text == "1139" || Search_box.Text == "087" || Search_box.Text == "224" || Search_box.Text == "902")
            {
                Con_Selector.Text = "Con 1";
                Scp_Selector.Text = ("SCP " + Search_box.Text);
            }
            if(Search_box.Text == "1162" || Search_box.Text == "701" || Search_box.Text == "008" || Search_box.Text == "2059" || Search_box.Text == "198" || Search_box.Text == "173" || Search_box.Text == "093" || Search_box.Text == "035" || Search_box.Text == "409")
            {
                Con_Selector.Text = "Con 2";
                Scp_Selector.Text = ("SCP "+Search_box.Text);
            }
            if (Search_box.Text == "049" || Search_box.Text == "017" || Search_box.Text == "2006" || Search_box.Text == "939" || Search_box.Text == "457")
            {
                Con_Selector.Text = "Con X";
                Scp_Selector.Text = ("SCP " + Search_box.Text);
            }
            if (Search_box.Text == "096" || Search_box.Text == "106" || Search_box.Text == "076" || Search_box.Text == "610")
            {
                Con_Selector.Text = "Con X Lower";
                Scp_Selector.Text = ("SCP " + Search_box.Text);
            }
        }

        private void Clipboar_BG_Click(object sender, EventArgs e)
        {

        }
    }
}
