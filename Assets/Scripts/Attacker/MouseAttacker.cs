using UnityEngine;
using System.Collections;

public class MouseAttacker : Attacker {

	// Update is called once per frame
	public override void Update () {
		base.Update();
		//Attack when fire1 is pressed
		if(Input.GetButtonDown("Fire1")){
			Attack();
		}
	}
}
