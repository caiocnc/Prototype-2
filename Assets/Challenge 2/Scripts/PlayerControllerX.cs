using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float timer = 0.5f;
    float waitTimer = 0.5f;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (timer < waitTimer)
        {
        }        
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
        timer += Time.deltaTime;
        Debug.Log(timer);
    }
}
