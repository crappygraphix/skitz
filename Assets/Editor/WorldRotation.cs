using UnityEngine;
using UnityEditor;

public static class DebugMenu
{
     [MenuItem("Debug/Print Global Rotation")]
     public static void PrintGlobalRotation()
     {
         if (Selection.activeGameObject != null)
         {
             Debug.Log(Selection.activeGameObject.name + " is at " + Selection.activeGameObject.transform.rotation.eulerAngles);
         }
     }
 }
