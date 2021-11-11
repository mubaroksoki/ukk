using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMartsiSyauqi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show(
                    "are you sure wan to delete this record?", "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)==DialogResult.Yes )
                    tabeldataBindingSource.RemoveCurrent();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pakabetaDataSet.tabeldata' table. You can move, or remove it, as needed.
            this.tabeldataTableAdapter.Fill(this.pakabetaDataSet.tabeldata);
            tabeldataBindingSource.DataSource = this.pakabetaDataSet.tabeldata;


        }

        private void stokbarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void kodebarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void namabarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hargapokok_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                kodebarang.Focus();
                this.pakabetaDataSet.tabeldata.AddtabeldataRow(this.pakabetaDataSet.tabeldata.NewtabeldataRow());
                tabeldataBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabeldataBindingSource.ResetBindings(false);


            }

        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            kodebarang.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tabeldataBindingSource.EndEdit();
                tabeldataTableAdapter.Update(this.pakabetaDataSet.tabeldata);
                panel1.Enabled = false;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabeldataBindingSource.ResetBindings(false);


            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            tabeldataBindingSource.ResetBindings(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabeldataBindingSource.RemoveCurrent();
        }
    }
}
