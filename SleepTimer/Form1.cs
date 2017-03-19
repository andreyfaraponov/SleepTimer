using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepTimer
{
    public partial class Form1 : Form
    {
        DateTime timeToSleep = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            UpdateTimers();
            comboBox1.DataSource = collectionAndTimer.hours;
            comboBox2.DataSource = collectionAndTimer.mins;
            #region Установка базового значения КомбоБоксам
            for (int i = 0; i < collectionAndTimer.hours.Length; i++)
            {
                if (DateTime.Now.Hour > (int)comboBox1.SelectedValue)
                {
                    comboBox1.SelectedIndex = DateTime.Now.Hour;
                }
            }
            for (int i = 0; i < collectionAndTimer.mins.Length; i++)
            {
                if (DateTime.Now.Minute >= (int)comboBox2.SelectedValue)
                {
                    comboBox2.SelectedItem = (int)collectionAndTimer.mins[i];
                }
            }
            #endregion
            timeToSleep = DateTime.Parse(comboBox1.SelectedValue.ToString() + ":" + comboBox2.SelectedValue.ToString());
        }
        private void combo4Minutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //normLabel.Text = combo4Minutes.SelectedItem.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            //label9.Text = timeToSleep.Hour.ToString("00") + ":" + timeToSleep.Minute.ToString("00") + ":00";
        }
        private void UpdateTimers()
        {
            //labelMin.Text = DateTime.Now.AddHours(4).AddMinutes(45).ToShortTimeString();
            //labelOpt.Text = DateTime.Now.AddHours(6).AddMinutes(15).ToShortTimeString();
            //labelNorm.Text = DateTime.Now.AddHours(7).AddMinutes(45).ToShortTimeString();
            //labelMax.Text = DateTime.Now.AddHours(9).AddMinutes(15).ToShortTimeString();
            labelMin.Text = changeTime(1, timeToSleep);
            labelOpt.Text = changeTime(2, timeToSleep);
            labelNorm.Text = changeTime(3, timeToSleep);
            labelMax.Text = changeTime(4, timeToSleep);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeToSleep = DateTime.Parse(comboBox1.SelectedValue.ToString() + ":" + comboBox2.SelectedValue.ToString());
            UpdateTimers();
        }
        public string changeTime(int circle, DateTime time)
        {
            switch (circle)
            {
                case 1:
                    return time.AddHours(4).AddMinutes(45).ToShortTimeString();
                case 2:
                    return time.AddHours(6).AddMinutes(15).ToShortTimeString();
                case 3:
                   return time.AddHours(7).AddMinutes(45).ToShortTimeString();
                case 4:
                    return time.AddHours(9).AddMinutes(15).ToShortTimeString();
                default:
                    time = DateTime.Now;
                    break;
            }
            return time.ToShortTimeString();
        }
    }
}
