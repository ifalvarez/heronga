using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Damageable), typeof(Wanderer), typeof(WandererDirectionChanger))]
public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.layer = 8;
		gameObject.tag = "Enemy";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
