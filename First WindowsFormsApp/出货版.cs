using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;

namespace First_WindowsFormsApp
{
    public partial class 出货版 : Form
    {

        string gpxs = null;
        string CD = System.IO.Directory.GetCurrentDirectory();

        public object ValueMaxLeft { get; private set; }

        public 出货版()
        {
            InitializeComponent();
        }

        //第一行修改产品的序列号
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnumber_Click(object sender, EventArgs e)
        {
            /*可以替换序列号了，同一个文件里若多次修改会出现中文乱码，所以采用向另一个文件输出的方式*/
            /*调试版仅修改序列号*/
            string num = numtextBox.Text;
            string path = CD+"\\lcd1.c";
            string con = "";
            // string oldnum = "\d\d";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("gb2312"));
            con = sr.ReadToEnd();
            //con = con.Replace("S/N:HN18Z0", "S/N:HN18Z0"+num);

            Regex regex = new Regex(@"S/N:HN18Z0\d\d");
            con = regex.Replace(con, "S/N:HN18Z0" + num);
            sr.Close();
            fs.Close();
            FileStream fs2 = new FileStream("F:\\在线光谱仪\\20180718\\小糸车灯光谱版本 - 调试版 -beat 1.1\\USER\\lcd.c", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            sw.WriteLine(con);
            sw.Close();
            fs2.Close();
            MessageBox.Show("序列号修改成功！");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        //替换KB系数，标识行：pixel=4.0141*(380+j)-1002.4; //**号
        private void button1_Click(object sender, EventArgs e)
        {
            //提取K,B系数 "F:\\我的winform\\bcdbxishu.txt"
            StreamReader sr3 = new StreamReader(@"C:\\Users\Administrator\\Desktop\\20180828调试软件\\bcdbxishu.txt", Encoding.GetEncoding("gb2312"));
                    string K = sr3.ReadLine();
                    string[] sline1 = K.Trim().Split('\r');
                    KtextBox.Text = sline1[0];
                    string B = sr3.ReadLine();
                    string[] sline2 = B.Trim().Split('\r');
                    BtextBox.Text = sline2[0];

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

          
        private void button1_Click_1(object sender, EventArgs e)
        {

            ////修改序列号
            //numhandler(CD + "\\lcd1.c", "F:\\在线光谱仪\\20180718\\小糸车灯光谱版本 - 出货版 -beat 1.1 -614\\小糸车灯光谱版本 - 出货版 -beat 1.1 - 副本\\USER\\lcd.c");


            //这里修改gpxs数据格式
            gpxshandler();
            //这里把修改gpxs数据格式后的文件保存到一个数组
            StreamReader sr4 = new StreamReader(CD+@"\\gpxs1.txt", Encoding.GetEncoding("gb2312"));
            string strLine;
    
            while (sr4.EndOfStream == false)
            {
                try
                {
                    strLine = sr4.ReadToEnd();
                    gpxs = Convert.ToString(strLine);
                }
                catch (Exception ex)
                {
                }
            }
            sr4.Dispose();


           

            //这里修改.c文件里的gpxs KB,   标志位：//HereAddNewGpxsOfMachine
            string num = numtextBox.Text;
            string path1 = CD+@"\\出货版collect1.c";
            string path2 = @"F:\\在线光谱仪\\20180718\小糸车灯光谱版本 - 出货版 -beat 1.1 -614\\小糸车灯光谱版本 - 出货版 -beat 1.1 - 副本\\USER\\collect.c";
            //string path2 = @"F:\\我的winform\\20180718\\小糸车灯光谱版本 - 出货版 -beat 1.1 -614\\小糸车灯光谱版本 - 出货版 -beat 1.1 - 副本\\USER\\collect.c";
            string con = "";

            //清空collect文件
            FileStream stream2 = File.Open(path2, FileMode.OpenOrCreate, FileAccess.Write);
            stream2.Seek(0, SeekOrigin.Begin);
            stream2.SetLength(0);
            stream2.Close();


            FileStream fs5 = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader sr5 = new StreamReader(path1, Encoding.GetEncoding("gb2312"));
            con = sr5.ReadToEnd();
           
            //修改gpxs
            con = con.Replace("HereAddNewGpxsOfMachine", num+ "号的gpxs\r\n" + gpxs+ "\r\n//HereAddNewGpxsOfMachine");
            //替换K,B系数
            string numK = KtextBox.Text;
            string numB = BtextBox.Text;
            Regex regex1 = new Regex(@"pixel\=4\.0141\*\(380\+j\)\-1002\.4");
            con = regex1.Replace(con, "pixel=" + numK + "*(380+j)" + numB);
            MessageBox.Show("KB修改成功！");


            sr5.Close();
            fs5.Close();
            FileStream fs6 = new FileStream(path2, FileMode.Open, FileAccess.Write);
            StreamWriter sw5 = new StreamWriter(fs6);
            sw5.Write(con);
            sw5.Close();
            fs6.Close();
            MessageBox.Show("出货版修改成功！");

        }

        //这里修改gpxs数据格式 
        private void gpxshandler()
        {

          
            string num = numtextBox.Text;
            string path1 = @"C:\\Users\Administrator\\Desktop\\20180828调试软件\\gpxs.txt";
            //string path1 = @"F:\\我的winform\\gpxs.txt";
            string path2 = CD+@"\\gpxs1.txt";
            string con1 = "";

            FileInfo fi = new FileInfo(path2);
            if (!fi.Exists)//如果文件不存在
            {
                fi.Create();//创建文件
            }


            FileStream fs2 = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs2);
            con1 = sr1.ReadToEnd();
            con1 = con1.Replace("\r", ",");
            con1 = con1.Remove(con1.LastIndexOf(","), 1);
            sr1.Close();
            fs2.Close();
            FileStream fs3 = new FileStream(path2, FileMode.Open, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(fs3);
            sw1.WriteLine(con1);
            sw1.Close();
            fs3.Close();
            MessageBox.Show("gpxs1.txt修改格式成功！");

        }

        //这里修改产品序列号  输入原始参考文件lcd1.c,输出到参与编译烧入的程序lcd.c中
        private void numhandler(string path1, string path2)
        {
            string num = numtextBox.Text;
            string con = "";
            FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(path1, Encoding.GetEncoding("gb2312"));
            con = sr.ReadToEnd();

            Regex regex = new Regex(@"S/N:HN18Z0\d\d");
            con = regex.Replace(con, "S/N:HN18Z0" + num);
            sr.Close();
            fs.Close();
            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            sw.WriteLine(con);
            sw.Close();
            fs2.Close();
            MessageBox.Show("序列号修改成功！");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //图表的文件打开
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Filter = "txt文件|*.txt|所有文件|*.*";
            double[] temp = new double[1000];
            int Len = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tBopenfile.Text = ofd.FileName;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string strLine;

                while (sr.EndOfStream == false)
                {
                    try
                    {
                        strLine = sr.ReadLine();
                        tBgpxs.Text = tBgpxs.Text + strLine + "\r\n";
                        temp[Len] = Convert.ToDouble(strLine);
                        Len++;
                    }
                    catch (Exception ex)
                    {
                    }
                }
                sr.Dispose();
                fs.Dispose();
            }

            for (int i = 0; i <= Len; i++)
            {
                if (temp[i] < 0)
                {
                    MessageBox.Show("gpxs有负数！请联系研发人员！");
                    break;
                }
                else   //绘制曲线图
                {
                   
                    float[] temp2= Array.ConvertAll(temp, d => (float)d);
                    userCurve1.ValueMaxLeft = temp2.Max();
                    userCurve1.ValueMaxRight = temp2.Max();
                    userCurve1.SetLeftCurve("A", temp2, Color.DodgerBlue);
                }
            }
            //显示数据到曲线图表


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string num = numtextBox.Text;
            string word1 = "\r\n\\\\" + num + "号的gpxs\r\n";
            string word2 = "\r\n\\\\" + num + "号的K,B";
            string word3 = "\r\n\\\\" + DateTime.Now.ToLocalTime().ToString(); 
            string numKB = "\r\n" + KtextBox.Text + "\r\n" + BtextBox.Text+ "\r\n";
            string pathjl = CD + "\\gpxs记录.txt";

           FileInfo fi = new FileInfo(pathjl);
            if (!fi.Exists)//如果文件不存在
            {
                fi.Create();//创建文件
            }

            FileStream fs2 = File.OpenWrite(pathjl);//打开文件
            fs2.Seek(0, SeekOrigin.End);//指向文件头
            byte[] b4 = Encoding.Default.GetBytes(word3.ToString());//将录入的内容转换为byte数组
            fs2.Write(b4, 0, b4.Length);//写入内容 当前日期
            byte[] b1 = Encoding.Default.GetBytes(word1.ToString());//将录入的内容转换为byte数组
            fs2.Write(b1, 0, b1.Length);//写入内容序列号
            byte[] b2 = Encoding.Default.GetBytes(gpxs.ToString());//将录入的内容转换为byte数组
            fs2.Write(b2, 0, b2.Length);//写入内容gpxs
            byte[] b3 = Encoding.Default.GetBytes(word2.ToString());//将录入的内容转换为byte数组
            fs2.Write(b3, 0, b3.Length);//写入内容kb
            byte[] numkb = Encoding.Default.GetBytes(numKB.ToString());//将录入的内容转换为byte数组
            fs2.Write(numkb, 0, numkb.Length);//写入内容
            fs2.Close();//关闭文件
            MessageBox.Show("操作成功");

        }

        private void butpic_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(this.Width, this.Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(this.Left, this.Top, 0, 0, new Size(this.Width, this.Height));//保存整个窗体为图片
                                                                                           //g.CopyFromScreen(panel游戏区 .PointToScreen(Point.Empty), Point.Empty, panel游戏区.Size);//只保存某个控件（这里是panel游戏区）

            string subPath = CD + "/pic/";
            if (false == System.IO.Directory.Exists(subPath))
            {
                //创建pic文件夹
                System.IO.Directory.CreateDirectory(subPath);
            }
            
            string num = numtextBox.Text;
            string filename = num+"号的截图.png";
            string path2 = subPath + filename;
            bit.Save(path2);//默认保存格式为PNG，保存成jpg格式质量不是很好
            MessageBox.Show("截图保存成功！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //修改产品序列号
            numhandler(CD + "\\lcd1.c", "F:\\在线光谱仪\\20180718\\小糸车灯光谱版本 - 触发版 -beat 1.1 -0705 - 副本\\小糸车灯光谱版本 - 出货版 -beat 1.1 - 副本\\USER\\lcd.c");

            //gpxs1文件打开  保存到string：gpxs
            MessageBox.Show("请先将这台仪器的gpxs粘贴进gpxs1.txt文件内！");
            MessageBox.Show("请先将这台仪器的K,B系数粘K,B方框内！");
            MessageBox.Show("请选择gpxs1.txt文件！");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Filter = "txt文件|*.txt|所有文件|*.*";
            double[] temp = new double[1000];

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tBopenfile.Text = ofd.FileName;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string strLine;

                while (sr.EndOfStream == false)
                {
                    try
                    {
                        strLine = sr.ReadToEnd();
                        gpxs = Convert.ToString(strLine);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                sr.Dispose();
                fs.Dispose();

                ////这里修改.c文件里的gpxs KB,和序列号   标志位：//HereAddNewGpxsOfMachine
                string num = numtextBox.Text;
                string path1 = CD+@"\\触发版collect1.c";
                string path2 = @"F:\\在线光谱仪\\20180718\\小糸车灯光谱版本 - 触发版 -beat 1.1 -0705 - 副本\\小糸车灯光谱版本 - 出货版 -beat 1.1 - 副本\\USER\\collect.c";
                //string path2 = @"F:\\我的winform\\20180718\\小糸车灯光谱版本 - 触发版 -beat 1.1 -0705 - 副本\\小糸车灯光谱版本 - 出货版 -beat 1.1 - 副本\\USER\\collect.c";
                string con = "";

                //清空collect文件
                FileStream stream2 = File.Open(path2, FileMode.OpenOrCreate, FileAccess.Write);
                stream2.Seek(0, SeekOrigin.Begin);
                stream2.SetLength(0);
                stream2.Close();

                FileStream fs5 = new FileStream(path1, FileMode.Open, FileAccess.Read);
                StreamReader sr5 = new StreamReader(path1, Encoding.GetEncoding("gb2312"));
                con = sr5.ReadToEnd();

                //修改gpxs
                con = con.Replace("HereAddNewGpxsOfMachine", num + "号的gpxs\r\n" + gpxs + "\r\n//HereAddNewGpxsOfMachine");
                //替换K,B系数
                string numK = KtextBox.Text;
                string numB = BtextBox.Text;
                Regex regex1 = new Regex(@"pixel\=4\.0141\*\(380\+j\)\-1002\.4");
                con = regex1.Replace(con, "pixel=" + numK + "*(380+j)" + numB);
                MessageBox.Show("KB修改成功！");


                sr5.Close();
                fs5.Close();
                FileStream fs6 = new FileStream(path2, FileMode.Open, FileAccess.Write);
                StreamWriter sw5 = new StreamWriter(fs6);
                sw5.Write(con);
                sw5.Close();
                fs6.Close();
                MessageBox.Show("出货版修改成功！");

            }
        }
    }



}
