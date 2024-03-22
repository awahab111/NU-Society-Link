using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NU_Society_Link.View
{
    public partial class AdminMainView : Form
    {
        public AdminMainView()
        {
            InitializeComponent();
            AssociateandraiseEvents();
        }

        void AssociateandraiseEvents()
        {
            ApproveSociety.Click += delegate { ApproveSocietyClick?.Invoke(null, EventArgs.Empty);};
        }

        public event EventHandler ApproveSocietyClick;

    }
}
