using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

	[SerializeField]private float waitTime = 5f;

	// Use this for initialization
	void Start () {
		Invoke("LoadFirstScene", waitTime);
		DontDestroyOnLoad(this.gameObject);
	}
	
	private void LoadFirstScene() 
	{
		SceneManager.LoadScene(1); //Load level 1;
	}
	
}
