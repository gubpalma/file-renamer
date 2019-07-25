using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class MainForm : Form
    {
        private string _sourceFolder;
        private ICollection<string> _sourcePaths;
        private ICollection<string> _previewPaths;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            var result = fbdSource.ShowDialog();

            if (result == DialogResult.OK)
            {
                _sourceFolder = fbdSource.SelectedPath;
                LoadPaths(_sourceFolder);
            }
            else
            {
                _sourceFolder = string.Empty;
                tbxSource.Text = _sourceFolder;
                lvwSource.Clear();
            }
        }

        private void LoadPaths(string path)
        {
            _sourcePaths = GetFiles(path);
            _previewPaths = GetFiles(path);

            tbxSource.Text = path;

            ShowPaths(lvwSource, _sourcePaths);
            ShowPaths(lvwPreview, _sourcePaths);
        }

        private static ICollection<string> GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        private static void ShowPaths(ListView listView, IEnumerable<string> paths)
        {
            listView.Items.Clear();
            listView.Items.AddRange(
                paths
                    .Select(i => new ListViewItem { Text = i })
                    .ToArray());
        }

        private static IEnumerable<string> PerformDisplayReplace(IEnumerable<string> paths, string regexValue, string replacementValue)
        {
            var output = new List<string>();

            if (!IsValidRegex(regexValue))
                return output;

            var regex = new Regex(regexValue);

            foreach (var path in paths ?? new List<string>())
            {
                var replacedFileName = regex.Replace(Path.GetFileName(path), replacementValue);

                output.Add($"{Path.GetDirectoryName(path)}\\{replacedFileName}");
            }

            return output;
        }

        private void PerformActualReplace(IEnumerable<string> paths, string regexValue, string replacementValue)
        {
            try
            {
                btnGo.BackColor = Color.YellowGreen;

                var output = new List<string>();

                if (!IsValidRegex(regexValue))
                    return;

                var regex = new Regex(regexValue);

                foreach (var path in paths ?? new List<string>())
                {
                    var replacedFileName = regex.Replace(Path.GetFileName(path), replacementValue);

                    if (output.Contains(replacedFileName))
                        throw new Exception("This replace would create multiple files of the same name.");

                    output.Add(replacedFileName);
                }

                foreach (var path in paths ?? new List<string>())
                {
                    var replacedFileName = regex.Replace(Path.GetFileName(path), replacementValue);

                    File.Move(path, $"{Path.GetDirectoryName(path)}\\{replacedFileName}");
                }
            }
            catch (Exception e)
            {
                erpGeneral.SetError(btnGo, e.Message);
                btnGo.BackColor = Color.Red;
            }
            finally
            {
                LoadPaths(_sourceFolder);
            }
        }

        private static bool IsValidRegex(string regexValue)
        {
            if (string.IsNullOrEmpty(regexValue))
                return false;

            try
            {
                var regex = new Regex(regexValue);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        private void TbxRegex_TextChanged(object sender, EventArgs e)
        {
            tbxRegex.ForeColor = IsValidRegex(tbxRegex.Text) ? Color.Black : Color.Red;
            DisplayReplaced();
        }

        private void TbxReplacement_TextChanged(object sender, EventArgs e) => DisplayReplaced();
        private void DisplayReplaced() => ShowPaths(lvwPreview, PerformDisplayReplace(_previewPaths, tbxRegex.Text, tbxReplacement.Text));
        private void BtnGo_Click(object sender, EventArgs e) => PerformActualReplace(_sourcePaths, tbxRegex.Text, tbxReplacement.Text);
    }
}
