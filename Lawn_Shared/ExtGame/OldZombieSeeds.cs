﻿using System;
using System.Collections.Generic;

namespace Lawn.ExtGame
{
    class OldZombieSeeds
    {
        public static Dictionary<int, int[][]> OldZombieSeedsDict = new Dictionary<int, int[][]>();
        public static void LoadOldZombieSeeds()
        {
            OldZombieSeedsDict.Add(1, new int[][]{
          new int[]{0,0,0,0,0,-1},
          new int[]{0,0,0,0,0,-1},
          new int[]{0,0,0,0,0,-1},
          new int[]{1,0,0,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(2, new int[][]{
          new int[]{0,0,0,0,0,-1},
          new int[]{0,0,0,0,0,-1},
          new int[]{2,0,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{2,2,2,1,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(3, new int[][]{
          new int[]{2,2,-1},
          new int[]{2,2,-1},
          new int[]{2,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,0,-1},
          new int[]{2,2,2,2,1,0,0,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(4, new int[][]{
          new int[]{0,0,0,0,-1},
          new int[]{2,2,-1},
          new int[]{2,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{4,2,0,0,0,-1},
          new int[]{4,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,0,-1},
          new int[]{4,2,0,0,0,0,0,0,0,-1},
          new int[]{4,2,0,0,0,0,0,0,0,-1},
          new int[]{4,4,2,2,1,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(6, new int[][]{
          new int[]{4,0,-1},
          new int[]{4,0,-1},
          new int[]{2,2,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{4,2,2,0,0,0,0,-1},
          new int[]{4,2,2,0,0,0,0,-1},
          new int[]{4,2,2,0,0,0,0,-1},
          new int[]{4,2,2,0,0,0,0,-1},
          new int[]{4,2,2,2,1,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(7, new int[][]{
          new int[]{2,0,0,-1},
          new int[]{2,2,-1},
          new int[]{3,2,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,2,1,0,0,0,0,0,0,-1},
          new int[]{3,3,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{3,3,3,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(8, new int[][]{
          new int[]{6,0,-1},
          new int[]{2,0,0,-1},
          new int[]{2,0,0,-1},
          new int[]{6,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{6,2,2,0,0,0,0,-1},
          new int[]{6,2,2,0,0,0,0,-1},
          new int[]{6,2,2,0,0,0,0,-1},
          new int[]{6,2,2,0,0,0,0,-1},
          new int[]{6,6,2,2,1,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(9, new int[][]{
          new int[]{3,0,0,-1},
          new int[]{2,0,0,-1},
          new int[]{0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{6,3,2,2,2,1,0,0,0,0,-1},
          new int[]{6,3,2,2,0,0,0,0,0,0,-1},
          new int[]{6,3,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,3,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,3,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,3,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,3,2,2,2,2,0,0,0,0,0,-1},
          new int[]{6,6,6,3,3,2,2,2,1,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(11, new int[][]{
          new int[]{0,0,0,0,0,-1},
          new int[]{0,0,0,0,0,-1},
          new int[]{5,0,-1},
          new int[]{5,0,0,0,0,0,-1},
          new int[]{5,0,0,0,0,0,-1},
          new int[]{5,5,0,0,0,0,0,-1},
          new int[]{5,5,0,0,0,0,0,-1},
          new int[]{5,5,0,0,0,0,-1},
          new int[]{5,5,0,0,0,0,-1},
          new int[]{5,5,5,1,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(12, new int[][]{
          new int[]{2,2,0,-1},
          new int[]{2,2,0,-1},
          new int[]{0,0,0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,-1},
          new int[]{6,2,2,2,1,0,0,0,0,0,0,-1},
          new int[]{6,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,2,2,2,0,0,0,0,0,0,-1},
          new int[]{6,6,3,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{6,6,3,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{6,6,3,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{6,6,3,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{6,6,6,2,2,2,2,1,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(13, new int[][]{
          new int[]{6,0,0,-1},
          new int[]{6,0,0,-1},
          new int[]{0,0,0,0,0,0,-1},
          new int[]{4,0,0,0,0,0,-1},
          new int[]{4,0,0,0,0,0,-1},
          new int[]{4,0,0,0,0,0,-1},
          new int[]{6,4,0,0,0,0,0,-1},
          new int[]{6,4,0,0,0,0,0,-1},
          new int[]{6,4,0,0,0,0,0,-1},
          new int[]{6,4,4,1,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(14, new int[][]{
          new int[]{0,0,0,0,0,0,-1},
          new int[]{2,2,0,-1},
          new int[]{3,2,0,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{3,3,0,0,0,0,-1},
          new int[]{3,3,0,0,0,0,-1},
          new int[]{5,2,0,0,0,0,0,-1},
          new int[]{5,2,0,0,0,0,0,-1},
          new int[]{5,3,0,0,0,0,0,-1},
          new int[]{5,5,3,1,0,0,0,0,0,0,-1},
          new int[]{5,5,2,0,0,0,0,0,0,-1},
          new int[]{5,5,2,0,0,0,0,0,0,-1},
          new int[]{5,5,3,2,2,0,0,0,0,0,0,-1},
          new int[]{5,5,3,2,2,0,0,0,0,0,0,-1},
          new int[]{5,5,3,2,2,0,0,0,0,0,0,-1},
          new int[]{5,5,5,3,2,2,2,0,0,0,0,0,-1},
          new int[]{5,5,5,3,2,2,2,0,0,0,0,0,-1},
          new int[]{5,5,5,3,2,2,2,0,0,0,0,0,-1},
          new int[]{5,5,5,3,2,2,2,0,0,0,0,-1},
          new int[]{5,5,5,5,3,2,2,2,2,1,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(16, new int[][]{
          new int[]{0,0,0,-1},
          new int[]{2,0,0,0,-1},
          new int[]{3,2,-1},
          new int[]{3,2,0,0,0,0,-1},
          new int[]{21,3,2,0,0,-1},
          new int[]{21,2,0,0,0,0,-1},
          new int[]{21,3,2,0,0,0,0,0,0,-1},
          new int[]{21,21,2,0,0,0,0,0,0,-1},
          new int[]{21,21,2,0,0,0,0,0,0,-1},
          new int[]{21,21,21,3,2,1,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(17, new int[][]{
          new int[]{2,0,0,-1},
          new int[]{2,2,0,-1},
          new int[]{2,0,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{6,2,2,0,0,0,0,0,-1},
          new int[]{6,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{21,6,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,5,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,21,5,2,2,2,1,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,6,5,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,5,5,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,6,6,6,5,5,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,6,6,6,5,5,5,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,21,21,6,6,6,5,5,5,2,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{21,21,21,21,6,6,6,6,5,5,5,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,6,6,6,6,6,5,5,5,5,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,6,6,6,6,6,5,5,5,5,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,6,6,6,6,6,5,5,5,5,5,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,6,6,6,6,6,5,5,5,5,5,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(18, new int[][]{
          new int[]{2,0,0,-1},
          new int[]{2,2,0,0,-1},
          new int[]{2,2,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,2,0,0,0,0,-1},
          new int[]{2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{23,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{23,2,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{23,23,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(19, new int[][]{
          new int[]{0,0,0,0,0,0,0,0,-1},
          new int[]{0,0,0,0,0,0,0,0,-1},
          new int[]{2,0,0,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,2,0,0,0,0,-1},
          new int[]{21,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,21,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,21,21,5,5,2,2,2,2,2,1,0,0,0,0,0,0,-1},
          new int[]{23,21,21,6,6,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{23,21,21,6,6,5,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{23,21,21,6,6,5,5,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{23,21,21,6,6,5,5,5,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{23,21,21,6,6,5,5,5,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{23,21,21,21,6,6,6,6,5,5,5,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,21,21,21,6,6,6,5,5,5,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,21,21,21,6,6,6,5,5,5,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,21,21,21,6,6,6,6,6,5,5,5,5,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,21,21,21,6,6,6,6,6,5,5,5,5,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(21, new int[][]{
          new int[]{2,0,0,-1},
          new int[]{2,0,0,0,-1},
          new int[]{2,2,0,0,-1},
          new int[]{2,2,2,2,0,0,0,0,-1},
          new int[]{2,2,2,2,2,0,0,0,-1},
          new int[]{7,2,2,2,2,0,0,0,-1},
          new int[]{7,7,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{7,7,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{7,7,7,2,2,2,2,0,0,0,0,0,-1},
          new int[]{7,7,7,7,2,2,2,2,2,2,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(22, new int[][]{
          new int[]{2,0,-1},
          new int[]{2,0,0,-1},
          new int[]{6,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{6,2,2,2,0,0,0,0,-1},
          new int[]{6,2,2,2,2,0,0,0,-1},
          new int[]{6,6,2,2,2,2,0,0,0,0,0,-1},
          new int[]{6,6,5,2,2,2,0,0,0,0,0,-1},
          new int[]{6,6,5,2,2,2,0,0,0,0,0,0,-1},
          new int[]{11,11,6,6,5,2,2,2,2,2,2,1,0,0,0,0,0,-1},
          new int[]{11,11,11,7,6,6,5,2,2,2,2,2,0,0,0,0,-1},
          new int[]{11,11,11,7,6,6,5,2,2,2,2,2,0,0,0,0,-1},
          new int[]{11,11,11,7,6,6,5,2,2,2,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{11,11,11,7,7,6,6,5,5,2,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{11,11,11,7,7,6,6,5,5,2,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{11,11,11,7,7,6,6,5,5,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{11,11,11,11,7,7,6,6,5,5,2,2,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{11,11,11,11,7,7,6,6,5,5,2,2,2,2,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{11,11,11,11,7,7,6,6,5,5,5,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{11,11,11,11,11,7,7,7,6,6,6,5,5,5,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(23, new int[][]{
          new int[]{2,0,-1},
          new int[]{2,0,0,-1},
          new int[]{2,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,2,0,0,0,0,-1},
          new int[]{4,2,2,2,0,0,0,0,-1},
          new int[]{11,4,4,2,2,2,2,0,0,0,0,0,-1},
          new int[]{14,11,4,4,2,2,2,0,0,0,0,0,-1},
          new int[]{14,11,11,4,4,2,2,2,0,0,0,0,-1},
          new int[]{14,14,11,11,4,4,2,2,2,2,1,0,0,0,0,0,0,-1},
          new int[]{14,14,11,11,4,4,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,14,11,11,4,4,4,2,2,2,2,0,0,0,0,0,-1},
          new int[]{14,14,11,11,11,4,4,4,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,11,11,11,4,4,4,4,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,14,14,11,11,11,11,4,4,4,4,4,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,11,4,4,4,4,4,4,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,11,11,4,4,4,4,4,4,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,11,11,11,4,4,4,4,4,4,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,11,11,11,11,11,11,4,4,4,4,4,4,4,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,11,11,11,11,11,11,4,4,4,4,4,4,4,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(24, new int[][]{
          new int[]{2,0,-1},
          new int[]{2,0,-1},
          new int[]{0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{2,2,2,2,0,0,0,0,-1},
          new int[]{11,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{11,7,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,11,8,7,2,2,2,2,0,0,0,0,-1},
          new int[]{14,11,8,7,2,2,2,2,2,1,0,0,0,0,0,0,0,-1},
          new int[]{14,11,8,7,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,14,11,8,7,7,2,2,2,2,2,2,0,0,0,0,-1},
          new int[]{14,14,11,8,7,7,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,11,8,7,7,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,11,11,8,8,7,7,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,14,14,11,11,8,8,7,7,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,11,11,11,8,8,7,7,7,2,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,14,14,11,11,11,8,8,7,7,7,2,2,2,2,2,2,2,0,0,0,0,0,-1},
          new int[]{14,14,14,11,11,11,8,8,7,7,7,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,8,8,8,7,7,7,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,11,8,8,8,7,7,7,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,11,8,8,8,7,7,7,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,11,11,8,8,8,7,7,7,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,11,11,11,11,11,11,8,8,8,7,7,7,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,11,11,11,11,11,11,8,8,8,8,7,7,7,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,11,11,11,11,11,11,8,8,8,8,7,7,7,7,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,11,11,11,11,11,8,8,8,8,7,7,7,7,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,11,11,11,11,11,8,8,8,8,7,7,7,7,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,14,11,11,11,11,11,11,8,8,8,8,7,7,7,7,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,14,14,14,11,11,11,11,11,11,8,8,8,8,7,7,7,7,2,2,2,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(26, new int[][]{
          new int[]{2,0,-1},
          new int[]{2,0,-1},
          new int[]{2,0,0,-1},
          new int[]{2,2,0,0,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,0,0,-1},
          new int[]{21,2,0,0,0,0,0,0,-1},
          new int[]{21,21,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,2,2,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,5,2,2,2,2,1,0,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,5,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,5,5,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,6,5,5,5,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,5,5,5,5,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,5,5,5,5,2,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,6,5,5,5,5,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,6,6,5,5,5,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,6,5,5,5,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,6,6,5,5,5,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,6,5,5,5,5,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(27, new int[][]{
          new int[]{2,0,-1},
          new int[]{4,2,-1},
          new int[]{3,0,-1},
          new int[]{4,2,0,0,0,0,0,0,-1},
          new int[]{4,2,0,0,0,0,0,0,-1},
          new int[]{4,3,2,0,0,0,0,0,-1},
          new int[]{4,3,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{6,4,3,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{6,4,3,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{6,4,4,4,3,2,2,1,0,0,0,0,0,0,0,0,0,-1},
          new int[]{6,4,4,4,3,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{6,4,4,4,3,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{6,6,4,4,4,3,3,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{6,6,4,4,4,4,3,3,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,6,6,4,4,4,4,3,3,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,6,6,6,4,4,4,4,3,3,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,4,4,4,4,3,3,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,4,4,4,4,3,3,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,6,4,4,4,4,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,6,4,4,4,4,4,3,3,3,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,6,6,6,6,4,4,4,4,4,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,6,6,6,6,4,4,4,4,4,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,6,6,6,6,4,4,4,4,4,3,3,3,3,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,6,6,6,6,4,4,4,4,4,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,12,6,6,6,6,4,4,4,4,4,3,3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,12,6,6,6,6,4,4,4,4,4,4,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,12,6,6,6,6,4,4,4,4,4,4,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,12,6,6,6,6,6,4,4,4,4,4,4,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,12,12,6,6,6,6,4,4,4,4,4,4,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{21,21,21,21,12,12,6,6,6,6,4,4,4,4,4,4,3,3,3,3,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(28, new int[][]{
          new int[]{3,-1},
          new int[]{2,0,0,-1},
          new int[]{3,0,-1},
          new int[]{2,2,0,0,0,0,0,0,-1},
          new int[]{3,2,0,0,0,0,0,0,-1},
          new int[]{12,3,0,0,0,0,0,0,-1},
          new int[]{12,3,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{3,3,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{12,3,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{12,3,3,2,2,2,1,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{3,3,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,3,3,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,12,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,12,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,12,3,3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,12,3,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,12,3,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,12,3,3,3,3,3,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{12,12,12,3,3,3,3,3,2,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(29, new int[][]{
          new int[]{2,0,-1},
          new int[]{2,0,-1},
          new int[]{2,0,0,-1},
          new int[]{2,2,0,0,0,0,0,0,-1},
          new int[]{2,2,0,0,0,0,0,0,-1},
          new int[]{2,2,2,0,0,0,0,0,-1},
          new int[]{14,7,2,2,2,0,0,0,0,0,-1},
          new int[]{14,11,7,2,2,2,0,0,0,0,-1},
          new int[]{14,11,7,2,2,2,0,0,0,0,-1},
          new int[]{14,12,11,11,7,2,2,2,1,0,0,0,0,0,0,-1},
          new int[]{14,11,11,7,6,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,12,11,11,7,6,2,2,2,0,0,0,0,0,0,-1},
          new int[]{14,14,11,11,11,6,6,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new int[]{14,14,12,11,11,11,6,6,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,12,11,11,11,6,6,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{14,14,14,12,11,11,11,7,6,6,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{23,14,14,14,12,11,11,11,7,6,6,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{23,14,14,14,12,11,11,11,7,6,6,2,2,2,2,2,0,0,0,0,0,0,-1},
          new int[]{23,14,14,14,12,11,11,11,11,7,7,6,6,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{23,14,14,14,12,12,11,11,11,11,7,7,6,6,2,2,2,2,2,1,0,0,0,0,0,0,0,-1},
          new int[]{23,14,14,14,12,12,11,11,11,11,7,7,6,6,2,2,2,2,2,0,0,0,0,0,0,0,-1},
          new int[]{23,14,14,14,12,12,11,11,11,11,7,7,6,6,6,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,12,12,11,11,11,11,7,7,6,6,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,12,12,11,11,11,11,7,7,6,6,6,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,14,12,12,11,11,11,11,7,7,6,6,6,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,14,12,12,12,11,11,11,11,7,7,6,6,6,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,14,12,12,12,11,11,11,11,7,7,6,6,6,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,14,12,12,12,11,11,11,11,7,7,6,6,6,6,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,14,12,12,12,11,11,11,11,7,7,7,6,6,6,6,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new int[]{23,23,14,14,14,12,12,12,12,11,11,11,11,7,7,7,6,6,6,6,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(61, new int[][]{
 new []{0,-1},
 new []{0,-1},
 new []{0,0,-1},
 new []{0,0,0,0,-1},
 new []{0,0,0,0,0,0,-1},
 new []{0,0,0,0,0,0,0,0,-1},
 new []{0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{30,29,18,15,6,1,0,0,0,0,0,0,0,0,-1},
 new []{30,29,28,6,0,0,0,0,0,0,0,-1},
 new []{30,29,28,6,0,0,0,0,0,0,0,-1},
 new []{30,30,29,28,6,15,6,0,0,0,0,0,0,-1},
 new []{30,30,29,6,18,15,6,0,0,0,0,0,0,-1},
 new []{30,30,29,29,28,18,6,6,0,0,0,0,0,0,-1},
 new []{30,30,29,29,15,15,6,6,0,0,0,0,0,0,-1},
 new []{30,30,29,29,28,15,6,6,0,0,0,0,0,0,-1},
 new []{30,30,29,29,28,28,6,6,00,0,0,0,0,0,-1},
 new []{30,30,29,29,29,28,15,6,6,0,0,0,0,0,0,-1},
 new []{30,30,30,29,29,29,28,20,20,20,20,20,20,15,6,6,1,0,0,0,0,-1},
 new []{30,30,30,29,29,29,28,23,18,15,6,6,0,0,0,0,0,0,-1},
 new []{30,30,29,29,29,28,28,23,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,30,29,29,29,29,28,23,18,15,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,29,29,29,29,28,28,23,18,15,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,30,29,29,29,29,23,15,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,30,29,29,29,29,28,23,23,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,30,29,29,29,29,29,28,23,23,15,15,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,29,29,29,29,29,28,28,23,23,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,30,29,29,29,29,29,28,23,18,15,6,6,6,0,0,0,0,0,0,-1},
 new []{30,30,30,30,29,29,29,29,29,28,28,23,23,20,20,20,20,20,20,20,18,15,15,1,6,6,6,0,0,0,0,-1}
   });
            OldZombieSeedsDict.Add(62, new int[][]
            {
                 new []{2,0,0,0,-1},
new []{2,2,0,0,0,0,-1},
new []{4,2,2,2,1,0,0,0,0,-1},
new []{4,3,2,2,2,0,0,0,0,0,-1},
new []{4,4,3,2,2,2,0,0,0,0,-1},
new []{14,4,4,3,2,2,2,2,1,0,0,-1},
new []{4,4,3,2,2,2,2,2,2,0,0,0,0,0,0,-1},
new []{14,4,4,3,3,2,2,2,2,2,2,0,0,0,0,-1},
new []{14,4,4,4,3,3,2,2,2,2,2,0,0,0,0,-1},
new []{20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,14,4,4,4,3,3,2,2,2,2,2,1,0,0,0,0,-1},
new []{14,14,7,4,4,4,3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,-1},
new []{14,14,7,4,4,4,4,3,3,3,2,2,2,2,2,2,0,0,0,0,0,-1},
new []{23,14,14,14,7,4,4,4,4,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,-1},
new []{23,14,14,14,7,7,4,4,4,4,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,-1},
new []{23,14,14,14,7,7,4,4,4,4,4,3,3,3,3,2,2,2,2,2,2,2,1,0,0,0,0,-1},
new []{23,23,14,14,14,14,7,7,7,4,4,4,4,4,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,-1},
new []{23,23,14,14,14,14,7,7,7,4,4,4,4,4,3,3,3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,-1},
new []{23,23,14,14,14,14,14,7,7,7,4,4,4,4,4,3,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,-1},
new []{-1},
new []{23,23,23,20,20,20,20,20,14,14,14,14,14,7,7,7,7,4,4,4,4,4,3,3,3,3,3,2,2,2,2,2,1,1,1,0,0,0,0,0,-1}
});


            OldZombieSeedsDict.Add(31, new int[][]{
          new []{0,0,0,-1},
          new []{2,0,-1},
          new []{2,0,-1},
          new []{2,0,0,0,0,0,0,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{11,2,0,0,0,0,0,0,-1},
          new []{21,11,2,0,0,0,0,0,0,0,0,0,-1},
          new []{21,11,11,2,2,0,0,0,0,0,0,0,-1},
          new []{21,21,11,11,2,2,0,0,0,0,0,0,-1},
          new []{21,21,11,2,2,2,1,0,0,0,0,0,0,0,0,0,0,-1}});
            OldZombieSeedsDict.Add(32, new int[][]{
          new []{2,0,-1},
          new []{2,0,-1},
          new []{2,0,-1},
          new []{2,0,0,0,0,0,0,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{15,2,0,0,0,0,0,0,-1},
          new []{2,2,2,0,0,0,0,0,0,0,0,0,-1},
          new []{8,2,2,0,0,0,0,0,0,0,0,0,-1},
          new []{15,8,2,0,0,0,0,0,0,0,0,0,-1},
          new []{8,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{15,8,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{8,8,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new []{8,8,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{15,8,8,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{15,8,8,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{8,8,8,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{15,8,8,8,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{15,8,8,8,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{15,15,8,8,8,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{15,15,8,8,8,8,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1}});
            OldZombieSeedsDict.Add(33, new int[][]{
          new []{0,0,0,-1},
          new []{2,0,-1},
          new []{0,0,0,-1},
          new []{2,0,0,0,0,0,0,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{16,2,0,0,0,0,0,0,-1},
          new []{12,2,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,12,2,0,0,0,0,0,0,0,0,-1},
          new []{12,12,2,2,0,0,0,0,0,0,0,-1},
          new []{16,16,13,12,12,1,2,2,2,0,0,0,0,0,0,0,0,-1}});
            OldZombieSeedsDict.Add(34, new int[][]{
          new []{2,0,-1},
          new []{2,0,-1},
          new []{2,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{2,2,2,0,0,0,0,0,-1},
          new []{12,2,2,0,0,0,0,0,0,0,0,0,-1},
          new []{16,13,2,2,2,0,0,0,0,0,0,0,-1},
          new []{12,2,2,2,0,0,0,0,0,0,0,0,-1},
          new []{16,13,12,2,2,2,1,0,0,0,0,0,0,0,0,0,0,-1},
          new []{12,12,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,13,12,12,2,2,2,2,0,0,0,0,0,0,0,0,-1},
          new []{16,13,13,12,12,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,13,13,12,12,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,16,13,13,12,12,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,16,13,13,12,12,12,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,16,13,13,13,12,12,12,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,16,13,13,13,12,12,12,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,16,13,13,13,13,12,12,12,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{16,16,13,13,13,13,12,12,12,12,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,-1}});
            OldZombieSeedsDict.Add(41, new int[][]{
 new []{0,-1},
 new []{0,0,-1},
 new []{0,0,0,0,-1},
 new []{2,0,0,0,0,0,0,-1},
 new []{2,2,0,0,0,0,0,0,-1},
 new []{4,2,2,0,0,0,0,0,-1},
 new []{4,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{20,20,20,20,4,2,2,2,2,0,0,0,0,-1},
 new []{4,4,2,2,2,0,0,0,0,0,0,0,-1},
 new []{20,20,20,20,20,20,4,4,4,2,2,2,2,1,0,0,0,0,0,0,0,0,-1}
            });
            OldZombieSeedsDict.Add(42, new int[][]{
 new []{2,-1},
 new []{0,0,-1},
 new []{0,0,0,-1},
 new []{2,0,0,0,0,0,0,-1},
 new []{2,2,0,0,0,0,0,0,-1},
 new []{2,2,0,0,0,0,0,0,-1},
 new []{2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{2,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{3,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{22,20,20,20,20,20,3,2,2,2,2,1,0,0,0,0,0,0,0,0,0,-1},
 new []{3,3,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{22,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{22,7,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{7,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{22,7,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{22,7,3,3,3,3,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{22,22,7,7,3,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{22,7,7,3,3,3,3,3,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{22,22,7,7,7,3,3,3,3,3,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{22,22,20,20,20,20,20,20,20,7,7,7,3,3,3,3,3,3,2,2,2,2,2,2,2,2,1,0,0,0,-1}
            });
            OldZombieSeedsDict.Add(43, new int[][]{
 new []{2,-1},
 new []{2,0,-1},
 new []{0,0,0,-1},
 new []{2,0,0,0,0,0,0,0,-1},
 new []{2,2,0,0,0,0,0,0,-1},
 new []{2,2,2,0,0,0,0,0,-1},
 new []{2,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{8,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{8,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{20,20,20,20,20,20,5,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,-1},
 new []{22,5,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
 new []{8,5,2,2,2,2,2,2,22,2,0,0,0,0,0,0,0,0,0,0,-1},
 new []{22,8,5,5,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{22,8,5,5,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{22,8,8,5,5,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{22,8,8,5,5,2,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{22,22,8,8,5,5,5,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,-1},
 new []{22,22,8,8,8,5,5,5,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{22,22,22,8,8,8,5,5,5,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{22,22,22,22,20,20,20,20,20,20,20,8,8,8,8,5,5,5,5,2,2,2,2,2,2,2,1,0,0,-1}
            });
            OldZombieSeedsDict.Add(44, new int[][]{
 new []{2,-1},
 new []{0,0,-1},
 new []{0,0,0,-1},
 new []{2,2,0,0,0,0,0,-1},
 new []{2,2,0,0,0,0,0,0,-1},
 new []{2,2,2,0,0,0,0,0,-1},
 new []{2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{2,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{7,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{21,20,20,20,20,20,2,2,2,1,0,0,0,0,0,0,-1},
 new []{7,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{21,7,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{21,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{21,7,7,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{15,7,7,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{21,8,7,7,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{21,21,8,7,7,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{21,21,8,7,7,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{21,15,8,7,7,7,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
 new []{23,21,21,20,20,20,20,20,20,8,8,7,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,-1},
 new []{21,21,15,8,7,7,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,-1},
 new []{23,21,21,8,8,7,7,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-1},
 new []{23,21,21,15,8,8,7,7,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,-1},
 new []{23,21,21,8,8,7,7,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{21,21,21,15,8,8,8,7,7,7,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{23,21,21,21,8,8,8,7,7,7,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{23,23,21,21,21,8,8,8,7,7,7,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,-1},
 new []{23,21,21,21,15,8,8,8,7,7,7,7,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{21,21,21,15,8,8,8,7,7,7,7,2,2,2,2,0,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,-1},
 new []{23,23,21,21,21,21,20,20,20,20,20,20,20,15,8,8,8,7,7,7,7,2,2,2,2,2,2,2,1,0,0,0,0,0,-1}
            });
            OldZombieSeedsDict.Add(36, new int[][]{
          new []{0,0,0,-1},
          new []{0,0,0,-1},
          new []{2,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{2,2,2,0,0,0,0,0,-1},
          new []{4,2,2,0,0,0,0,0,-1},
          new []{17,4,2,2,2,0,0,0,0,0,0,0,0,-1},
          new []{17,4,2,2,2,2,0,0,0,0,-1},
          new []{17,17,4,4,2,2,2,0,0,0,0,0,0,0,-1},
          new []{17,17,4,4,4,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(37, new int[][]{
          new []{2,0,-1},
          new []{2,0,-1},
          new []{2,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{2,2,2,0,0,0,0,0,-1},
          new []{3,2,2,0,0,0,0,0,-1},
          new []{17,3,2,2,2,0,0,0,0,0,0,0,0,-1},
          new []{17,3,2,2,2,2,0,0,0,0,-1},
          new []{17,3,3,2,2,2,2,0,0,0,0,0,0,0,-1},
          new []{17,17,3,3,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{17,17,14,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{17,17,14,3,3,3,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,17,17,14,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,17,17,14,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,18,17,17,14,3,3,3,3,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,18,17,17,14,14,3,3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,18,17,17,14,14,3,3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,18,17,17,17,14,14,3,3,3,3,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,18,18,17,17,17,14,14,3,3,3,3,3,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{18,18,18,17,17,17,14,14,14,3,3,3,3,3,2,2,2,2,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1}
      });
            OldZombieSeedsDict.Add(38, new int[][]{
          new []{0,0,0,-1},
          new []{0,0,0,-1},
          new []{2,0,-1},
          new []{2,2,0,0,0,0,0,0,-1},
          new []{7,2,2,0,0,0,0,0,-1},
          new []{7,6,2,2,0,0,0,0,-1},
          new []{7,6,2,2,2,0,0,0,0,0,0,0,0,-1},
          new []{7,7,6,2,2,2,0,0,0,0,-1},
          new []{7,7,6,6,2,2,2,0,0,0,0,0,0,0,-1},
          new []{7,7,6,6,6,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1}
          });
            OldZombieSeedsDict.Add(39, new int[][]{
          new []{4,-1},
          new []{4,-1},
          new []{6,-1},
          new []{4,0,0,0,0,0,0,0,-1},
          new []{4,4,0,0,0,0,0,0,-1},
          new []{6,4,0,0,0,0,0,0,-1},
          new []{6,6,4,0,0,0,0,0,0,0,0,0,0,-1},
          new []{12,6,4,4,0,0,0,0,0,-1},
          new []{7,6,6,4,4,4,0,0,0,0,0,0,0,-1},
          new []{7,7,6,6,6,4,4,4,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{21,12,7,7,6,6,6,4,4,4,4,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{21,7,7,6,6,6,6,4,4,4,4,4,0,0,0,0,0,0,0,0,0,0,0,-1},
          new []{21,7,7,7,6,6,6,6,4,4,4,4,4,4,4,4,0,0,0,0,0,0,0,0,0,-1},
          new []{21,21,12,7,7,7,6,6,6,6,4,4,4,4,4,4,4,4,4,0,0,0,0,0,-1},
          new []{21,21,13,12,7,7,7,6,6,6,6,4,4,4,4,4,4,4,4,4,0,0,0,0,-1},
          new []{21,21,13,12,7,7,7,6,6,6,6,4,4,4,4,4,4,4,4,4,0,0,0,0,0,0,0,-1},
          new []{21,21,12,12,7,7,7,6,6,6,6,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0,0,-1},
          new []{21,21,13,12,12,7,7,7,6,6,6,6,4,4,4,4,4,4,4,4,4,4,4,0,0,0,0,-1},
          new []{21,21,13,12,12,7,7,7,6,6,6,6,6,6,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0,0,-1},
          new []{21,21,13,12,12,7,7,7,7,6,6,6,6,6,6,4,4,4,4,4,4,4,4,4,4,1,0,0,0,0,0,-1}
      });

        }
        public static void Main(String[] args)
        {
            LoadOldZombieSeeds();
            Console.WriteLine("{");
            foreach (int k in OldZombieSeedsDict.Keys)
            {
                Console.WriteLine($"    {k}:");
                foreach (int[] j in OldZombieSeedsDict[k])
                {
                    Console.WriteLine("[" + String.Join(',', j) + "]");
                }
            }
        }
    }
}
