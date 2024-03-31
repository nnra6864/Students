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
    public partial class Students : Form
    {
        AddStudent addStudent = new AddStudent();

        public Students()
        {
            InitializeComponent();
            lbStudents.DataSource = addStudent.studentsList;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            addStudent.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            addStudent.studentsList.Clear();
        }

        private void ClearList() 
        {
            List<int> clearList = new List<int>();

            if (lbStudents.SelectedItems.Count <= 0)
            {
                return;
            }

            foreach (var item in lbStudents.SelectedIndices)
            {
                clearList.Add((int)item);
            }

            var removal = clearList.OrderByDescending(x => x);

            foreach (var item in removal) 
            {
                addStudent.studentsList.RemoveAt((int)item);
            }
        }
    }
}
