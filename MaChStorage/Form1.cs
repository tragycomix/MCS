using MaChStorage.Data;
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
    public partial class Form1 : Form
    {
        MaChStorageEntities Database;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database = new MaChStorageEntities();
            InitData();
        }

        private void InitData()
        {
            
        }

        private void CloseApp_Click(object Sender = null, EventArgs EventArgs = null) => Close();
    }
}
