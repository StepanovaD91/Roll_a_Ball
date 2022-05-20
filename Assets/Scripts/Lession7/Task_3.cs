using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.Debug;

namespace ListTest
{
    public class Task_3 : MonoBehaviour
    {
        public void Start()
        {
            List<int> integerList = new List<int>() {
                2, 1, 2, 3, 4, 54, -12, 3, 4, 2, 1, 4, 7, 35, -16, 13, 4,
            };
            Dictionary<int, int> uniqInteger = new Dictionary<int, int>();

            foreach (int i in integerList)
            {
                if (uniqInteger.ContainsKey(i))
                {
                    uniqInteger[i]++;
                }
                else
                {
                    uniqInteger[i] = 1;
                }
            }

            foreach (KeyValuePair<int, int> p in uniqInteger)
            {
                Log($"Элемент {p.Key} встречается {p.Value} раз");
            }

        }
    }
}


