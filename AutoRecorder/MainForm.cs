﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRecorder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listView.Columns.Add("Nimi", 200);
            listView.Items.Add("nakki");
            listView.Items.Add("nakki");
            listView.Items.Add("nakki");

            listView.Update();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.ReadSettings();
        }
    }
}
