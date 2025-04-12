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
        }

        // Handles saving the new pattern to the custom patterns JSON
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate that title and description are provided
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Create new RegexPattern object with user input
            RegexPattern pattern = new RegexPattern
            {
                Title = txtTitle.Text.Trim(),
                Pattern = patternText, // Regex pattern passed from main form
                Description = txtDescription.Text.Trim(),
                Tags = txtTags.Text.Split(',').Select(t => t.Trim()).Where(t => t != "").ToList() // Parse comma-separated tags
            };

            string filePath = "saved_patterns.json";
            List<RegexPattern> patterns = new();

            // If file exists, load existing patterns from it
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                patterns = JsonSerializer.Deserialize<List<RegexPattern>>(existingJson);
            }

            // Add new pattern to the list and save back to file
            patterns.Add(pattern);
            string newJson = JsonSerializer.Serialize(patterns, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, newJson);

            MessageBox.Show("Pattern saved successfully!");
            this.Close(); // Close the save form
        }
    }
}