using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swapcolum : MonoBehaviour
{
    [SerializeField]
    private GameObject swap;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(spawner());
        
    }

    IEnumerator spawner()
    {
        yield return new WaitForSeconds(1);
        Vector3 temp = swap.transform.position;
        temp.y = Random.Range(-1.5f, 1.5f);
        Instantiate(swap,temp, Quaternion.identity);
        StartCoroutine(spawner());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
