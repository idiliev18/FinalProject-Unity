using UnityEngine;
using System.Runtime.InteropServices;

public class LocalStorageSystem : MonoBehaviour
{
    [DllImport("__Internal")]
    public static extern void SaveLocalStorage(int value);

    [DllImport("__Internal")]
    public static extern string LoadLocalStorage();
}
