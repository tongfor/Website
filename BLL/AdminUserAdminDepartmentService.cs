/** 
* AdminUserAdminDepartmentService.cs
*
* 功 能： 表AdminUserAdminDepartment业务层
* 类 名： AdminUserAdminDepartment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/4/9 23:03:57   N/A    初版
*
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：成都盈辉创动科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
//----------AdminUserAdminDepartment开始----------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using DALMySql;

namespace BLL
{
	public partial class AdminUserAdminDepartmentService : BaseService<AdminUserAdminDepartment>
    {
        //EF上下文
        protected readonly CdyhcdDBContext _db;
        //操作DAL
        protected IAdminUserAdminDepartmentDAL adminUserAdminDepartmentDAL;

        #region 构造函数

		public AdminUserAdminDepartmentService(CdyhcdDBContext db)
		{
            _db = db;
			SetIBaseDal();
		}

		#endregion
		
        #region 重写IBaseDal获取方法

		public sealed override void SetIBaseDal()
        {
            IBaseDal = adminUserAdminDepartmentDAL = new DALSession(_db).IAdminUserAdminDepartmentDAL;
        }

		#endregion

        #region 根据条件获取模型

		/// <summary>
        /// 根据条件得到模型
        /// </summary>
        /// <param name="queryWhere">条件Lambda表达式</param>
        /// <returns></returns>
		public AdminUserAdminDepartment GetModelBy(Expression<Func<AdminUserAdminDepartment, bool>> queryWhere)
		{
			AdminUserAdminDepartment result = this.GetListBy(queryWhere).FirstOrDefault();
			return result;
		}

		/// <summary>
        /// 异步根据条件得到模型
        /// </summary>
        /// <param name="queryWhere">条件Lambda表达式</param>
        /// <returns></returns>
		 public async Task<AdminUserAdminDepartment> GetModelByAsync(Expression<Func<AdminUserAdminDepartment, bool>> queryWhere)
        {
            var modelList = await this.GetListByAsync(queryWhere);
            AdminUserAdminDepartment result = modelList.FirstOrDefault();
            return result;
        }

		#endregion 
    }
}

//----------AdminUserAdminDepartment结束----------

    