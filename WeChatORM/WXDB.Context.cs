﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeChatORM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WXDBEntity : DbContext
    {
        public WXDBEntity()
            : base("name=WXDBEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<WX_Access_token> WX_Access_token { get; set; }
        public DbSet<WX_RequestMsgLog> WX_RequestMsgLog { get; set; }
        public DbSet<WX_RequestParserFail> WX_RequestParserFail { get; set; }
        public DbSet<WX_ResponseMsgLog> WX_ResponseMsgLog { get; set; }
        public DbSet<Global_Error> Global_Error { get; set; }
    }
}