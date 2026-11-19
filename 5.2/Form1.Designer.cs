namespace BackupApp
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            txtSourcePath = new TextBox();
            txtDestPath = new TextBox();
            btnSelectSource = new Button();
            btnSelectDest = new Button();
            btnBackup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Menbe Qovlugu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Teyinat Qovlugu";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 305);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(41, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Netice";
            // 
            // txtSourcePath
            // 
            txtSourcePath.Location = new Point(12, 58);
            txtSourcePath.Name = "txtSourcePath";
            txtSourcePath.Size = new Size(776, 23);
            txtSourcePath.TabIndex = 3;
            // 
            // txtDestPath
            // 
            txtDestPath.Location = new Point(12, 171);
            txtDestPath.Name = "txtDestPath";
            txtDestPath.Size = new Size(776, 23);
            txtDestPath.TabIndex = 4;
            // 
            // btnSelectSource
            // 
            btnSelectSource.Location = new Point(12, 99);
            btnSelectSource.Name = "btnSelectSource";
            btnSelectSource.Size = new Size(776, 23);
            btnSelectSource.TabIndex = 5;
            btnSelectSource.Text = "Sec";
            btnSelectSource.UseVisualStyleBackColor = true;
            // 
            // btnSelectDest
            // 
            btnSelectDest.Location = new Point(12, 211);
            btnSelectDest.Name = "btnSelectDest";
            btnSelectDest.Size = new Size(776, 23);
            btnSelectDest.TabIndex = 6;
            btnSelectDest.Text = "Sec";
            btnSelectDest.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(12, 257);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(776, 23);
            btnBackup.TabIndex = 7;
            btnBackup.Text = "Ehtiyyat Nusxe Yarat";
            btnBackup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackup);
            Controls.Add(btnSelectDest);
            Controls.Add(btnSelectSource);
            Controls.Add(txtDestPath);
            Controls.Add(txtSourcePath);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResult;
        private TextBox txtSourcePath;
        private TextBox txtDestPath;
        private Button btnSelectSource;
        private Button btnSelectDest;
        private Button btnBackup;
    }
}
