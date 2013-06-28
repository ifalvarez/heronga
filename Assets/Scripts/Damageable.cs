using UnityEngine;
using System.Collections;

public class Damageable : MonoBehaviour {
	
	public int hp = 100;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hp <= 0){
			Die();
		}
	}
	
	public void Damage(int amount){
		hp -= amount;
	}
	
	public void Die(){
		Destroy(gameObject);
	}
}
