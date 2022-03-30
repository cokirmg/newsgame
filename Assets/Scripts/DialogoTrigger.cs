using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour
{
    public Dialogo dialogo;
    public GameObject frases;

    public void TriggerDialogo()
    {
        FindObjectOfType<DialogoManager>().StartDialogo(dialogo);
        frases.SetActive(true);

    }
}
