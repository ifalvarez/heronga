using UnityEngine;
using System.Collections;

public class Nova : Skill {
	
	public Projectile projectile;
	public float radius = 5;
	public int damage = 500;
	
	public override void Start ()
	{
		base.Start ();
	}
	
	public override bool Unleash (Performer performer)
	{
		Collider[] hitColliders = Physics.OverlapSphere(performer.transform.position, radius);
        int i = 0;
		Damageable d = null;
        while (i < hitColliders.Length) {
            d = hitColliders[i].GetComponent<Damageable>();
			if (d != null){
				d.Damage(damage);
			}
			i++;
        }
		Instantiate(gameObject, performer.transform.position, Quaternion.identity);
		return true;
	}
}
