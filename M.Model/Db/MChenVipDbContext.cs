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

            modelBuilder.Entity<DevLoveInfo>().HasData(
                new DevLoveInfo
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

            modelBuilder.Entity<GuidePagesMenuInfo>().HasData(
                // 首页 方方 QQ 微信 表白 工具 游戏
                new GuidePagesMenuInfo()
                {
                    MenuID = 1,
                    MenuName = "首页",
                    MenuUrl = "http://home.mchen.vip",
                    MenuOrder = 1
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 2,
                    MenuName = "Mr.Fang♥Mrs.Zhou",
                    MenuUrl = "http://fh.mchen.vip",
                    MenuOrder = 2
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 3,
                    MenuName = "QQ",
                    MenuUrl = "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes",
                    MenuOrder = 3
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 4,
                    MenuName = "微信",
                    MenuUrl = "http://mchen.vip/accsets/images/weixin.jpg",
                    MenuOrder = 4
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 5,
                    MenuName = "表白小工具",
                    MenuUrl = "http://devlove.mchen.vip",
                    MenuOrder = 5
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 6,
                    MenuName = "实用小工具",
                    MenuUrl = "http://tool.mchen.vip",
                    MenuOrder = 6
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 7,
                    MenuName = "休闲小游戏",
                    MenuUrl = "http://game.mchen.vip",
                    MenuOrder = 7
                });
        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<DevLoveInfo> DevLoveInfo { get; set; }

        public DbSet<EmailHistoryInfo> EmailHistoryInfo { get; set; }

        public DbSet<GuidePagesMenuInfo> GuidePagesMenuInfo { get; set; }
    }
}
