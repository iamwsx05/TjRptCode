using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common.Entity;
using iCare.Core.Entity;
using iCare.Core.Itf;
using iCare.Core.Utils;

namespace Common.Itf
{
    /// <summary>
    /// ItfCommon
    /// </summary>
    [ServiceContract]
    public interface ItfCommon : IWcf, IDisposable
    {
        #region GetFullTableData
        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <param name="typeID">1 医生 2 护士</param>
        /// <returns></returns>
        [OperationContract(Name = "GetEmployee")]
        EntityEmployee[] GetEmployee(int typeID);

        [OperationContract(Name = "GetEmpDept")]
        EntityDeptEmployee[] GetEmpDept();

        [OperationContract(Name = "GetEmpRole")]
        EntityRoleEmployee[] GetEmpRole();

        [OperationContract(Name = "GetDepartment")]
        EntityDepartment[] GetDepartment();

        [OperationContract(Name = "GetDepartmentAttri")]
        EntityDeptattribute[] GetDepartmentAttri();

        [OperationContract(Name = "GetArea")]
        EntityArea[] GetArea();

        [OperationContract(Name = "GetDeptArea")]
        EntityDeptArea[] GetDeptArea();

        [OperationContract(Name = "GetIcd")]
        EntityIcd[] GetIcd();

        //[OperationContract(Name = "GetFrequency")]
        //EntityFrequency[] GetFrequency();

        //[OperationContract(Name = "GetUsage")]
        //EntityUsage[] GetUsage();

        #endregion


    }
}
