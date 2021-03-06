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

namespace MemoPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorfuente = colorDialog1.ShowDialog();
            if(colorfuente == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }  
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Type = fontDialog1.ShowDialog();
            if(Type == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }  
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Al files(.)  | .";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(open.FileName);
            }



           
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "text files(*.txt) | *.txt  ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }


           
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarcomo = new SaveFileDialog();
            System.IO.StreamWriter mystreamwriter = null;
            guardarcomo.Filter = "Text(*.txt) | *.txt | HTML(*.html*) | *.html | All Files(*.*) |*.*)";
            guardarcomo.CheckFileExists= true;
            guardarcomo.Title = "Guardar Como";
            guardarcomo.ShowDialog(this);
            try
            {
                mystreamwriter = new System.IO.StreamWriter(guardarcomo.FileName);  
                mystreamwriter.Write(richTextBox1.Text);
                mystreamwriter.Flush();
            }
            catch (Exception)
            {
                mystreamwriter = null;  
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
