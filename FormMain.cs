namespace DirectoryTruncate
{
   public partial class FormMain : Form
   {
      public FormMain()
      {
         InitializeComponent();
      }

      private void buttonTruncateFiles_Click(object sender, EventArgs e)
      {
         string directoryPath = textBoxDirectory.Text;
         string msg = "";

         if (string.IsNullOrWhiteSpace(directoryPath) || !Directory.Exists(directoryPath))
         {
            MessageBox.Show("Please enter a valid directory path.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         }

         try
         {
            var files = Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories);

            progressBar1.Minimum = 0;
            int count = progressBar1.Maximum = files.Count();

            foreach (var file in files)
            {
               try
               {
                  using (var fs = new FileStream(file, FileMode.Truncate))
                  {
                     // Truncates the file to zero length.
                  }
                  progressBar1.Value += 1;
                  toolStripStatusLabel1.Text = file.Replace(directoryPath, "");
                  Application.DoEvents();

               }
               catch (Exception ex)
               {
                  // You can log the file and the exception if needed.
                  MessageBox.Show($"Failed to truncate file: {file}\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }

            msg = $"All {count} files have been truncated to zero bytes";
         }
         catch (Exception ex)
         {
            msg = $"An error occurred: {ex.Message}";
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         progressBar1.Value = 0;
         toolStripStatusLabel1.Text = msg;
      }

      private void buttonBrowse_Click(object sender, EventArgs e)
      {
         using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
         {
            folderDialog.Description = "Select a folder to truncate files in";
            folderDialog.ShowNewFolderButton = false;

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
               textBoxDirectory.Text = folderDialog.SelectedPath;
            }
         }
      }
   }
}
