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
