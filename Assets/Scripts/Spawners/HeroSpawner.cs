using UnityEngine;
using System.Collections;

public class HeroSpawner : Spawner {

	public override void AfterSpawn (GameObject clone)
	{
		base.AfterSpawn (clone);
		clone.AddComponent<PlayerControlled>();
	}
}
