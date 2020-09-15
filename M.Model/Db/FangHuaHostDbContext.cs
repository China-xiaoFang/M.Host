using M.Helper.AppConfigurtaion;
using M.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace M.Model.Db
{
    public class FangHuaHostDbContext : DbContext
    {
        public FangHuaHostDbContext(DbContextOptions<FangHuaHostDbContext> options)
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
                new Admin { Id = 2, AdminName = "Mr.Fang", AdminPwd = "Fh2269..." });

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
                new GuidePagesMenuInfo()
                {
                    MenuID = 1,
                    MenuName = "首页",
                    MenuUrl = "https://home.fanghua.host",
                    MenuOrder = 1
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 2,
                    MenuName = "QQ",
                    MenuUrl = "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes",
                    MenuOrder = 2
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 3,
                    MenuName = "微信",
                    MenuUrl = "https://fanghua.host/assets/images/weixin.jpg",
                    MenuOrder = 3
                },
                 new GuidePagesMenuInfo()
                 {
                     MenuID = 4,
                     MenuName = "Mr.Fang♥Mrs.Zhou",
                     MenuUrl = "https://fh.fanghua.host",
                     MenuOrder = 4
                 },
                new GuidePagesMenuInfo()
                {
                    MenuID = 5,
                    MenuName = "表白小工具",
                    MenuUrl = "https://devlove.fanghua.host",
                    MenuOrder = 5
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 6,
                    MenuName = "实用小工具",
                    MenuUrl = "https://tool.fanghua.host",
                    MenuOrder = 6
                },
                new GuidePagesMenuInfo()
                {
                    MenuID = 7,
                    MenuName = "休闲小游戏",
                    MenuUrl = "https://game.fanghua.host",
                    MenuOrder = 7
                });

            for (int i = 1; i <= 100; i++)
            {
                modelBuilder.Entity<BackGroundImageInfo>().HasData(
                new BackGroundImageInfo()
                {
                    BGId = i,
                    BGUrl = "http://fanghua.host/assets/images/background/bg" + i + ".jpg"
                });
            }

            modelBuilder.Entity<CopywritingInfo>().HasData(
                new CopywritingInfo()
                {
                    Id = 1,
                    Content = "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。"
                },
                new CopywritingInfo()
                {
                    Id = 2,
                    Content = "脏的人多了，干净反倒成了一种错。"
                },
                new CopywritingInfo()
                {
                    Id = 3,
                    Content = "你羡慕的生活都是你没熬过的苦。"
                },
                new CopywritingInfo()
                {
                    Id = 4,
                    Content = "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。"
                },
                new CopywritingInfo()
                {
                    Id = 5,
                    Content = "生活便是寻求新的知识。——门捷列夫"
                },
                new CopywritingInfo()
                {
                    Id = 6,
                    Content = "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。"
                },
                new CopywritingInfo()
                {
                    Id = 7,
                    Content = "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。"
                });
        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<DevLoveInfo> DevLoveInfo { get; set; }

        public DbSet<EmailHistoryInfo> EmailHistoryInfo { get; set; }

        public DbSet<GuidePagesMenuInfo> GuidePagesMenuInfo { get; set; }

        public DbSet<AccessHistoryLog> AccessHistoryLog { get; set; }

        public DbSet<BackGroundImageInfo> BackGroundImageInfo { get; set; }

        public DbSet<CopywritingInfo> CopywritingInfo { get; set; }
    }
}