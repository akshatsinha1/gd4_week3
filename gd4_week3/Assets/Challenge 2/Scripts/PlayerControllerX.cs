﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float waitTime = 1;
    private float timer = 1;

    // Update is called once per frame
    void Update()
    {
        if (timer < waitTime) timer += Time.deltaTime;
        // On spacebar press, send dog

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(timer >= waitTime)
            {
                timer = 0;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            }
        }


    }
}
