using SqlSugar;

namespace Model
{
    [SugarTable("I_Measure")]
    public class I_Measure
    {
        /// <summary>
        /// 物资编码 
        ///</summary>
        [SugarColumn(ColumnName = "ID", IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        /// 物资名称 
        ///</summary>
        [SugarColumn(ColumnName = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// 物资代码 
        /// 默认值: ((-1))
        ///</summary>
        [SugarColumn(ColumnName = "MTypeID")]
        public string MTypeID { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "OtherTypeID")]
        public string OtherTypeID { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "OtherTypeName")]
        public string OtherTypeName { get; set; }
        /// <summary>
        /// 度量单位 
        ///</summary>
        [SugarColumn(ColumnName = "Unit")]
        public string Unit { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "UnitName")]
        public string UnitName { get; set; }
        /// <summary>
        /// 备注 
        ///</summary>
        [SugarColumn(ColumnName = "Remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 最后修改人 
        ///</summary>
        [SugarColumn(ColumnName = "CreatorName")]
        public string CreatorName { get; set; }
        /// <summary>
        /// 最后修改时间 
        ///</summary>
        [SugarColumn(ColumnName = "CreatorDate")]
        public DateTime? CreatorDate { get; set; }
        /// <summary>
        /// 拼音 
        ///</summary>
        [SugarColumn(ColumnName = "PinYin")]
        public string PinYin { get; set; }
        /// <summary>
        /// 是否有效 
        /// 默认值: ((1))
        ///</summary>
        [SugarColumn(ColumnName = "IsActive")]
        public bool IsActive { get; set; }
        /// <summary>
        /// 实际出手价格 病历收费模块使用 
        ///</summary>
        [SugarColumn(ColumnName = "RealPrice")]
        public decimal? RealPrice { get; set; }
        /// <summary>
        /// 收费刻度 
        /// 默认值: ((1))
        ///</summary>
        [SugarColumn(ColumnName = "FeeScale")]
        public int? FeeScale { get; set; }
        /// <summary>
        /// 顺序号 
        ///</summary>
        [SugarColumn(ColumnName = "SN")]
        public int? Sn { get; set; }
        /// <summary>
        /// 最大限制金额（例子：收费不超过3元） 
        ///</summary>
        [SugarColumn(ColumnName = "LimitMaxPrice")]
        public int? LimitMaxPrice { get; set; }
        /// <summary>
        /// 项目编码 
        ///</summary>
        [SugarColumn(ColumnName = "ProjectCode")]
        public string ProjectCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "YBCode")]
        public string YBCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "YBPrice")]
        public decimal? YBPrice { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "YBUnitConvert")]
        public int? YBUnitConvert { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "IsApplyActive")]
        public bool? IsApplyActive { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "GJMCode")]
        public string GJMCode { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "YBDictionaryType")]
        public string YBDictionaryType { get; set; }
    }

}
