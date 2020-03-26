using M.Model.Db;
using Microsoft.EntityFrameworkCore;

namespace M.Model
{
    public class DbInitializer
    {
        public void InitializeAsync(MChenVipDbContext context)
        {
            // 根据Migrations修改/创建数据库
            context.Database.MigrateAsync();
        }
    }
}