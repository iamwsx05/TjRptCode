using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weCare.Core.Entity;
using weCare.Core.Utils;
using Common.Entity;
using Console.Biz;
using Console.Itf;

namespace Console.Svc
{
    /// <summary>
    /// SvcDictionary
    /// </summary>
    public class SvcDictionary : Console.Itf.ItfDictionary
    {
        #region department

        #region LoadDeptInfo
        /// <summary>
        /// LoadDeptInfo
        /// </summary>
        /// <returns></returns>
        public List<EntityCodeDepartment> LoadDeptInfo()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadDeptInfo();
            }
        }
        #endregion

        #region LoadDeptRoom
        /// <summary>
        /// LoadDeptRoom
        /// </summary>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public List<EntityDicDeptRoom> LoadDeptRoom(string deptCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadDeptRoom(deptCode);
            }
        }
        #endregion

        #region LoadDeptExpert
        /// <summary>
        /// LoadDeptExpert
        /// </summary>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public List<EntityDicDeptReg> LoadDeptExpert(string deptCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadDeptExpert(deptCode);
            }
        }
        #endregion

        #region SaveDepartment
        /// <summary>
        /// SaveDepartment
        /// </summary>
        /// <param name="deptVo"></param>
        /// <param name="deptOrig"></param>
        /// <param name="lstDeptRoom"></param>
        /// <param name="lstDeptReg"></param>
        /// <returns></returns>
        public int SaveDepartment(EntityCodeDepartment deptVo, EntityCodeDepartment deptOrig, List<EntityDicDeptRoom> lstDeptRoom, List<EntityDicDeptReg> lstDeptReg)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.SaveDepartment(deptVo, deptOrig, lstDeptRoom, lstDeptReg);
            }
        }
        #endregion

        #region DelDepartment
        /// <summary>
        /// DelDepartment
        /// </summary>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public int DelDepartment(string deptCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.DelDepartment(deptCode);
            }
        }
        #endregion

        #endregion

        #region employee

        #region LoadEmpInfo
        /// <summary>
        /// LoadEmpInfo
        /// </summary>
        /// <returns></returns>
        public List<EntityOperatorDisp> LoadEmpInfo()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadEmpInfo();
            }
        }
        #endregion

        #region LoadCodeOperatorAndPlus
        /// <summary>
        /// LoadCodeOperatorAndPlus
        /// </summary>
        /// <param name="operCode"></param>
        /// <param name="mainVo"></param>
        /// <param name="plusVo"></param>
        public void LoadCodeOperatorAndPlus(string operCode, out EntityCodeOperator mainVo, out EntityPlusOperator plusVo)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                biz.LoadCodeOperatorAndPlus(operCode, out mainVo, out plusVo);
            }
        }
        #endregion

        #region LoadOperatorRole
        /// <summary>
        /// LoadOperatorRole
        /// </summary>
        /// <param name="operCode"></param>
        /// <returns></returns>
        public List<EntityDefOperatorRole> LoadOperatorRole(string operCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadOperatorRole(operCode);
            }
        }
        #endregion

        #region LoadOperatorDept
        /// <summary>
        /// LoadOperatorDept
        /// </summary>
        /// <param name="operCode"></param>
        /// <returns></returns>
        public List<EntityDefDeptemployee> LoadOperatorDept(string operCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadOperatorDept(operCode);
            }
        }
        #endregion

        #region SaveOperatorDept
        /// <summary>
        /// SaveOperatorDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveOperatorDept(EntityDefDeptemployee vo)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.SaveOperatorDept(vo);
            }
        }
        #endregion

        #region UpdateOperatorDeptDefault
        /// <summary>
        /// UpdateOperatorDeptDefault
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int UpdateOperatorDeptDefault(EntityDefDeptemployee vo)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.UpdateOperatorDeptDefault(vo);
            }
        }
        #endregion

        #region SaveOperatorRole
        /// <summary>
        /// SaveOperatorRole
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveOperatorRole(EntityDefOperatorRole vo)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.SaveOperatorRole(vo);
            }
        }
        #endregion

        #region DelOperatorDept
        /// <summary>
        /// DelOperatorDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int DelOperatorDept(EntityDefDeptemployee vo)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.DelOperatorDept(vo);
            }
        }
        #endregion

        #region DelOperatorRole
        /// <summary>
        /// DelOperatorRole
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int DelOperatorRole(EntityDefOperatorRole vo)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.DelOperatorRole(vo);
            }
        }
        #endregion

        #region SaveOperator
        /// <summary>
        /// SaveOperator
        /// </summary>
        /// <param name="mainVo"></param>
        /// <param name="plusVo"></param>
        /// <param name="operOrig"></param>
        /// <returns></returns>
        public int SaveOperator(EntityCodeOperator mainVo, EntityPlusOperator plusVo, EntityCodeOperator operOrig)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.SaveOperator(mainVo, plusVo, operOrig);
            }
        }
        #endregion

        #region DelOperator
        /// <summary>
        /// DelOperator
        /// </summary>
        /// <param name="operCode"></param>
        /// <returns></returns>
        public int DelOperator(string operCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.DelOperator(operCode);
            }
        }
        #endregion

        #endregion

        #region role

        #region LoadRoleOper
        /// <summary>
        /// LoadRoleOper
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public List<EntityDefOperatorRole> LoadRoleOper(string roleCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadRoleOper(roleCode);
            }
        }
        #endregion

        #region LoadRoleFunc
        /// <summary>
        /// LoadRoleFunc
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public List<EntityRoleFunction> LoadRoleFunc(string roleCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.LoadRoleFunc(roleCode);
            }
        }
        #endregion

        #region SaveRoleFunc
        /// <summary>
        /// SaveRoleFunc
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="type">1 new; 2 delete</param>
        /// <returns></returns>
        public int SaveRoleFunc(EntityRoleFunction vo, int type)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.SaveRoleFunc(vo, type);
            }
        }
        #endregion

        #region SaveRole
        /// <summary>
        /// SaveRole
        /// </summary>
        /// <param name="lstRoleUpdate"></param>
        /// <param name="lstRoleNew"></param>
        /// <returns></returns>
        public int SaveRole(List<EntityCodeRole> lstRoleUpdate, List<EntityCodeRole> lstRoleNew)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.SaveRole(lstRoleUpdate, lstRoleNew);
            }
        }
        #endregion

        #region DelRole
        /// <summary>
        /// DelRole
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public int DelRole(string roleCode)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.DelRole(roleCode);
            }
        }
        #endregion

        #endregion

        #region 患者资料

        #region 获取病人资料
        /// <summary>
        /// 获取病人资料
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<EntityPatientInfo> GetPatInfo(string key, string value)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.GetPatInfo(key, value);
            }
        }
        #endregion

        #region 保存病人资料
        /// <summary>
        /// 保存病人资料
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        public int SavePatInfo(ref EntityPatientInfo pat)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.SavePatInfo(ref pat);
            }
        }
        #endregion

        #region 删除病人资料
        /// <summary>
        /// 删除病人资料
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public int DelPatInfo(string pid)
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.DelPatInfo(pid);
            }
        }
        #endregion

        #endregion

        #region 外部导入字典

        #region 中天

        #region 导入科室
        /// <summary>
        /// 导入科室
        /// </summary>
        /// <returns></returns>
        public int ImportDeptInfo()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.ImportDeptInfo();
            }
        }
        #endregion

        #region 导入职工
        /// <summary>
        /// 导入职工
        /// </summary>
        /// <returns></returns>
        public int ImportEmpInfo()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.ImportEmpInfo();
            }
        }
        #endregion

        #region 导入职称
        /// <summary>
        /// 导入职称
        /// </summary>
        /// <returns></returns>
        public int ImportRankInfo()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.ImportRankInfo();
            }
        }
        #endregion

        #region 导入患者信息
        /// <summary>
        /// 导入患者信息
        /// </summary>
        /// <returns></returns>
        public int ImportPatInfo()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.ImportPatInfo();
            }
        }
        #endregion

        #endregion

        #region 惠侨

        #region 导入科室
        /// <summary>
        /// 导入科室
        /// </summary>
        /// <returns></returns>
        public int ImportDeptForHq()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.ImportDeptForHq();
            }
        }
        #endregion

        #region 导入职工
        /// <summary>
        /// 导入职工
        /// </summary>
        /// <returns></returns>
        public int ImportEmpForHq()
        {
            using (BizDictionary biz = new BizDictionary())
            {
                return biz.ImportEmpForHq();
            }
        }
        #endregion

        #endregion
        
        #endregion

        #region Verify
        /// <summary>
        /// Verify
        /// </summary>
        /// <returns></returns>
        public bool Verify()
        { return true; }
        #endregion

        #region IDispose
        /// <summary>
        /// IDispose
        /// </summary>
        public void Dispose()
        { GC.SuppressFinalize(this); }
        #endregion
    }
}
