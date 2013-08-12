using UnityEngine;
using System.Collections;

public class HomingGreenBall : Skill {
	
	public DistanceHomingProjectile projectile;
	public int damage = 10;
	
	public override bool Unleash()
	{
		RangeAttacker rangeAttacker = attacker as RangeAttacker;
		if(rangeAttacker.target != null){
			DistanceHomingProjectile pr = Instantiate(projectile, performer.transform.position, 
				performer.transform.rotation) as DistanceHomingProjectile;
			pr.damage = damage;
			pr.transform.parent = GameObject.Find("DynamicObjects").transform;
			pr.target = rangeAttacker.target;
			return true;
		}else{
			return false;
		}
				
	}
}
