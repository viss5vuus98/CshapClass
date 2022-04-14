using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn公分轉英吋_Click(object sender, EventArgs e)
        {
            if (text公分.Text != "") //空字串 確定使用者有輸入值
            {
                try
                {
                    float myCm = 0.0f;
                    float myInch = 0.0f;
                    string strInput = text公分.Text;
                    myCm = System.Convert.ToSingle(strInput);
                    myInch = myCm * 0.3937f;
                    //text英吋.Text = Convert.ToString(myInch);
                    text英吋.Text = string.Format("{0:F}", myInch);
                    text公分.Text = "";
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString(), "發生錯誤");
                    text英吋.Clear();
                    text公分.Clear();
                }
                finally
                {
                    text坪數.Clear();
                    text平方公尺.Clear();
                    text公斤.Clear();
                    text磅.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }
        }

        private void btn英吋轉公分_Click(object sender, EventArgs e)
        {
            if (text英吋.Text != "")
            {
                string strInput = text英吋.Text;
                double myInch = Convert.ToDouble(strInput);
                text公分.Text = string.Format("{0:F}", myInch / 2.2);
                text英吋.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }
            
        }

        private void btn坪數轉平方公尺_Click(object sender, EventArgs e)
        {
            if (text坪數.Text.Length > 0)  //C# 字串是字元組成的陣列
            {
                try
                {
                    double myPin = 0.0;
                    myPin = Convert.ToDouble(text坪數.Text);
                    text平方公尺.Text = string.Format("{0:F}", myPin * 3.0358);
                    text坪數.Clear();
                }
                catch
                {
                    MessageBox.Show("輸入公分格式錯誤，請重新輸入");
                    text坪數.Clear();
                    text平方公尺.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }

            

        }

        private void btn平方公尺轉坪數_Click(object sender, EventArgs e)
        {
            if (text平方公尺.Text != "")
            {
                string strInput = text平方公尺.Text;
                double myM2 = Convert.ToDouble(strInput);
                text坪數.Text = string.Format("{0:F}", myM2 / 2.2);
                text平方公尺.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }
            
        }

        private void btn公斤轉磅_Click(object sender, EventArgs e)
        {
            /* if (text公斤.Text != "")
             {
                 string strInput = text公斤.Text;
                 double myKg = Convert.ToDouble(strInput);
                 text磅.Text = string.Format("{0:F}", myKg * 2.2);
                 text公斤.Text = "";
             }
             else
             {
                 MessageBox.Show("請輸入公分數值");
             }*/

            //
            if (text公斤.Text.Length > 0)
            {
                double myKg, myPound = 0.0;
                bool isRight = false;

                isRight = System.Double.TryParse(text公斤.Text, out myKg);
                if (isRight != false)
                {
                    text磅.Text = string.Format("{0:F}", myKg * 2.2);
                    text公斤.Clear();
                    
                }
                else
                {
                    MessageBox.Show("請輸入正確的公斤數值");
                    text公分.Clear();
                    text英吋.Clear();
                    text坪數.Clear();
                    text平方公尺.Clear();
                    text磅.Clear();
                }
            }
            
            
        }

        private void btn磅轉公斤_Click(object sender, EventArgs e)
        {
            if (text磅.Text != "")
            {
                string strInput = text磅.Text;
                double myBB = Convert.ToDouble(strInput);
                text公斤.Text = string.Format("{0:F}", myBB / 2.2);
                text磅.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入公分數值");
            }
        }
    }
}
