﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalebg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 temScale = transform.localScale;

        float height = sr.bounds.size.y;
        float width = sr.bounds.size.x;

        float worldHeight = Camera.main.orthographicSize * 2f;
        float worlWidth = worldHeight * Screen.width / Screen.height;

        temScale.y = worldHeight / height;
        temScale.x = worlWidth / width;

        transform.localScale = temScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
