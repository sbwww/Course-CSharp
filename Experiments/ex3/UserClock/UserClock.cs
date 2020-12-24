using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserClock {
    public partial class UserClock : UserControl {
        public UserClock() {
            InitializeComponent();
        }

        private DateTime Time;

        private void timer1_Tick(object sender, EventArgs e) {
            System.Console.WriteLine("Tick");
            Time = DateTime.Now;
            Invalidate();
        }

        public void InitCoordinates(Graphics dc) {
            if (Width == 0 || Height == 0)return;
            dc.TranslateTransform(Width / 2, Height / 2);
            dc.ScaleTransform(Height / 250F, Width / 250F);
        }

        public void DrawDots(Graphics dc, Brush brush) {
            int iSize = 0;
            for (int i = 0; i < 60; ++i) {
                if (i % 5 == 0)iSize = 15;
                else iSize = 5;
            }
            dc.FillEllipse(brush, -iSize / 2, -100 - iSize / 2, iSize, iSize);
            dc.RotateTransform(6);
        }

        protected virtual void DrawHourHand(Graphics grfx, Pen pn) {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360.0F * Time.Hour / 12 + 30.0F * Time.Minute / 60);
            grfx.DrawLine(pn, 0, 0, 0, -50);
            grfx.Restore(gs);
        }

        protected virtual void DrawMinuteHand(Graphics grfx, Pen pn) {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360.0F * Time.Minute / 60 + 6.0F * Time.Second / 60);
            grfx.DrawLine(pn, 0, 0, 0, -70);
            grfx.Restore(gs);
        }

        protected virtual void DrawSecondHand(Graphics grfx, Pen pn) {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360.0F * Time.Second / 60);
            grfx.DrawLine(pn, 0, 0, 0, -100);
            grfx.Restore(gs);
        }

        private void UserClock_Paint(object sender, PaintEventArgs e) {
            Graphics dc = e.Graphics;
            Pen pn = new Pen(ForeColor);
            SolidBrush br = new SolidBrush(ForeColor);
            InitCoordinates(dc);
            DrawDots(dc, br);
            DrawHourHand(dc, pn);
            DrawMinuteHand(dc, pn);
            DrawSecondHand(dc, pn);
        }

        private void UserClock_Load(object sender, EventArgs e) {
            timer1.Start();
        }
    }
}