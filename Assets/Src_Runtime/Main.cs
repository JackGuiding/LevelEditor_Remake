using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSample {

    public class Main : MonoBehaviour {

        [SerializeField] int stage;

        [SerializeField] AssetsCore assetsCore;

        void Awake() {
            Debug.Log("Main.Awake");

            // ==== CTOR ====
            assetsCore.Ctor();

            // ==== INIT ====
            assetsCore.Init();
        }

        void Update() {
            if (Input.GetKeyUp(KeyCode.Space)) {
                EnterGame(stage);
            }
        }

        void EnterGame(int stage) {
            
            bool has = assetsCore.Stage_TryGet(stage, out StageTM tm);
            if (!has) {
                Debug.LogError("Main.EnterGame: Stage not found: " + stage);
                return;
            }

            // 1. 创建场景里的机关: GearEntity
            // 2. 主角
            // 3. 背景山
            // 4. 播放
            GearSpawnerTM[] gears = tm.gears;
            for (int i = 0; i < gears.Length; i += 1) {
                GearSpawnerTM gearSpawner = gears[i];
                GearEntity entity = Factory.Gear_CreateBySpawner(assetsCore, gearSpawner);
                // 存储
            }
            Debug.Log("TODO: 创建机关");

        }

    }
}
