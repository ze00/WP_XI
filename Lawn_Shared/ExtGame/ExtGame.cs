using System;
using System.Collections.Generic;
using System.Text;

namespace Lawn.ExtGame
{
    public class ExtGameLevel
    {
        /// <summary>
        /// 条3窝4
        /// 7-1白天草地 初始阳光100
        /// 不长墓碑
        ///  开局右边5*3范围全是墓碑
        /// </summary>
        public const int CUSTOM_LEVEL_T3W4 = 61;

        /// <summary>
        /// 驱羊攻虎
        /// 开局60秒发育时间
        /// 14死亡生成两个11 7死亡生成3 4死亡生成两个0 23死亡生成两个4
        /// </summary>
        public const int CUSTOM_LEVEL_QYGH = 62;
    }
    public class ExtGameDef
    {
        public const int NUM_OF_SEEDPACKETS_ROW = 14;
        public const int NUM_BIG_STAGE = 7;
        public const int CUSTOM_LEVEL_START = 51;
        public const int CUSTOM_LEVEL_END = 62;
        public const int CUSTOM_LEVEL_QYGH_ZOMBIES_COUNTDOWN = 8000;
        public const int ZOMBIE_CATAPULT_LAUNCH_RATE = 150;
    }
}
