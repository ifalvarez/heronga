using UnityEngine;
using System.Collections;

public class DebugConsole : MonoBehaviour {
	
	public static string text = "...";
	
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(0,Screen.height-90f,Screen.width,90f), "Debug Console" + "\n" + text);
	}
}
