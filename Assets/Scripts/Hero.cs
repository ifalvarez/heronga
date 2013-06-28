using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
	
	public GameObject followTarget = null;
	
	// Use this for initialization
	void Start () {
		HeroManager.Instance.heroes.Add(this);
	}
	
	// Update is called once per frame
	void Update () {
		if (followTarget != null){
			Follow(); 			
		}
	}
	
	public void Follow(Hero hero){
		followTarget = hero.transform.Find("Follower anchor").gameObject;
	}
	
	private void Follow(){
		Walker walker = GetComponent<Walker>();
		walker.move = followTarget.transform.position - transform.position;
	}
}
