﻿using Braincase.USGS.DEM;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DXApplication1.Account;
using DXApplication1.Models;
using DXApplication1.Views;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace DXApplication1
{

    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int chk = 0;
        Panel panel2 = new Panel();
        SimpleButton simpleButtonBatDau = new SimpleButton();
        Label labeTocDo = new Label();
        SimpleButton simpleButtonDatLai = new SimpleButton();
        CheckButton checkButtonTamDung = new CheckButton();
        TrackBar trackBarTocDo = new TrackBar();
        public FrmMain()
        {
            InitializeComponent();
            testribon();
        }

        public void testribon()
        {

            simpleButtonBatDau.ImageOptions.Image = global::DXApplication1.Properties.Resources.start_16;
            simpleButtonBatDau.Location = new System.Drawing.Point(590, 2);
            simpleButtonBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            simpleButtonBatDau.Name = "simpleButtonBatDau";
            simpleButtonBatDau.Size = new System.Drawing.Size(75, 27);
            simpleButtonBatDau.TabIndex = 12;
            simpleButtonBatDau.Text = "Bắt Đầu";
            simpleButtonBatDau.Click += new System.EventHandler(this.simpleButtonBatDau_Click);


            labeTocDo.AutoSize = true;
            labeTocDo.Location = new System.Drawing.Point(395, 37);
            labeTocDo.Name = "labeTocDo";
            labeTocDo.Size = new System.Drawing.Size(80, 17);
            labeTocDo.TabIndex = 11;
            labeTocDo.Text = "Tốc độ : X1";


            simpleButtonDatLai.Location = new System.Drawing.Point(806, 2);
            simpleButtonDatLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            simpleButtonDatLai.Name = "simpleButtonDatLai";
            simpleButtonDatLai.Size = new System.Drawing.Size(51, 27);
            simpleButtonDatLai.TabIndex = 10;
            simpleButtonDatLai.Text = "Đặt Lại";
            simpleButtonDatLai.Click += new System.EventHandler(this.simpleButtonDatLai_Click);


            checkButtonTamDung.ImageOptions.Image = global::DXApplication1.Properties.Resources.pause_16;
            checkButtonTamDung.Location = new System.Drawing.Point(693, 1);
            checkButtonTamDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            checkButtonTamDung.Name = "checkButtonTamDung";
            checkButtonTamDung.Size = new System.Drawing.Size(89, 28);
            checkButtonTamDung.TabIndex = 9;
            checkButtonTamDung.Text = "Tạm Dừng";
            checkButtonTamDung.CheckedChanged += new System.EventHandler(this.checkButtonTamDung_CheckedChanged);


            trackBarTocDo.Location = new System.Drawing.Point(280, 2);
            trackBarTocDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            trackBarTocDo.Maximum = 7;
            trackBarTocDo.Minimum = 1;
            trackBarTocDo.Name = "trackBarTocDo";
            trackBarTocDo.Size = new System.Drawing.Size(274, 56);
            trackBarTocDo.TabIndex = 8;
            trackBarTocDo.Value = 4;
            trackBarTocDo.ValueChanged += new System.EventHandler(this.trackBarTocDo_ValueChanged);


            panel2.Controls.Add(simpleButtonBatDau);
            panel2.Controls.Add(labeTocDo);
            panel2.Controls.Add(simpleButtonDatLai);
            panel2.Controls.Add(checkButtonTamDung);
            panel2.Controls.Add(trackBarTocDo);
            panel2.Location = new System.Drawing.Point(283, 30);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1000, 60);
            panel2.Visible = false;


            panel2.Location = new Point(200, 100);
            ribbonControl1.AddControl(panel2);
        }

        //set form mặc định
        public void Skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Whiteprint";       //tên giao diện set mặc định
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            if (ribbonControl1.SelectedPage == rbpHeThong)
            {
                panel2.Visible = false;
                Program.frm_Map.Close();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Skins();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(chk == 0)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.lg.Close();
                }
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Program.lg = new frmLogin();
            Program.lg.Show();

        }

        private void tabHienThi1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNXEMTTCN")
                {                   
                    kt = 1;
                    break;
                }
            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền xem thông tin!!!", "Thông báo");
            else
            {
                Program.detail_user = new ThongTinNguoiDung();
                Program.detail_userSql.Select_Detail(Program.detail_user, Program.lg.UserLogin.MaDangNhapNguoiDung);
                Detail_User detail_form = new Detail_User();
                detail_form.ShowDialog();
            }    
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "TDMKCN")
                {                   
                    kt = 1;
                    break;
                }

            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền xem thông tin!!!", "Thông báo");
            else
            {
                Program.up_datePass = new UpdatePass();
                Program.up_datePass.ShowDialog();
            }    
          
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                chk = 1;
                Program.lg = new frmLogin();
                Program.lg.Show();
                this.Hide();
            }

        }

        private void barButtonItemBanDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frm_Map = new Views.Frm_test1();
            Program.frm_Map.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(Program.frm_Map);
            Program.frm_Map.Dock = DockStyle.Fill;
            Program.frm_Map.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Program.frm_Map.Show();
            panel2.Visible = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.fileDem.Show();
        }
        // Is Fixing
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelMain.Controls.Contains(Program.frm_Map))
            {
                barButtonItem2_ItemClick(null, null);
                Program.frm_Map.simpleButtonLuuPhuongAn_Click(null, null);
            }
            else
            {
                Program.frm_Map.simpleButtonLuuPhuongAn_Click(null, null);
            }
        }
        private void trackBarTocDo_ValueChanged(object sender, EventArgs e)
        {
            while (true)
            {
                bool tryToLockSpeed = false;
                Monitor.TryEnter(Frm_test1.speedLock, ref tryToLockSpeed);
                float proportion = Program.frm_Map.MapValueToProportion(trackBarTocDo.Value);
                if (tryToLockSpeed)
                {
                    Frm_test1.speed = (short)(Frm_test1.speedInit * proportion);
                    labeTocDo.Text = "Tốc độ : X" + proportion;
                    Monitor.Exit(Frm_test1.speedLock);
                    break;
                }
            }
        }

        private void checkButtonTamDung_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButtonTamDung.Checked)
            {

                checkButtonTamDung.Image = Properties.Resources.start_16;
                checkButtonTamDung.Text = "Tiếp Tục";
                // Set Pause
                lock (Frm_test1.pauseLock)
                {
                    Frm_test1.isPause = true;
                }
            }
            else
            {
                checkButtonTamDung.Image = Properties.Resources.pause_16;
                checkButtonTamDung.Text = "Tạm Dừng";
                // Set Pause
                lock (Frm_test1.pauseLock)
                {
                    Frm_test1.isPause = false;
                }
            }
        }

        private void simpleButtonBatDau_Click(object sender, EventArgs e)
        {
            Frm_test1.readyToWrite.Set();
            Program.frm_Map.a = new Thread((() =>
            {
                Frm_test1.ChangeHeight();
            }));
            Program.frm_Map.a.IsBackground = true;
            Program.frm_Map.a.Start();
            Program.frm_Map.b = new Thread(() =>
            {
                Program.frm_Map.DrawImage(Program.frm_Map.pictureBoxMap);
            });
            Program.frm_Map.b.Start();
            Program.frm_Map.b.IsBackground = true;
        }

        private void simpleButtonDatLai_Click(object sender, EventArgs e)
        {
            Program.frm_Map.a.Abort();
            Program.frm_Map.b.Abort();
            Frm_test1._mDem.Read(Program.frm_Map.path);
            Program.frm_Map.pictureBoxMap.Image = Program.frm_Map.bitmapInit;
            Program.frm_Map.bitmapResize = new Bitmap(Frm_test1.bitmapInit1, 1201, 1201);
        }
    }
}
