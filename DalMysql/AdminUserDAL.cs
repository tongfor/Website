/** 
* AdminUserDAL.cs
*
* 功 能： 表AdminUser数据层
* 类 名： AdminUser
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/1/26 15:37:49   N/A    初版
*
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：成都盈辉创动科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
//----------AdminUser开始----------

using Models;
using IDAL;
using RepositoryPattern;
using Microsoft.EntityFrameworkCore;

namespace DALMySql
{
	public partial class AdminUserDAL : BaseDAL<AdminUser>, IAdminUserDAL
    {
		public AdminUserDAL(CdyhcdDBContext db, DbContextOptions dbContextOptions) : base(db, dbContextOptions)
        {
        }
    }
}

//----------AdminUser结束----------

    