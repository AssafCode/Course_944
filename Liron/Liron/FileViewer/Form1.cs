using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += (s, e) => {
                FillTreeView(@"c:\temp");
            };

            tvFiles.AfterSelect += TvFiles_AfterSelect;
        }

        private void TvFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var nodeText = e.Node.Text;

            if (e.Node == null)
                return;

            if (Directory.Exists(nodeText))
            {
                pgInfo.SelectedObject = new DirectoryInfo(nodeText);
                return;
            }

            if (!File.Exists(nodeText))
                return;

            txtContent.Text = File.ReadAllText(nodeText);
            pgInfo.SelectedObject = new FileInfo(nodeText);
        }

        private void FillTreeView(string path)
        {
            tvFiles.BeginUpdate();

            tvFiles.Nodes.Clear();
            TreeNode root = tvFiles.Nodes.Add(path);
            FillPath(path, root);

            tvFiles.EndUpdate();
        }

        private void FillPath(string currentPath, TreeNode currentNode)
        {
            foreach (var directory in Directory.GetDirectories(currentPath))
            {
                TreeNode child = currentNode.Nodes.Add(directory);
                FillPath(directory, child);
            }

            foreach (var file in Directory.GetFiles(currentPath))
                currentNode.Nodes.Add(file);
        }
    }
}
