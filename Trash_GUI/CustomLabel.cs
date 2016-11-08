using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashGUI
{
    public partial class CustomLabel : Label
    {
        public CustomLabel()
        {
            InitializeComponent();
        }

        public CustomLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }        
    }
}
