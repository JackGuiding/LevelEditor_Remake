using System;
using UnityEngine;

namespace LevelSample {

    [ExecuteInEditMode]
    public class GearSpawnerEM : MonoBehaviour {

        public GearSpawnerTM spawnerTM;

        // Runtime 里禁止多个Update
        // Editor 可以
        // 注: 需要在 class 增加 [ExecuteInEditMode] 才会执行
        void Update() {
            var so = spawnerTM.so;
            if (so == null) {
                return;
            }

            var tm = so.tm;
            var prefab = tm.modPrefab;
            if (prefab == null) {
                return;
            }

            if (transform.childCount == 0) {
                var mod = GameObject.Instantiate(prefab, transform);
            }

            string n = "Gear_" + tm.typeName;
            if (gameObject.name != n) {
                gameObject.name = n;
            }

        }

        [ContextMenu("Save")]
        public void Save() {
            spawnerTM.position = transform.position;
            spawnerTM.rotation = transform.rotation.eulerAngles;
        }

    }

}