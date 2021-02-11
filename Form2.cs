using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_3_hopefullylast03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }
        public string SP { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer lul = new SoundPlayer(SP);
             lul.PlaySync();

        }
    }
}
