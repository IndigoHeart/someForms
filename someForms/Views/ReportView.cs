using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using someForms.Model;

namespace someForms.Views
{
    public partial class ReportView : DevExpress.XtraEditors.XtraUserControl
    {
        public ReportView()
        {
            InitializeComponent();
            BindingSource source = new BindingSource();
            source.DataSource = typeof(ReportBase);
            source.AddNew();

            dataLayoutControl1.DataSource = source;
            dataLayoutControl1.RetrieveFields();
        }
    }
}
