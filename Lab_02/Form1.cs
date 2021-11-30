using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class lab02Form : Form
    {
        public lab02Form()
        {
            InitializeComponent();
        }
        private void AtualizarCor()
        {
            corLabel.BackColor = Color.FromArgb(
                vermelhoHScrollBar.Value,
                verdeHScrollBar.Value,
                azulHScrollBar.Value
                );
        }

        private void vermelhoHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            vermelhoLabel.Text = vermelhoHScrollBar.Value.ToString();
            AtualizarCor();
        }

        private void verdeHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            verdeLabel.Text = verdeHScrollBar.Value.ToString();
            AtualizarCor();
        }

        private void azulHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            azulLabel.Text = azulHScrollBar.Value.ToString();
            AtualizarCor();
        }

        private void lab02Form_Load(object sender, EventArgs e)
        {
            vermelhoHScrollBar_Scroll(null, null);
            verdeHScrollBar_Scroll(null, null);
            azulHScrollBar_Scroll(null, null);
        }
    }
}
