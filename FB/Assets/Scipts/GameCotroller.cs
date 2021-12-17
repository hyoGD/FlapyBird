using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCotroller : MonoBehaviour
{
    public bool isEndGame ;
    bool isStarFirstTime = true;
    int gameScore = 0;
   // private const string HIGHT_SCORE = "Hight Score";
    public Text txtScore;
    public GameObject Score;
    public GameObject pnlEndGame;
    public GameObject GiftLove;
    public Text txtEndScore;
    public Text txtHightScore;
   
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        isStarFirstTime = true;
        Score.SetActive(true);
        pnlEndGame.SetActive(false);
       // GiftLove.SetActive(false);
      //  PlayerPrefs.DeleteAll();
        //txtHightScore.text = PlayerPrefs.GetInt("HightScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isStarFirstTime)
            {

                PlayGame();

            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
                Debug.LogError("???");
            }
        }
            //  love();
        }
    
    public void getScore()
    {
        gameScore++;
        txtScore.text = "Score: " + gameScore.ToString();
        if (gameScore > PlayerPrefs.GetInt("HightScore", 0))
        {
            PlayerPrefs.SetInt("HightScore", gameScore);
           // txtHightScore.text = "Hight Score\n" + gameScore.ToString();
        }

    }
    public void love()
    {
        if (gameScore == 18)
        {
            GiftLove.SetActive(true);
        }
    }


    void PlayGame()
    {
        SceneManager.LoadScene(0);    //load man choi
    }
    public void Restart()
    {
        PlayGame();
       
    }
    public void EndGame()
    {
        
        isEndGame = true;   //pause audio
        isStarFirstTime = false;   //ko click dc 
        Time.timeScale = 0;
        Score.SetActive(false);
        pnlEndGame.SetActive(true);
        txtEndScore.text = "Score: " + gameScore.ToString();
        txtHightScore.text = "High Score\n" + PlayerPrefs.GetInt("HightScore", 0).ToString();
    }
 
   
}
