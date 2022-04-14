using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("第一個Window Form程式");
            Console.WriteLine("小數位數 pi: {0:F}",3.141592);  //格式化字元在索引直後加    :F 預設小數點後2位  :F4 小數點後4位 自動四捨五入
            Console.WriteLine("百分比號: {0:P}", 0.8765); //百分比
            Console.WriteLine("科學記號: {0:E}",0.0000000012345); // 浮點數的表示法
            Console.WriteLine("科學記號: {0:E}", 123400000.0);
            Console.WriteLine("金融符號: {0:C}", 100000000); //以作業系統的設定顯示當地的符號
            Console.WriteLine("整數補零: {0:D8}", 12345); //整數補零到8位 補在數字前面\ 常用

            Console.WriteLine("現在時間: {0:d}", System.DateTime.Now); // 時間屬性 2022/4/14
            Console.WriteLine("{0:D}", DateTime.Now); //小寫 2022年4月14日
            Console.WriteLine("{0:F}", DateTime.Now); //2022年4月14日 上午 10:50:45
            Console.WriteLine("{0:T}", DateTime.Now); //上午 10:50:45
            Console.WriteLine("{0:t}", DateTime.Now); //上午 10:50
            Console.WriteLine("{0:M}", DateTime.Now); //4月14日


            System.Windows.Forms.MessageBox.Show("歡迎使用");// 彈跳窗
            
            MessageBox.Show("Windows Form App 開發", "標題", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);  //加入按鈕功能

            lblTitle.Text = "Super 好喝冷飲自動販賣機";
            lblResponse.Text = "請選擇您要購買的飲料";
        }

        private void btn紅茶_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "你選擇了紅茶，請投入20元";   //text只接受字串
        }

        private void btn綠茶_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "你選擇了綠茶，請投入25元";
        }

        private void btn奶茶_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "你選擇了奶茶，請投入40元";
        }


        private void btnCoke_Click(object sender, EventArgs e)
        {
            lblResponse.Text = "你選擇了可樂，請投入15元";
        }
    }
}
