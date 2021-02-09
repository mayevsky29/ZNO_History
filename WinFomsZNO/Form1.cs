using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZNO_History;
using WinFomsZNO.Model;


namespace WinFomsZNO
{
    public partial class Form1 : Form
    {
       
        private readonly MyContext context;
        public Form1()
        {

            context = new MyContext();
            DbSeeder.SeedAll(context);
            InitializeComponent();
        
               

        }

       +

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
