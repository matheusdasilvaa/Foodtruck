using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class ListaPedidos : Form
    {
        public ListaPedidos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ListaPedidos
            // 
            this.ClientSize = new System.Drawing.Size(1050, 631);
            this.Name = "ListaPedidos";
            this.ResumeLayout(false);

        }
    }
}
