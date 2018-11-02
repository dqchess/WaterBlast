﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WaterBlast.Game.Manager;
using WaterBlast.Game.Common;

namespace WaterBlast.Game.UI
{
    public class Hammer : Item
    {
        public void OnPressed()
        {
            int index = (int)ItemType.hammer;
            if (GameDataMgr.Get().availableItemCount[index] > 0)
            {
                GameDataMgr.Get().isUseItem[index] = !GameDataMgr.Get().isUseItem[index];
                bool isUseItem = GameDataMgr.Get().isUseItem[index];
                itemClicked.SetInfo(isUseItem, (ItemType)index);
                itemUI.GetComponent<UISprite>().depth = (isUseItem == true) ? 6 : 2;
            }
            else
            {
                //아이템 샵 팝업.
            }
        }
    }
}