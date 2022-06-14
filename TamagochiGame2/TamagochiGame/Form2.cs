using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamagochiGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fonePB.Image = new Bitmap($"{Application.StartupPath}\\Fone.png");
        }

     
    }
}
