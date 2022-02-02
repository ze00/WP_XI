using System;
using System.Collections.Generic;
using Sexy;
using Sexy.TodLib;

namespace Lawn
{
    internal class CheatPanel : LawnDialog, SliderListener, CheckboxListener
    {
        public CheatPanel(LawnApp theApp, bool theFromGameSelector) : base(theApp, null, 2, true, "Cheat Panel", "", "", 0)
        {
            mApp = theApp;
            SetColor(3, new SexyColor(255, 255, 100));
            mBackToGameButton = GameButton.MakeButton(1000, this, "[BACK_TO_GAME]");
            mBackToGameButton.SetLabel("[DIALOG_BUTTON_OK]");
            mEasyPlantingCheckbox = LawnCommon.MakeNewCheckbox(1, this, mApp.mEasyPlantingCheat);
            mSunButton = GameButton.MakeButton(2, this, "9990 Sun");
            mPassLevelButton = GameButton.MakeButton(3, this, "Pass This Level");
            mTriggerMowersButton = GameButton.MakeButton(4, this, "Trigger Mowers");
            mFastMoCheckbox = LawnCommon.MakeNewCheckbox(5, this, GlobalStaticVars.gFastMo);
            mEnableVirtualKeyboardButton = GameButton.MakeButton(6, this, "Use TodKeys");
            base.CalcSize(0, 0);
        }

        public override void Dispose()
        {
            mBackToGameButton.Dispose();
            base.Dispose();
        }

        public override int GetPreferredHeight(int theWidth)
        {
            return (int)410;
        }

        public override void AddedToManager(WidgetManager theWidgetManager)
        {
            base.AddedToManager(theWidgetManager);
            AddWidget(mBackToGameButton);
            AddWidget(mEasyPlantingCheckbox);
            AddWidget(mSunButton);
            AddWidget(mPassLevelButton);
            AddWidget(mTriggerMowersButton);
            AddWidget(mFastMoCheckbox);
            AddWidget(mEnableVirtualKeyboardButton);
        }

        public override void RemovedFromManager(WidgetManager theWidgetManager)
        {
            base.RemovedFromManager(theWidgetManager);
            RemoveWidget(mBackToGameButton);
            RemoveWidget(mEasyPlantingCheckbox);
            RemoveWidget(mSunButton);
            RemoveWidget(mPassLevelButton);
            RemoveWidget(mTriggerMowersButton);
            RemoveWidget(mFastMoCheckbox);
            RemoveWidget(mEnableVirtualKeyboardButton);
        }

        public override void Resize(int theX, int theY, int theWidth, int theHeight)
        {
            base.Resize(theX, theY, theWidth, theHeight);
            int btnHeight = AtlasResources.IMAGE_BUTTON_LEFT.mHeight;
            mBackToGameButton.Resize(100, mHeight - 70, mWidth - 200, btnHeight);

            mEasyPlantingCheckbox.Resize(300, 120, (int)Constants.InvertAndScale(46f), (int)Constants.InvertAndScale(45f));
            mSunButton.Resize(370, 130, 200, btnHeight);
            mPassLevelButton.Resize(50, 190, 250, btnHeight);
            mTriggerMowersButton.Resize(320, 190, 250, btnHeight);
            mVersionY = Constants.NewOptionsDialog_Version_High_Y;
            mFastMoCheckbox.Resize(300, 240, (int)Constants.InvertAndScale(46f), (int)Constants.InvertAndScale(45f));
            mEnableVirtualKeyboardButton.Resize(370, 250, 200, btnHeight);
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            SexyColor theColor = new SexyColor(107, 109, 145);
            TodCommon.TodDrawString(g, "Easy Planting", 300 - 10, 130, Resources.FONT_DWARVENTODCRAFT15, theColor, DrawStringJustification.Right);
            TodCommon.TodDrawString(g, "Fast Motion", 300 - 10, 250, Resources.FONT_DWARVENTODCRAFT15, theColor, DrawStringJustification.Right);
        }

        public virtual void SliderVal(int theId, double theVal)
        {
        }

        public override void CheckboxChecked(int theId, bool check)
        {
            mApp.PlaySample(Resources.SOUND_BUTTONCLICK);
            switch (theId)
            {
            case 1:
                mApp.mEasyPlantingCheat = check;
                break;
            case 5:
                mApp.ToggleFastMo();
                break;
            }
        }

        public override void ButtonPress(int theId)
        {
            mApp.PlaySample(Resources.SOUND_GRAVEBUTTON);
        }

        public override bool BackButtonPress()
        {
            int id = mBackToGameButton.mId;
            ButtonPress(id);
            ButtonDepress(id);
            return true;
        }

        public override void ButtonDepress(int theId)
        {
            //base.ButtonDepress(theId);
            switch (theId)
            {
            case 2:
                mApp.mBoard.mSunMoney = 9990;
                return;
            case 3:
                mApp.KillDialog(2);
                mApp.mBoard.RemoveAllZombies();
                mApp.mBoard.FadeOutLevel();
                mApp.mBoard.mBoardFadeOutCounter = 200;
                return;
            case 4:
                LawnMower lawnMower = null;
                while (mApp.mBoard.IterateLawnMowers(ref lawnMower))
                {
                    lawnMower.StartMower();
                }
                break;
            case 6:
                mApp.KillDialog(2);
                GlobalStaticVars.gLawnApp.mWidgetManager.mIMEHandler.StopTextComposition();
                GlobalStaticVars.gLawnApp.mWidgetManager.mIMEHandler.StartTextComposition();
                break;
            case 1000:
                mApp.KillDialog(2);
                mApp.WriteCurrentUserConfig();
                return;
            }
        }

        public override void KeyDown(KeyCode theKey)
        {
            if (mApp.mBoard != null)
            {
                mApp.mBoard.DoTypingCheck(theKey);
            }
            if (theKey == KeyCode.Space || theKey == KeyCode.Return)
            {
                base.ButtonDepress(1000);
                return;
            }
            if (theKey == KeyCode.Escape)
            {
                base.ButtonDepress(1001);
            }
        }

        public override void Update()
        {
            base.Update();
        }


        public string mVersion = string.Empty;

        public int mVersionY;

        public Checkbox mEasyPlantingCheckbox;
        public LawnStoneButton mSunButton;
        public LawnStoneButton mBackToGameButton;
        public LawnStoneButton mPassLevelButton;
        public LawnStoneButton mTriggerMowersButton;
        public Checkbox mFastMoCheckbox;
        public LawnStoneButton mEnableVirtualKeyboardButton;
    }
}
