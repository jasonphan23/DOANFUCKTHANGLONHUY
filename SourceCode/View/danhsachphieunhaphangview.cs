using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.ENTITY;

namespace WindowsFormsApplication1.View
{
    public partial class danhsachphieunhaphangview : UserControl
    {
        Book book;
        public danhsachphieunhaphangview()
        {
            InitializeComponent();
            this.book = new Book();
        }
    }
}
