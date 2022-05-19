using System;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public class LoadGoodBonus : MonoBehaviour
    {

        public void Awake()
        {
            var goodBonus = Resources.Load<GameObject>("Watermelon");

            var goodBonusInstance = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance.SetBonusPosition(new Vector3(8.5f, 0.5f, 3.8f));
            goodBonusInstance.name = "GoodBonus1";

            var goodBonusInstance1 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance1.SetBonusPosition(new Vector3(4.8f, 0.5f, 7.98f));
            goodBonusInstance1.name = "GoodBonus2";

            var goodBonusInstance2 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance2.SetBonusPosition(new Vector3(13.66f, 0.5f, 19.56f));
            goodBonusInstance2.name = "GoodBonus3";

            var goodBonusInstance3 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance3.SetBonusPosition(new Vector3(24.5f, 0.5f, 3.63f));
            goodBonusInstance3.name = "GoodBonus4";

            var goodBonusInstance4 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance4.SetBonusPosition(new Vector3(24.25f, 0.5f, 22.38f));
            goodBonusInstance4.name = "GoodBonus5";

            var goodBonusInstance5 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance5.SetBonusPosition(new Vector3(5.76f, 0.5f, 36.32f));
            goodBonusInstance5.name = "GoodBonus6";

            var goodBonusInstance6 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance6.SetBonusPosition(new Vector3(36.69f, 0.5f, 16.3f));
            goodBonusInstance6.name = "GoodBonus7";

            var goodBonusInstance7 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            goodBonusInstance7.SetBonusPosition(new Vector3(19.86f, 0.5f, -0.07f));
            goodBonusInstance7.name = "GoodBonus8";

            Resources.UnloadUnusedAssets();
        }


    }
}
