using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartExample.ChartControl {
    public partial class ctlChartControl : UserControl {
        
        public ctlChartControl() {
            InitializeComponent();
        }
        
        public void DatBind(object data, string title, string labelProperty, string valueProperty) {
            FormatChart(title, labelProperty, valueProperty);
            chartControl.DataSource = data;
            chartControl.DataBind();
        }

        private void FormatChart(string title, string labelProperty, string valueProperty) {

            var series = chartControl.Series[0];

            series.XValueMember = labelProperty;
            series.YValueMembers = valueProperty;
            series.ChartType = SeriesChartType.Pie;
            series.Palette = ChartColorPalette.BrightPastel;
            series["PieLabelStyle"] = "Disabled";
            series["PieDrawingStyle"] = "SoftEdge";

            chartControl.Titles.Add(title);
            chartControl.Titles[0].Font = new Font(chartControl.Titles[0].Font, FontStyle.Bold);

        }


    }

}
