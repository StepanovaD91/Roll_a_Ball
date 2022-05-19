using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class LoadBadBonus : MonoBehaviour
    {
        public void Awake()
        {
            var badBonus = Resources.Load<GameObject>("Drink");

            var badBonusInstance = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            badBonusInstance.SetBonusPosition(new Vector3(3.93f, 0.42f, 0f));
            badBonusInstance.name = "BadBonus1";

            var badBonusInstance1 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            badBonusInstance1.SetBonusPosition(new Vector3(34.54f, 0.42f, 7.73f));
            badBonusInstance1.name = "BadBonus2";

            var badBonusInstance2 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            badBonusInstance2.SetBonusPosition(new Vector3(20.07f, 0.42f, 17.06f));
            badBonusInstance2.name = "BadBonus3";

            var badBonusInstance3 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            badBonusInstance3.SetBonusPosition(new Vector3(27.95f, 0.42f, 26.27f));
            badBonusInstance3.name = "BadBonus4";

            var badBonusInstance4 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            badBonusInstance4.SetBonusPosition(new Vector3(12.03f, 0.42f, 29.88f));
            badBonusInstance4.name = "BadBonus5";

            var badBonusInstance5 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            badBonusInstance5.SetBonusPosition(new Vector3(32.12f, 0.42f, 33.93f));
            badBonusInstance5.name = "BadBonus6";

            Resources.UnloadUnusedAssets();
        }


    }
}
