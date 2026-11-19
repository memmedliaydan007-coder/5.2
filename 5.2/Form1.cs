using System;
using System.IO;
using System.Windows.Forms;

namespace BackupApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtSourcePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDestPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string sourceDir = txtSourcePath.Text.Trim();
            string destDir = txtDestPath.Text.Trim();

            if (string.IsNullOrEmpty(sourceDir) || string.IsNullOrEmpty(destDir))
            {
                MessageBox.Show("Zəhmət olmasa həm mənbə, həm də təyinat qovluğunu daxil edin.", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("Xəta: Göstərilən mənbə qovluğu mövcud deyil!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(destDir))
            {
                Directory.CreateDirectory(destDir);
            }

            string[] txtFiles = Directory.GetFiles(sourceDir, "*.txt");
            int copiedCount = 0;
            long totalSize = 0;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            foreach (string filePath in txtFiles)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                string newFileName = $"{currentDate}_{fileInfo.Name}";
                string destFilePath = Path.Combine(destDir, newFileName);

                File.Copy(filePath, destFilePath, true);

                copiedCount++;
                totalSize += fileInfo.Length;
            }

            lblResult.Text = $"Əməliyyat tamamlandı!\nKopyalanan fayl sayı: {copiedCount}\nÜmumi ölçü: {totalSize} bayt";
        }
    }
}
