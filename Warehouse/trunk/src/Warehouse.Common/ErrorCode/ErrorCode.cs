using System;
using System.ComponentModel;

namespace Warehouse.Common
{
    /// <summary>
    /// 记录所有Web服务的错误信息
    /// 示例：10123
    /// 1系统错误；2为服务级错误
    /// 01服务模块代码
    public enum ErrorCode
    {
        /// <summary>
        /// 未知错误
        /// </summary>
        [Description("未知错误")]
        UnknownError = 1,

        /// <summary>
        /// 系统错误
        /// </summary>
        [Description("系统错误")]
        SystemError = 10001,

        /// <summary>
        /// 参数错误
        /// </summary>
        [Description("参数错误")]
        ParameterError = 20001,

        /// <summary>
        /// 数据库错误
        /// </summary>
        [Description("数据库错误")]
        DbError = 20002,

        /// <summary>
        /// 没有查询到数据
        /// </summary>
        [Description("没有查询到数据")]
        NoData = 20003,

        /// <summary>
        /// 更新数据库失败
        /// </summary>
        [Description("更新数据库失败")]
        SaveDbChangesFailed = 20004,

        /// <summary>
        /// 保存文件失败
        /// </summary>
        [Description("保存文件失败")]
        SaveFileFailed = 20005,

        /// <summary>
        /// {0}数据不存在，或已被删除
        /// </summary>
        [Description("{0}数据不存在，或已被删除")]
        DataNoExistWithParam = 20006,

        /// <summary>
        /// 操作的数据不存在，或已被删除
        /// </summary>
        [Description("操作的数据不存在，或已被删除")]
        DataNoExist = 20007,

        [Description("此入库信息已经存在！")]
        PutInInfoHasExist = 30001,

        [Description("此二维码已经存在")]
        TwoDimensioncodeHasExist = 30002,


        [Description("此出场订单不存在")]
        RemovalWarehouseOrderNoExist = 30003,

        [Description("部门已经存在")]
        DepartmentHasExist = 40001,

        [Description("部门不存在")]
        DepartmentHasNoExist = 40002,

        [Description("此部门下存在用户，不能删除")]
        DepartmentHasUser = 40003,


        [Description("添加用户失败")]
        AddUserFailed = 50001,

        [Description("添加用户信息失败")]
        AddUserInfoFailed = 50002,


        [Description("当前用户不存在")]
        UserNoExist = 50003,

        [Description("该用户已经被删除")]
        UserHasDeleted = 50004,

        [Description("该用户信息不存在")]
        UserInfoNoExist = 50005,

        [Description("修改密码失败")]
        ChangePasswordFailed = 50006,


        [Description("变速箱型号已存在")]
        SpeedChangeBoxHasExist = 60001,

        [Description("此变速箱型号下有数据，不能删除")]
        SpeedChangeHasTwoDimensioncodes = 60002,

        [Description("条形码信息不存在")]
        BarCodeNotExist = 60003,
    }
}
