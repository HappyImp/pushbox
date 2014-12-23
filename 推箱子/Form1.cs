using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Media;

namespace 推箱子
{
    public enum Status { Wall, Passageway, Worker, Destination, Box, WorkerInDestination, BoxInDestination, right, up, left, down };
    struct Undo
    {
        public
          Status[,] n;
    }
    public partial class Form1 : Form
    {
        //List<Status[,]> Cancel=new List<Status[,]>();//存放走过的步
        //int undoint=0;//撤销到哪步
        Stack<Status[,]> Cancel = new Stack<Status[,]>(5);
        woker work = new woker();
        int manX = 0, manY = 0, Thisguan = 1;
        public static int count = 0;//worker坐标,当前关卡数
        static int time = 0;
        string path = "..\\..\\files\\map\\1.map";
        string pathcun = "..\\..\\files\\map\\cun.map";
        string goodpath = "icon\\iconOriginal\\";
        Status[,] s = new Status[15, 15];

        public bool shifou(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            if (fs.Length == 0)
            {
                fs.Close();
                return false;
            }
            fs.Close();
            return true;
        }
        public void OpenMap(Status[,] s, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < s.GetLength(0); i++)
                for (int j = 0; j < s.GetLength(1); j++)
                    s[i, j] = (Status)br.ReadByte();
            time = 0;
            timer1.Start();
            Cancel.Clear();
            br.Close();
            fs.Close();
        }
        public void DrawMap()
        {

            Bitmap bit = new Bitmap(450, 450);
            //     封装 GDI+ 位图，此位图由图形图像及其特性的像素数据
            Graphics g = Graphics.FromImage(bit);
            for (int i = 0; i < s.GetLength(0); i++)
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    Image image = Image.FromFile("..\\..\\files\\"+goodpath + s[i, j].ToString().Trim() + ".gif");
                    if (s[i, j] == Status.Worker || s[i, j] == Status.down || s[i, j] == Status.left || s[i, j] == Status.right || s[i, j] == Status.up || s[i, j] == Status.WorkerInDestination)
                    {
                        manX = i;
                        manY = j;
                    }
                    g.DrawImage(image, new Point(i * 30, j * 30));
                }
            pictureBox1.Image = Image.FromHbitmap(bit.GetHbitmap());
            CountLable.Text = "第" + count.ToString() + "步";

        }

        private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            time += 1;
        }



        private void TimeAdd()
        {
            while (true)
            {
                time++;
                timeLabel.Text = "用时：" + time.ToString() + "秒";
                Thread.Sleep(1000);
            }
        }
        SoundPlayer sp;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
           
            if (shifou(pathcun))
            {
                path = pathcun;
            }

        }

        private void NewBut_Click(object sender, EventArgs e)
        {
            MapConfig m = new MapConfig();
            m.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Undo aa = new Undo();
            aa.n = new Status[15, 15];
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                {
                    aa.n[i, j] = s[i, j];
                }
            if (e.KeyCode == Keys.Down)
            {
                if (work.WorkMove(s, ref manX, ref manY, 0, 1))
                {
                    count++;
                    Cancel.Push(aa.n);
                }
                if (s[manX, manY] != Status.WorkerInDestination)
                    s[manX, manY] = Status.down;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (work.WorkMove(s, ref manX, ref manY, 0, -1))
                {
                    count++;
                    Cancel.Push(aa.n);
                }
                if (s[manX, manY] != Status.WorkerInDestination)
                    s[manX, manY] = Status.up;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (work.WorkMove(s, ref manX, ref manY, 1, 0))
                {
                    count++;
                    Cancel.Push(aa.n);
                }
                if (s[manX, manY] != Status.WorkerInDestination)
                    s[manX, manY] = Status.right;

            }
            if (e.KeyCode == Keys.Left)
            {
                if (work.WorkMove(s, ref manX, ref manY, -1, 0))
                {
                    count++;
                    Cancel.Push(aa.n);
                }
                if (s[manX, manY] != Status.WorkerInDestination)
                    s[manX, manY] = Status.left;
            }
            if ((e.Control) && (e.KeyCode == Keys.Z))
            {
                try
                {
                    s = Cancel.Pop();
                    count--;
                    DrawMap();
                }
                catch
                {
                    MessageBox.Show("不可后退", "Error");
                }
            }
            if (e.KeyCode == Keys.G)
            {
                goodMethod();
            }else if(e.KeyCode==Keys.B){
                badMethod();
            }
            DrawMap();
            if (work.IsWin(s))
            {
                timer1.Stop();
                MessageBox.Show("过关", "恭喜");
                Thisguan++;
                path = "..\\..\\files\\map\\" + Thisguan.ToString() + ".map";
                OpenMap(s, path);
                DrawMap();
                label1.Text = "现在是第：" + (Thisguan).ToString() + "关";
                count = 0;

            }
        }

        private void LastBut_Click(object sender, EventArgs e)
        {
            try
            {
                Thisguan--;
                path = "..\\..\\files\\map\\" + Thisguan.ToString() + ".map";
                OpenMap(s, path);
                time = 0;
                timer1.Start();
                Form1.count = 0;
            }
            catch (FileNotFoundException m)
            {
                MessageBox.Show("不存在此关卡", "警告");
                Thisguan++;
            }
        }

        private void NextBut_Click(object sender, EventArgs e)
        {
            try
            {
                Thisguan++;
                path = "..\\..\\files\\map\\" + Thisguan.ToString() + ".map";
                OpenMap(s, path);
                time = 0;
                timer1.Start();
                Form1.count = 0;
            }
            catch (FileNotFoundException m)
            {
                MessageBox.Show("不存在此关卡", "警告");
                Thisguan--;
            }
        }

        private void UndoBut_Click(object sender, EventArgs e)
        {
            try
            {
                s = Cancel.Pop();
                count--;
                DrawMap();
            }
            catch
            {
                MessageBox.Show("不可后退", "Error");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OpenMap(s, path);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
            label1.Text = "现在是第：" + Thisguan.ToString() + "关";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            timeLabel.Text = "用时：" + time.ToString() + "秒";
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("选择你要的关卡！", "提示", "", -1, -1);
            int fanhui = Thisguan;
            Thisguan = int.Parse(str);
            path = "..\\..\\files\\map\\" + Thisguan.ToString() + ".map";
            try
            {
                OpenMap(s, path);
                DrawMap();
            }
            catch
            {
                MessageBox.Show("这关不存在", "错误");
                Thisguan = fanhui;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("是否要保存，便于下次继续", "提示", MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation);
            if (MsgBoxResult == DialogResult.Yes)
            {
                MapConfig.SaveMap(s, pathcun);
            }
            else
            {
                FileStream st = new FileStream(pathcun, FileMode.Create);
                st.Close();
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            OpenMap(s, path);
        }

        private void good_Click(object sender, EventArgs e)
        {
            goodMethod();
        }

        public void goodMethod() {
            goodpath = "icon\\";
            sp = new SoundPlayer(@"..\..\files\music\openMusic.wav");
            sp.Load();
            sp.PlayLooping();
        }

        public void badMethod()
        {
            goodpath = "icon\\iconOriginal\\";
            sp.Stop();
        }
    }
}
