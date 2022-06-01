using UnityEditor;
namespace Maze
{
    public class MenuItems
    {
        [MenuItem("Maze/Пункт меню №0 %g")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Maze");
        }

        [MenuItem("Maze/Пункт меню №1 %#a")]
        private static void NewMenuOption()
        {
        }

        [MenuItem("Maze/Пункт меню №2 ")]
        private static void NewNestedOption()
        {
        }

        [MenuItem("Maze/Пункт меню №3 _g")]
        private static void NewOptionWithHotkey()
        {
        }

        [MenuItem("Maze/Пункт меню/Пункт меню №3 _g")]
        private static void NewOptionWithHot()
        {
        }

        [MenuItem("Assets/Maze")]
        private static void LoadAdditiveScene()
        {
        }

        [MenuItem("Assets/Create/Maze")]
        private static void AddConfig()
        {
        }

        [MenuItem("CONTEXT/Rigidbody/Maze")]
        private static void NewOpenForRigidBody()
        {
        }


    }
}

