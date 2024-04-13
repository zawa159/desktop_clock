using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_colock
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int interval = 1000; // タイマーの間隔を1000ミリ秒（1秒）に設定
        private DateTime date;
        private String nowDate;

        public Form1()
        {
            InitializeComponent();

            //タイマーの準備
            timer = new Timer();  //タイマーnew
            timer.Interval = interval;  //タイマーのインターバル設定
            timer.Tick += Clock_Tick; // タイマーのTickイベントハンドラを設定

            //常に手前に表示
            this.TopMost = !this.TopMost;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            date = DateTime.Now;  //現在日時を取得
            nowDate = (date.ToString("HH:mm:ss")); // ラベルのテキストを更新
            NowTime.Text = nowDate; // カウンターの値をテキストに表示し、カウンターをインクリメント
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //フォームロード時に動作させる
            timer.Start();
        }

        //右クリック  「終了」
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
