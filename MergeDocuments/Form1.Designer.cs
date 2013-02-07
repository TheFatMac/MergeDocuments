namespace MergeDocuments
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          this.docs_to_merge_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
          this.select_folder_button = new System.Windows.Forms.Button();
          this.merge_button = new System.Windows.Forms.Button();
          this.folder_to_merge_textBox = new System.Windows.Forms.TextBox();
          this.label1 = new System.Windows.Forms.Label();
          this.new_document_name_textBox = new System.Windows.Forms.TextBox();
          this.label2 = new System.Windows.Forms.Label();
          this.SuspendLayout();
          // 
          // docs_to_merge_folderBrowserDialog
          // 
          this.docs_to_merge_folderBrowserDialog.SelectedPath = global::MergeDocuments.Properties.Settings.Default.previous_directory;
          // 
          // select_folder_button
          // 
          this.select_folder_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.select_folder_button.Location = new System.Drawing.Point(605, 62);
          this.select_folder_button.Name = "select_folder_button";
          this.select_folder_button.Size = new System.Drawing.Size(130, 26);
          this.select_folder_button.TabIndex = 0;
          this.select_folder_button.Text = "Select Folder";
          this.select_folder_button.UseVisualStyleBackColor = true;
          this.select_folder_button.Click += new System.EventHandler(this.select_folder_button_Click);
          // 
          // merge_button
          // 
          this.merge_button.BackColor = System.Drawing.SystemColors.Control;
          this.merge_button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.merge_button.Location = new System.Drawing.Point(311, 98);
          this.merge_button.Name = "merge_button";
          this.merge_button.Size = new System.Drawing.Size(130, 26);
          this.merge_button.TabIndex = 3;
          this.merge_button.Text = "Merge Documents";
          this.merge_button.UseVisualStyleBackColor = true;
          this.merge_button.Click += new System.EventHandler(this.merge_button_Click);
          // 
          // folder_to_merge_textBox
          // 
          this.folder_to_merge_textBox.BackColor = System.Drawing.Color.White;
          this.folder_to_merge_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.folder_to_merge_textBox.Location = new System.Drawing.Point(11, 34);
          this.folder_to_merge_textBox.Name = "folder_to_merge_textBox";
          this.folder_to_merge_textBox.ReadOnly = true;
          this.folder_to_merge_textBox.Size = new System.Drawing.Size(724, 22);
          this.folder_to_merge_textBox.TabIndex = 1;
          this.folder_to_merge_textBox.WordWrap = false;
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label1.Location = new System.Drawing.Point(12, 9);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(293, 18);
          this.label1.TabIndex = 3;
          this.label1.Text = "Folder with Documents to be merged:";
          // 
          // new_document_name_textBox
          // 
          this.new_document_name_textBox.BackColor = System.Drawing.Color.White;
          this.new_document_name_textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.new_document_name_textBox.Location = new System.Drawing.Point(11, 101);
          this.new_document_name_textBox.Name = "new_document_name_textBox";
          this.new_document_name_textBox.Size = new System.Drawing.Size(294, 22);
          this.new_document_name_textBox.TabIndex = 2;
          this.new_document_name_textBox.WordWrap = false;
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label2.Location = new System.Drawing.Point(12, 80);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(227, 18);
          this.label2.TabIndex = 5;
          this.label2.Text = "Name for Merged Document:";
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(747, 138);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.new_document_name_textBox);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.folder_to_merge_textBox);
          this.Controls.Add(this.merge_button);
          this.Controls.Add(this.select_folder_button);
          this.MaximizeBox = false;
          this.Name = "Form1";
          this.ShowIcon = false;
          this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Merge Word Documents";
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog docs_to_merge_folderBrowserDialog;
        private System.Windows.Forms.Button select_folder_button;
        private System.Windows.Forms.Button merge_button;
        private System.Windows.Forms.TextBox folder_to_merge_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_document_name_textBox;
        private System.Windows.Forms.Label label2;
    }
}

