using System;
using UnityEngine;
using UnityEditor;

namespace LevelSample {

    // Editor Model, EM
    // 编辑器模型: 编辑TM
    public class StageEM : MonoBehaviour {

        public int typeID;

        public StageSO so;

        // 就做一件事: 保存数据到 tm 里
        [ContextMenu("Save")]
        public void Save() {

            string n = "Stage_" + typeID;
            if (gameObject.name != n) {
                gameObject.name = n;
            }

            so.tm.typeID = typeID;
            SaveGears();
        }

        void SaveGears() {
            GearSpawnerEM[] gearEMs = GetComponentsInChildren<GearSpawnerEM>();
            GearSpawnerTM[] gearTMs = new GearSpawnerTM[gearEMs.Length];
            for (int i = 0; i < gearTMs.Length; i += 1) {
                GearSpawnerEM em = gearEMs[i];
                em.Save();

                gearTMs[i] = em.spawnerTM;
            }

            // 只是保存到内存里, 不是硬盘
            // SetDirty
            so.tm.gears = gearTMs;
            EditorUtility.SetDirty(so);
        }

    }

}