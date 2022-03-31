using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBotones : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage
                if (hit.transform.gameObject.tag == "boton")
                {
                    audio.PlayOneShot(audioClip);
                    Debug.Log("uwu");
                }
            }
        }
    }
}

