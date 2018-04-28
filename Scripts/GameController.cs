using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Player player;
    public float resetTimer = 5f;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (player.holdingBall == false)
        {
            resetTimer -= Time.deltaTime;
            if (resetTimer <= 0 && ScoreArea.numberOfBalls!= 0)
            {
                ScoreArea.numberOfBalls -= 1;
                Debug.Log("Number of Balls : " + ScoreArea.numberOfBalls.ToString());

                //Reload the Game to again. 
                SceneManager.LoadScene("first");

            }
            else{
                if(ScoreArea.numberOfBalls==0){
                    ScoreArea.numberOfBalls=15;
                    ScoreArea.score=0;
                    ScoreArea.difficultyLevel=1;
                   //Reload the Game to again. 
                   //SceneManager.LoadScene("first");
                    
                    }
            }
        }


    }
}
