using System;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSample {

    public class AssetsCore : MonoBehaviour {

        Dictionary<string, GameObject> entities;
        Dictionary<int/*TypeID*/, StageSO> stages;
        Dictionary<int/*TypeID*/, GearSO> gears;

        public void Ctor() {
            entities = new Dictionary<string, GameObject>();
            stages = new Dictionary<int, StageSO>();
            gears = new Dictionary<int, GearSO>();
        }

        public void Init() {

            // Entities
            GameObject[] entityPrefabs = Resources.LoadAll<GameObject>("Entities");
            for (int i = 0; i < entityPrefabs.Length; i += 1) {
                GameObject prefab = entityPrefabs[i];
                entities.Add(prefab.name, prefab);
            }

            // Stages
            StageSO[] stageSOs = Resources.LoadAll<StageSO>("");
            for (int i = 0; i < stageSOs.Length; i += 1) {
                StageSO so = stageSOs[i];
                stages.Add(so.tm.typeID, so);
            }

            // Gears
            GearSO[] gearSOs = Resources.LoadAll<GearSO>("");
            for (int i = 0; i < gearSOs.Length; i += 1) {
                GearSO so = gearSOs[i];
                gears.Add(so.tm.typeID, so);
            }
        }

        // 获取 Entity 的 Prefab
        public bool Entity_Gear_TryGet(out GameObject prefab) {
            string name = "Entity_Gear";
            return Entity_TryGet(name, out prefab);
        }

        bool Entity_TryGet(string name, out GameObject prefab) {
            return entities.TryGetValue(name, out prefab);
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

        public bool Gear_TryGet(int typeID, out GearTM tm) {
            GearSO so;
            if (gears.TryGetValue(typeID, out so)) {
                tm = so.tm;
                return true;
            } else {
                tm = default;
                return false;
            }
        }

    }

}