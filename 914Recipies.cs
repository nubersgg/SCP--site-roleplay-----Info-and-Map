using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scp_Map
{
    public partial class _914Recipies : Form
    {
        private readonly Dictionary<string, List<Item>> modesData = new Dictionary<string, List<Item>>();
        private readonly List<Combination> combinations = new List<Combination>();

        public _914Recipies()
        {
            InitializeComponent();

            // Initialize data (you can load this from your actual data source)
            InitializeData();

            // Initialize UI
            InitializeComboBoxes();
        }

        private void InitializeData()
        {
            // Populate modesData with your data
            modesData.Add("Top Boxes", new List<Item>
            {
                new Item { Name = "Better Medkit", Rough = "Medkit", OneToOne = "Pizza", Fine = "Medkit", VeryFine = "Random" },
                new Item { Name = "Blowtorch", Rough = "Coffee", OneToOne = "Crowbar", Fine = "Flashlight / Hacking Device", VeryFine = "Wall Patch" },
                // ... (continue with other items in the 'Top Boxes' mode)
            });

            modesData.Add("Weaponry", new List<Item>
            {
                new Item { Name = "AK74", Rough = "Random", OneToOne = "Random", Fine = "Random", VeryFine = "Random" },
                new Item { Name = "Desert Eagle", Rough = "Coffee", OneToOne = "G17", Fine = "MP5SD", VeryFine = "Green Food" },
                // ... (continue with other items in the 'Weaponry' mode)
            });

            // Populate combinations with your data
            combinations.Add(new Combination { Source = "Colored Food (Any)", Target = "Crowbar", Result = "Very Fine" });
            combinations.Add(new Combination { Source = "Top Boxes", Target = "Blowtorch", Result = "Flashlight / Hacking Device" });
            // Add more combinations as needed
        }

        private void InitializeComboBoxes()
        {
            // Clear items in combo boxes
            sourceComboBox.Items.Clear();
            targetComboBox.Items.Clear();

            // Populate combo boxes with available item names
            foreach (var mode in modesData.Values)
            {
                foreach (var item in mode)
                {
                    sourceComboBox.Items.Add(item.Name);
                    targetComboBox.Items.Add(item.Name);
                }
            }

            // Set default selected index
            sourceComboBox.SelectedIndex = 0;
            targetComboBox.SelectedIndex = 0;
        }

        private void generatePathButton_Click(object sender, EventArgs e)
        {
            string sourceItem = sourceComboBox.SelectedItem.ToString();
            string targetItem = targetComboBox.SelectedItem.ToString();

            string path = GeneratePath(sourceItem, targetItem);
            resultLabel.Text = path;
        }

        private string GeneratePath(string sourceItem, string targetItem)
        {
            List<string> pathComponents = new List<string>();

            // Find the path from sourceItem to targetItem
            FindPath(sourceItem, targetItem, pathComponents);

            // Build the result string
            string path = string.Join(" + ", pathComponents);
            return path.Length > 0 ? path : $"No path found from {sourceItem} to {targetItem}";
        }

        private bool FindPath(string current, string target, List<string> pathComponents)
        {
            // Base case: we found the target item
            if (current == target)
            {
                pathComponents.Add(target);
                return true;
            }

            // Check each combination for a match
            foreach (var combo in combinations)
            {
                if (combo.Source == current && FindPath(combo.Result, target, pathComponents))
                {
                    // We found a path, add the current item to the components
                    pathComponents.Insert(0, current + " + " + combo.Result);
                    return true;
                }
            }

            return false;
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Rough { get; set; }
        public string OneToOne { get; set; }
        public string Fine { get; set; }
        public string VeryFine { get; set; }
    }

    public class Combination
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public string Result { get; set; }
    }
}
