using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSample {

    public class Main : MonoBehaviour {

        [SerializeField] int stage;

        void Awake() {
            Debug.Log("Main.Awake");
        }

        void Update() {
            if (Input.GetKeyUp(KeyCode.Space)) {
                EnterGame(stage);
            }
        }

        void EnterGame(int stage) {
            Debug.Log("Main.EnterGame: " + stage);
            // 1. 创建场景里的机关: GearEntity
            // 2. 主角
            // 3. 背景山
            // 4. 播放
            if (stage == 1) {

            } else if (stage == 2) {

            }
        }

    }
}
