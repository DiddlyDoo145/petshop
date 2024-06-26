﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class BlurBg : Form
    {
        public BlurBg()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Load += BlurBg_Load;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MARGINS margins = new MARGINS();
            margins.Top = Height;
            margins.Left = Left;
            Console.WriteLine("SetAero: 7 = {0}, 10 = {1}",
                DllHelper.SetAero7(this.Handle, margins),
                DllHelper.SetAero10(this.Handle));
            this.BackColor = Color.Black;
            this.Location = new Point(175, 100);
            this.Size = new Size(1355, 820);
        }

        private void BlurBg_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool pinlog_in = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "EmpCODEPIN")
                {
                    pinlog_in = true;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.BringToFront();
                    break;
                }
            }
            if (pinlog_in == false)
            {
                EmpCODEPIN ecp = new EmpCODEPIN();
                ecp.StartPosition = FormStartPosition.CenterScreen;
                ecp.Show();
            }
        }

        private void BlurBg_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
    #region blurBackground

    public static class DllHelper
    {
        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        [DllImport("DwmApi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS pMarInset);

        public static int SetAero10(IntPtr hwnd)
        {
            AccentPolicy accentPolicy = new AccentPolicy
            {
                AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND,
                AccentFlags = 0,
                GradientColor = 0,
                AnimationId = 0
            };
            WindowCompositionAttributeData data = new WindowCompositionAttributeData
            {
                Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY
            };
            int accentSize = Marshal.SizeOf(accentPolicy);
            IntPtr accentPtr = Marshal.AllocHGlobal(accentSize);
            Marshal.StructureToPtr(accentPolicy, accentPtr, false);
            data.Data = accentPtr;
            data.SizeOfData = accentSize;
            int result = SetWindowCompositionAttribute(hwnd, ref data);
            Marshal.FreeHGlobal(accentPtr);
            return result;
        }
        public static int SetAero7(IntPtr mainWindowPtr, MARGINS margins)
        {
            return DwmExtendFrameIntoClientArea(mainWindowPtr, ref margins);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowCompositionAttributeData
    {
        public WindowCompositionAttribute Attribute;
        public IntPtr Data;
        public int SizeOfData;
    }
    internal enum WindowCompositionAttribute
    {
        WCA_UNDEFINED = 0,
        WCA_NCRENDERING_ENABLED = 1,
        WCA_NCRENDERING_POLICY = 2,
        WCA_TRANSITIONS_FORCEDISABLED = 3,
        WCA_ALLOW_NCPAINT = 4,
        WCA_CAPTION_BUTTON_BOUNDS = 5,
        WCA_NONCLIENT_RTL_LAYOUT = 6,
        WCA_FORCE_ICONIC_REPRESENTATION = 7,
        WCA_EXTENDED_FRAME_BOUNDS = 8,
        WCA_HAS_ICONIC_BITMAP = 9,
        WCA_THEME_ATTRIBUTES = 10,
        WCA_NCRENDERING_EXILED = 11,
        WCA_NCADORNMENTINFO = 12,
        WCA_EXCLUDED_FROM_LIVEPREVIEW = 13,
        WCA_VIDEO_OVERLAY_ACTIVE = 14,
        WCA_FORCE_ACTIVEWINDOW_APPEARANCE = 15,
        WCA_DISALLOW_PEEK = 16,
        WCA_CLOAK = 17,
        WCA_CLOAKED = 18,
        WCA_ACCENT_POLICY = 19,
        WCA_FREEZE_REPRESENTATION = 20,
        WCA_EVER_UNCLOAKED = 21,
        WCA_VISUAL_OWNER = 22,
        WCA_HOLOGRAPHIC = 23,
        WCA_EXCLUDED_FROM_DDA = 24,
        WCA_PASSIVEUPDATEMODE = 25,
        WCA_LAST = 26
    }
    internal enum AccentState
    {
        ACCENT_DISABLED = 0,
        ACCENT_ENABLE_GRADIENT = 1,
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
        ACCENT_ENABLE_BLURBEHIND = 3,
        ACCENT_ENABLE_ACRYLICBLURBEHIND = 4,
        ACCENT_ENABLE_HOSTBACKDROP = 5,
        ACCENT_INVALID_STATE = 6
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct AccentPolicy
    {
        public AccentState AccentState;
        public int AccentFlags;
        public int GradientColor;
        public int AnimationId;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct MARGINS
    {
        public int Left;
        public int Right;
        public int Top;
        public int Bottom;
    }
    #endregion
}
