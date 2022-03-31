using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    [Entity (TableName = "dicCai")]
    public class EntityDicCai : BaseDataContract
    {
        [DataMember]
        [Entity(FieldName = "id", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public string id { get; set; }
        [DataMember]
        [Entity(FieldName = "names", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string names { get; set; }
        [DataMember]
        [Entity(FieldName = "breakfast", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 3)]
        public string breakfast { get; set; }
        [DataMember]
        [Entity(FieldName = "lunch", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 4)]
        public string lunch { get; set; }
        [DataMember]
        [Entity(FieldName = "dinner", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 5)]
        public string dinner { get; set; }
        [DataMember]
        [Entity(FieldName = "other", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 6)]
        public string other { get; set; }
        [DataMember]
        [Entity(FieldName = "methods", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public string methods { get; set; }
        [DataMember]
        [Entity(FieldName = "kCal", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 8)]
        public decimal kCal { get; set; }
        [DataMember]
        [Entity(FieldName = "KJ", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 9)]
        public decimal KJ { get; set; }
        [DataMember]
        [Entity(FieldName = "PROTEIN", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 10)]
        public decimal PROTEIN { get; set; }
        [DataMember]
        [Entity(FieldName = "FAT", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 11)]
        public decimal FAT { get; set; }
        [DataMember]
        [Entity(FieldName = "CHO", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 12)]
        public decimal CHO { get; set; }
        [DataMember]
        [Entity(FieldName = "BRXXW", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 13)]
        public decimal BRXXW { get; set; }
        [DataMember]
        [Entity(FieldName = "DGC", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 14)]
        public decimal DGC { get; set; }
        [DataMember]
        [Entity(FieldName = "ASH", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 15)]
        public decimal ASH { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminA", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 16)]
        public decimal vitaminA { get; set; }
        [DataMember]
        [Entity(FieldName = "THIAMIN", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 17)]
        public decimal THIAMIN { get; set; }
        [DataMember]
        [Entity(FieldName = "RIBOFLAVIN", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 18)]
        public decimal RIBOFLAVIN { get; set; }
        [DataMember]
        [Entity(FieldName = "NIACIN", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 19)]
        public decimal NIACIN { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminC", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 20)]
        public decimal vitaminC { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminE", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 21)]
        public decimal vitaminE { get; set; }
        [DataMember]
        [Entity(FieldName = "CA", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 22)]
        public decimal CA { get; set; }
        [DataMember]
        [Entity(FieldName = "P", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 23)]
        public decimal P { get; set; }
        [DataMember]
        [Entity(FieldName = "K", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 24)]
        public decimal K { get; set; }
        [DataMember]
        [Entity(FieldName = "NA", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 25)]
        public decimal NA { get; set; }
        [DataMember]
        [Entity(FieldName = "MG", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 26)]
        public decimal MG { get; set; }
        [DataMember]
        [Entity(FieldName = "FE", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 27)]
        public decimal FE { get; set; }
        [DataMember]
        [Entity(FieldName = "ZN", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 28)]
        public decimal ZN { get; set; }
        [DataMember]
        [Entity(FieldName = "SE", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 29)]
        public decimal SE { get; set; }
        [DataMember]
        [Entity(FieldName = "CU", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 30)]
        public decimal CU { get; set; }
        [DataMember]
        [Entity(FieldName = "MN", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 31)]
        public decimal MN { get; set; }
        [DataMember]
        [Entity(FieldName = "I", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 32)]
        public decimal I { get; set; }
        [DataMember]
        [Entity(FieldName = "F", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 33)]
        public decimal F { get; set; }
        [DataMember]
        [Entity(FieldName = "CR", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 34)]
        public decimal CR { get; set; }
        [DataMember]
        [Entity(FieldName = "MU", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 35)]
        public decimal MU { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminD", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 36)]
        public decimal vitaminD { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminB6", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 37)]
        public decimal vitaminB6 { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminB12", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 38)]
        public decimal vitaminB12 { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminB5", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 39)]
        public decimal vitaminB5 { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminB9", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 40)]
        public decimal vitaminB9 { get; set; }
        [DataMember]
        [Entity(FieldName = "DANJIAN", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 41)]
        public decimal DANJIAN { get; set; }
        [DataMember]
        [Entity(FieldName = "vitaminH", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 42)]
        public decimal vitaminH { get; set; }
        [DataMember]
        [Entity(FieldName = "bakfield1", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 43)]
        public string bakfield1 { get; set; }
        [DataMember]
        [Entity(FieldName = "bakfield2", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 44)]
        public string bakfield2 { get; set; }
        [DataMember]
        [Entity(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 45)]
        public DateTime? createDate { get; set; }
        [DataMember]
        [Entity(FieldName = "creator", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 46)]
        public string creator { get; set; }
        [DataMember]
        [Entity(FieldName = "creatorName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 47)]
        public string creatorName { get; set; }
        [DataMember]
        [Entity(FieldName = "modifedDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 48)]
        public DateTime? modifedDate { get; set; }
        [DataMember]
        [Entity(FieldName = "modifedName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 49)]
        public string modifedName { get; set; }
        [DataMember]
        [Entity(FieldName = "modifedor", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 50)]
        public string modifedor { get; set; }
        /// <summary>
        /// 菜谱id
        /// </summary>
        [DataMember]
        public List<string>  lstCaiSlaveId { get; set; }

        /// <summary>
        /// 菜原料
        /// </summary>
        public List<EntityDicCaiIngredient> lstCaiIngredient { get; set; }

        [DataMember]
        public string caiSlaveId { get; set; }
        /// <summary>
        /// 菜谱名称
        /// </summary>
        [DataMember]
        public string caiSlaveNameStr { get; set; }
        /// <summary>
        /// 餐次
        /// </summary>
        [DataMember]
        public string mealStr { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string id = "id";
            public string names = "names";
            public string breakfast = "breakfast";
            public string lunch = "lunch";
            public string dinner = "dinner";
            public string other = "other";
            public string methods = "methods";
            public string kCal = "kCal";
            public string KJ = "KJ";
            public string PROTEIN = "PROTEIN";
            public string FAT = "FAT";
            public string CHO = "CHO";
            public string BRXXW = "BRXXW";
            public string DGC = "DGC";
            public string ASH = "ASH";
            public string vitaminA = "vitaminA";
            public string THIAMIN = "THIAMIN";
            public string RIBOFLAVIN = "RIBOFLAVIN";
            public string NIACIN = "NIACIN";
            public string vitaminC = "vitaminC";
            public string vitaminE = "vitaminE";
            public string CA = "CA";
            public string P = "P";
            public string K = "K";
            public string NA = "NA";
            public string MG = "MG";
            public string FE = "FE";
            public string ZN = "ZN";
            public string SE = "SE";
            public string CU = "CU";
            public string MN = "MN";
            public string I = "I";
            public string F = "F";
            public string CR = "CR";
            public string MU = "MU";
            public string vitaminD = "vitaminD";
            public string vitaminB6 = "vitaminB6";
            public string vitaminB12 = "vitaminB12";
            public string vitaminB5 = "vitaminB5";
            public string vitaminB9 = "vitaminB9";
            public string DANJIAN = "DANJIAN";
            public string vitaminH = "vitaminH";
            public string bakfield1 = "bakfield1";
            public string bakfield2 = "bakfield2";
            public string createDate = "createDate";
            public string creator = "creator";
            public string creatorName = "creatorName";
            public string modifedDate = "modifedDate";
            public string modifedName = "modifedName";
            public string modifedor = "modifedor";
        }
    }
}
