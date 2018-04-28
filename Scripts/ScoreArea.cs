using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
 

public class ScoreArea : MonoBehaviour {
    
    public static float score = 0.0f;
    public static float accuracy = 0.0f;                    
    public Text scoreText;
    public Text levelText;
    public Text remainingText;
    public Text levelupText;
    public Image LevelUpContainer;
    //public  Image  Ball_Obj1,Ball_Obj2,Ball_Obj3,Ball_Obj4,Ball_Obj5,Ball_Obj6,Ball_Obj7,Ball_Obj8,Ball_Obj9,Ball_Obj10,Ball_Obj11,Ball_Obj12,Ball_Obj13,Ball_Obj14,Ball_Obj15;
    public Image[] Ball_Obj_Names ;
    public  static int difficultyLevel = 1;
    public  static int numberOfBalls = 15;
    public RestartMenu restartMenue;

    public static bool isScore = false;

    // Use this for initialization
    void Start () {

        isScore = false;

        Debug.Log("score! ===>  "+ score);
        Debug.Log("numberOfBalls! ===>  "+ numberOfBalls);
        if(score==0.0){
          scoreText.text =" "; 
        }
        else{
         scoreText.text = ((int)score).ToString(); 
         for (int i =15; i > numberOfBalls; i--)
		    {  
              //Debug.Log("IIIIIII! ===>  "+ i);
             Ball_Obj_Names[15-i].enabled=false;
            } 
        }
        levelText.text = ((int)difficultyLevel).ToString(); 
        remainingText.text = ((int)numberOfBalls).ToString(); 
        levelupText.text =" "; 
        LevelUpContainer.enabled=false;


	}
	
	// Update is called once per frame
	void Update () {
        if(numberOfBalls == 0){
        accuracy=(score/30)*100;
          restartMenue.ToggleEndMenue(score,accuracy);
        }
        

	}


    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Ball>() != null)
        {

            isScore = true;

            if (difficultyLevel == 1)
            {
                score += 1;
            }
            else if (difficultyLevel == 2)
            {
                score += 2;
            }
            else if (difficultyLevel == 3)
            {
                score += 3;
            }


            Debug.Log("Score! ===>  " + score);
            // Ball_Obj1.enabled = false;
            scoreText.text = ((int)score).ToString();
            //Ball_Obj_Names[numberOfBalls-1].enabled=false;
            //Ball_Obj.SetActive(false);
        }


        if (score == 5)
        {
            //Debug.Log("Level 2 ^_^");
            difficultyLevel = 2;
            levelupText.text ="You have completed Level 1"; 
            LevelUpContainer.enabled=true;
        }
        if (score ==15)
        {
            Debug.Log("Level 3 ^_^");
            difficultyLevel = 3;
            levelupText.text ="Congratulations ! You have completed Level 2"; 
            LevelUpContainer.enabled=true;
        }
        if (score == 30)
        {
            //Debug.Log("Amazing !  You completed the game to the end");
            levelupText.text ="Amazing ! You have completed the game to the end"; 
            LevelUpContainer.enabled=true;
            //partical system
        }
    }
}
