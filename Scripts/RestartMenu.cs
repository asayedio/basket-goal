using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour {
    public Text scoreText;
	public Text acuraccyText;

	// Use this for initialization
	void Start () {
	gameObject.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ToggleEndMenue(float score,float accuracy){
		gameObject.SetActive(true);
		scoreText.text = ((int)score).ToString();
		acuraccyText.text = ((int)accuracy).ToString();
	}

	public void Restart(){
		ScoreArea.numberOfBalls=15;
		ScoreArea.score= 0.0f;
        ScoreArea.difficultyLevel = 1;
		gameObject.SetActive(false);
		SceneManager.LoadScene("first");
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);	
	}

	public void ToMainMenue(){
		Debug.Log("eeeeeeeeeeee" );
		gameObject.SetActive(false);
		Debug.Log("i wii go" );
		SceneManager.LoadScene("MainMenuScene");
	}
}
