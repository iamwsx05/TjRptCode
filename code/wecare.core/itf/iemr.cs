using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weCare.Core.Itf
{
    /// <summary>
    /// RichText样式接口
    /// </summary>
    public interface IRichTextStyle
    {
        /// <summary>
        /// 显示元素红点
        /// </summary>
        bool IsShowElementRedPoint { get; set; }
    }
}
