using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls1
{
    public partial class panel : UserControl
    {
        private static panel _instance;

        public static panel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new panel();
                return _instance;
            }
        }

        public static panel Instance1
        {
            get
            {
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public panel()
        {
            InitializeComponent();
        }

        private void Admin_updateInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
