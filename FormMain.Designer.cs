namespace DirectoryTruncate
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
         textBoxDirectory = new TextBox();
         buttonTruncateFiles = new Button();
         buttonBrowse = new Button();
         progressBar1 = new ProgressBar();
         statusStrip1 = new StatusStrip();
         toolStripStatusLabel1 = new ToolStripStatusLabel();
         textBoxFilter = new TextBox();
         label1 = new Label();
         statusStrip1.SuspendLayout();
         SuspendLayout();
         // 
         // textBoxDirectory
         // 
         textBoxDirectory.Location = new Point(56, 8);
         textBoxDirectory.Name = "textBoxDirectory";
         textBoxDirectory.Size = new Size(448, 23);
         textBoxDirectory.TabIndex = 0;
         // 
         // buttonTruncateFiles
         // 
         buttonTruncateFiles.Location = new Point(432, 72);
         buttonTruncateFiles.Name = "buttonTruncateFiles";
         buttonTruncateFiles.Size = new Size(75, 23);
         buttonTruncateFiles.TabIndex = 1;
         buttonTruncateFiles.Text = "Truncate";
         buttonTruncateFiles.UseVisualStyleBackColor = true;
         buttonTruncateFiles.Click += buttonTruncateFiles_Click;
         // 
         // buttonBrowse
         // 
         buttonBrowse.Location = new Point(8, 8);
         buttonBrowse.Name = "buttonBrowse";
         buttonBrowse.Size = new Size(40, 23);
         buttonBrowse.TabIndex = 2;
         buttonBrowse.Text = "...";
         buttonBrowse.UseVisualStyleBackColor = true;
         buttonBrowse.Click += buttonBrowse_Click;
         // 
         // progressBar1
         // 
         progressBar1.Location = new Point(8, 72);
         progressBar1.Name = "progressBar1";
         progressBar1.Size = new Size(416, 23);
         progressBar1.Style = ProgressBarStyle.Continuous;
         progressBar1.TabIndex = 3;
         // 
         // statusStrip1
         // 
         statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
         statusStrip1.Location = new Point(0, 103);
         statusStrip1.Name = "statusStrip1";
         statusStrip1.Size = new Size(521, 22);
         statusStrip1.TabIndex = 4;
         statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         toolStripStatusLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
         toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         toolStripStatusLabel1.Size = new Size(38, 17);
         toolStripStatusLabel1.Text = "Ready";
         // 
         // textBoxFilter
         // 
         textBoxFilter.Location = new Point(184, 40);
         textBoxFilter.Name = "textBoxFilter";
         textBoxFilter.Size = new Size(320, 23);
         textBoxFilter.TabIndex = 5;
         // 
         // label1
         // 
         label1.Location = new Point(8, 40);
         label1.Name = "label1";
         label1.Size = new Size(172, 23);
         label1.TabIndex = 6;
         label1.Text = "Only filesnames containing:";
         label1.TextAlign = ContentAlignment.MiddleRight;
         // 
         // FormMain
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(521, 125);
         Controls.Add(label1);
         Controls.Add(textBoxFilter);
         Controls.Add(statusStrip1);
         Controls.Add(progressBar1);
         Controls.Add(buttonBrowse);
         Controls.Add(buttonTruncateFiles);
         Controls.Add(textBoxDirectory);
         Icon = (Icon)resources.GetObject("$this.Icon");
         Name = "FormMain";
         Text = "Directory Truncater";
         statusStrip1.ResumeLayout(false);
         statusStrip1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox textBoxDirectory;
      private Button buttonTruncateFiles;
      private Button buttonBrowse;
      private ProgressBar progressBar1;
      private StatusStrip statusStrip1;
      private ToolStripStatusLabel toolStripStatusLabel1;
      private TextBox textBoxFilter;
      private Label label1;
   }
}
