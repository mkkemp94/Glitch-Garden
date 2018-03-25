using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelTime;

	void Start() {
		if (autoLoadNextLevelTime == 0) {
			Debug.Log("Auto load next level disabled.");
		} else {
			// After the specified time... call LoadNextLevel()
			Invoke("LoadNextLevel", autoLoadNextLevelTime);
		}
	}
	
	public void LoadLevel(string name) {
		Debug.Log("Load Level request for " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest() {
		Debug.Log("Quit game requested");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		Debug.Log("Load next level");
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
