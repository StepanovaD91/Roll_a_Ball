using UnityEngine;
using static UnityEngine.Debug;

namespace ExtensionsTest
{
    public static class MyExtensions
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }

    public class ExtensionsTest : MonoBehaviour
    {
        public void Start()
        {
            string s = "Hello World";
            char c = 'o';
            int i = s.CharCount(c);
            Log(i);
        }
    }
}
