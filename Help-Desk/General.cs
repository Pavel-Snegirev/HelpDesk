using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }
        private void General_Load(object sender, EventArgs e)
        {
            
        }




        //*********************************начало секции hover: кнопок управления переход открытие форм проверка многократности*************************************//

        private void PictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_cell_phone_50px_1.png");
        }

        private void PictureBox2_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_cell_phone_50px_2.png");
        }

        private void PictureBox3_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_checked_50px_3.png");
        }

        private void PictureBox3_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_checked_50px_4.png");
        }

        private void PictureBox5_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_combo_chart_50px.png");
        }

        private void PictureBox5_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_combo_chart_50px_1.png");
        }

        private void PictureBox6_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_geography_50px.png");
        }

        private void PictureBox6_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_geography_50px_1.png");
        }

        private void PictureBox7_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_email_50px_3.png");
        }

        private void PictureBox7_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"G:\Проекты C#\Help-Desk\Help-Desk\bin\Debug\img\icons8_email_50px_2.png");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            //formDeskGPS.MdiParent = this;


            //if (formDeskGPS == null) //  проверка на многократное открытие формы
            //{
                                
            //    formDeskGPS.FormClosed += (x, y) => { formDeskGPS = null; }; //для избежания проблем с повторным открытием после закрытия
            //}
            //formDeskGPS.Show();
           
        }




        //*************************************конец секции hover : кнопок управления***********************************************************************//


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            map.Visible = true;
            

            map.DragButton = MouseButtons.Left;

            map.MapProvider = GMapProviders.GoogleMap;
            double lat = 56.8456729; //широта
            double longt = 35.8955904; //долгота
            map.Position = new GMap.NET.PointLatLng(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 200;
            map.Zoom = 15;
            PointLatLng point = new PointLatLng(lat, longt);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);


        }

        
    }
}
