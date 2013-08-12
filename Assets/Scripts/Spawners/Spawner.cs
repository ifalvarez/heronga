using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public GameObject spawn;
	public float radius = 0f;
	
	// Use this for initialization
	virtual public void Start () {
		Spawn();	
	}
	
	// Update is called once per frame
	virtual public void Update () {
		
	}
	
	public GameObject Spawn(){
		Vector3 spawnPosition = transform.position + 
			new Vector3(Random.Range(-1f,1f) * radius, 0f, Random.Range(-1f, 1f) * radius);
		spawnPosition.y = transform.position.y;
		GameObject clone = Instantiate(spawn, spawnPosition, Quaternion.identity) as GameObject;
		clone.transform.parent = GameObject.Find("DynamicObjects").transform;
		AfterSpawn(clone);
		return clone;
	}
	
	virtual public void AfterSpawn(GameObject clone){
		
	}
}
