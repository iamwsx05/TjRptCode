using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace RptFunc.Entity
{
    public class EntityYcjgRpt  :BaseDataContract
    {
        [DataMember]
        public string lnc_name { get; set; }
        [DataMember]
        public string reg_no { get; set; }//体检号,   
        [DataMember]
        public string pat_name { get; set; }//姓名,
        [DataMember]
        public string sex { get; set; }//when '1' then '男' when '2' then '女' else '' end 性别,
        [DataMember]
        public string age { get; set; }//年龄,
        [DataMember]
        public string tel { get; set; }//电话,
        [DataMember]
        public string idcard { get; set; }//身份证,
        [DataMember]
        public string comb_name { get; set; }// 组合项目,
        [DataMember]
        public string res_tag { get; set; }//异常结果
    }
}
