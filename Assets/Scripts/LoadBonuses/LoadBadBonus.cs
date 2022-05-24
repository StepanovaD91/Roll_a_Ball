using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Maze
{
    public class LoadBadBonus : MonoBehaviour
    {
        private SerializableXMLData<SaveDataBadBonus> _serializableXMLData = new SerializableXMLData<SaveDataBadBonus>();
        public void Awake()
        {
            var badBonus = Resources.Load<GameObject>("Drink");

            var badBonusInstance = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            var path = Path.Combine(Application.streamingAssetsPath, "Drink");
            var saveData = _serializableXMLData.Load(path);
            badBonusInstance.SetBonusPosition(saveData.Position);
            badBonusInstance.name = "BadBonus1";

            var badBonusInstance1 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            var path1 = Path.Combine(Application.streamingAssetsPath, "Drink (1)");
            var saveData1 = _serializableXMLData.Load(path1);
            badBonusInstance1.SetBonusPosition(saveData1.Position);
            badBonusInstance1.name = "BadBonus2";

            var badBonusInstance2 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            var path2 = Path.Combine(Application.streamingAssetsPath, "Drink (2)");
            var saveData2 = _serializableXMLData.Load(path2);
            badBonusInstance2.SetBonusPosition(saveData2.Position);
            badBonusInstance2.name = "BadBonus3";

            var badBonusInstance3 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            var path3 = Path.Combine(Application.streamingAssetsPath, "Drink (3)");
            var saveData3 = _serializableXMLData.Load(path3);
            badBonusInstance3.SetBonusPosition(saveData3.Position);
            badBonusInstance3.name = "BadBonus4";

            var badBonusInstance4 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            var path4 = Path.Combine(Application.streamingAssetsPath, "Drink (4)");
            var saveData4 = _serializableXMLData.Load(path4);
            badBonusInstance4.SetBonusPosition(saveData4.Position);
            badBonusInstance4.name = "BadBonus5";

            var badBonusInstance5 = GameObject.Instantiate(badBonus, this.transform).GetComponent<InteractiveObject>();
            var path5 = Path.Combine(Application.streamingAssetsPath, "Drink (5)");
            var saveData5 = _serializableXMLData.Load(path5);
            badBonusInstance5.SetBonusPosition(saveData5.Position);
            badBonusInstance5.name = "BadBonus6";

            Resources.UnloadUnusedAssets();
        }


    }
}
