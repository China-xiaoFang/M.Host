using M.Helper.AppConfigurtaion;
using M.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace M.Model.Db
{
    public class MChenVipDbContext : DbContext
    {
        public MChenVipDbContext(DbContextOptions<MChenVipDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                AppConfigurtaionService.Configuration["ConnectionStrings:Default"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin { Id = 1, AdminName = "admin", AdminPwd = "123456" },
                new Admin { Id = 2, AdminName = "fangfang", AdminPwd = "Fh2269..." });

            modelBuilder.Entity<DevloveInfo>().HasData(
                new DevloveInfo
                {
                    DLId = 1,
                    DLName = "Mr.Fang",
                    DLoveName = "文洁",
                    DLInfo = "希望以后和你的生活，温柔，有趣，不必太激烈，三餐，四季，不必太匆忙，毕竟我有一生的时间要和你浪费。",
                    DLoveInfo = "我永远在！",
                    DLYear = "2017",
                    DLMonth = "3",
                    DLDay = "6",
                    DLQQ = "2875616188"
                });
        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<DevloveInfo> DevloveInfo { get; set; }

        public DbSet<EmailHistoryInfo> EmailHistoryInfo { get; set; }
    }
}
