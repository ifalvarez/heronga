using UnityEngine;
using System.Collections;

public class Nova : Skill {
	public float radius = 5;
	public int damage = 500;
	
	protected Animator animator = null;
	protected ParticleSystem effect = null;
	
	public override void Start ()
	{
		base.Start ();
		effect = GetComponentInChildren<ParticleSystem>();
	}
	
	
	public override bool Unleash ()
	{
		animator = performer.transform.parent.GetComponentInChildren<Animator>();
		animator.SetBool("spell", true);
		effect.Play();
		Collider[] hitColliders = Physics.OverlapSphere(performer.transform.position, radius);
        int i = 0;
		Damageable d = null;
		while (i < hitColliders.Length) {
            d = hitColliders[i].GetComponent<Damageable>();
			if (d != null && d.gameObject.GetInstanceID() != performer.transform.parent.gameObject.GetInstanceID()){
				//Debug.Log("damaged: "+d.gameObject.name + d.gameObject.GetInstanceID() + "...." +performer.gameObject.GetInstanceID());
				d.Damage(damage);
			}
			i++;
        }
		return true;
	}
}
