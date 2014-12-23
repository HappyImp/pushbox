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
using Microsoft.VisualBasic;
namespace 推箱子
{
    public partial class MapConfig : Form
    {
        int lastWorkerX = -1;
        int lastWorkerY = -1;
        Status Select_now;//选中的工具
        Status[,] Sta_maps = new Status[15, 15];//地图数组  
        string path = "..\\..\\files\\map\\";
        public int WorkNum(Status[,] s)
        {
            int i = 0;
            for (int k = 0; k < s.GetLength(0); k++)
                for (int l = 0; l < s.GetLength(1); l++)
                    if (s[k, l] == Status.Worker)
                        i++;
            return i;
        }
        public MapConfig()
        {
            InitializeComponent();

        }

        private void DesBut_Click(object sender, EventArgs e)
        {
            //选中目标
            Select_now = Status.Destination;
        }

        private void WorkerBut_Click(object sender, EventArgs e)
        {
            //选中工人
            Select_now = Status.Worker;
        }

        private void BoxBut_Click(object sender, EventArgs e)
        {
            Select_now = Status.Box;
        }

        private void PasBut_Click(object sender, EventArgs e)
        {
            Select_now = Status.Passageway;
        }

        private void WallBut_Click(object sender, EventArgs e)
        {
            Select_now = Status.Wall;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int x, y;
            x = e.X / 30;
            y = e.Y / 30;
            findWorker();
            Sta_maps[x, y] = Select_now;
            if (Status.Worker.ToString().Equals(Select_now.ToString()))
            {
                clearWorker();
            }
            drawimage();

        }
        private void ClearMap()
        {
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    Sta_maps[i, j] = Status.Wall;
            drawimage();
        }
        public static void SaveMap(Status[,] s, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < s.GetLength(0); i++)
                for (int j = 0; j < s.GetLength(1); j++)
                    bw.Write((byte)s[i, j]);
            bw.Close();
            fs.Close();
        }

        Bitmap bit;
        Graphics g;
        System.Drawing.Image image;
        public void drawimage()
        {
            bit = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            g = Graphics.FromImage(bit);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            for (int i = 0; i < 15; i++)
            {

                for (int j = 0; j < 15; j++)
                {
                    if (Sta_maps[i, j] == Status.Wall)
                    {
                        image = new Bitmap("..\\..\\files\\icon\\wall.gif");
                        g.DrawImage(image, i * 30, j * 30, 30, 30);
                    }
                    if (Sta_maps[i, j] == Status.Worker)
                    {
                        image = new Bitmap("..\\..\\files\\icon\\worker.gif");
                        g.DrawImage(image, i * 30, j * 30, 30, 30);
                    }
                    if (Sta_maps[i, j] == Status.Box)
                    {
                        image = new Bitmap("..\\..\\files\\icon\\box.gif");
                        g.DrawImage(image, i * 30, j * 30, 30, 30);
                    }
                    if (Sta_maps[i, j] == Status.Passageway)
                    {
                        image = new Bitmap("..\\..\\files\\icon\\passageway.gif");
                        g.DrawImage(image, i * 30, j * 30, 30, 30);
                    }
                    if (Sta_maps[i, j] == Status.Destination)
                    {
                        image = new Bitmap("..\\..\\files\\icon\\Destination.gif");
                        g.DrawImage(image, i * 30, j * 30, 30, 30);
                    }
                }
            }
            this.pictureBox1.Image = bit;
        }

        public void findWorker()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (Sta_maps[i, j] == Status.Worker)
                    {
                        if (lastWorkerX == -1 && lastWorkerY == -1)
                        {
                            lastWorkerX = i;
                            lastWorkerY = j;
                            return;
                        }
                    }
                }
            }
            lastWorkerX = -1;
            lastWorkerY = -1;
        }

        public void clearWorker()
        {
            if (lastWorkerX > -1 && lastWorkerY > -1)
            {
                Sta_maps[lastWorkerX, lastWorkerY] = Status.Wall;
                lastWorkerX = -1;
                lastWorkerY = -1;
            }
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            ClearMap();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (WorkNum(Sta_maps) != 1)
            {
                MessageBox.Show("请重新编辑，人物数量不正确", "Error");
                return;
            }
            string str = Microsoft.VisualBasic.Interaction.InputBox("请输入你要保存第几关！", "提示", "", -1, -1);
            string path1 = path + str + ".map";
            SaveMap(Sta_maps, path1);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MapConfig_Load(object sender, EventArgs e)
        {
            ClearMap();
        }


    }
}
