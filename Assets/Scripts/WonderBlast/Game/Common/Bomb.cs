﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using WonderBlast.Game.Manager;

namespace WonderBlast.Game.Common
{
    public class Bomb : Special
    {
        //public override List<BlockDef> Match(int x, int y)
        //{
        //    List<BlockDef> blocks = new List<BlockDef>();

        //    //bomb1 = type;
        //    //bool isCombo = GetCombo(x, y);
        //    //if (!isCombo)
        //    //{
        //    //    BombMatch(blocks, x, y);
        //    //}
        //    //else
        //    //{
        //    //    SpecialCombo(blocks, GameMgr.Get()._Stage.width, GameMgr.Get()._Stage.height, x, y);
        //    //}

        //    return blocks;
        //}

        public override List<BlockDef> Match(int x, int y)
        {
            List<BlockDef> blocks = new List<BlockDef>();

            AddBlock(blocks, x, y);
            AddBlock(blocks, x - 1, y);
            AddBlock(blocks, x + 1, y);
            AddBlock(blocks, x, y - 1);
            AddBlock(blocks, x, y + 1);
            AddBlock(blocks, x - 1, y - 1);
            AddBlock(blocks, x + 1, y - 1);
            AddBlock(blocks, x - 1, y + 1);
            AddBlock(blocks, x + 1, y + 1);

            return blocks;
        }

        public override List<BlockDef> ComboMatch(int x, int y)
        {
            List<BlockDef> blocks = Match(x, y);

            AddBlock(blocks, x, y - 2);
            AddBlock(blocks, x, y + 2);
            AddBlock(blocks, x - 1, y - 2);
            AddBlock(blocks, x - 1, y + 2);
            AddBlock(blocks, x - 2, y - 2);
            AddBlock(blocks, x - 2, y - 1);
            AddBlock(blocks, x - 2, y);
            AddBlock(blocks, x - 2, y + 1);
            AddBlock(blocks, x - 2, y + 2);
            AddBlock(blocks, x + 1, y - 2);
            AddBlock(blocks, x + 1, y + 2);
            AddBlock(blocks, x + 2, y - 2);
            AddBlock(blocks, x + 2, y - 1);
            AddBlock(blocks, x + 2, y);
            AddBlock(blocks, x + 2, y + 1);
            AddBlock(blocks, x + 2, y + 2);

            return blocks;
        }
    }
}