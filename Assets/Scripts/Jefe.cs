using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jefe : MonoBehaviour
{
    public DialogoManager dialogoManager;
    public Dialogo dialogo;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Llamada()
    {
        dialogoManager.StartDialogo(dialogo);
        anim.SetBool("llamando", true);
        if(dialogoManager.terminadoDialogo == true)
        {
            anim.SetBool("llamando", false);
            anim.SetBool("colgar", true);
        }
    }
}
