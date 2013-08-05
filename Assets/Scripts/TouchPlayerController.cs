using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using TouchScript.Events;

public class TouchPlayerController : MonoBehaviour {
	
	public static int direction = -1;
	private FlickGesture flick;
	private float fadeTime = 0f;
	
	// Use this for initialization
	void Start () {
		flick = GetComponent<FlickGesture>();
		flick.StateChanged += OnFlick;
	}
	
	void Update() {
		if(Time.time > fadeTime){
			direction = -1;
		}
	}
	
	private void OnFlick(object sender, GestureStateChangeEventArgs e)
    {
		if (e.State == Gesture.GestureState.Recognized)
        {
			if (Mathf.Abs(flick.ScreenFlickVector.x) > Mathf.Abs(flick.ScreenFlickVector.y)){
				if(flick.ScreenFlickVector.x > 0){
					TouchPlayerController.direction = 1;
				}else{
					TouchPlayerController.direction = 3;
				}
			}else{
				if(flick.ScreenFlickVector.y > 0){
					TouchPlayerController.direction = 0;
				}else{
					TouchPlayerController.direction = 2;
				}
			}
			fadeTime = Time.time + 0.01f;
		}		
	}
}
