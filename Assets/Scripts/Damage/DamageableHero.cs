using UnityEngine;
using System.Collections;

public class DamageableHero : Damageable {
	
	override public void Die(){
		HeroManager.Instance.heroes.Remove(transform.parent.GetComponentInChildren<Hero>());
		base.Die();
	}
}
