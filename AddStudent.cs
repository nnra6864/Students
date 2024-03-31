using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class AddStudent : Form
    {
        public BindingList<Student> studentsList = new BindingList<Student>();

        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            newStudent.name = tbName.Text;
            newStudent.lastName = tbLastName.Text;
            try { newStudent.index = int.Parse(tbIndex.Text); } catch { }
            newStudent.direction = comBoxDirection.Text;
            newStudent.date = dtpDate.Value;

            studentsList.Add(newStudent);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbLastName.Text = "";
            tbIndex.Text = "";
            comBoxDirection.SelectedIndex = 0; comBoxDirection.SelectedItem = 0;
            dtpDate.Value = DateTime.Now.Date;
        }
    }
}
