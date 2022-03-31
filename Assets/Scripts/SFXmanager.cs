using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXmanager : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;
    

    public void Awake()
    {
       

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void reproducir()
    {
       audioSource.PlayOneShot(audioClip);
    }
}
