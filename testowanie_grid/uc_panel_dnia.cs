using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testowanie_grid
{
    public partial class uc_panel_dnia : UserControl
    {
        public uc_panel_dnia()
        {
            InitializeComponent();
        }


        public uc_panel_dnia(DateTime data)
        {
            InitializeComponent();

            lb_nazwa_dnia.Text = data.Day.ToString();
            for(int i=0;i<3;i++)
            {
                uc_operacja nowy = new uc_operacja();
                nowy.Text = i.ToString();
                flP_dane_operacji.Controls.Add(nowy);
            }
        }
    }
}
