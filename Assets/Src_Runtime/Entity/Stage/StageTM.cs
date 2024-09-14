using System;
using UnityEngine;

namespace LevelSample {

    // Template Model, TM
    // 模板数据模型: 主要作用是配置
    // 给策划用的
    [Serializable]
    public struct StageTM {

        public int typeID;

        // 机关是什么, 摆在哪里, 面向哪里, 数值是多少, 数量有多少个
        public GearSpawnerTM[] gears;

    }

}