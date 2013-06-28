using UnityEngine;
using System.Collections;

public class UnitySingletonPersistent<T> : UnitySingleton<T> where T : MonoBehaviour
{
    public virtual void Awake ()
    {
        DontDestroyOnLoad (this.gameObject);
        if (_instance == null) {
            _instance = this as T;
        } else {
            Destroy (gameObject);
        }
    }
}
