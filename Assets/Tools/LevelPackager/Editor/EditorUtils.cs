using UnityEditor;
using System.Collections.Generic;
using UnityEngine;

namespace RunAndJump.LevelCreator
{


    public static class EditorUtils
    {
        //Create a new scene
        public static void NewScene()
        {
            EditorApplication.SaveCurrentSceneIfUserWantsTo();
            EditorApplication.NewScene();
        }

        //Remove all the elements of the scene
        public static void CleanScene()
        {
            GameObject[] allObjects = Object.FindObjectsOfType<GameObject>();
            foreach (GameObject go in allObjects)
            {
                GameObject.DestroyImmediate(go);
            }
        }

        //Create a new scene capable to be used as a level
        public static void NewLevel()
        {
            NewScene();
            CleanScene();
            GameObject levelGO = new GameObject("Level");
            levelGO.transform.position = Vector3.zero;
            levelGO.AddComponent<Level>();
        }
        public static List<T> GetAssetsWithScript<T>(string path) where T : MonoBehaviour
        {
            T tmp;
            string assetPath;
            GameObject asset;

            List<T> assetList = new List<T>();
            string[] guids = AssetDatabase.FindAssets("t:Prefab", new string[] { path });
            for (int i = 0; i < guids.Length; i++)
            {
                assetPath = AssetDatabase.GUIDToAssetPath(guids[i]);
                asset = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;
                tmp = asset.GetComponent<T>();
                if (tmp != null)
                {
                    assetList.Add(tmp);
                }
            }
            return assetList;
        }

        public static List<T> GetListFromEnum<T>()
        {
            List<T> enumList = new List<T>();
            System.Array enums = System.Enum.GetValues(typeof(T));
            foreach (T e in enums)
            {
                enumList.Add(e);
            }
            return enumList;
        }

       
    }
}
