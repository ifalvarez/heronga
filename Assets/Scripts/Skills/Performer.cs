using UnityEngine;
using System.Collections;

public class Performer : MonoBehaviour {
	
	public Skill[] skills;
	public GameObject target = null;
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	GameObject getAutoTarget(){
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
			return closestEnemy;
		}
		return null;
	}
}
