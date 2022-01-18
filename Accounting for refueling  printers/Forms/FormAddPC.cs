using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_refueling__printers.Forms
{
    public partial class FormAddPC : Form
    {
        public FormAddPC()
        {
            InitializeComponent();
        }

        private void FormAddPC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.RAM". При необходимости она может быть перемещена или удалена.
            this.rAMTableAdapter.Fill(this.databaseDataSet.RAM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.GPU". При необходимости она может быть перемещена или удалена.
            this.gPUTableAdapter.Fill(this.databaseDataSet.GPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.CPU". При необходимости она может быть перемещена или удалена.
            this.cPUTableAdapter.Fill(this.databaseDataSet.CPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.OC". При необходимости она может быть перемещена или удалена.
            this.oCTableAdapter.Fill(this.databaseDataSet.OC);

        }
    }
}
