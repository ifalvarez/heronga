using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {
	//Make the object look at the main camera at all times
	
	public void LateUpdate ()
	{
		transform.forward = -Camera.main.transform.forward;
	}
}