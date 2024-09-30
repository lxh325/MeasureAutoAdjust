using DAL.Helper;
using Model;
using SqlSugar;

namespace DAL
{
    public class AdjustMeasureDAL
    {
        public  async Task<bool> AdjustMeasurePrice(I_AdjustPricePlan info)
        {
            try
            {
                await SqlSugarDbContext.MainDbContext.AsTenant().BeginTranAsync();
                await SqlSugarDbContext.MainDbContext.Updateable<I_Measure>()
                    .SetColumns(x=>x.RealPrice==info.AdjustUnitPrice)
                    .SetColumns(x => x.YBPrice == info.AdjustYBPrice)
                    .Where(x=>x.Id==info.MaterialID)
                    .ExecuteCommandAsync();
                await SqlSugarDbContext.MainDbContext.Updateable<I_AdjustPricePlan>()
                   .SetColumns(x => x.IsTriggered == true)
                   .SetColumns(x => x.TriggerType == 1)
                   .SetColumns(x => x.TriggerTime == DateTime.Now)
                   .Where(x => x.Id == info.Id)
                   .ExecuteCommandAsync();
                await SqlSugarDbContext.MainDbContext.AsTenant().CommitTranAsync();
                LogHelper.WriteInfo("措施【" + info.MaterialName+ "】价格修改完成！调价前价格:" + Math.Round(info.OriginalUnitPrice,2) + "，调价后价格："+ Math.Round(info.AdjustUnitPrice,2));
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.WriteError("AdjustMeasureDAL/AdjustMeasurePrice:调价DAL出错：" + ex.Message);
                await SqlSugarDbContext.MainDbContext.AsTenant().RollbackTranAsync();
                return false;
            }
        }
        public  List<I_AdjustPricePlan> GetPlanList()
        {
            try
            {
               return  SqlSugarDbContext.MainDbContext.Queryable<I_AdjustPricePlan>()
                    .Where(x=>x.IsActive==true&&x.IsTriggered==false)
                    .ToList();
            }
            catch (Exception ex)
            {
                LogHelper.WriteError("AdjustMeasureDAL/GetPlanList:获取调价计划列表DAL出错：" + ex.Message);
                return null;
            }
        }
    }
}
