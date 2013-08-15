using UnityEngine;
using System.Collections;

public class ColliderHomingProjectile : Projectile {
	
	/*public GameObject target = null;
	private bool selfDestroying = false;
	
	// Use this for initialization
	override public void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	override public void Update () {
		base.Update();
		if (selfDestroying){
			transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		}else if (target != null){
			transform.LookAt(target.transform.position);
			transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		}else{
			//getAutoTarget();
			selfDestroying = true;
			Expire(1f);
		}
	}
	
	override public void CheckDestroyProjectile(Collision other) {
		if(other.gameObject.GetInstanceID() == target.GetInstanceID()){
			base.CheckDestroyProjectile(other);
		}
	}
	
	override public void CheckDamage(Collision other) {
		if(other.gameObject.GetInstanceID() == target.GetInstanceID()){
			base.CheckDamage(other);
		}
	}
	
	void getAutoTarget(){
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		if (enemies.Length > 0){
			GameObject closestEnemy = enemies[0];
			float closestEnemyDistance = Vector3.Distance(transform.position, closestEnemy.transform.position);
			float distance = 0;
			foreach(GameObject enemy in enemies){
				distance = Vector3.Distance(transform.position, enemy.transform.position);
				if (distance < closestEnemyDistance){
					closestEnemyDistance = distance;
					closestEnemy = enemy;
				}
			}
			target = closestEnemy;
		}
	}
	
	void autoDestroy(){
		
	}*/
}
