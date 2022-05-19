using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class LoadRequiredBonus : MonoBehaviour
    {
        public void Awake()
        {
            var requiredBonus = Resources.Load<GameObject>("Apple");

            var requiredBonusInstance = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance.SetBonusPosition(new Vector3(0f, 0.5f, 4.12f));
            requiredBonusInstance.name = "RequiredBonus1";

            var requiredBonusInstance1 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance1.SetBonusPosition(new Vector3(27.53f, 0.5f, 0f));
            requiredBonusInstance1.name = "RequiredBonus2";

            var requiredBonusInstance2 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance2.SetBonusPosition(new Vector3(34.1f, 0.5f, 0f));
            requiredBonusInstance2.name = "RequiredBonus3";

            var requiredBonusInstance3 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance3.SetBonusPosition(new Vector3(28.33f, 0.5f, 7.61f));
            requiredBonusInstance3.name = "RequiredBonus4";

            var requiredBonusInstance4 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance4.SetBonusPosition(new Vector3(20.16f, 0.5f, 7.61f));
            requiredBonusInstance4.name = "RequiredBonus5";

            var requiredBonusInstance5 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance5.SetBonusPosition(new Vector3(12.0f, 0.5f, 11.72f));
            requiredBonusInstance5.name = "RequiredBonus6";

            var requiredBonusInstance6 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance6.SetBonusPosition(new Vector3(5.66f, 0.5f, 11.72f));
            requiredBonusInstance6.name = "RequiredBonus7";

            var requiredBonusInstance7 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance7.SetBonusPosition(new Vector3(0.0f, 0.5f, 11.72f));
            requiredBonusInstance7.name = "RequiredBonus8";

            var requiredBonusInstance8 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance8.SetBonusPosition(new Vector3(32.17f, 0.5f, 16.0f));
            requiredBonusInstance8.name = "RequiredBonus9";

            var requiredBonusInstance9 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance9.SetBonusPosition(new Vector3(35.94f, 0.5f, 23.65f));
            requiredBonusInstance9.name = "RequiredBonus10";

            var requiredBonusInstance10 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance10.SetBonusPosition(new Vector3(19.95f, 0.5f, 23.65f));
            requiredBonusInstance10.name = "RequiredBonus11";

            var requiredBonusInstance11 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance11.SetBonusPosition(new Vector3(4.24f, 0.5f, 24.45f));
            requiredBonusInstance11.name = "RequiredBonus12";

            var requiredBonusInstance12 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance12.SetBonusPosition(new Vector3(0.0f, 0.5f, 35.87f));
            requiredBonusInstance12.name = "RequiredBonus13";

            var requiredBonusInstance13 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance13.SetBonusPosition(new Vector3(24.0f, 0.5f, 35.87f));
            requiredBonusInstance13.name = "RequiredBonus14";

            var requiredBonusInstance14 = GameObject.Instantiate(requiredBonus, this.transform).GetComponent<InteractiveObject>();
            requiredBonusInstance14.SetBonusPosition(new Vector3(16.23f, 0.5f, 32.04f));
            requiredBonusInstance14.name = "RequiredBonus15";

            Resources.UnloadUnusedAssets();
        }
    }
}

