/** 
* AdminDepartmentDAL.cs
*
* 功 能： 表AdminDepartment数据层
* 类 名： AdminDepartment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/4/8 21:13:05   N/A    初版
*
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：成都盈辉创动科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
//----------AdminDepartment开始----------

using Models;
using IDAL;

namespace DALMySql
{
	public partial class AdminDepartmentDAL : BaseDAL<AdminDepartment>, IAdminDepartmentDAL
    {
		public AdminDepartmentDAL(CdyhcdDBContext db) : base(db)
        {
        }
    }
}

//----------AdminDepartment结束----------

    