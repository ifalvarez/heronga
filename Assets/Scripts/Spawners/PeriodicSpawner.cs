using UnityEngine;
using System.Collections;

public class PeriodicSpawner : Spawner {

	public float spawnTime = 3f;
	public float nextSpawnTime = 0f;
	
	// Update is called once per frame
	override public void Update () {
		if(Time.time >= nextSpawnTime){
			Spawn();
			nextSpawnTime = Time.time + spawnTime;
		}
	}
}
