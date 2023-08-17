using System;
using System.Collections.Generic;
using System.Text;
using Sexy;
using Lawn;
using System.CodeDom;

namespace Lawn.ExtGame
{
    public class ExtGameLevel
    {
        // 条3窝4
        // 7-1白天草地 初始阳光100
        // 不长墓碑
        //  开局右边5*3范围全是墓碑
        public const int CUSTOM_LEVEL_T3W4 = 61;

        // 驱羊攻虎
        // 开局60秒发育时间
        // 14死亡生成两个11 7死亡生成3 4死亡生成两个0 23死亡生成两个4
        public const int CUSTOM_LEVEL_QYGH = 62;
        // 喜剧之夜
        // 夜晚关卡 暴风雨天气（屏幕会一闪一闪）节奏原版 小丑不会爆炸血量114514 啃咬1/s无精英 无法携带大嘴花和魅惑菇
        public const int CUSTOM_XJZY = 63;
        // 寸土寸金
        //7-4场景屋顶但是天上不掉阳光
        //开局无花盆阳光325
        //花盆每种植一个阳光加10
        public const int CUSTOM_LEVEL_CTCJ = 64;
        /*
僵尸有0 1 2 3 4 5 6 7 8 12 15 18 21混乱出
没一轮前三小波没有3 7 8 15 18 21
卡槽五个
不允许携带生产阳光的植物
 *
 */
        public const int CUSTOM_MINIGAME_65 = 65;
        // 雷厉风行
        //这关没铲子
        //换手套
        //ban一下三叶草
        //场景白天，开局400阳光，僵尸随存活时间移速不断增加（每啃食植物一次或被减速冰冻僵尸会重置移速）
        public const int CUSTOM_LEVEL_LLFX = 66;
        //场景泳池，ban莲叶，潜水有五分之一的概率掉落莲叶
        //初始阳光为125，这关叫智慧之僵（禁止戏水）
        public const int CUSTOM_LEVEL_ZHZJ = 67;
        //场景黑夜，开局2排墓碑，在原有墓碑生成的基础上
        //舞王在有墓碑的情况下，直接从每个墓碑召唤一个僵尸
        //从墓碑有百分之20召唤普僵，百分之20路障，百分之20铁桶,百分之10三爷,百分之10撑杆,百分之10冰车,百分之10二爷
        //舞王的血量改为2500+70(临界值)
        public const int CUSTOM_LEVEL_MYPD = 68;
        //本关出现精英撑杆，改为1500+70雪，移速为原始撑杆的二倍，精英有红眼特效，一次跳6格，精英撑杆的概率大概在1/3左右，黑夜屋顶，开局100阳光
        //BAN三叶草
        //叫激进の撑杆
        public const int CUSTOM_LEVEL_JJDCG = 69;
        public const int CUSTOM_LEVEL_WLKH = 71;
        public const int CUSTOM_LEVEL_WLKH_DAY = 70;
        public const int CUSTOM_LEVEL_BOSS = 60;
        public const int CUSTOM_MINIGAME_55 = 55;
    }
    public class ExtGameDef
    {
        public const int NUM_OF_SEEDPACKETS_ROW = 14;
        public const int NUM_BIG_STAGE = 8;
        public const int CUSTOM_LEVEL_START = 51;
        // 冒险模式终结
        public const int CUSTOM_LEVEL_END = ExtGameLevel.CUSTOM_LEVEL_WLKH;
        public const int CUSTOM_LEVEL_QYGH_ZOMBIES_COUNTDOWN = 7500;
        public const int CUSTOM_LEVEL_BOSS_ZOMBIES_COUNTDOWN = 7500;
        public const int ZOMBIE_CATAPULT_LAUNCH_RATE = 150;


        public static Dictionary<ZombieType, int> CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE = new Dictionary<ZombieType, int>();
        public static int[] CUSTOM_MINIGAME_65_ZOMBIES = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 12, 15, 18, 21, 16, 26, 31 };
        public static int[] CUSTOM_MINIGAME_65_NOT_ALLOWED_EARLY = new int[] { 3, 7, 8, 15, 18, 21, 16, 26 };
        // 第一次玉米 第二次豌豆第三次星星 第四次冰豆 第五次卷心菜 第六次火豆 第七次黄油 第八次西瓜第九次冰瓜
        public static ProjectileType[] CUSTOM_CABBAGE_PROJECTILES_SHIFT = new ProjectileType[] { ProjectileType.Kernel, ProjectileType.Pea, ProjectileType.Star, ProjectileType.Snowpea, ProjectileType.Cabbage, ProjectileType.Fireball, ProjectileType.Butter, ProjectileType.Melon, ProjectileType.Wintermelon };
        public const float CUSTOM_MINIGAME_66_VELOCITY_MAX_FACTOR = 4.0f;
        // 30 * 100cs
        public const float CUSTOM_MINIGAME_66_VELOCITY_MAX_SURVIVAL_TIME = 90 * 100;
        public const int CUSTOM_CABBAGE_PROJECTILES_SHIFT_END = 8;
        public const int CUSTOM_WLKH_SUNFLOWER_MASTER_COUNTDOWN = 2400;
        public static void InitExtGameDef()
        {
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.GatlingHead, 5);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.Balloon, 3);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.Zamboni, 3);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.Pogo, 2);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.Normal, 3);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.TrafficCone, 2);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.RedeyeGargantuar, 1);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.Polevaulter, 6);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.SquashHead, 4);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.Newspaper, 4);
            CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE.Add(ZombieType.JackInTheBox, 2);
        }
    }
}
