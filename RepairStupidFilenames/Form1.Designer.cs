namespace RepairStupidFilenames
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
			this.buttonAnalyze = new System.Windows.Forms.Button();
			this.labelFolderHint = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonAccept = new System.Windows.Forms.Button();
			this.listViewPreview = new System.Windows.Forms.ListView();
			this.columnHeaderOld = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxPrefix = new System.Windows.Forms.TextBox();
			this.labelPrefixHint = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonAnalyze
			// 
			this.buttonAnalyze.Location = new System.Drawing.Point(55, 96);
			this.buttonAnalyze.Name = "buttonAnalyze";
			this.buttonAnalyze.Size = new System.Drawing.Size(75, 23);
			this.buttonAnalyze.TabIndex = 0;
			this.buttonAnalyze.Text = "Analyze";
			this.buttonAnalyze.UseVisualStyleBackColor = true;
			this.buttonAnalyze.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelFolderHint
			// 
			this.labelFolderHint.AutoSize = true;
			this.labelFolderHint.Location = new System.Drawing.Point(12, 28);
			this.labelFolderHint.Name = "labelFolderHint";
			this.labelFolderHint.Size = new System.Drawing.Size(64, 13);
			this.labelFolderHint.TabIndex = 1;
			this.labelFolderHint.Text = "File or folder";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(82, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(190, 20);
			this.textBox1.TabIndex = 2;
			// 
			// buttonAccept
			// 
			this.buttonAccept.Location = new System.Drawing.Point(183, 161);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(75, 23);
			this.buttonAccept.TabIndex = 4;
			this.buttonAccept.Text = "Accept";
			this.buttonAccept.UseVisualStyleBackColor = true;
			this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
			// 
			// listViewPreview
			// 
			this.listViewPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOld,
            this.columnHeaderNew});
			this.listViewPreview.FullRowSelect = true;
			this.listViewPreview.GridLines = true;
			this.listViewPreview.HideSelection = false;
			this.listViewPreview.Location = new System.Drawing.Point(295, 12);
			this.listViewPreview.Name = "listViewPreview";
			this.listViewPreview.Size = new System.Drawing.Size(677, 485);
			this.listViewPreview.TabIndex = 5;
			this.listViewPreview.UseCompatibleStateImageBehavior = false;
			this.listViewPreview.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderOld
			// 
			this.columnHeaderOld.Text = "Old";
			this.columnHeaderOld.Width = 298;
			// 
			// columnHeaderNew
			// 
			this.columnHeaderNew.Text = "New";
			this.columnHeaderNew.Width = 312;
			// 
			// textBoxPrefix
			// 
			this.textBoxPrefix.Location = new System.Drawing.Point(97, 52);
			this.textBoxPrefix.Name = "textBoxPrefix";
			this.textBoxPrefix.Size = new System.Drawing.Size(175, 20);
			this.textBoxPrefix.TabIndex = 6;
			// 
			// labelPrefixHint
			// 
			this.labelPrefixHint.AutoSize = true;
			this.labelPrefixHint.Location = new System.Drawing.Point(12, 55);
			this.labelPrefixHint.Name = "labelPrefixHint";
			this.labelPrefixHint.Size = new System.Drawing.Size(79, 13);
			this.labelPrefixHint.TabIndex = 1;
			this.labelPrefixHint.Text = "Prefix (optional)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 509);
			this.Controls.Add(this.textBoxPrefix);
			this.Controls.Add(this.listViewPreview);
			this.Controls.Add(this.buttonAccept);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelPrefixHint);
			this.Controls.Add(this.labelFolderHint);
			this.Controls.Add(this.buttonAnalyze);
			this.Name = "Form1";
			this.Text = "Repair stupid file names";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAnalyze;
		private System.Windows.Forms.Label labelFolderHint;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonAccept;
		private System.Windows.Forms.ListView listViewPreview;
		private System.Windows.Forms.ColumnHeader columnHeaderOld;
		private System.Windows.Forms.ColumnHeader columnHeaderNew;
		private System.Windows.Forms.TextBox textBoxPrefix;
		private System.Windows.Forms.Label labelPrefixHint;
	}
}

