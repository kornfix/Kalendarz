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

    public partial class uc_operacja : UserControl
    {
        bool pokaz_wiecej = true;
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public uc_operacja()
        {
            InitializeComponent();
        }

        private void btn_arrow_Click(object sender, EventArgs e)
        {
            List<Label> customLabels = new List<Label>();
            if (!pokaz_wiecej)
            {
                btn_arrow.ImageIndex = 1;
                pokaz_wiecej = !pokaz_wiecej;
                flowLayoutPanel1.Controls.Clear();
            }else
            {
                for (int i = 0; i < 14; i++)
                {
                    Label label = new Label();
                    label.Text = "coś";
                    label.AutoSize = true;
                    customLabels.Add(label);
                    flowLayoutPanel1.Controls.Add(label);
                }
                btn_arrow.ImageIndex = 0;
                pokaz_wiecej = !pokaz_wiecej;
            }
        }


      
    }
}
