using System;
using System.Collections.Generic;
using System.Text;

namespace Lawn.ExtGame
{
    public class ExtGameLevel
    {
        /// <summary>
        /// 7-1白天草地 初始阳光100
        /// 不长墓碑
        ///  卡槽向日葵 墓碑吞噬者 樱桃 路灯 窝瓜 三线 大蒜 南瓜
        ///  开局右边5*3范围全是墓碑
        ///  左方5*3范围花盆
        ///  第十个卡槽显示寒冰菇耗费50 冷却10s 使用后全屏僵尸减速10s
        /// </summary>
        public const int CUSTOM_LEVEL_T3W4 = 61;
    }
    public class ExtGameDef
    {
        public const int NUM_BIG_STAGE = 7;
        public const int CUSTOM_LEVEL_START = 51;
        public const int CUSTOM_LEVEL_END = 61;

        public const int ZOMBIE_CATAPULT_LAUNCH_RATE = 150;
    }
}
