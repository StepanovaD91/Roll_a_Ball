using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


namespace Maze
{
    public class LoadGoodBonus : MonoBehaviour
    {
        private SerializableXMLData<SaveDataGoodBonus> _serializableXMLData = new SerializableXMLData<SaveDataGoodBonus>();

        public void Awake()
        {
            var goodBonus = Resources.Load<GameObject>("Watermelon");

            var goodBonusInstance = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path = Path.Combine(Application.streamingAssetsPath, "Watermelon");
            var saveData = _serializableXMLData.Load(path);
            goodBonusInstance.SetBonusPosition(saveData.Position);
            goodBonusInstance.name = "GoodBonus1";

            var goodBonusInstance1 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path1 = Path.Combine(Application.streamingAssetsPath, "Watermelon (1)");
            var saveData1 = _serializableXMLData.Load(path1);
            goodBonusInstance1.SetBonusPosition(saveData1.Position);
            goodBonusInstance1.name = "GoodBonus2";

            var goodBonusInstance2 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path2 = Path.Combine(Application.streamingAssetsPath, "Watermelon (2)");
            var saveData2 = _serializableXMLData.Load(path2);
            goodBonusInstance2.SetBonusPosition(saveData2.Position);
            goodBonusInstance2.name = "GoodBonus3";

            var goodBonusInstance3 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path3 = Path.Combine(Application.streamingAssetsPath, "Watermelon (3)");
            var saveData3 = _serializableXMLData.Load(path3);
            goodBonusInstance3.SetBonusPosition(saveData3.Position);
            goodBonusInstance3.name = "GoodBonus4";

            var goodBonusInstance4 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path4 = Path.Combine(Application.streamingAssetsPath, "Watermelon (4)");
            var saveData4 = _serializableXMLData.Load(path4);
            goodBonusInstance4.SetBonusPosition(saveData4.Position);
            goodBonusInstance4.name = "GoodBonus5";

            var goodBonusInstance5 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path5 = Path.Combine(Application.streamingAssetsPath, "Watermelon (5)");
            var saveData5 = _serializableXMLData.Load(path5);
            goodBonusInstance5.SetBonusPosition(saveData5.Position);
            goodBonusInstance5.name = "GoodBonus6";

            var goodBonusInstance6 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path6 = Path.Combine(Application.streamingAssetsPath, "Watermelon (6)");
            var saveData6 = _serializableXMLData.Load(path6);
            goodBonusInstance6.SetBonusPosition(saveData6.Position);
            goodBonusInstance6.name = "GoodBonus7";

            var goodBonusInstance7 = GameObject.Instantiate(goodBonus, this.transform).GetComponent<InteractiveObject>();
            var path7 = Path.Combine(Application.streamingAssetsPath, "Watermelon (7)");
            var saveData7 = _serializableXMLData.Load(path7);
            goodBonusInstance7.SetBonusPosition(saveData7.Position);
            goodBonusInstance7.name = "GoodBonus8";

            Resources.UnloadUnusedAssets();
        }


    }
}
