using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

namespace Maze
{
    public class GameControllerUI : MonoBehaviour
    {
        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }

        public void Exit()
        {
            Application.Quit();
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif
        }

    }
}