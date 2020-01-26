using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Collections;

namespace meuautoclick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Left click: Apertando 'g', você vai gravar a tela!                                                            " +
   
                "Left click: Apertando 'd', você vai fazer double click!                                                   " +
                "Right click: Apertando 'r', você vai fazer right click!                                                      " + 
                "Pra começar aperte 's'!                                                                                                   " +
                "Pra Cancelar, aperte 'ESC'!                                                                                                 " +
                "Pra gravar Hotkey aperte o button Gravar");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
