﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAKutuphaneotomasyonu.DATA;

namespace WFAKutuphaneOtomasyonu.UI
{
    public partial class LoginForm : Form
    {
        KullaniciYöneticisi kullaniciYoneticisi;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlForm kayitOlForm = new KayitOlForm();
            kayitOlForm.ShowDialog();


        }
    }
}
