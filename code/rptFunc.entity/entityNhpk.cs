using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace RptFunc.Nhpk
{

    public class EntityTmpZybZd4
    {
        public string reg_no { get; set; }//体检号
        public string reg_date { get; set; }//体检日期
        public string lnc_code { get; set; }//单位
        public string A01 { get; set; }//报告地区-编码
        public string A02 { get; set; }//报告地区-名称
        public string A03 { get; set; }//报告单位-编码
        public string A04 { get; set; }//报告单位-名称
        public string A05 { get; set; }//职业健康检查机构所在地区-编码
        public string A06 { get; set; }//职业健康检查机构所在地区-名称
        public string A07 { get; set; }//职业健康检查机构-编码
        public string A08 { get; set; }//职业健康检查机构-名称
        public string A09 { get; set; }//体检时间
        public string A10 { get; set; }//用人单位名称
        public string A11 { get; set; }//联系电话
        public string A12 { get; set; }//所属地区
        public string A13 { get; set; }//所属地区-编码
        public string A14 { get; set; }//通讯地址
        public string A15 { get; set; }//邮编
        public string A16 { get; set; }//组织机构代码
        public string A17 { get; set; }//企业规模-编码
        public string A18 { get; set; }//企业规模-名称
        public string A19 { get; set; }//注册类型-编码
        public string A20 { get; set; }//注册类型-名称
        public string A21 { get; set; }//行业代码 industryCategoryCode":"需输入长度为4位的行业类别代码"
        public string A22 { get; set; }//行业分类-名称
        public string A23 { get; set; }//姓名
        public string A24 { get; set; }//身份证号
        public string A25 { get; set; }//联系电话
        public string A26 { get; set; }//体检类型-编码
        public string A27 { get; set; }//体检类型-名称
        public string A28 { get; set; }//性别-编码
        public string A29 { get; set; }//性别-名称
        public string A30 { get; set; }//出生日期
        public string A31 { get; set; }//总工龄-年
        public string A32 { get; set; }//总工龄-月
        public string A33 { get; set; }//接触监测的主要职业病危害因素名称-编码
        public string A34 { get; set; }//接触监测的主要职业病危害因素名称-名称
        public string A42 { get; set; }//备注（如为其他尘，请标明具体尘的名称）	
        public string A35 { get; set; }//职业危害接触工龄-年
        public string A36 { get; set; }//职业危害接触工龄-月
        public string A37 { get; set; }//接触所监测危害因素工龄-年
        public string A38 { get; set; }//接触所监测危害因素工龄-月
        public string A39 { get; set; }//车间
        public string A40 { get; set; }//工种-编码
        public string A41 { get; set; }//工种-名称
        public string A43 { get; set; }//用人单位联系人
        public string A44 { get; set; }//接触的其他职业病危害因素
        public string A45 { get; set; }//所在部门
        public string A46 { get; set; }//车间
        public string A47 { get; set; }//工号
        public string A48 { get; set; }//收费类别 团检、散检或未填写
        public string A49 { get; set; }//体检分类
        public string A50 { get; set; }//机构内团检序列号
        public string A51 { get; set; }//初检条码
        public string A52 { get; set; }// 体检套餐名称
        public string A53 { get; set; }//婚否
        public string A54 { get; set; }//总检医生姓名
        public string A55 { get; set; }//总检医生编码
        public string A56 { get; set; }//社保编号
        public string A57 { get; set; }//停用
        public string C01 { get; set; }//体检结论-编码
        public string C01a { get; set; }//体检结论-名称
        public string C01c { get; set; }//体检结论1-名称*
        public string C01d { get; set; }//体检结论2-名称*--其它其他疾病或异常描述
        public string C01e { get; set; }//疑似职业病代码 当体检结论是疑似职业病时, 该项必填参见数据元值域代码表:职业病种类代码表
        public string C01f { get; set; }//职业禁忌证名称  --当体检结论是疑似职业病时,该项必填参见数据元值域代码表:职业病种类代码表
        public string C02 { get; set; }//填表单位
        public string C03 { get; set; }//填表人
        public string C04 { get; set; }//填表人联系电话
        public string C05 { get; set; }//填表日期
        public string C06 { get; set; }//审核状态代码  --参见数据元值域代码表:审核状态代码表
        public string C07 { get; set; }//审核意见
        public string C08 { get; set; }//审核时间      --yyyyMMdd
        public string C09 { get; set; }//审核人姓名
        public string C10 { get; set; }//审核机构
        public string C11 { get; set; }//isReview 是否复查 True/False	（0 否、1 是）
        public string C12 { get; set; }//监测类型代码    01 常规监测、 02主动监测、 03 其他
        public string C13 { get; set; }//开始接害日期    --yyyyMMdd 检查类型是岗前时非必填
        public string flag { get; set; }//状态 flag = 0 正常 flag = 1 全部生成完成 flag = 2 重新生成
        public string rec_oper { get; set; }//生成人 报告人姓名
        public string rec_time { get; set; }//-生成时间
        public string rec_end_oper { get; set; }//-最后修改人
        public string rec_end_time { get; set; }// --最后修改时间
        public string cardtype { get; set; }//身份证类型
        public string ID { get; set; }//ID号

        public string examItemPname { get; set; }
        public string examItemName { get; set; }
        public string examItemCode { get; set; }
        public string examResultType { get; set; }
        public string examResult { get; set; }
        public string examItemUnitCode { get; set; }
        public string referenceRangeMin { get; set; }
        public string referenceRangeMax { get; set; }
        public string abnormal { get; set; }
        public string depName { get; set; }
        public string updateTime { get; set; }
        public string stdId { get; set; }
        public string xmdm { get; set; }

        /// <summary>
        /// //////////////////////////////////////////////
        /// </summary>
        public string B4070500 { get; set; }
        public string B4070500_unit { get; set; }
        public string B4070500_min { get; set; }
        public string B4070500_max { get; set; }
        public string B3051700 { get; set; }
        public string B3051700_unit { get; set; }
        public string B3051700_min { get; set; }
        public string B3051700_max { get; set; }
        public string B3020100 { get; set; }
        public string B3020100_unit { get; set; }
        public string B3020100_min { get; set; }
        public string B3020100_max { get; set; }

        public string B3020200 { get; set; }
        public string B3020200_unit { get; set; }
        public string B3020200_min { get; set; }
        public string B3020200_max { get; set; }

        public string B3020300 { get; set; }
        public string B3020300_unit { get; set; }
        public string B3020300_min { get; set; }
        public string B3020300_max { get; set; }



        public string B3080200 { get; set; }
        public string B3080200_unit { get; set; }
        public string B3080200_min { get; set; }
        public string B3080200_max { get; set; }
        public string B4040900 { get; set; }
        public string B4040900_unit { get; set; }
        public string B4040900_min { get; set; }
        public string B4040900_max { get; set; }
        public string B4021100 { get; set; }
        public string B4021100_unit { get; set; }
        public string B4021100_min { get; set; }
        public string B4021100_max { get; set; }
        public string B4020300 { get; set; }
        public string B4020300_unit { get; set; }
        public string B4020300_min { get; set; }
        public string B4020300_max { get; set; }
        public string B4020500 { get; set; }
        public string B4020500_unit { get; set; }
        public string B4020500_min { get; set; }
        public string B4020500_max { get; set; }
        public string B4020600 { get; set; }
        public string B4020600_unit { get; set; }
        public string B4020600_min { get; set; }
        public string B4020600_max { get; set; }
        public string B4012600 { get; set; }
        public string B4012600_unit { get; set; }
        public string B4012600_min { get; set; }
        public string B4012600_max { get; set; }
        public string B4012000 { get; set; }
        public string B4012000_unit { get; set; }
        public string B4012000_min { get; set; }
        public string B4012000_max { get; set; }
        public string B4011600 { get; set; }
        public string B4011600_unit { get; set; }
        public string B4011600_min { get; set; }
        public string B4011600_max { get; set; }
        public string B4010100 { get; set; }
        public string B4010100_unit { get; set; }
        public string B4010100_min { get; set; }
        public string B4010100_max { get; set; }
        public string B2010502 { get; set; }
        public string B2010502_unit { get; set; }
        public string B2010502_min { get; set; }
        public string B2010502_max { get; set; }
        public string B2010501 { get; set; }
        public string B2010501_unit { get; set; }
        public string B2010501_min { get; set; }
        public string B2010501_max { get; set; }

    }

    public class EntityTmpZybZd4g
    {
        public string reg_no { get; set; }//--体检号
        public string itemCode { get; set; }// --职业病危害因素代码
        public string itemName { get; set; }// ----危害因素名称
        public string examConclusionCode { get; set; }// --体检结论代码
        public string yszybCode { get; set; }//--疑似职业病代码
        public string zyjjzName { get; set; }// --职业禁忌证名称
        public string qtjbName { get; set; }//  --其他疾病或异常描述
    }


    public class EntityExamList
    {
        public string reg_no { get; set; }
        public string examItemPname { get; set; }
        public string examItemName { get; set; }
        public string examItemCode { get; set; }
        public string examResultType { get; set; }
        public string examResult { get; set; }
        public string examItemUnitCode { get; set; }
        public string referenceRangeMin { get; set; }
        public string referenceRangeMax { get; set; }
        public string abnormal { get; set; }
        public string depName { get; set; }
        public string updateTime { get; set; }
        public string stdId { get; set; }
        public string xmdm { get; set; }
    }
}
