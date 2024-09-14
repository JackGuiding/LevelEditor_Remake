using System;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSample {

    public class AssetsCore : MonoBehaviour {

        Dictionary<int/*TypeID*/, StageSO> stages;

        public void Ctor() {
            stages = new Dictionary<int, StageSO>();
        }

        public void Init() {
           StageSO[] stageSOs = Resources.LoadAll<StageSO>("");
           for (int i = 0; i < stageSOs.Length; i += 1) {
                StageSO so = stageSOs[i];
                stages.Add(so.tm.stageTypeID, so);
           }
        }

        // 获取某一关的数据
        public bool Stage_TryGet(int typeID, out StageTM tm) {
            StageSO so;
            if (stages.TryGetValue(typeID, out so)) {
                tm = so.tm;
                return true;
            } else {
                tm = default;
                return false;
            }
        }

    }

}