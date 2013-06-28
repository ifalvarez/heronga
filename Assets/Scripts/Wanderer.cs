using UnityEngine;
using System.Collections;

public class Wanderer : Walker {
	
	public float changeDirectionTime = 1f;
	public float nextChangeDirectionTime = 0f;
	public int direction = 0;
	
	// Update is called once per frame
	public override void Update () {
		base.Update();
		if (Time.time >= nextChangeDirectionTime){
			changeDirection();
		}
	}
	
	public void changeDirection(){
		//choose direction
		int change = Random.Range(0,2);
		if (change == 0){
			direction += 1;
		}else{
			direction -= 1;
		}
		if (direction < 0){
			direction = 3;
		}
		if (direction > 3){
			direction = 0;
		}
		switch(direction){
		case 0:
			move = UP;
			break;
		case 1:
			move = RIGHT;
			break;
		case 2:
			move = DOWN;
			break;
		case 3:
			move = LEFT;
			break;
		}
		nextChangeDirectionTime = Time.time + changeDirectionTime;
		
	}
	
	
}
