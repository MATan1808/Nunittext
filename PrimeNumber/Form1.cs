using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            int number, kq;
            bool isNumber = int.TryParse(txta.Text, out number);
            number =int.Parse( txta.Text);
            PrimeChecker c = new PrimeChecker(number);
            kq = c.IsPrime(number);
            if (isNumber)
            {
                if (kq==1)
                {
                    txtkq.Text = $"{number} là số nguyên tố";
                }
                else
                {
                    txtkq.Text = $"{number} không phải là số nguyên tố";
                }
            }
            else
            {
                txtkq.Text = "Vui lòng nhập một số nguyên hợp lệ";
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại và thoát ứng dụng
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngui1_Click(object sender, EventArgs e)
        {
            int year,kqyear ;
            bool isNumber = int.TryParse(txtyear.Text, out year);
            year = int.Parse(txtyear.Text);
            IsLeapYear c = new IsLeapYear(year);   
            kqyear= c.LeapYear(year);
            if (isNumber)
            {
                if (kqyear == 1)
                {
                    txtkqyear.Text = $"{year} là Năm Nhuận";
                }
                else
                {
                    txtkqyear.Text = $"{year} không phải là Năm Nhuận";
                }
            }
            else
            {
                txtkqyear.Text = "Vui lòng nhập một số nguyên hợp lệ";
            }

        }
    }
}
