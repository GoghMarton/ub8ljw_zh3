using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ub8ljw_zh3.Models;

namespace ub8ljw_zh3
{
    public partial class Form3 : Form
    {
        StudiesContext context = new StudiesContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Tanárlistázás();
        }

        private void Tanárlistázás()
        {
            var tanárok = from x in context.Instructor
                          select x;

            listBox1.DisplayMember = "Name";
            listBox1.DataSource = tanárok.ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (this.ShowDialog() == DialogResult.OK)
            {
                var kiválasztottTanár = (Instructor)listBox1.SelectedItem;

                var törlendőTanár = (from x in context.Instructor
                                     where x.InstructorSk == kiválasztottTanár.InstructorSk
                                     select x).FirstOrDefault();

                context.Instructor.Remove(törlendőTanár);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Tanárlistázás();

                MessageBox.Show("OK-val zárult");
            }
            else
            {
                MessageBox.Show("Nem OK-val zárult");
            }


        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
