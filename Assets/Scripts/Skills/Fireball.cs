using UnityEngine;
using System.Collections;

public class Fireball : Skill {
	
	public Projectile projectile;
	
	public override bool Unleash (Performer performer)
	{
		Unleash(performer, performer.target);
		return true;
	}
	
	public override bool Unleash(Performer performer, GameObject target)
	{
		if(target != null){
			HomingProjectile pr = Instantiate(projectile, performer.transform.position, 
				performer.transform.rotation) as HomingProjectile;
			pr.transform.parent = GameObject.Find("DynamicObjects").transform;
			pr.target = target;
			return true;
		}else{
			return false;
		}
				
	}
}
