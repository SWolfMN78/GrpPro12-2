using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpPro12_2AssigningTicketTimeSlots
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }
        private void frmOptions_Load(object sender, EventArgs e)
        {
            
        }

        #region button
        private void button1_Click(object sender, EventArgs e)
        {
            //when this is pressed it for now it will close the form.
            //***** This will be considered complete when the information is loaded to
            //the main form.
            Close();
        }
        #endregion
    }
}
