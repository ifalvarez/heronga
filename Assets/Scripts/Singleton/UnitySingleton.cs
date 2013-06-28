using UnityEngine;
using System.Collections;

public class UnitySingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T _instance = null;
    public static T Instance {
        get {
            if (_instance == null) {
                _instance = FindObjectOfType (typeof(T)) as T;
                if (_instance == null) {
                	GameObject obj = new GameObject ();
					obj.name = typeof(T).ToString ();
                    _instance = obj.AddComponent<T>();
                }
            }
            return _instance;
        }
    }
	
	// Make sure the instance isn't referenced anymore when the user quit, just in case.
    private void OnApplicationQuit()
    {
        _instance = null;
    }
}