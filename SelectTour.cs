﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace formProject
{
    public partial class SelectTour : Form
    {
        List<Panel> TourList = new List<Panel>();

        readonly SelectTourDate MainMenu;
        readonly SelectTour SelectMenu;

        bool isFemale = false;

        public SelectTour(SelectTourDate MainMenu)
        {
            InitializeComponent();

            this.MainMenu = MainMenu;
            SelectMenu = this;

            DateTimePicker2.MinDate = DateTimeLimits.Min();
            DateTimePicker2.MaxDate = DateTimeLimits.Max();

            //********************************DataBase
            CreateTourPanel("2+1", "Manisa > İstanbul", "12:00", "08h30m", 600);
            CreateTourPanel("2+1", "İstanbul > Bandırma", "06:00", "03h30m", 400);
            CreateTourPanel("2+1", "İstanbul > Manisa", "21:00", "08h30m", 600);
            CreateTourPanel("2+1", "Bandırma > İstanbul", "10:00", "03h30m", 350);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void BtnPrevDay_Click(object sender, EventArgs e)
        {
            if(!(DateTimePicker2.Value.AddDays(-1) < DateTimeLimits.Min()))
            {
                DateTimePicker2.Value = DateTimePicker2.Value.AddDays(-1);
            }
        }

        private void BtnNextDay_Click(object sender, EventArgs e)
        {
            if (!(DateTimePicker2.Value.AddDays(1) > DateTimeLimits.Max()))
            {
                DateTimePicker2.Value = DateTimePicker2.Value.AddDays(1);
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        public void ReWriteDate(DateTime dateToWrite)
        {
            DateTimePicker2.Value = dateToWrite;
        }

        void switchToBuyScreen(object sender, EventArgs e, int cost)
        {
            BuyScreen temp = new BuyScreen();
            temp.Show();
        }

        public void CreateTourPanel(string sittingArrangement,
            string fromTo, string departureTime, string duration, int cost)
        {
            Panel panelTemp = new Panel();
            panelTemp.Size = new Size(700, 71);
            panelTemp.Location = (new Point(19 , 14 + (77 * TourList.Count)));
            panelTemp.BackColor = Color.LightBlue;

            //this.Load += new System.EventHandler(this.Form2_Load);
            panelTemp.Click += (sender, e) => switchToBuyScreen(sender, e, cost);

            for (int i = 0; i < 5; i++)
            {
                Label labelTemp = new Label();
                switch (i)
                {
                    case 0:
                        labelTemp.Location = (new Point(27, 22));
                        labelTemp.Text = sittingArrangement;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 14);
                        break;
                    case 1:
                        labelTemp.Location = (new Point(3, 46));
                        labelTemp.Text = fromTo;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 15);
                        break;
                    case 2:
                        labelTemp.Location = (new Point(320, 1));
                        labelTemp.Text = departureTime;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 20);
                        break;
                    case 3:
                        labelTemp.Location = (new Point(323, 36));
                        labelTemp.Text = duration;
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 14);
                        break;
                    case 4:
                        labelTemp.Location = (new Point(603, 20));
                        labelTemp.Text = cost + "TL";
                        labelTemp.Font = ChangeFontSize(labelTemp.Font, 20);
                        break;
                }

                labelTemp.AutoSize = true;
                panelTemp.Controls.Add(labelTemp);
            }
            panel3.Controls.Add(panelTemp);
            TourList.Add(panelTemp);
        }

        Font ChangeFontSize(Font font, float size)
        {
            return new Font(font.FontFamily, size, font.Style);
        }

        private void SetGenderOnForm(BuyScreen form4)
        {
            if (isFemale)
                form4.UsersGender = Gender.Female;
            else
                form4.UsersGender = Gender.Male;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            BtnBack_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BtnPrevDay_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BtnNextDay_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}