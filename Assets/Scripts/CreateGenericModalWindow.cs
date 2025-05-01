using System;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public partial class GenericModalWindow : MonoBehaviour
{
#if UNITY_EDITOR
    [MenuItem("GameObject/UI/Generic Modal Window")]
    public static void CreateModal()
    {
        GameObject obj = Instantiate(Resources.Load<GameObject>("Generic Modal Panel"));
        obj.transform.SetParent(Selection.activeGameObject.transform, false);
    }
#endif
}
