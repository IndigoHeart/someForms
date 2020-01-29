using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace someForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Switch to the next tab in tabcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void next_button_Click(object sender, EventArgs e)
        {
            //int number_of_tabs = tabControl1.TabCount;
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                tabControl1.SelectTab(0);
            }
            else
            {
                tabControl1.SelectTab(tabControl1.SelectedIndex + 1);
            }
        }
        /// <summary>
        /// Switch to the prev tab in tabcontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prev_button_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(tabControl1.TabCount - 1);
            }
            else
            {
                tabControl1.SelectTab(tabControl1.SelectedIndex - 1);
            }
        }
    }
}
