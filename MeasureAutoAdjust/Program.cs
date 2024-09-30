
using MeasureAutoAdjust.BLL;
using MeasureAutoAdjust.common;


DisableConsoleQuickEdit.Go();
new AdjustMeasureBLL().Start();
var cancellationTokenSource = new CancellationTokenSource();
AppDomain.CurrentDomain.ProcessExit += (s, e) => cancellationTokenSource.Cancel();
Console.CancelKeyPress += (s, e) => cancellationTokenSource.Cancel();
await Task.Delay(-1, cancellationTokenSource.Token).ContinueWith(t => { });