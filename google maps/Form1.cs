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
        int zoom = 13, heading;

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            zoom = trackBar2.Value;
            streetadd = textBox1.Text;
            cityname = textBox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetadd + "," + cityname + "&zoom=" + zoom + "&size=443x398&sensor=false");
            WebResponse responsePic = requestPic.GetResponse();
            Image map = Image.FromStream(responsePic.GetResponseStream());
            pictureBox1.Image = map;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            streetadd = textBox1.Text;
            cityname = textBox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetadd + "," + cityname + "&zoom=11&size=443x398&sensor=false");
            WebResponse responsePic = requestPic.GetResponse();
            Image map = Image.FromStream(responsePic.GetResponseStream());
            pictureBox1.Image = map;

            requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/streetview?size=443x398&location=" + streetadd + ","+ cityname + "&heading=" + heading + "235&sensor=false");
            responsePic = requestPic.GetResponse();
            Image smap = Image.FromStream(responsePic.GetResponseStream());
            pictureBox2.Image = smap;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            heading = trackBar1.Value * 20;
            streetadd = textBox1.Text;
            cityname = textBox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/streetview?size=443x398&location=" + streetadd + ","+ cityname + "&heading=" + heading + "&sensor=false");
            WebResponse responsePic = requestPic.GetResponse();
            Image smap = Image.FromStream(responsePic.GetResponseStream());
            pictureBox2.Image = smap;
        }
        

    }
}
