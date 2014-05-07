using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace google_maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string streetadd, cityname;

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            lblTrackBar.Text = "" + trackBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            streetadd = textBox1.Text;
            cityname = textBox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetadd + "'" + cityname + "&zoom=11&size=443x398&sensor=false");
            WebResponse responsePic = requestPic.GetResponse();
            Image map = Image.FromStream(responsePic.GetResponseStream());
            pictureBox1.Image = map;

        }
    }
}
