using System;
using System.Collections.Generic;
using System.Text;
using Sexy;
using Lawn;
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
        // 喜剧之夜
        // 夜晚关卡 暴风雨天气（屏幕会一闪一闪）节奏原版 小丑不会爆炸血量114514 啃咬1/s无精英 无法携带大嘴花和魅惑菇
        public const int CUSTOM_XJZY = 63;
        public const int CUSTOM_LEVEL_BOSS = 60;
        public const int CUSTOM_MINIGAME_55 = 55;
    }
    public class ExtGameDef
    {
        public const int NUM_OF_SEEDPACKETS_ROW = 14;
        public const int NUM_BIG_STAGE = 7;
        public const int CUSTOM_LEVEL_START = 51;
        public const int CUSTOM_LEVEL_END = ExtGameLevel.CUSTOM_XJZY;
        public const int CUSTOM_LEVEL_QYGH_ZOMBIES_COUNTDOWN = 7500;
        public const int CUSTOM_LEVEL_BOSS_ZOMBIES_COUNTDOWN = 6000;
        public const int ZOMBIE_CATAPULT_LAUNCH_RATE = 150;


        public static Dictionary<ZombieType, int> CUSTOM_MINIGAME_55_ZOMBIE_WEIGHTS_OVERRIDE = new Dictionary<ZombieType, int>();
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
    enum CustomLevelSelectorID
    {
        DIALOG_ID = 114515,
        RAISER_BUTTON_ID = 7,
    }

    public class CustomLevelInfo
    {
        public string mAuthor;
        public string mScene;
    }
    public class LoadCustomLevelDialog : LawnDialog, ListListener, ButtonListener
    {

        private ListWidget mCustomLevelsWidget;
        public List<string> mFiles = new List<string>();
        public LoadCustomLevelDialog(LawnApp theApp) : base(theApp, null, (int)CustomLevelSelectorID.DIALOG_ID, true, "CUSTOM_LEVEL_SELECTOR", "", "", 2)
        {
            mCustomLevelsWidget = new ListWidget(0, Resources.FONT_BRIANNETOD16, this);
            mCustomLevelsWidget.SetColors(LawnCommon.gUserListWidgetColors, 5);
            mCustomLevelsWidget.mDrawOutline = true;
            mCustomLevelsWidget.mJustify = 1;
            mCustomLevelsWidget.mItemHeight = (int)Constants.InvertAndScale(24f);
            mFiles.Add("Hello");
            mFiles.Add("World");
            foreach (string file in mFiles)
            {
                mCustomLevelsWidget.SetSelect(mCustomLevelsWidget.AddLine(file, true));
            }
        }

        public void ListClicked(int theId, int theIdx, int theClickCount)
        {
            Console.WriteLine($"{theId} CLICKED on {theIdx} {theClickCount} count");
        }

        public void ListClosed(int theId)
        {
           
        }

        public void ListHiliteChanged(int theId, int theOldIdx, int theNewIdx)
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            base.Dispose();
            RemoveAllWidgets(true, true);
        }

        public override void AddedToManager(WidgetManager theWidgetManager)
        {
            base.AddedToManager(theWidgetManager);
            AddWidget(mCustomLevelsWidget);
        }

        public override void RemovedFromManager(WidgetManager theWidgetManager)
        {
            base.RemovedFromManager(theWidgetManager);
            RemoveWidget(mCustomLevelsWidget);
        }

        public override void ButtonPress(int theId)
        {
            base.ButtonPress(theId);
        }

        public override bool BackButtonPress()
        {
            return base.BackButtonPress();
        }

        public override void ButtonDepress(int theId)
        {
            mApp.KillDialog((int)ExtGame.CustomLevelSelectorID.DIALOG_ID);
            base.ButtonDepress(theId);
        }
    }
}
