﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_rad
{
    public partial class UtrkaVrstaForm : Form
    {
        public UtrkaVrstaForm()
        {
            InitializeComponent();
        }

        private void UtrkaVrstaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zavrsniDataSet.UtrkaVrsta' table. You can move, or remove it, as needed.
            this.utrkaVrstaTableAdapter.Fill(this.zavrsniDataSet.UtrkaVrsta);

        }
    }
}
