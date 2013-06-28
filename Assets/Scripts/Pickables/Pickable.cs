using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Pickable : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		GetComponent<Collider>().isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	virtual public void Pick(Picker picker){
		Debug.Log("Default pick called");
	}
	
	void OnTriggerEnter(Collider other){
		Picker picker = other.gameObject.GetComponent<Picker>();
		if (picker != null){
			Pick(picker);
			Destroy(gameObject);
		}
	}
}
