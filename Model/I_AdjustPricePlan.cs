using SqlSugar;

namespace Model
{
    [SugarTable("I_AdjustPricePlan")]
    public class I_AdjustPricePlan
    {
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "ID", IsPrimaryKey = true)]
        public Guid Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "MaterialID")]
        public int MaterialID { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "MaterialName")]
        public string MaterialName { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "AdjustBatchNo")]
        public string AdjustBatchNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "OriginalUnitPrice")]
        public decimal OriginalUnitPrice { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "OriginalYBPrice")]
        public decimal OriginalYBPrice { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "AdjustUnitPrice")]
        public decimal AdjustUnitPrice { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "AdjustYBPrice")]
        public decimal AdjustYBPrice { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "PlanEnableTime")]
        public DateTime PlanEnableTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "PlanTriggerTime")]
        public DateTime PlanTriggerTime { get; set; }
        /// <summary>
        /// 1:到时间触发 ，2：处理批次结余触发 ，3：根据批次结余与时间 
        ///</summary>
        [SugarColumn(ColumnName = "PlanTriggerType")]
        public int PlanTriggerType { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "CurrentDeliveryCode")]
        public string CurrentDeliveryCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "CurrentUseSurplus")]
        public int? CurrentUseSurplus { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "TriggerSurplus")]
        public int? TriggerSurplus { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "IsTriggered")]
        public bool IsTriggered { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "TriggerType")]
        public int? TriggerType { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "TriggerTime")]
        public DateTime? TriggerTime { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "IsActive")]
        public bool IsActive { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Remark")]
        public string Remark { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "CreatePerson")]
        public string CreatePerson { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "CreateTime")]
        public DateTime? CreateTime { get; set; }
    }

}
