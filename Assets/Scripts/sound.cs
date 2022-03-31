using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource au;
    public AudioClip clip;

    private void Start()
    {
        au.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sonido()
    {
        au.PlayOneShot(clip);
    }
    
}
