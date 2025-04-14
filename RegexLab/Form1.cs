using RegexLab.Models;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RegexLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Initialize UI components
        }

        // Pattern storage for default and custom sets
        private List<RegexPattern> defaultPatterns = new();
        private List<RegexPattern> customPatterns = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDefaultPatterns(); // Load default pattern set from JSON
            LoadCustomPatterns();  // Load user-saved custom patterns
            LoadPatternList();     // Populate pattern combo box (default initially)
        }

        // Applies light or dark theme to the UI
        private void ApplyTheme(bool dark)
        {
            Color backColor = dark ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            Color foreColor = dark ? Color.White : SystemColors.ControlText;

            this.BackColor = backColor;

            foreach (Control ctrl in this.Controls)
            {
                ApplyThemeRecursive(ctrl, backColor, foreColor); // Recursively apply to child controls
            }
        }

        // Recursively apply theme colors to child controls
        private void ApplyThemeRecursive(Control ctrl, Color back, Color fore)
        {
            ctrl.BackColor = back;
            ctrl.ForeColor = fore;

            foreach (Control child in ctrl.Controls)
            {
                ApplyThemeRecursive(child, back, fore);
            }
        }

        // Loads default regex patterns from file
        private void LoadDefaultPatterns()
        {
            string path = "default_patterns.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                defaultPatterns = JsonSerializer.Deserialize<List<RegexPattern>>(json);
            }
        }

        // Loads user-saved custom regex patterns from file
        private void LoadCustomPatterns()
        {
            string path = "saved_patterns.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                customPatterns = JsonSerializer.Deserialize<List<RegexPattern>>(json);
            }
        }

        // Populates the pattern selection combo box
        private void LoadPatternList()
        {
            cmbPatterns.Items.Clear();

            var patterns = rbtnDefault.Checked ? defaultPatterns : customPatterns;

            foreach (var pattern in patterns)
            {
                cmbPatterns.Items.Add(pattern.Title);
            }

            if (cmbPatterns.Items.Count > 0)
                cmbPatterns.SelectedIndex = 0;
        }

        // Runs regex match and displays results
        private void btnTest_Click(object sender, EventArgs e)
        {
            txtOutputText.Clear();
            lblMatchCount.Text = "Matches: 0";

            string pattern = txtRegex.Text.Trim();
            string inputText = txtInputText.Text;

            if (string.IsNullOrWhiteSpace(pattern) || string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please enter both regex pattern and input text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(inputText);

                if (matches.Count == 0)
                {
                    txtOutputText.Text = "No matches found.";
                    return;
                }

                List<string> matchList = matches.Cast<Match>().Select(m => m.Value).ToList();

                // 🔧 Trim spaces if enabled
                if (menuTrimSpaces.Checked)
                    matchList = matchList.Select(m => m.Trim()).ToList();

                // 🔡 Ignore case: normalize to lowercase then filter duplicates
                if (menuIgnoreCase.Checked)
                    matchList = matchList.Select(m => m.ToLower()).Distinct().ToList();

                // 🔁 Remove duplicate matches (case-sensitive)
                if (menuDuplicateFilter.Checked && !menuIgnoreCase.Checked)
                    matchList = matchList.Distinct().ToList();

                // 🔤 Sort results alphabetically
                if (menuSortAlphabetically.Checked)
                    matchList = matchList.OrderBy(m => m).ToList();

                // Display the final results
                txtOutputText.Text = string.Join(Environment.NewLine, matchList);
                lblMatchCount.Text = $"Matches: {matchList.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid regex pattern.\n" + ex.Message, "Regex Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears input, output and match count
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputText.Clear();
            txtOutputText.Clear();
            lblMatchCount.Text = "Matches: 0";
        }

        // Opens the pattern save form with current regex pattern
        private void btnSavePattern_Click(object sender, EventArgs e)
        {
            string currentPattern = txtRegex.Text;

            if (string.IsNullOrWhiteSpace(currentPattern))
            {
                MessageBox.Show("Regex pattern is empty.");
                return;
            }

            SavePatternForm form = new SavePatternForm(currentPattern);
            form.ShowDialog();
        }

        // Reloads default pattern list when selected
        private void rbtnDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDefault.Checked)
                LoadPatternList();
        }

        // Reloads custom pattern list when selected
        private void rbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCustom.Checked)
                LoadPatternList();
        }

        // Loads pattern content into the regex input box

        private void cmbPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbPatterns.SelectedIndex;
            if (index < 0) return;

            var selected = rbtnDefault.Checked ? defaultPatterns[index] : customPatterns[index];
            txtRegex.Text = selected.Pattern;

        }

        // Saves output to file as .txt or .json
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutputText.Text))
            {
                MessageBox.Show("There is no data to save.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Results";
            saveDialog.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json";
            saveDialog.FileName = "regex_results";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                try
                {
                    if (Path.GetExtension(path).ToLower() == ".json")
                    {
                        var matches = txtOutputText.Text
                            .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

                        var exportObj = new
                        {
                            pattern = txtRegex.Text,
                            matches = matches,
                            total = matches.Count
                        };

                        string json = JsonSerializer.Serialize(exportObj, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(path, json);
                    }
                    else
                    {
                        File.WriteAllText(path, txtOutputText.Text);
                    }

                    MessageBox.Show("Results saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save file:\n" + ex.Message);
                }
            }
        }

        // Shows tooltip with pattern description and tags
        private void lblPatternInfo_MouseHover(object sender, EventArgs e)
        {
            int index = cmbPatterns.SelectedIndex;
            if (index < 0) return;

            var selected = rbtnDefault.Checked ? defaultPatterns[index] : customPatterns[index];

            string info =
                $"{selected.Title}\n" +
                $"{selected.Description}\n" +
                $"Tags: {string.Join(", ", selected.Tags)}";

            toolTip1.SetToolTip(lblPatternInfo, info);
        }

        // Loads a text file into the input text area
        private void menuOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Text File";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    txtInputText.Text = fileContent;

                    MessageBox.Show("File loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load file:\n" + ex.Message);
                }
            }
        }

        // Handles dark theme toggle
        private void menuDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            ApplyTheme(menuDarkTheme.Checked);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutputText.Text))
            {
                MessageBox.Show("There is no data to save.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Results";
            saveDialog.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json";
            saveDialog.FileName = "regex_results";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                try
                {
                    if (Path.GetExtension(path).ToLower() == ".json")
                    {
                        var matches = txtOutputText.Text
                            .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

                        var exportObj = new
                        {
                            pattern = txtRegex.Text,
                            matches = matches,
                            total = matches.Count
                        };

                        string json = JsonSerializer.Serialize(exportObj, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(path, json);
                    }
                    else
                    {
                        File.WriteAllText(path, txtOutputText.Text);
                    }

                    MessageBox.Show("Results saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save file:\n" + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        // Gets the control that currently has focus and is a TextBoxBase (TextBox, RichTextBox etc.)
        private TextBoxBase GetFocusedTextBox()
        {
            return this.ActiveControl as TextBoxBase;
        }

        private void menuUndo_Click(object sender, EventArgs e)
        {
            var tb = GetFocusedTextBox();
            if (tb != null && tb.CanUndo)
                tb.Undo(); // Undo last action
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            var tb = GetFocusedTextBox();
            if (tb != null && tb.SelectedText.Length > 0)
                tb.Cut(); // Cuts selected text
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            var tb = GetFocusedTextBox();
            if (tb != null && tb.SelectedText.Length > 0)
                tb.Copy(); // Copies selected text
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            var tb = GetFocusedTextBox();
            if (tb != null && Clipboard.ContainsText())
                tb.Paste(); // Pastes clipboard text
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            var tb = GetFocusedTextBox();
            if (tb != null)
                tb.SelectAll(); // Selects all text in the focused box
        }
        private void menuHowToUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Enter or paste the input text into the left box.\n" +
                "2. Enter a regex pattern manually or select from the list.\n" +
                "3. Click 'Test Regex' to extract matches.\n" +
                "4. Use the right box to view/export filtered results.",
                "How to Use",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuRegexReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Common Regex Symbols:\n\n" +
                ".  → any character\n" +
                "\\d → digit (0-9)\n" +
                "\\w → word character\n" +
                "\\s → whitespace\n" +
                "^  → start of line\n" +
                "$  → end of line\n" +
                "*  → 0 or more times\n" +
                "+  → 1 or more times\n" +
                "?  → optional\n" +
                "[abc] → match a, b, or c\n" +
                "(...) → group\n",
                "Regex Reference",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Zulwatha/RegexLab", // GitHub adress
                UseShellExecute = true
            });
        }

        private void menuCheckForUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "You're using the latest version of RegexLab.\n\nNo updates are available at this time.",
                "Check for Updates",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "RegexLab v1.0\n\nDeveloped by: [Your Name]\nGitHub: github.com/yourusername\n\nA smart regex testing and filtering tool built with ❤️ in C#.",
                "About RegexLab",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }



        private void customPatternsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SavePatternForm form = new SavePatternForm();
            form.ShowDialog();

        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            var tb = GetFocusedTextBox();
            if (tb != null)
                tb.SelectAll(); // Selects all text in the focused box
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Show context menu just below the button
            menuExportOptions.Show(btnExport, new Point(0, btnExport.Height));
        }

        private void menuExportSave_Click(object sender, EventArgs e)
        {
            // Check if there is any output to save
            if (string.IsNullOrWhiteSpace(txtOutputText.Text))
            {
                MessageBox.Show("There is no data to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show Save File Dialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Output";
            saveDialog.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json";
            saveDialog.FileName = "regex_results";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                try
                {
                    // If JSON format is selected
                    if (Path.GetExtension(path).ToLower() == ".json")
                    {
                        var matches = txtOutputText.Text
                            .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

                        var exportObj = new
                        {
                            pattern = txtRegex.Text,
                            matches = matches,
                            total = matches.Count
                        };

                        string json = JsonSerializer.Serialize(exportObj, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(path, json);
                    }
                    else // Save as plain .txt
                    {
                        File.WriteAllText(path, txtOutputText.Text);
                    }

                    MessageBox.Show("Output saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuExportCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutputText.Text))
            {
                MessageBox.Show("There is no output to copy.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Clipboard.SetText(txtOutputText.Text); // Copy output text to clipboard
            MessageBox.Show("Output copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}
