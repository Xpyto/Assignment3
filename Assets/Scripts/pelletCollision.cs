using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelletCollision : MonoBehaviour
{
    AudioSource eat;
    
    // Start is called before the first frame update
    void Start()
    {
        eat = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void onTriggerEnter(Collision collision)
    {
        eat.Play();
        gameObject.SetActive(false);
    }
}
