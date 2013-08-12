using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HeroManager : UnitySingleton<HeroManager> {
	
	public List<Hero> heroes = new List<Hero>();
	public List<GameObject> availableHeroes = new List<GameObject>();
	
	// Update is called once per frame
	void Update () {
		if(heroes.Count == 0 || GameObject.Find("Enemy 1") == null){
			GameOver();
		}
		if(heroes.Count > 0 && heroes[0].GetComponent<PlayerControlled>() == null){
			heroes[0].gameObject.AddComponent<PlayerControlled>();		
		}
	}
	
	public void GameOver(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
