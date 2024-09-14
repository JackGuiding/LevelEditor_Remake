using System;
using UnityEngine;
using UnityEditor;

namespace LevelSample {

    // Editor Model, EM
    // 编辑器模型: 编辑TM
    public class StageEM : MonoBehaviour {

        public int stageTypeID;

        public StageSO so;

        // 就做一件事: 保存数据到 tm 里
        [ContextMenu("Save")]
        public void Save() {
            so.tm.stageTypeID = stageTypeID;
            SaveGears();
        }

        void SaveGears() {
            GearEM[] gearEMs = GetComponentsInChildren<GearEM>();
            GearTM[] gearTMs = new GearTM[gearEMs.Length];
            for (int i = 0; i < gearTMs.Length; i += 1) {
                GearEM em = gearEMs[i];
                em.Save();

                gearTMs[i] = em.tm;
            }

            // 只是保存到内存里, 不是硬盘
            // SetDirty
            so.tm.gears = gearTMs;
            EditorUtility.SetDirty(so);
        }

    }

}