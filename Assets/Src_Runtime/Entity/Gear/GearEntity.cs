using System;
using UnityEngine;

namespace LevelSample {

    public class GearEntity : MonoBehaviour {

        public float moveSpeed;

        public int hp;
        public int hpMax;

        public void TF_SetPosition(Vector3 position) {
            transform.position = position;
        }

        public void TF_SetRotation(Vector3 eulerAngles) {
            transform.rotation = Quaternion.Euler(eulerAngles);
        }

    }

}