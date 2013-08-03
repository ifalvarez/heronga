using UnityEngine;
using System.Collections;
using System.Linq;

public class AddHero : Pickable {
	
	override public void Pick(Picker picker){
		//Create a follower anchor a the last hero
		Hero lastHero = HeroManager.Instance.heroes[HeroManager.Instance.heroes.Count - 1];
		GameObject anchor = new GameObject("Follower anchor");
		anchor.transform.parent = lastHero.transform;
		anchor.transform.position = lastHero.transform.position - lastHero.transform.forward * 
			lastHero.GetComponent<CharacterController>().radius * 3;
		
		//Create the new hero if there is one available
		if (HeroManager.Instance.availableHeroes.Count > 0){
			GameObject hero = HeroManager.Instance.availableHeroes[0];
			HeroManager.Instance.availableHeroes.Remove(hero);
			
			GameObject newHeroGo = Instantiate(hero, 
				lastHero.transform.Find("Follower anchor").transform.position + new Vector3(0f,2f,0f), Quaternion.identity) 
					as GameObject;
			newHeroGo.transform.parent = GameObject.Find("DynamicObjects").transform;
			Hero newHero = newHeroGo.GetComponent<Hero>();
			
			//Make the new hero follow the last hero
			HeroManager.Instance.heroes.Add(newHero);
			newHero.Follow(lastHero);
		}
	}
}
