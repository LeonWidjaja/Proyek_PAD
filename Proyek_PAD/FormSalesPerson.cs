﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_PAD
{
    public partial class FormSalesPerson : Form
    {
        private SalesPerson loggedInUser;
        public FormSalesPerson(SalesPerson loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }
    }
}
