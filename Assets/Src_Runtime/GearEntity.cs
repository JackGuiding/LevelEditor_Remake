using System;
using UnityEngine;

namespace LevelSample {

    public class GearEntity : MonoBehaviour {

        public int hp;

        public void TF_SetPosition(Vector3 position) {
            transform.position = position;
        }

        public void TF_SetRotation(Vector3 eulerAngles) {
            transform.rotation = Quaternion.Euler(eulerAngles);
        }

    }

}