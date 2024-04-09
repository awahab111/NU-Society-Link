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
    public partial class AssignTaskView : Form
    {
        public event EventHandler? AssignTask;
        public AssignTaskView()
        {
            InitializeComponent();
            btnAssignTask.Click += delegate { AssignTask?.DynamicInvoke(this, EventArgs.Empty); };
        }

        public string taskDescription => txtTaskDescription.Text;

        public string taskAssingee => txtAssignedTo.Text;

        public DateTime dueDate => dtpDueDate.Value;

        public string eventTitle => txtEventTitle.Text;

        public Label Flag => lblflag;

    }
}
