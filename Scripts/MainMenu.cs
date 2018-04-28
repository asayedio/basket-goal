using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// If the user click on play button
	public void Play(){
		Debug.Log("i'm in play in main menu script" );
		SceneManager.LoadScene("first");
        ScoreArea.isScore = false;
	 }

}
