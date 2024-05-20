using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Management;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.CSharp;
using System.CodeDom;
using System.Reflection;
using Microsoft.Win32.SafeHandles;
using System.Threading;
namespace PerfWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        [DllImport("user32.dll")]
        static extern bool DrawMenuBar(IntPtr hWnd);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern bool GetAsyncKeyState(Keys vKey);
        private static bool getstate = false;
        public static Form2 form2 = new Form2();
        private const int GWL_STYLE = -16;
        private const uint WS_BORDER = 0x00800000;
        private const uint WS_CAPTION = 0x00C00000;
        private const uint WS_SYSMENU = 0x00080000;
        private const uint WS_MINIMIZEBOX = 0x00020000;
        private const uint WS_MAXIMIZEBOX = 0x00010000;
        private const uint WS_OVERLAPPED = 0x00000000;
        private const uint WS_POPUP = 0x80000000;
        private const uint WS_TABSTOP = 0x00010000;
        private const uint WS_VISIBLE = 0x10000000;
        private static int[] wd = { 2, 2 };
        private static int[] wu = { 2, 2 };
        public static void valchanged(int n, bool val)
        {
            if (val)
            {
                if (wd[n] <= 1)
                {
                    wd[n] = wd[n] + 1;
                }
                wu[n] = 0;
            }
            else
            {
                if (wu[n] <= 1)
                {
                    wu[n] = wu[n] + 1;
                }
                wd[n] = 0;
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            getstate = true;
            Task.Run(() => StartWindowTitleRemover());
            Task.Run(() => Start());
            try
            {
                form2.Show();
            }
            catch { }
        }
        private void StartWindowTitleRemover()
        {
            while (true)
            {
                valchanged(0, GetAsyncKeyState(Keys.PageDown));
                if (wu[0] == 1)
                {
                    int width = Screen.PrimaryScreen.Bounds.Width;
                    int height = Screen.PrimaryScreen.Bounds.Height;
                    IntPtr window = GetForegroundWindow();
                    SetWindowLong(window, GWL_STYLE, WS_SYSMENU);
                    SetWindowPos(window, -2, 0, 0, width, height, 0x0040);
                    DrawMenuBar(window);
                }
                valchanged(1, GetAsyncKeyState(Keys.PageUp));
                if (wu[1] == 1)
                {
                    IntPtr window = GetForegroundWindow();
                    SetWindowLong(window, GWL_STYLE, WS_CAPTION | WS_POPUP | WS_BORDER | WS_SYSMENU | WS_TABSTOP | WS_VISIBLE | WS_OVERLAPPED | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);
                    DrawMenuBar(window);
                }
                System.Threading.Thread.Sleep(100);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e.KeyData);
        }
        private void OnKeyDown(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                const string message = "• Author: Michaël André Franiatte.\n\r\n\r• Contact: michael.franiatte@gmail.com.\n\r\n\r• Publisher: https://github.com/michaelandrefraniatte.\n\r\n\r• Copyrights: All rights reserved, no permissions granted.\n\r\n\r• License: Not open source, not free of charge to use.";
                const string caption = "About";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void chkMain_CheckedChanged(object sender, EventArgs e)
        {
            form2.ohmdt.MainboardEnabled = chkMain.Checked;
        }
        private void chkFan_CheckedChanged(object sender, EventArgs e)
        {
            form2.ohmdt.FanControllerEnabled = chkFan.Checked;
        }
        private void chkCPU_CheckedChanged(object sender, EventArgs e)
        {
            form2.ohmdt.CPUEnabled = chkCPU.Checked;
        }
        private void chkGPU_CheckedChanged(object sender, EventArgs e)
        {
            form2.ohmdt.GPUEnabled = chkGPU.Checked;
        }
        private void chkRAM_CheckedChanged(object sender, EventArgs e)
        {
            form2.ohmdt.RAMEnabled = chkRAM.Checked;
        }
        private void chkHDD_CheckedChanged(object sender, EventArgs e)
        {
            form2.ohmdt.HDDEnabled = chkHDD.Checked;
        }
        public void Start()
        {
            while (getstate)
            {
                if (form2.ohmdt.nodeCount.ToString() != "" & form2.ohmdt.SensorCount.ToString() != "")
                {
                    this.lblNodeCount.Text = "Hardwares " + form2.ohmdt.nodeCount.ToString();
                    this.lblSensorCount.Text = "Sensors " + form2.ohmdt.SensorCount.ToString();
                    getstate = false;
                }
                Thread.Sleep(1000);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            getstate = false;
        }
    }
}