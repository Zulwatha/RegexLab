using RegexLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexLab
{
    public partial class SavePatternForm : Form
    {
        // Default constructor
        public SavePatternForm()
        {
            InitializeComponent();
        }

        // Stores the regex pattern passed from the main form
        private string patternText;

        // Constructor that receives the current regex pattern
        public SavePatternForm(string pattern)
        {
            InitializeComponent();
            patternText = pattern;
        }

        // Loads the form and displays the current pattern in read-only box
        private void SavePatternForm_Load(object sender, EventArgs e)
        {
            txtPatternDisplay.Text = patternText;
            LoadPatternsToList();

        }
        private void LoadPatternsToList()
        {
            lstPatterns.Items.Clear();

            string path = "saved_patterns.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                var patterns = JsonSerializer.Deserialize<List<RegexPattern>>(json);
                foreach (var p in patterns)
                {
                    lstPatterns.Items.Add(p.Title);
                }
            }
        }

        // Handles saving the new pattern to the custom patterns JSON
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtPatternDisplay.Text))
            {
                MessageBox.Show("Title and Pattern are required.");
                return;
            }

            var newPattern = new RegexPattern
            {
                Title = txtTitle.Text.Trim(),
                Pattern = txtPatternDisplay.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Tags = txtTags.Text.Split(',').Select(t => t.Trim()).Where(t => !string.IsNullOrWhiteSpace(t)).ToList()
            };

            string path = "saved_patterns.json";
            List<RegexPattern> patterns = new();

            if (File.Exists(path))
            {
                string existingJson = File.ReadAllText(path);
                patterns = JsonSerializer.Deserialize<List<RegexPattern>>(existingJson);
            }

            patterns.Add(newPattern);
            File.WriteAllText(path, JsonSerializer.Serialize(patterns, new JsonSerializerOptions { WriteIndented = true }));

            LoadPatternsToList();
            MessageBox.Show("New pattern saved!");
        }


        private void lstPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstPatterns.SelectedIndex;
            if (index < 0) return;

            string path = "saved_patterns.json";
            var json = File.ReadAllText(path);
            var patterns = JsonSerializer.Deserialize<List<RegexPattern>>(json);

            var selected = patterns[index];

            txtTitle.Text = selected.Title;
            txtPatternDisplay.Text = selected.Pattern;
            txtDescription.Text = selected.Description;
            txtTags.Text = string.Join(", ", selected.Tags);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstPatterns.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a pattern to update.");
                return;
            }

            string path = "saved_patterns.json";
            var json = File.ReadAllText(path);
            var patterns = JsonSerializer.Deserialize<List<RegexPattern>>(json);

            patterns[index] = new RegexPattern
            {
                Title = txtTitle.Text.Trim(),
                Pattern = txtPatternDisplay.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Tags = txtTags.Text.Split(',').Select(t => t.Trim()).Where(t => !string.IsNullOrWhiteSpace(t)).ToList()
            };

            File.WriteAllText(path, JsonSerializer.Serialize(patterns, new JsonSerializerOptions { WriteIndented = true }));
            LoadPatternsToList();
            MessageBox.Show("Pattern updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstPatterns.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a pattern to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this pattern?",
                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string path = "saved_patterns.json";
            var json = File.ReadAllText(path);
            var patterns = JsonSerializer.Deserialize<List<RegexPattern>>(json);

            patterns.RemoveAt(index);
            File.WriteAllText(path, JsonSerializer.Serialize(patterns, new JsonSerializerOptions { WriteIndented = true }));
            LoadPatternsToList();
            txtTitle.Clear();
            txtPatternDisplay.Clear();
            txtDescription.Clear();
            txtTags.Clear();
            MessageBox.Show("Pattern deleted.");
        }

    }
}