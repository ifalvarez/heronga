using UnityEngine;
using System.Collections;

public class DamageableHero : Damageable {
	
	override public void Die(){
		base.Die();
		HeroManager.Instance.heroes.Remove(GetComponent<Hero>());
	}
}
