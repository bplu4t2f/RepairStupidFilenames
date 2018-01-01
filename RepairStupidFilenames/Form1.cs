using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairStupidFilenames
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private List<(string oldName, string newName)> pendingActions;

		private void button1_Click(object sender, EventArgs e)
		{
			var file = this.textBox1.Text;
			if (String.IsNullOrWhiteSpace(file))
			{
				MessageBox.Show("user pls");
				return;
			}
			var prefix = this.textBoxPrefix.Text;

			var errors = new List<(string file, Exception ex)>();
			var infoList = new List<Info>();

			if (Directory.Exists(file))
			{
				foreach (var child in Directory.GetFiles(file))
				{
					this.ProcessFile(prefix, Path.Combine(file, child), errors, infoList);
				}
			}
			else
			{
				this.ProcessFile(prefix, file, errors, infoList);
			}

			if (errors.Any())
			{
				var message = "Failed to analyze some files. Continue anyway?" + Environment.NewLine + String.Join(Environment.NewLine, errors.Select(x => $"{x.file}: {x.ex.Message}"));
				var choice = MessageBox.Show(this, message, "Analyze error", MessageBoxButtons.YesNo);
				if (choice != DialogResult.Yes)
				{
					return;
				}
			}

			if (!infoList.Any())
			{
				return;
			}

			int trackNumberLength;
			{
				var maxTrackNumber = infoList.Max(x => x.trackNumber);
				// At least 2, because single digit track numbers are sad
				trackNumberLength = Math.Min(maxTrackNumber.ToString().Length, 2);
			}

			this.pendingActions = new List<(string oldName, string newName)>();
			{
				var invalidFileNameChars = Path.GetInvalidFileNameChars();
				foreach (var info in infoList)
				{
					string title = info.title;
					foreach (var c in invalidFileNameChars)
					{
						title = title.Replace(c, '_');
					}

					string extension = Path.GetExtension(info.originalFilePath);
					string trackNumber = info.trackNumber.ToString("D" + trackNumberLength);

					var newFileName = $"{prefix}{trackNumber} {title}{extension}";
					var newFilePath = Path.Combine(Path.GetDirectoryName(info.originalFilePath), newFileName);
					this.pendingActions.Add((info.originalFilePath, newFilePath));
				}
			}

			this.listViewPreview.Items.Clear();
			foreach (var action in this.pendingActions)
			{
				Debug.WriteLine("OLD: " + action.oldName);
				Debug.WriteLine("NEW: " + action.newName);
				var item = this.listViewPreview.Items.Add(Path.GetFileName(action.oldName));
				item.SubItems.Add(Path.GetFileName(action.newName));
			}
		}

		class Info
		{
			public Info(string originalFilePath, string title, uint trackNumber)
			{
				this.originalFilePath = originalFilePath;
				this.title = title;
				this.trackNumber = trackNumber;
			}

			public string originalFilePath;
			public string title;
			public uint trackNumber;
		}

		private void ProcessFile(string prefix, string filePath, List<(string, Exception)> errors, List<Info> infoList)
		{
			try
			{
				string title;
				uint trackNumber;

				using (var tagFile = TagLib.File.Create(filePath))
				{
					title = tagFile.Tag.Title;
					trackNumber = tagFile.Tag.Track;
					if (String.IsNullOrWhiteSpace(title) || trackNumber == 0)
					{
						return;
					}
				}

				infoList.Add(new Info(filePath, title, trackNumber));
			}
			catch (Exception ex)
			{
				errors.Add((filePath, ex));
				return;
			}

		}

		private void buttonAccept_Click(object sender, EventArgs e)
		{
			if (this.pendingActions == null)
			{
				return;
			}

			try
			{
				foreach (var file in this.pendingActions)
				{
					File.Move(file.oldName, file.newName);
				}

				this.pendingActions = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error moving files." + Environment.NewLine + ex.ToString());
			}
		}
	}
}
