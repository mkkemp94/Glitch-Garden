using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;
	
	void Awake () {
		GameObject.DontDestroyOnLoad(gameObject);
		Debug.Log("Don't destroy on load: " + name);
	}
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	public void OnLevelWasLoaded(int level) {
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log("Play music for level: " + level + " : " + thisLevelMusic);
		if (thisLevelMusic) {
			audio.clip = thisLevelMusic;
			audio.loop = true;
			audio.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
