using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common.Entity;
using weCare.Core.Entity;
using weCare.Core.Itf;
using weCare.Core.Utils;

namespace Console.Itf
{
    [ServiceContract]
    public interface ItfDictionary : IWcf, IDisposable
    {
        #region department
        /// <summary>
        /// 读取
        /// </summary>
        /// <returns></returns>
        [OperationContract(Name = "LoadDeptInfo")]
        List<EntityCodeDepartment> LoadDeptInfo();

        [OperationContract(Name = "LoadDeptRoom")]
        List<EntityDicDeptRoom> LoadDeptRoom(string deptCode);

        [OperationContract(Name = "LoadDeptExpert")]
        List<EntityDicDeptReg> LoadDeptExpert(string deptCode);

        [OperationContract(Name = "SaveDepartment")]
        int SaveDepartment(EntityCodeDepartment deptVo, EntityCodeDepartment deptOrig, List<EntityDicDeptRoom> lstDeptRoom, List<EntityDicDeptReg> lstDeptReg);

        [OperationContract(Name = "DelDepartment")]
        int DelDepartment(string deptCode);

        #endregion

        #region employee

        [OperationContract(Name = "LoadEmpInfo")]
        List<EntityOperatorDisp> LoadEmpInfo();

        [OperationContract(Name = "LoadCodeOperatorAndPlus")]
        void LoadCodeOperatorAndPlus(string operCode, out EntityCodeOperator mainVo, out EntityPlusOperator plusVo);

        [OperationContract(Name = "LoadOperatorRole")]
        List<EntityDefOperatorRole> LoadOperatorRole(string operCode);

        [OperationContract(Name = "LoadOperatorDept")]
        List<EntityDefDeptemployee> LoadOperatorDept(string operCode);

        [OperationContract(Name = "SaveOperatorDept")]
        int SaveOperatorDept(EntityDefDeptemployee vo);

        [OperationContract(Name = "SaveOperatorRole")]
        int SaveOperatorRole(EntityDefOperatorRole vo);

        [OperationContract(Name = "DelOperatorDept")]
        int DelOperatorDept(EntityDefDeptemployee vo);

        [OperationContract(Name = "DelOperatorRole")]
        int DelOperatorRole(EntityDefOperatorRole vo);

        [OperationContract(Name = "SaveOperator")]
        int SaveOperator(EntityCodeOperator mainVo, EntityPlusOperator plusVo, EntityCodeOperator operOrig);

        [OperationContract(Name = "DelOperator")]
        int DelOperator(string operCode);

        [OperationContract(Name = "UpdateOperatorDeptDefault")]
        int UpdateOperatorDeptDefault(EntityDefDeptemployee vo);
        #endregion

        #region role

        [OperationContract(Name = "LoadRoleOper")]
        List<EntityDefOperatorRole> LoadRoleOper(string roleCode);

        [OperationContract(Name = "LoadRoleFunc")]
        List<EntityRoleFunction> LoadRoleFunc(string roleCode);

        [OperationContract(Name = "SaveRoleFunc")]
        int SaveRoleFunc(EntityRoleFunction vo, int type);

        [OperationContract(Name = "SaveRole")]
        int SaveRole(List<EntityCodeRole> lstRoleUpdate, List<EntityCodeRole> lstRoleNew);

        [OperationContract(Name = "DelRole")]
        int DelRole(string roleCode);

        #endregion

        #region 患者资料

        /// <summary>
        /// 获取病人资料
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetPatInfo")]
        List<EntityPatientInfo> GetPatInfo(string key, string value);

        /// <summary>
        /// 保存病人资料
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        [OperationContract(Name = "SavePatInfo")]
        int SavePatInfo(ref EntityPatientInfo pat);

        /// <summary>
        /// 删除病人资料
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [OperationContract(Name = "DelPatInfo")]
        int DelPatInfo(string pid);

        #endregion

        #region 导入数据

        #region 中天

        [OperationContract(Name = "ImportDeptInfo")]
        int ImportDeptInfo();

        [OperationContract(Name = "ImportEmpInfo")]
        int ImportEmpInfo();

        [OperationContract(Name = "ImportPatInfo")]
        int ImportPatInfo();

        [OperationContract(Name = "ImportRankInfo")]
        int ImportRankInfo();

        #endregion

        #region 惠侨

        [OperationContract(Name = "ImportDeptForHq")]
        int ImportDeptForHq();

        [OperationContract(Name = "ImportEmpForHq")]
        int ImportEmpForHq();

        #endregion
        
        #endregion
    }
}
