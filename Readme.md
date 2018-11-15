<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/ImprovingDataGroupingPerformance/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/ImprovingDataGroupingPerformance/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/ImprovingDataGroupingPerformance/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/ImprovingDataGroupingPerformance/MainPage.xaml.vb))
<!-- default file list end -->
# How to Improve Performance when Grouping Data


<p>This example demonstrates how to group data by multiple columns. The code is enclosed within calls to the <i>GridControl.Begin</i><i>DataUpdate</i> and <i>GridControl.EndDataUpdate</i> methods. This improves the grid's performance by grouping data only once, after the <i>EndDataUpdate</i> method is called.</p><br />


<br/>


