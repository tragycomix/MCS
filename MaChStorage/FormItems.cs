using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaChStorage
{
    public partial class FormItems : Form
    {
        bool _Changes = false;


        public FormItems()
        {
            InitializeComponent();
        }

        private void FormItems_Load(object sender, EventArgs e)
        {

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_Changes || MessageBox.Show("Ukončit bez uložení změn?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { Close(); }
        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e) => AddNewItem();
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e) => DataRefresh();
        private void SaveChangesToolStripMenuItem_Click(object sender, EventArgs e) => SaveChanges();

        private void AddNewItem()
        {
            //using (var _dlg = new MessageBox())

            _Changes = true;
            DataRefresh();
        }

        private void SaveChanges()
        {
            MessageBox.Show("SaveChanges");
        }

        private void DataRefresh()
        {
            MessageBox.Show("DataRefresh");
        }

    }
}
