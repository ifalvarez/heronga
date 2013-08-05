using UnityEngine;
using System.Collections;

public class TouchPlayerController : MonoBehaviour {
	
	public static int direction = -1;
	private float fadeTime = 0f;
	private int touchId = 0;
	
	// Use this for initialization
	void Start () {
	}
	
	void Update() {
		if(Time.time > fadeTime){
			direction = -1;
		}
		if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Moved){
			OnFlick(Input.touches[0]);
		}
	}
	
	private void OnFlick(Touch touch)
    {
		if (Mathf.Abs(touch.deltaPosition.x) > Mathf.Abs(touch.deltaPosition.y)){
			if(touch.deltaPosition.x > 0){
				TouchPlayerController.direction = 1;
			}else{
				TouchPlayerController.direction = 3;
			}
		}else{
			if(touch.deltaPosition.y > 0){
				TouchPlayerController.direction = 0;
			}else{
				TouchPlayerController.direction = 2;
			}
		}
		fadeTime = Time.time + 0.01f;		
	}
}
