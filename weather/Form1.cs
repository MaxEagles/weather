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
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace weather
{
    public partial class Form1 : Form
    {
        Color textColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            labelCity.BackColor = Color.Transparent;
            labelCondition.BackColor = Color.Transparent;
            labelCondition2.BackColor = Color.Transparent;
            labelTemp.BackColor = Color.Transparent;
            labelMaxTemp.BackColor = Color.Transparent;
            labelMinTemp.BackColor = Color.Transparent;
            labelHumidity.BackColor = Color.Transparent;
            labelWindSpeed.BackColor = Color.Transparent;
            labelFeels.BackColor = Color.Transparent;
            labelPressure.BackColor = Color.Transparent;
            labelWater.BackColor = Color.Transparent;
            tableLayoutPanel1.BackColor = Color.Transparent;
            for(int i=0;i<10;i++)
            {
                tableLayoutPanel1.Controls.Add(new Label() { BackColor = Color.Transparent, TextAlign=ContentAlignment.MiddleCenter }, i, 0);
                tableLayoutPanel1.Controls.Add(new Label() { BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter }, i, 1);
                tableLayoutPanel1.Controls.Add(new PictureBox(), i, 2);
            }
        }
      
        private void textBoxCity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                string city = textBoxCity.Text;
                textBoxCity.Text = textBoxCity.Text.Substring(0, 1).ToUpper() + textBoxCity.Text.Substring(1);
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=0ea757d738d79d020cb87b4ee8e6214e&units=metric&mode=xml&lang=ru");

                try
                {
                    XDocument doc = XDocument.Load(url);

                    string iconID = (string)doc.Root.Descendants("weather").FirstOrDefault().Attribute("icon").Value;
                    if (iconID[2] == 'd')
                    {
                        textColor = Color.Black;
                    }
                    else
                    {
                        textColor = Color.White;
                    }
                    labelCity.ForeColor = textColor;
                    labelCondition.ForeColor = textColor;
                    labelCondition2.ForeColor = textColor;
                    labelTemp.ForeColor = textColor;
                    labelMaxTemp.ForeColor = textColor;
                    labelMinTemp.ForeColor = textColor;
                    labelHumidity.ForeColor = textColor;
                    labelWindSpeed.ForeColor = textColor;
                    labelFeels.ForeColor = textColor;
                    labelPressure.ForeColor = textColor;
                    labelWater.ForeColor = textColor;
                    tableLayoutPanel1.ForeColor = textColor;


                    string imageName = iconID + ".jpg";
                    panel1.BackgroundImage = Image.FromFile(imageName);

                    string condition = (string)doc.Root.Descendants("clouds").FirstOrDefault().Attribute("name").Value;
                    string condition2 = (string)doc.Root.Descendants("weather").FirstOrDefault().Attribute("value").Value;
                    if(condition==condition2)
                    {
                        condition2 = "";
                    }

                    string temperature = (string)doc.Root.Descendants("temperature").FirstOrDefault().Attribute("value").Value + "°";
                    if (temperature.Contains("."))
                    {
                        temperature = temperature.Substring(0, temperature.IndexOf(".")) + "°";
                    }
                    string tempMax = "Макс: " + (string)doc.Root.Descendants("temperature").FirstOrDefault().Attribute("max").Value + "°";
                    if (tempMax.Contains("."))
                    {
                        tempMax = tempMax.Substring(0, tempMax.IndexOf(".")) + "°";
                    }
                    string tempMin = "Мин: " + (string)doc.Root.Descendants("temperature").FirstOrDefault().Attribute("min").Value + "°";
                    if (tempMin.Contains("."))
                    {
                        tempMin = tempMin.Substring(0, tempMin.IndexOf(".")) + "°";
                    }

                    string humidity = "Влажность\n" + (string)doc.Root.Descendants("humidity").FirstOrDefault().Attribute("value").Value + "%";

                    string windSpeed = "Ветер\n" + (string)doc.Root.Descendants("wind").FirstOrDefault().Descendants("speed").FirstOrDefault().Attribute("value").Value + "м/с";
                    if (windSpeed.Contains("."))
                    {
                        windSpeed = windSpeed.Substring(0, windSpeed.IndexOf(".")) + "м/с";
                    }

                    string feels = "Ощущается\n" + (string)doc.Root.Descendants("feels_like").FirstOrDefault().Attribute("value").Value + "°";
                    if (feels.Contains("."))
                    {
                        feels = feels.Substring(0, feels.IndexOf(".")) + "°";
                    }

                    string pressure = (string)doc.Root.Descendants("pressure").FirstOrDefault().Attribute("value").Value;
                    double p = Convert.ToDouble(pressure) * 0.75;
                    pressure = "Давление\n" + Convert.ToString(p) + "\nмм рт. ст.";

                    string water;
                    if ((string)doc.Root.Descendants("precipitation").FirstOrDefault().Attribute("mode").Value != "no")
                    {
                        water = "Осадки\n" + (string)doc.Root.Descendants("precipitation").FirstOrDefault().Attribute("value").Value + "мм";
                    }
                    else
                    {
                        water = "Осадки\n0мм";
                    }

                    labelTemp.Text = temperature;
                    labelMaxTemp.Text = tempMax;
                    labelMinTemp.Text = tempMin;                    
                    labelCondition.Text = condition;
                    labelCondition2.Text = condition2;
                    labelHumidity.Text = humidity;
                    labelWindSpeed.Text = windSpeed;
                    labelFeels.Text = feels;
                    labelPressure.Text = pressure;
                    labelWater.Text = water;
                }
                catch (System.Net.WebException)
                {
                    panel1.BackgroundImage = Image.FromFile("sky.jpg");
                    labelCondition.Text = "город не найден";
                    labelCondition2.Text = "";
                    labelTemp.Text = "";
                    labelMaxTemp.Text = "";
                    labelMinTemp.Text = "";
                    labelHumidity.Text = "";
                    labelWindSpeed.Text = "";
                    labelFeels.Text = "";
                    labelPressure.Text = "";
                    labelWater.Text = "";
                }

                string url2 = string.Format("http://api.openweathermap.org/data/2.5/forecast?q=" + city + "&appid=0ea757d738d79d020cb87b4ee8e6214e&units=metric&mode=xml&lang=ru&cnt=11");

                try
                {
                    tableLayoutPanel1.Visible = true;
                    XDocument doc = XDocument.Load(url2);
                    string[] times = new string[10];
                    string[] temps = new string[10];
                    string[] images = new string[10];
                    for (int i = 0; i < 10; i++)
                    {
                        times[i] = (string)doc.Root.Descendants("forecast").FirstOrDefault().Descendants("time").ElementAt(i+1).Attribute("from").Value;
                        times[i] = times[i].Substring(times[i].IndexOf("T")+1, 5);
                        temps[i] = (string)doc.Root.Descendants("forecast").FirstOrDefault().Descendants("time").ElementAt(i).Descendants("temperature").FirstOrDefault().Attribute("value").Value + "°";
                        if (temps[i].Contains("."))
                        {
                            temps[i] = temps[i].Substring(0, temps[i].IndexOf(".")) + "°";
                        }
                        images[i] = " http://openweathermap.org/img/wn/" + (string)doc.Root.Descendants("forecast").FirstOrDefault().Descendants("time").ElementAt(i).Descendants("symbol").FirstOrDefault().Attribute("var").Value + ".png";
                        tableLayoutPanel1.Controls[i*3].Text = times[i];
                        tableLayoutPanel1.Controls[i*3+1].Text = temps[i];
                        ((PictureBox)tableLayoutPanel1.Controls[i * 3 + 2]).ImageLocation = images[i];
                    }
                    
                }
                catch(System.Net.WebException)
                {
                    tableLayoutPanel1.Visible = false;
                }

            }
        }

       
    }
}
