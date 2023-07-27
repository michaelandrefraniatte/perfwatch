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
        private static bool getstate = false;
        public static Form2 form2 = new Form2();
        private void Form1_Shown(object sender, EventArgs e)
        {
            getstate = true;
            Task.Run(() => Start());
            try
            {
                form2.Show();
            }
            catch { }
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