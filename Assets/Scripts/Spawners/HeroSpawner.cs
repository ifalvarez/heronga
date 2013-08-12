using UnityEngine;
using System.Collections;

public class HeroSpawner : Spawner {
	
	// Use this for initialization
	public override void Start () {
		spawn = HeroManager.Instance.availableHeroes[0];
		HeroManager.Instance.availableHeroes.Remove(spawn);
		GameObject newHero = Spawn();
		HeroManager.Instance.heroes.Add(newHero.GetComponent<Hero>());
	}
	
	public override void AfterSpawn (GameObject clone)
	{
		base.AfterSpawn (clone);
		Destroy(this.gameObject);
	}
}
