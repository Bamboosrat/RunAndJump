#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class HelloWorld
{

#if UNITY_EDITOR
    [MenuItem ("GameObject/Create HelloWorld")]
    private static void CreateHelloWorldGameObject()
    {
        if (EditorUtility.DisplayDialog(
        "Hello World",
            "Do you really want to do this?",
            "Create",
            "Cancel")) {
            new GameObject("Hello World");
        }
    }
#endif


}
