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
        //タイマー、現在時刻
        private Timer timer;
        private int interval = 1000; // タイマーの間隔を1000ミリ秒（1秒）に設定
        private DateTime date;
        private String nowDate;

        //画面を掴んで移動
        private Point mousePoint;  //マウスのクリック位置を記憶

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

        private void Form1_Load(object sender, EventArgs e)
        {
            //フォームロード時に動作させる
            timer.Start();
        }

        //右クリック  「終了」
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //画面を閉じる
        }


        //現在時刻を取得
        private void Clock_Tick(object sender, EventArgs e)
        {
            //現在日時を取得
            date = DateTime.Now;
            
            // ラベルのテキストを作成
            nowDate = (date.ToString("HH:mm:ss"));
            
            // 時刻をラベルに表示
            NowTime.Text = nowDate;
        }

        //画面を掴んで移動
        private void NowTime_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void NowTime_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //左右
                this.Left += e.X - mousePoint.X;
                //上下
                this.Top += e.Y - mousePoint.Y;
            }
        }
    }
}


/*
 * ・サイズ記憶
 * ・起動時のポジションを記憶
 * ・サイズに合わせて文字サイズを変更
 * ・
 */