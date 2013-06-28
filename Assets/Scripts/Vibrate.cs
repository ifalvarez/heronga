using UnityEngine;
using System.Collections;

public class Vibrate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * 0.01f);
		transform.Translate(Vector3.down * 0.01f);
	}
}
