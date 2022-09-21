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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgam, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgam = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            sbStudNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            sbProgram.Text = DelProgam(StudentInfoClass.Program).ToString();
            sbLastN.Text = DelProgam(StudentInfoClass.LastName).ToString();
            sbFirstN.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            sbAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            sbContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            sbAddress.Text = DelAddress(StudentInfoClass.Address).ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
