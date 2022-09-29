using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekrantemizlenecekmi;
        int _ilksayi;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "0";
        }

        private void btn_number1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (window.Text == "0")
            
            {
                window.Text = "";
            }
            window.Text += "1";
        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "2";
        }

        private void btn_number3_Click(object sender, EventArgs e) {
            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "3";
        }

        private void btn_number4_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "4";
        }

        private void btn_number5_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "5";
        }

        private void btn_number6_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "6";
        }

        private void btn_number7_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "7";
        }

        private void btn_number8_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "8";
        }

        private void btn_number9_Click(object sender, EventArgs e)
        {

            if (_ekrantemizlenecekmi)
            {
                window.Text = "";
                _ekrantemizlenecekmi = false;
            }

            if (window.Text == "0")

            {
                window.Text = "";
            }
            window.Text += "9";
        }

        private void btn_collection_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(window.Text);
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            int sonuc;
            int ikincisayi = Convert.ToInt32(window.Text);

            switch (_islem)
            {
                case '+':
                    sonuc = ikincisayi + _ilksayi;
                    break;
                case '-':
                    sonuc = ikincisayi - _ilksayi;
                    break;
                case '/':
                    sonuc = ikincisayi / _ilksayi;
                    break;
                case '*':
                    sonuc = ikincisayi * _ilksayi;
                    break;
                    default:
                    sonuc = 0;
                    break;
            }
            window.Text = Convert.ToString(sonuc);
        }

        private void btn_extraction_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(window.Text);
        }

        private void btn_crash_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(window.Text);
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(window.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            window.Text = "0";
        }
    }
}
