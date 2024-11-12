# Creating-a-Spline-Area-Series-to-Track-Annual-Gold-Price-Fluctuations
Creating a Spline Area Series to Track Annual Gold Price Fluctuations Across Major Global Currencies

In today’s post, we’ll walk you through creating a visually compelling *Spline Area Chart* to track annual gold price fluctuations across major global currencies, using the powerful [Syncfusion .NET MAUI Cartesian Charts control](https://www.syncfusion.com/maui-controls/maui-cartesian-charts). We’ll cover how to enhance your chart’s interactivity and visual appeal by incorporating custom tooltips, threshold lines, and dynamic series updates based on user input.

## Custom Tooltip
 By customizing tooltips, we can deliver precise and relevant information in a clear and engaging way. Syncfusion’s [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) property enables you to design personalized tooltips that display vital details in a format that suits your application’s needs.

## Custom Threshold Line
 Threshold lines are useful for marking significant data points on a chart. By adding horizontal threshold lines with [annotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Annotations), we can instantly highlight key information. In this implementation, we’ve added annotations that display the highest and lowest annual growth in gold prices. These lines help users quickly identify important trends and patterns within the data. Additionally, the annotations are fully customizable, allowing you to adjust their appearance to create a more polished user interface.

## Combo Box Selection
To make the chart more interactive, we’ve used the [Syncfusion Combo Box control](https://www.syncfusion.com/maui-controls/maui-combobox) to allow users to select different currencies. Based on the selected currency, the chart’s spline area series is dynamically updated to reflect the gold price fluctuations for that currency. This approach gives users flexibility, enabling them to explore the data for various currencies without needing to refresh the page or reload the chart.



## Troubleshooting:
### Path too long exception:
If you encounter a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For a step-by-step procedure, refer to the [Tracking Annual Gold Price Fluctuations by Percentage Across Major Global Currencies blog]().

