using System.Collections.Generic;
using System.ServiceModel;

namespace weCare
{
    [ServiceContract]
    public interface ItfUpdate
    {
        /// <summary>
        /// 获取版本号
        /// </summary>
        /// <param name="version"></param>
        [OperationContract]
        void GetVersion(ref string version);

        /// <summary>
        /// 更新版本号
        /// </summary>
        /// <param name="version"></param>
        [OperationContract]
        void UpdateVersion(string version);

        /// <summary>
        /// 获取更新文件列表
        /// </summary>
        /// <param name="isAll"></param>
        /// <returns></returns>
        [OperationContract]
        List<string> GetUpdateFileList(bool isAll);

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] DownLoadFile(string file);

    }
}
