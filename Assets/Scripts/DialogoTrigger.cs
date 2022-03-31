using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour
{
    public Dialogo dialogo;
    public GameObject frases;

    public AudioSource au;
    public AudioClip clip;

    private void Start()
    {
        au.PlayOneShot(clip);
    }
    public void TriggerDialogo()
    {
        FindObjectOfType<DialogoManager>().StartDialogo(dialogo);
        frases.SetActive(true);

    }
}
