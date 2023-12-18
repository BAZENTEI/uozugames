using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSE : MonoBehaviour
{
    public AudioClip jump;
    AudioSource AudioSource;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AudioSource = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource.clip = jump;
            AudioSource.Play();
        }
    }
}
