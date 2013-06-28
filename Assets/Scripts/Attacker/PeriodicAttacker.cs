using UnityEngine;
using System.Collections;

public class PeriodicAttacker : Attacker {

	// Update is called once per frame
	public override void Update () {
		base.Update();
		Attack ();
	}
}
