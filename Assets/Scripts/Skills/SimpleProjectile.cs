using UnityEngine;
using System.Collections;

public class SimpleProjectile : Skill {
	
	public Projectile projectile;
	public int damage = 10;
	public Transform castingPoint;
		
	override public void Start(){
	base.Start();
		if (castingPoint == null){
			castingPoint = performer.transform;
		}
	}
	
	public override bool Unleash()
	{
		RangeAttacker rangeAttacker = attacker as RangeAttacker;
		if(rangeAttacker.target != null){
			Projectile pr = Instantiate(projectile, castingPoint.position, 
				performer.transform.rotation) as Projectile;
			pr.damage = damage;
			pr.transform.parent = GameObject.Find("DynamicObjects").transform;
			return true;
		}else{
			return false;
		}
				
	}
}
