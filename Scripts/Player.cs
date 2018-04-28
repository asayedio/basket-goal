using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public Ball ball;
    public GameObject PlayerCamera;

    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;

    public bool holdingBall = true;


    private Vector3 playerPosition;


    // Use this for initialization
    void Start () {

        if (ScoreArea.numberOfBalls == 0)
        {
            if (ScoreArea.score >= 15)
            {
                Debug.Log("you Win !");
                //End the game here and popup  window with details "you win" , "your score" etc...
            }
            else
            {
                Debug.Log("you Lose");
                //End the game here and popup  window with details "you Lose" , "your score" , "Restart" etc...
            }

        }


        ball.GetComponent<Rigidbody>().useGravity = false;

        playerPosition = transform.position;

        if (ScoreArea.difficultyLevel == 1)
        {
            transform.position = playerPosition;
            ballThrowingForce = 500;
        }
        else if (ScoreArea.difficultyLevel == 2)
        {
            transform.position = new Vector3(playerPosition.x, playerPosition.y, playerPosition.z - 5);
            ballThrowingForce = 640;
        }
        else if (ScoreArea.difficultyLevel == 3)
        {
            transform.position = new Vector3(playerPosition.x, playerPosition.y, playerPosition.z - 10);
            ballThrowingForce = 780;
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (holdingBall)
        {
            ball.transform.position = PlayerCamera.transform.position
                                    + PlayerCamera.transform.forward * ballDistance;

            if (Input.GetKey(KeyCode.Space))
            {
                holdingBall = false;
                //ball.ActivateTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * ballThrowingForce);
            }
        }


    }
}
