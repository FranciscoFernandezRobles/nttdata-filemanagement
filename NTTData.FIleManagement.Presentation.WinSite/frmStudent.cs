using NTTData.FileManagement.Business.Logic.Contracts;
using NTTData.FileManagement.Business.Logic.Implementations;
using NTTData.FileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace NTTData.FIleManagement.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings.Get("StudentsFilePath");
            MessageBox.Show(path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IStudentService studentService = new StudentService();
            Student student = new Student();
            student.Name=txtName.Text;
            student.Surnane=txtSurname.Text;
            student.Birthday=DateTime.Parse(txtBirthday.Text);
            student.Id=int.Parse(txtId.Text);

            studentService.Add(student);

            MessageBox.Show("The student is saved");
        }
    }
}
