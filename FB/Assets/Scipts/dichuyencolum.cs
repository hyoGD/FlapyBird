using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyencolum : MonoBehaviour
{
    public float MoveSpeed;
   // public float Oldposition;

    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        MoveSpeed = 3;
       // Oldposition = 12;
        
      
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("oke oke!!!!");
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * MoveSpeed, 0, 0));
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    void OnTriggerEnter2D(Collider2D  other)
    {
        Debug.Log("wall");
       // obj.transform.position = new Vector3(Oldposition, Random.Range(miny, maxy +1 ) , 0);
       if(other.tag == "Reset")
        {
            Destroy(gameObject);
        }
    }
}
