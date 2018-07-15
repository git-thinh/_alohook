using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace zalohook
{
    class status_01
    {
        #region

        private static void SetPosition(int a, int b)
        {
            SetCursorPos(a, b);
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);


        //Initialization
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool EnableWindow(IntPtr hwnd, bool enable);
        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr handle, int x, int y, int width,
        int height, bool redraw);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool BringWindowToTop(IntPtr hWnd);

        static int SW_SHOW = 5;





        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        static void mouse_click(int X, int Y)
        {
            SetPosition(X, Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)X, (uint)Y, 0, 0);
            Thread.Sleep(3000);
        }

        #endregion

        [STAThread]
        public static void Run(int timeOut)
        {
            string[] a = @"Đón gót dài đầu sư tử
Đón gót ngắn đầu sư tử
SB11BC_Thắt lưng da
SB11N_Thắt lưng da
SA14_Móc chìa khóa
SA13_Móc chìa khóa
SA12_Móc chìa khóa
SB17R_Thắt lưng da
SB2240_Thắt lưng da
SB2320_Thắt lưng da
SB15BC_Thắt lưng da
SB14BC_Thắt lưng da
SW2309_Ví đựng card
SW2310_Ví đựng card
SW2320_Ví đựng card
SW2328_Ví đựng card
SW2340_Ví đựng card
SW2355_Ví đựng card
SW2028_Ví da nam
SW2040_Ví da nam
SW111BC
SW222BC
SW222BR
SW222BG
SW666BC
SM111BC
SKC116BC
TCC31_Clutch Ipad nâu vân
SKC111BC
TCC21_Clutch Iphone 2 khóa
TCC11_Clutch Iphone 1 khóa
SKB2028_ Túi công sở cỡ lớn
SKB666BY
SK27246_Giày lười mũi đan xen
SK27246_Giày lười mũi đan xen
SK27246_Giày lười mũi đan xen
SK27246_Giày lười mũi đan xen
SK27246_Giày lười mũi đan xen
SK27244_Giày lười 2 vạch caro
SK27244_Giày lười 2 vạch caro
SK27244_Giày lười 2 vạch caro
SK27244_Giày lười 2 vạch caro
SK27244_Giày lười 2 vạch caro
SK2508_Giày lười sọc ngang
SK2508_Giày lười sọc ngang
SK2508_Giày lười sọc ngang
SK2508_Giày lười sọc ngang
SK2508_Giày lười sọc ngang
SK2130_Giày lười hoa văn
SK2130_Giày lười hoa văn
SK2130_Giày lười hoa văn
SK2130_Giày lười hoa văn
SK2130_Giày lười hoa văn
SK21758_Giày lười trơn
SK21758_Giày lười trơn
SK21758_Giày lười trơn
SK21758_Giày lười trơn
SK21758_Giày lười trơn
TOKYO999BY
TOKYO999BY
TOKYO999BY
TOKYO999BY
TOKYO999BY
TOKYO999B
TOKYO999B
TOKYO999B
TOKYO999B
TOKYO999B
TOKYO999KBR
TOKYO999KBR
TOKYO999KBR
TOKYO999KBR
TOKYO999KBR
SK2015_Giày da lộn
SK2015_Giày da lộn
SK2015_Giày da lộn
SK2015_Giày da lộn
SK2015_Giày da lộn
TOKYO999KB
TOKYO999KB
TOKYO999KB
TOKYO999KB
TOKYO999KB
SK18577_Giày dây trơn
SK18577_Giày dây trơn
SK18577_Giày dây trơn
SK18577_Giày dây trơn
SK18577_Giày dây trơn
SK18573_Giày dây mũi đậm
SK18573_Giày dây mũi đậm
SK18573_Giày dây mũi đậm
SK18573_Giày dây mũi đậm
SK18573_Giày dây mũi đậm
SK18567B_ Giày dây 2 viền gờ
SK18567B_ Giày dây 2 viền gờ
SK18567B_ Giày dây 2 viền gờ
SK18567B_ Giày dây 2 viền gờ
SK18567B_ Giày dây 2 viền gờ
SK18567BR_ Giày dây 2 viền gờ
SK18567BR_ Giày dây 2 viền gờ
SK18567BR_ Giày dây 2 viền gờ
SK18567BR_ Giày dây 2 viền gờ
SK18567BR_ Giày dây 2 viền gờ
SK17242_Giày dây trơn
SK17242_Giày dây trơn
SK17242_Giày dây trơn
SK17242_Giày dây trơn
SK17242_Giày dây trơn
SK1633_Giày công sở cá sấu mũi trơn
SK1633_Giày công sở cá sấu mũi trơn
SK1633_Giày công sở cá sấu mũi trơn
SK1633_Giày công sở cá sấu mũi trơn
SK1633_Giày công sở cá sấu mũi trơn
TOKYO6688LBC
TOKYO6688LBC
TOKYO6688LBC
TOKYO6688LBC
TOKYO6688LBC
SK16353_Giày dây da lộn giữa
SK16353_Giày dây da lộn giữa
SK16353_Giày dây da lộn giữa
SK16353_Giày dây da lộn giữa
SK16353_Giày dây da lộn giữa
SK16352_Giày dây trơn
SK16352_Giày dây trơn
SK16352_Giày dây trơn
SK16352_Giày dây trơn
SK16352_Giày dây trơn
SK16351_Giày dây mũi lỗ
SK16351_Giày dây mũi lỗ
SK16351_Giày dây mũi lỗ
SK16351_Giày dây mũi lỗ
SK16351_Giày dây mũi lỗ
SK1508_Giày công sở oxford
SK1508_Giày công sở oxford
SK1508_Giày công sở oxford
SK1508_Giày công sở oxford
SK1508_Giày công sở oxford
TOKYO889LBR
TOKYO889LBR
TOKYO889LBR
TOKYO889LBR
TOKYO889LBR
TOKYO888LBR
TOKYO888LBR
TOKYO888LBR
TOKYO888LBR
TOKYO888LBR
TOKYO668LBR
TOKYO668LBR
TOKYO668LBR
TOKYO668LBR
TOKYO668LBR
TOKYO333LBR
TOKYO333LBR
TOKYO333LBR
TOKYO333LBR
TOKYO333LBR
TOKYO333LBC
TOKYO333LBC
TOKYO333LBC
TOKYO333LBC
TOKYO333LBC
TOKYO668LBC
TOKYO668LBC
TOKYO668LBC
TOKYO668LBC
TOKYO668LBC
TOKYO888LBY
TOKYO888LBY
TOKYO888LBY
TOKYO888LBY
TOKYO888LBY
TOKYO333LBY
TOKYO333LBY
TOKYO333LBY
TOKYO333LBY
TOKYO333LBY
TOKYO6699LB
TOKYO6699LB
TOKYO6699LB
TOKYO6699LB
TOKYO6699LB
TOKYO6688LB
TOKYO6688LB
TOKYO6688LB
TOKYO6688LB
TOKYO6688LB
TOKYO6655LBR
TOKYO6655LBR
TOKYO6655LBR
TOKYO6655LBR
TOKYO6655LBR
TOKYO6633LB
TOKYO6633LB
TOKYO6633LB
TOKYO6633LB
TOKYO6633LB
TOKYO999LB
TOKYO999LB
TOKYO999LB
TOKYO999LB
TOKYO999LB
TOKYO889LB
TOKYO889LB
TOKYO889LB
TOKYO889LB
TOKYO889LB
TOKYO888LB
TOKYO888LB
TOKYO888LB
TOKYO888LB
TOKYO888LB
TOKYO668LB
TOKYO668LB
TOKYO668LB
TOKYO668LB
TOKYO668LB
TOKYO666LB
TOKYO666LB
TOKYO666LB
TOKYO666LB
TOKYO666LB
TOKYO333LB
TOKYO333LB
TOKYO333LB
TOKYO333LB
TOKYO333LB
SK07761BR_Giày lười dạo phố
SK07761BR_Giày lười dạo phố
SK07761BR_Giày lười dạo phố
SK07761BR_Giày lười dạo phố
SK07761BR_Giày lười dạo phố
SK07760B_Giày lười da cá sấu khóa H
SK07760B_Giày lười da cá sấu khóa H
SK07760B_Giày lười da cá sấu khóa H
SK07760B_Giày lười da cá sấu khóa H
SK07760B_Giày lười da cá sấu khóa H
SK07761B_Giày lười dạo phố
SK07761B_Giày lười dạo phố
SK07761B_Giày lười dạo phố
SK07761B_Giày lười dạo phố
SK07761B_Giày lười dạo phố
SK07760BR_Giày lười da cá sấu khóa H
SK07760BR_Giày lười da cá sấu khóa H
SK07760BR_Giày lười da cá sấu khóa H
SK07760BR_Giày lười da cá sấu khóa H
SK07760BR_Giày lười da cá sấu khóa H
SK018_Giày lười viền 2 bên
SK018_Giày lười viền 2 bên
SK018_Giày lười viền 2 bên
SK018_Giày lười viền 2 bên
SK018_Giày lười viền 2 bên
SK017_Giày lười viền 2 bên
SK017_Giày lười viền 2 bên
SK017_Giày lười viền 2 bên
SK017_Giày lười viền 2 bên
SK017_Giày lười viền 2 bên
SK016_Giày dây viền 2 bên
SK016_Giày dây viền 2 bên
SK016_Giày dây viền 2 bên
SK016_Giày dây viền 2 bên
SK016_Giày dây viền 2 bên
SK015_Giày dây viền 2 bên
SK015_Giày dây viền 2 bên
SK015_Giày dây viền 2 bên
SK015_Giày dây viền 2 bên
SK015_Giày dây viền 2 bên
SK014_Giày lười mõm nhọn
SK014_Giày lười mõm nhọn
SK014_Giày lười mõm nhọn
SK014_Giày lười mõm nhọn
SK014_Giày lười mõm nhọn
SK013_Giày lười mõm nhọn
SK013_Giày lười mõm nhọn
SK013_Giày lười mõm nhọn
SK013_Giày lười mõm nhọn
SK013_Giày lười mõm nhọn
SK012_Giày dây mũi lỗ
SK012_Giày dây mũi lỗ
SK012_Giày dây mũi lỗ
SK012_Giày dây mũi lỗ
SK012_Giày dây mũi lỗ
SK011_Giày dây mũi lỗ
SK011_Giày dây mũi lỗ
SK011_Giày dây mũi lỗ
SK011_Giày dây mũi lỗ
SK011_Giày dây mũi lỗ
TOKYO6789TAB
TOKYO6789TAB
TOKYO6789TAB
TOKYO6789TAB
TOKYO6789TAB
SK078B_Giày lười đan xen khóa ngang
SK078B_Giày lười đan xen khóa ngang
SK078B_Giày lười đan xen khóa ngang
SK078B_Giày lười đan xen khóa ngang
SK078B_Giày lười đan xen khóa ngang
SK0782B_Giày lười đan
SK0782B_Giày lười đan
SK0782B_Giày lười đan
SK0782B_Giày lười đan
SK0782B_Giày lười đan
SK010_Giày dây sport
SK010_Giày dây sport
SK010_Giày dây sport
SK010_Giày dây sport
SK010_Giày dây sport
SK009_Giày dây sport
SK009_Giày dây sport
SK009_Giày dây sport
SK009_Giày dây sport
SK009_Giày dây sport
SK008_Giày lười trơn
SK008_Giày lười trơn
SK008_Giày lười trơn
SK008_Giày lười trơn
SK008_Giày lười trơn
SK007_Giày lười trơn
SK007_Giày lười trơn
SK007_Giày lười trơn
SK007_Giày lười trơn
SK007_Giày lười trơn
SK006_Boots  kéo khóa cao cổ
SK006_Boots  kéo khóa cao cổ
SK006_Boots  kéo khóa cao cổ
SK006_Boots  kéo khóa cao cổ
SK006_Boots  kéo khóa cao cổ
TOKYO111BABR
TOKYO111BABR
TOKYO111BABR
TOKYO111BABR
TOKYO111BABR
SK005_Boots kéo khóa cao cổ
SK005_Boots kéo khóa cao cổ
SK005_Boots kéo khóa cao cổ
SK005_Boots kéo khóa cao cổ
SK005_Boots kéo khóa cao cổ
SK004_Boots buộc dây cao cổ
SK004_Boots buộc dây cao cổ
SK004_Boots buộc dây cao cổ
SK004_Boots buộc dây cao cổ
SK004_Boots buộc dây cao cổ
SK003_Boots buộc dây cao cổ
SK003_Boots buộc dây cao cổ
SK003_Boots buộc dây cao cổ
SK003_Boots buộc dây cao cổ
SK003_Boots buộc dây cao cổ
TOKYO111BABC
TOKYO111BABC
TOKYO111BABC
TOKYO111BABC
TOKYO111BABC
TOKYO222BC
TOKYO222BC
TOKYO222BC
TOKYO222BC
TOKYO222BC
SK002_Giày công sở tokyo classic
SK002_Giày công sở tokyo classic
SK002_Giày công sở tokyo classic
SK002_Giày công sở tokyo classic
SK002_Giày công sở tokyo classic
SK0188_Giày lười đế cao su
SK0188_Giày lười đế cao su
SK0188_Giày lười đế cao su
SK0188_Giày lười đế cao su
SK0188_Giày lười đế cao su
SK001_Giày công sở tokyo classic
SK001_Giày công sở tokyo classic
SK001_Giày công sở tokyo classic
SK001_Giày công sở tokyo classic
SK001_Giày công sở tokyo classic
TOKYO111BABY
TOKYO111BABY
TOKYO111BABY
TOKYO111BABY
TOKYO111BABY
SK078_Giày lười đan xen khóa ngang
SK078_Giày lười đan xen khóa ngang
SK078_Giày lười đan xen khóa ngang
SK078_Giày lười đan xen khóa ngang
SK078_Giày lười đan xen khóa ngang
SK0782BY_Giày lười đan
SK0782BY_Giày lười đan
SK0782BY_Giày lười đan
SK0782BY_Giày lười đan
SK0782BY_Giày lười đan
SK0781 _Giày lười đan xen khóa ngang
SK0781 _Giày lười đan xen khóa ngang
SK0781 _Giày lười đan xen khóa ngang
SK0781 _Giày lười đan xen khóa ngang
SK0781 _Giày lười đan xen khóa ngang
TOKYO6789BAB
TOKYO6789BAB
TOKYO6789BAB
TOKYO6789BAB
TOKYO6789BAB
TOKYO660B
TOKYO660B
TOKYO660B
TOKYO660B
TOKYO660B
TOKYO222B
TOKYO222B
TOKYO222B
TOKYO222B
TOKYO222B
TOKYO111BAB
TOKYO111BAB
TOKYO111BAB
TOKYO111BAB
TOKYO111BAB
SK2015_Giày da lộn
SK21758_Giày lười trơn
SK2508_Giày lười sọc ngang
SK2130_Giày lười hoa văn
SK27246_Giày lười mũi đan xen
SK27244_Giày lười 2 vạch caro
SK16353_Giày dây da lộn giữa
SK16352_Giày dây trơn
SK18577_Giày dây trơn
SK18573_Giày dây mũi đậm
SK18567BR_ Giày dây 2 viền gờ
SK17242_Giày dây trơn
SK16351_Giày dây mũi lỗ
SK1633_Giày công sở cá sấu mũi trơn
SK1508_Giày công sở oxford
SK0188_Giày lười đế cao su
SK07761B_Giày lười dạo phố
SK07760BR_Giày lười da cá sấu khóa H
SK078_Giày lười đan xen khóa ngang
SA21_Kẹp giấy da
SA11_Móc chìa khóa
SB2120_Thắt lưng da
SKB2010_ Túi công sở cỡ lớn
TCB22_Túi công sở cỡ lớn
SK001_Giày công sở tokyo classic
SK002_Giày công sở tokyo classic
SK003_Boots buộc dây cao cổ
SK004_Boots buộc dây cao cổ
SK005_Boots kéo khóa cao cổ
SK006_Boots  kéo khóa cao cổ
SK007_Giày lười trơn
SK008_Giày lười trơn
SK009_Giày dây sport
SK010_Giày dây sport
SK011_Giày dây mũi lỗ
SK012_Giày dây mũi lỗ
SK013_Giày lười mõm nhọn
SK014_Giày lười mõm nhọn
SK015_Giày dây viền 2 bên
SK016_Giày dây viền 2 bên
SK017_Giày lười viền 2 bên
SK018_Giày lười viền 2 bên
Ví nam Monica
TCC30_Clutch Ipad nâu cà phê
TCC20_Clutch Iphone 2 khóa
TCC10_Clutch Iphone 1 khóa
SW2120_Ví da nam
SW2220_Ví da nam
SW1020_Ví da nam
SW2010_Ví da nam
SW2020_Ví da nam
SW2410_Ví đựng card
SLB2055 Cặp da
SLB2010 Cặp da
SLC3010 Clutch nam
SLC3020 Clutch nam
SLC2510 Clutch nam
SLC2520 Clutch nam
SLW10 Ví đứng
SLW20 Ví ngang
SLW30 Ví dài
SLW40 Ví đựng card
SBL22 Thắt lưng
SB2410_Thắt lưng da
SW111B
SW666B
SM111B
SW222B
TOKYO668LB
TOKYO668LBC
TOKYO668LBR
TOKYO666LB
TOKYO6688LB
TOKYO6688LBC
TOKYO999LB
TOKYO999KB
TOKYO999KBR
TOKYO999B
TOKYO999BY
TOKYO6699LB
TOKYO6633LB
TOKYO6655LBR
TOKYO888LB
TOKYO888LBR
TOKYO888LBY
TOKYO333LB
SKB333B
SKB666B
SKB555B
TCC333B
TOKYO6789BAB
TOKYO6789TAB
TOKYO660B
TOKYO111BAB
TOKYO222B
TOKYO222BC
Đón gót da
SK078B_Giày lười đan xen khóa ngang
SK0781 _Giày lười đan xen khóa ngang
SK0782BY_Giày lười đan
SK0782B_Giày lười đan
SK07760B_Giày lười da cá sấu khóa H
SK18567B_ Giày dây 2 viền gờ
SK07761BR_Giày lười dạo phố
TOKYO333LBY
TOKYO333LBR
TOKYO333LBC
Khăn Shinko
Giá để thắt lưng
Giá treo giày
Giá treo túi
TOKYO111BABC
TOKYO111BABY
TOKYO111BABR
M6789
M6789B
M888LB
M888LBC
M888LBY
M888LBR
TOKYO668LBY
TOKYO999BC
TOKYO999BR
M999CC
SB14B_Thắt lưng da
SB11B_Thắt lưng da
SB17B_Thắt lưng da
SB15B_Thắt lưng da
SB18BC_Thắt lưng da
SB19B_Thắt lưng da
SKB224N
SKC111B
SKC116B
SKC112B
TOKYO889LBR
TOKYO889LB".Split(new string[] { Environment.NewLine }, StringSplitOptions.None);


            Process[] processes = Process.GetProcesses();

            if (File.Exists("pid.txt"))
            {
                string spid = File.ReadAllText("pid.txt");
                if (!string.IsNullOrEmpty(spid))
                {
                    int id = 0;
                    if (int.TryParse(spid.Trim(), out id))
                    {
                        if (id > 0)
                        {
                            try
                            {
                                foreach (Process p in processes)
                                {
                                    if (p.Id == id)
                                    {
                                        p.Kill();
                                        break;
                                    }
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }

            Thread.Sleep(timeOut);
            Clipboard.SetText("903209655");

            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle) && p.MainWindowTitle.ToLower().Contains("zalo"))
                {
                    //SetPosition(10, 10);
                    //App app = new App(p);
                    //app.Show();

                    IntPtr HWND = p.MainWindowHandle;
                    ShowWindow(HWND, SW_SHOW);
                    EnableWindow(HWND, true);
                    MoveWindow(HWND, 0, 50, 640, 480, true);

                    BringWindowToTop(HWND);

                    mouse_click(99, 15); //zalo click icon taskbar

                    mouse_click(300, 93); //zalo click more ...

                    mouse_click(100, 180); //zalo click status edit

                    //mouse_click(274, 381); //zalo enter phone number

                    //SendKeys.SendWait("^v");
                    ////SendKeys.SendWait("{CTRL}v");
                    ////SendKeys.SendWait("^(v)");
                    ////SendKeys.SendWait("{CTRL}v");
                    //Thread.Sleep(1000);

                    //mouse_click(719, 376); //zalo click button search
                    //mouse_click(636, 544); //zalo send message

                    int k = new Random().Next(0, a.Length - 1);
                    string name = a[k] + " " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    Console.Title = name;
                    Clipboard.SetText(name);
                    SendKeys.SendWait("^v");
                    Thread.Sleep(1000);
                    SendKeys.SendWait("{ENTER}");

                    break;
                }
            }

            int pid = Process.GetCurrentProcess().Id;
            File.WriteAllText("pid.txt", pid.ToString());

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Process proc = new Process();
            proc.StartInfo.FileName = path;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();

            //Console.ReadKey();
        } //end


    }
}
