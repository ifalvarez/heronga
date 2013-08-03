using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeroManager : UnitySingleton<HeroManager> {
	
	public List<Hero> heroes = new List<Hero>();
	public List<GameObject> availableHeroes = new List<GameObject>();
	
	// Update is called once per frame
	void Update () {
	
	}
}
