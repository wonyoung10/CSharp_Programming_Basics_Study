using System.Diagnostics.Eventing.Reader;

namespace tree_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode node1 = new TreeNode(tbNode.Text);

            if (treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected)
            {
                treeView1.SelectedNode.Nodes.Add(node1);
            }
            else treeView1.Nodes.Add(node1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && !treeView1.SelectedNode.IsSelected)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
        List<TreeNode> chkNodes = new List<TreeNode>();
        void RemoveCheckedNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    chkNodes.Add(node);
                }
                else
                {
                    RemoveCheckedNodes(node.Nodes);
                }
            }
            foreach(TreeNode chknode in chkNodes)
            {
                nodes.Remove(chknode);
            }
        }

        private void ChkDelete_Click(object sender, EventArgs e)
        {
            RemoveCheckedNodes(treeView1.Nodes);

        }

    }
}

