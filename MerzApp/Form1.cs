using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MerzApp
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

        private void menuQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            Stream stream = null;
            TextReader reader = null;

            openFile.InitialDirectory = @"c:\";
            openFile.Filter = "txt files (*.txt)|*.txt|config files (*.config)|*.config|All files *.*|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFile.OpenFile()) != null)
                    {
                        Debug.WriteLine(stream);
                        using (stream)
                        {
                            using (reader = new StreamReader(stream))
                            {
                                String line = reader.ReadLine();
                                ListViewItem items = new ListViewItem(line);
                                Debug.WriteLine(line);
                                items.SubItems.Add(line);
                                listOfFiles.Items.Add(items);
                            }
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
    }
}
