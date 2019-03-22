using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class mdi_admin : Form
    {
        private int childFormNumber = 0;

        public mdi_admin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNew_User au = new AddNew_User();
            au.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void addNewUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddNew_User au = new AddNew_User();
            au.Show();
        }

        private void addNewUserToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            AddNew_User au = new AddNew_User();
            au.Show();
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Unit aun = new Add_Unit();
            aun.Show();

        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void addProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product ap = new Add_Product();
            ap.Show();
        }

        private void purchaseMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_master pm = new Purchase_master();
            pm.Show();
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        private void dealerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dealer_info di = new dealer_info();
            di.Show();
        }

        private void sellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sells sl = new sells();
            sl.Show();

        }
    }
}
