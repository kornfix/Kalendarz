using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testowanie_grid
{
    public partial class Form1 : Form
    {
        public enum DniTygodnia
        {
            Poniedziałek = 0,
            Wtorek = 1,
            Środa = 2,
            Czwartek = 3,
            Piątek = 4,
            Sobota = 5,
            Niedziela = 6,
        }
        public Form1()
        {
            InitializeComponent();
            wczytaj_kalendarz();
        }


        public void wczytaj_kalendarz()
        {
            //tableLayoutPanel1.Visible = false;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.AutoSize;
            for (int i = 0; i < 7; i++)
            {
                Label text = new Label();
                text.AutoSize = true;
                text.Font = new Font("Arial", 24, FontStyle.Bold);
                text.Text = ((DniTygodnia)i).ToString();
                tableLayoutPanel1.Controls.Add(text, i, 0);
            }
            int ile = 0;
            DateTime now = DateTime.Now;
            DateTime firstDay = new DateTime(now.Year, now.Month, 1);
            for (int i = 1; i < 7; i++)
            {
                for (int j = 0; j < 7;j++)
                {

                    uc_panel_dnia upd = new uc_panel_dnia(firstDay.AddDays(ile));
                    ile++;
                    //MessageBox.Show(ile.ToString());
                    tableLayoutPanel1.Controls.Add(upd, j, i);
                }
            }
        }
    }



}
