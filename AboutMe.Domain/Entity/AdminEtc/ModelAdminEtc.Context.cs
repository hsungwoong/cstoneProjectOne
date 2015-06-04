﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AboutMe.Domain.Entity.AdminEtc
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AdminEtcEntities : DbContext
    {
        public AdminEtcEntities()
            : base("name=AdminEtcEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN_MEMBER> ADMIN_MEMBER { get; set; }
    
        public virtual ObjectResult<SP_ADM_ADMIN_MEMBER_CNT> SP_ADM_ADMIN_MEMBER_CNT(string sEARCH_COL, string sEARCH_KEYWORD)
        {
            var sEARCH_COLParameter = sEARCH_COL != null ?
                new ObjectParameter("SEARCH_COL", sEARCH_COL) :
                new ObjectParameter("SEARCH_COL", typeof(string));
    
            var sEARCH_KEYWORDParameter = sEARCH_KEYWORD != null ?
                new ObjectParameter("SEARCH_KEYWORD", sEARCH_KEYWORD) :
                new ObjectParameter("SEARCH_KEYWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ADM_ADMIN_MEMBER_CNT>("SP_ADM_ADMIN_MEMBER_CNT", sEARCH_COLParameter, sEARCH_KEYWORDParameter);
        }
    
        public virtual ObjectResult<SP_ADM_ADMIN_MEMBER_SEL_RESULT> SP_ADM_ADMIN_MEMBER_SEL(string sEARCH_COL, string sEARCH_KEYWORD, string sORT_COL, string sORT_DIR, Nullable<int> pAGE, Nullable<int> pAGESIZE)
        {
            var sEARCH_COLParameter = sEARCH_COL != null ?
                new ObjectParameter("SEARCH_COL", sEARCH_COL) :
                new ObjectParameter("SEARCH_COL", typeof(string));
    
            var sEARCH_KEYWORDParameter = sEARCH_KEYWORD != null ?
                new ObjectParameter("SEARCH_KEYWORD", sEARCH_KEYWORD) :
                new ObjectParameter("SEARCH_KEYWORD", typeof(string));
    
            var sORT_COLParameter = sORT_COL != null ?
                new ObjectParameter("SORT_COL", sORT_COL) :
                new ObjectParameter("SORT_COL", typeof(string));
    
            var sORT_DIRParameter = sORT_DIR != null ?
                new ObjectParameter("SORT_DIR", sORT_DIR) :
                new ObjectParameter("SORT_DIR", typeof(string));
    
            var pAGEParameter = pAGE.HasValue ?
                new ObjectParameter("PAGE", pAGE) :
                new ObjectParameter("PAGE", typeof(int));
    
            var pAGESIZEParameter = pAGESIZE.HasValue ?
                new ObjectParameter("PAGESIZE", pAGESIZE) :
                new ObjectParameter("PAGESIZE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ADM_ADMIN_MEMBER_SEL_RESULT>("SP_ADM_ADMIN_MEMBER_SEL", sEARCH_COLParameter, sEARCH_KEYWORDParameter, sORT_COLParameter, sORT_DIRParameter, pAGEParameter, pAGESIZEParameter);
        }
    
        public virtual ObjectResult<SP_DUMMY_ADMIN_SEL_Result> SP_DUMMY_ADMIN_SEL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DUMMY_ADMIN_SEL_Result>("SP_DUMMY_ADMIN_SEL");
        }
    
        public virtual ObjectResult<SP_ADM_ADMIN_DEPT_SEL_Result> SP_ADM_ADMIN_DEPT_SEL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ADM_ADMIN_DEPT_SEL_Result>("SP_ADM_ADMIN_DEPT_SEL");
        }
    
        public virtual int SP_ADM_ADMIN_MEMBER_INS(string aDM_ID, string aDM_PASS, string aDM_NAME, string aDM_DEPT, Nullable<int> pOINT)
        {
            var aDM_IDParameter = aDM_ID != null ?
                new ObjectParameter("ADM_ID", aDM_ID) :
                new ObjectParameter("ADM_ID", typeof(string));
    
            var aDM_PASSParameter = aDM_PASS != null ?
                new ObjectParameter("ADM_PASS", aDM_PASS) :
                new ObjectParameter("ADM_PASS", typeof(string));
    
            var aDM_NAMEParameter = aDM_NAME != null ?
                new ObjectParameter("ADM_NAME", aDM_NAME) :
                new ObjectParameter("ADM_NAME", typeof(string));
    
            var aDM_DEPTParameter = aDM_DEPT != null ?
                new ObjectParameter("ADM_DEPT", aDM_DEPT) :
                new ObjectParameter("ADM_DEPT", typeof(string));
    
            var pOINTParameter = pOINT.HasValue ?
                new ObjectParameter("POINT", pOINT) :
                new ObjectParameter("POINT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ADM_ADMIN_MEMBER_INS", aDM_IDParameter, aDM_PASSParameter, aDM_NAMEParameter, aDM_DEPTParameter, pOINTParameter);
        }
    }
}