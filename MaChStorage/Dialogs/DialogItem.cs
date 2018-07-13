using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaChStorage.Dialogs
{
    public partial class DialogItem : Form
    {
        Data.ItemsVW _Item;
        Data.MaChStorageEntities _Database;

        public DialogItem(Data.MaChStorageEntities database, Data.ItemsVW item = null)
        {
            InitializeComponent();

            _Database = database ?? new Data.MaChStorageEntities();
            _Item = item ?? new Data.ItemsVW();

            var suppData = _Database.Suppliers.OrderBy(s => s.Name);
            if (item == null) suppData = suppData.Where(s => s.Active == 1).OrderBy(s => s.Name);

            supplierBindingSource.DataSource = suppData.ToList();
            itemsVWBindingSource.DataSource = _Item;
        }
    }
}
