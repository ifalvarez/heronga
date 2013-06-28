using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.IgnoreLayerCollision(9,10);
		Physics.IgnoreLayerCollision(0,10);
		Physics.IgnoreLayerCollision(10,10);
		Physics.IgnoreLayerCollision(9,9);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
