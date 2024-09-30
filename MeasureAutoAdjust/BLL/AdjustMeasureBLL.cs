using DAL;
using DAL.Helper;
using System.Numerics;
using System.Timers;

namespace MeasureAutoAdjust.BLL
{
    public class AdjustMeasureBLL
    {
        private System.Timers.Timer myTimer = null; //时钟   

        public void Start()
        {
            
            int pollingTime = ConfigHelper.PollingTime;
            if (pollingTime > 0)
            {
                LogHelper.WriteInfo("开始执行医保措施自动调价计划，每" + pollingTime + "分钟轮询一次。");
                myTimer = new System.Timers.Timer(pollingTime * 60 * 1000);
                myTimer.Elapsed += new ElapsedEventHandler(AdjustPrice);
                myTimer.Enabled = true;
                myTimer.AutoReset = true;
            }
        }

        private async void AdjustPrice(object? sender, ElapsedEventArgs e)
        {
            try
            {
                DateTime dtNow = DateTime.Now;
                var list = new AdjustMeasureDAL().GetPlanList();
                foreach (var plan in list)
                {
                    switch (plan.PlanTriggerType)
                    {
                        case 1: //指定触发模式为时间模式
                            if (plan.PlanTriggerTime <= dtNow) //降价可通过到达触发时间触发
                            {
                                await new AdjustMeasureDAL().AdjustMeasurePrice(plan);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteError("AdjustMeasureBLL/AdjustPrice:执行医保措施调价自动调价计划流程异常："+ex.Message);
            }
        }
    }
}
