using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Vector2 birdlfly;
    public float flyPower;
    public AudioClip Fly;
    public AudioClip Vacham;
    private AudioSource audioSoure;
    private Animator anim;
    // private AudioSource gameOver;
    
    GameObject obj;
    GameObject GameController;


     void Start()
    {
        obj = gameObject;
        audioSoure = obj.GetComponent<AudioSource>();
        audioSoure.clip = Fly;
        anim = obj.GetComponent<Animator>();
        anim.SetBool("isDie", false);
        if(GameController == null)
        {
            GameController = GameObject.FindGameObjectWithTag("GameController");
        }
        birdlfly = obj.transform.position = new Vector2(x, y);
    }
    float x = -8f;
    float y = 1f;
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
           if(!GameController.GetComponent<GameCotroller>().isEndGame)
            audioSoure.Play();

            
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSoure.clip = Vacham;
        audioSoure.Play();
       
        EndGame();

    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.GetComponent<GameCotroller>().getScore();
    }
    public void EndGame()
    {
        //audioSoure.clip = gameOverclip;
        //audioSoure.Play();
       anim.SetBool("isDie", true);
       GameController.GetComponent<GameCotroller>().EndGame();
    }



}
