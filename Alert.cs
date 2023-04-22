using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace installmentsApp
{
    class Alert
    {
        public Alert(string msg, AlertForm.alertTypeEnum type)
        {
            AlertForm f = new AlertForm();
            f.setAlert(msg, type);
        }
    }
}
