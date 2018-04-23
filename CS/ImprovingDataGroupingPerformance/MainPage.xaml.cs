using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace ImprovingDataGroupingPerformance {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = new ProductList();
            GroupData(new string[]{"Country", "City", "Quantity", "UnitPrice"});
        }
        private void GroupData(string[] fieldNames) {
            grid.BeginDataUpdate();
            try {
                grid.ClearGrouping();
                for (int i = 0; i < fieldNames.Length; i++) {
                    GridColumn col = grid.Columns[fieldNames[i]];
                    if (col != null)
                        grid.GroupBy(col);
                }
            }
            finally {
                grid.EndDataUpdate();
            }
        }
    }
}
