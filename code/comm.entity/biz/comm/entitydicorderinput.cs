using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// 医嘱录入字典
    /// </summary>
    [DataContract, Serializable]
    public class EntityDicOrderInput : BaseDataContract
    {
        [DataMember]
        public string itemCode { get; set; }
        [DataMember]
        public string xtbm { get; set; }
        [DataMember]
        public string xmbm { get; set; }
        [DataMember]
        public string xmmc { get; set; }
        [DataMember]
        public string xtmc { get; set; }        
        [DataMember]
        public string itemName { get; set; }
        [DataMember]
        public string standard { get; set; }
        [DataMember]
        public string smallUnit { get; set; }
        [DataMember]
        public string retPrice { get; set; }
        [DataMember]
        public string gbCode { get; set; }
        [DataMember]
        public string pyCode { get; set; }
        [DataMember]
        public string wbCode { get; set; }
        [DataMember]
        public string laCode { get; set; }
        [DataMember]
        public string gpRate { get; set; }
        [DataMember]
        public string apRate { get; set; }
        [DataMember]
        public string itemCls { get; set; }
        [DataMember]
        public string itemClsName { get; set; }
        [DataMember]
        public string priceFlag { get; set; }
        [DataMember]
        public string dose { get; set; }
        [DataMember]
        public string doseUnit { get; set; }
        [DataMember]
        public string direCode { get; set; }
        [DataMember]
        public string freqCode { get; set; }
        [DataMember]
        public string bigUnit { get; set; }
        [DataMember]
        public string packRate { get; set; }
        [DataMember]
        public string espFlag { get; set; }
        [DataMember]
        public string expFlag { get; set; }
        [DataMember]
        public string mcFlag { get; set; }
        [DataMember]
        public string spFlag { get; set; }
        [DataMember]
        public string disable { get; set; }
        [DataMember]
        public string locFlag { get; set; }
        [DataMember]
        public string packClass { get; set; }
        [DataMember]
        public string packCode { get; set; }
        [DataMember]
        public string phCode { get; set; }
        [DataMember]
        public string clsFlag { get; set; }
        [DataMember]
        public string drugCls { get; set; }
        [DataMember]
        public string acctRate { get; set; }
        [DataMember]
        public string oldCode { get; set; }
        [DataMember]
        public string direName { get; set; }
        [DataMember]
        public string freqName { get; set; }
        [DataMember]
        public string deptCode { get; set; }
        [DataMember]
        public string deptName { get; set; }
        /// <summary>
        /// 大规格（大包装）标志
        /// </summary>
        [DataMember]
        public string bigFlag { get; set; }
        /// <summary>
        /// 抗生素级别
        /// </summary>
        [DataMember]
        public int antiLevel { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string itemCode = "itemCode";
            public string xtbm = "xtbm";
            public string xtmc = "xtmc";
            public string xmbm = "xmbm";
            public string xmmc = "xmmc";
            public string itemName = "itemName";
            public string standard = "standard";
            public string smallUnit = "smallUnit";
            public string retPrice = "retPrice";
            public string gbCode = "gbCode";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string laCode = "laCode";
            public string gpRate = "gpRate";
            public string apRate = "apRate";
            public string itemCls = "itemCls";
            public string itemClsName = "itemClsName";
            public string priceFlag = "priceFlag";
            public string dose = "dose";
            public string doseUnit = "doseUnit";
            public string direCode = "direCode";
            public string freqCode = "freqCode";
            public string bigUnit = "bigUnit";
            public string packRate = "packRate";
            public string espFlag = "espFlag";
            public string expFlag = "expFlag";
            public string mcFlag = "mcFlag";
            public string spFlag = "spFlag";
            public string disable = "disable";
            public string locFlag = "locFlag";
            public string packClass = "packClass";
            public string packCode = "packCode";
            public string phCode = "phCode";
            public string clsFlag = "clsFlag";
            public string drugCls = "drugCls";
            public string acctRate = "acctRate";
            public string oldCode = "oldCode";
            public string direName = "direName";
            public string freqName = "freqName";
            public string deptCode = "deptCode";
            public string deptName = "deptName";
            public string bigFlag = "bigFlag";
            public string antiLevel = "antiLevel";
        }

    }


}
