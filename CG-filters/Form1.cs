using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CG_filters
{
  public partial class Form1 : Form
  {
    private Bitmap image;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void file_open_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All files (*.*) | *.*";

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        image = new Bitmap(dialog.FileName);
        pictureBox1.Image = image;
        pictureBox1.Refresh();
      }
    }
  }
}
