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
        Data.MaChStorageEntities _Database;

        public FormItems()
        {
            InitializeComponent();
        }

        private void FormItems_Load(object sender, EventArgs e)
        {
            _Database = new Data.MaChStorageEntities();
            InitData();
        }

        private void InitData()
        {
            itemsVWBindingSource.DataSource = _Database.ItemsVWs.ToList();
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
            using (var dlg = new Dialogs.DialogItem(_Database))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _Changes = true;
                    DataRefresh();
                }
            }
        }

        private void SaveChanges()
        {
            MessageBox.Show("SaveChanges");
        }

        private void DataRefresh()
        {
            MessageBox.Show("DataRefresh");
        }

        private void DgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e) => _Changes = true;

        private void DgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var dlg = new Dialogs.DialogItem(_Database, itemsVWBindingSource.Current as Data.ItemsVW))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                { DataRefresh(); }
            }
        }
    }
}
