using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class LoadDeadBonus : MonoBehaviour
    {
        public void Awake()
        {
            var deadBonus = Resources.Load<GameObject>("Ham");

            var deadBonusInstance = GameObject.Instantiate(deadBonus, this.transform).GetComponent<InteractiveObject>();
            deadBonusInstance.SetBonusPosition(new Vector3(0.0f, 0.83f, 22.76f));
            deadBonusInstance.name = "DeadBonus1";

            var deadBonusInstance1 = GameObject.Instantiate(deadBonus, this.transform).GetComponent<InteractiveObject>();
            deadBonusInstance1.SetBonusPosition(new Vector3(20.03f, 0.83f, 28.07f));
            deadBonusInstance1.name = "DeadBonus2";

            var deadBonusInstance2 = GameObject.Instantiate(deadBonus, this.transform).GetComponent<InteractiveObject>();
            deadBonusInstance2.SetBonusPosition(new Vector3(28.22f, 0.83f, 14.07f));
            deadBonusInstance2.name = "DeadBonus3";

            Resources.UnloadUnusedAssets();
        }
    }

}
