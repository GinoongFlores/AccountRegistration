using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form1 : Form
    {
        DelegateNumber delegateNumber;
        DelegateText delegateText;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextClick(object sender, EventArgs e)
        {

            //  StudentInfoClass.Program = (long)Convert.ToDouble(Program.Text.ToString());
            StudentInfoClass.FirstName = firstName.Text.ToString();
            StudentInfoClass.LastName = lastName.Text.ToString();
            StudentInfoClass.MiddleName = middleName.Text.ToString();
            StudentInfoClass.Address = Address.Text.ToString();
            StudentInfoClass.Program = programComboBox.Text.ToString();
            StudentInfoClass.Age = (long)Convert.ToDouble(Age.Text.ToString());
            StudentInfoClass.ContactNo = (long)Convert.ToDouble(ContactNo.Text.ToString());
            StudentInfoClass.StudentNo = (long)Convert.ToDouble(studentNo.Text.ToString());

            FrmConfirm frmConfirm = new FrmConfirm();
            frmConfirm.ShowDialog();
        }
    }
}
