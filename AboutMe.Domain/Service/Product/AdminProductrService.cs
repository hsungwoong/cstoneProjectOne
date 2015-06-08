using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AboutMe.Domain.Entity.AdminProduct;

namespace AboutMe.Domain.Service.Product
{
    class AdminProductrService :IAdminProductService
    {

        //카테고리 insert
        public void InsertAdminProduct(string CATE_GBN, string CATE_CODE, int RE_SORT, string DEPTH1_CODE, string DEPTH1_NAME, string DEPTH1_IMG, string DEPTH2_CODE, string DEPTH2_NAME, string DEPTH_FLAG, string DISPLAY_YN)
        {
            using (AdminProductEntities AdmProductContext = new AdminProductEntities())
            {
                AdmProductContext.SP_ADM_CATEGORY_INS(CATE_GBN, CATE_CODE, RE_SORT, DEPTH1_CODE, DEPTH1_NAME, DEPTH1_IMG, DEPTH2_CODE, DEPTH2_NAME, DEPTH_FLAG, DISPLAY_YN);
            }
        }
    }
}
