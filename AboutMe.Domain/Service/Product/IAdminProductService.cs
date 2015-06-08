using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AboutMe.Domain.Entity.AdminProduct;

namespace AboutMe.Domain.Service.Product
{
    public interface IAdminProductService
    {
        void InsertAdminProduct(string CATE_GBN, string CATE_CODE, int RE_SORT, string DEPTH1_CODE, string DEPTH1_NAME, string DEPTH1_IMG, string DEPTH2_CODE, string DEPTH2_NAME, string DEPTH_FLAG, string DISPLAY_YN);
        //List<SP_ADM_ADMIN_DEPT_SEL_Result> GetAdmDeptList();
    }
}
