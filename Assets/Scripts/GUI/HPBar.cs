using UnityEngine;
using System.Collections;

public class HPBar : MonoBehaviour {
	
	public void setPercentage(float percentage){
		renderer.material.SetFloat("_Cutoff", -percentage);
	}
}
