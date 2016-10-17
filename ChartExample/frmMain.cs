using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartExample {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            LoadChart();
        }

        private void LoadChart() {

            var _data = new DataTable();
            _data = new DataTable();
            _data.Columns.Add("Description", typeof(string));
            _data.Columns.Add("Count", typeof(int));
            _data.Rows.Add("Group 1", 46);
            _data.Rows.Add("Group 2", 321);
            _data.Rows.Add("Group 3", 134);
            _data.Rows.Add("Group 4", 23);
            _data.Rows.Add("Group 5", 273);
            _data.Rows.Add("Group 6", 102);

            ctlChartControl1.DatBind(_data, "My Chart Title", "Description", "Count");


        }

    }
}
