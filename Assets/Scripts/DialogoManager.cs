using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogoManager : MonoBehaviour
{
    public Queue <string> sentences;
    public TextMeshProUGUI textoDigalogo;
    public GameObject phone;
    public GameObject dialogo;
    public GameObject portada;
    public GameObject botonesCatalago;
    public GameObject jefe;
    public bool terminadoDialogo = false;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
       
    }


    public void StartDialogo(Dialogo dialogo)
    {
        sentences.Clear();

        foreach(string sentence in dialogo.sentences)
        {
            sentences.Enqueue(sentence);
        }

        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if(sentences.Count == 0)
        {
            TerminarDialogo();
            return;
        }

        string sentence = sentences.Dequeue();
        textoDigalogo.text = sentence;
    }

    public void TerminarDialogo()
    {
        terminadoDialogo = true;
        phone.SetActive(true);
        dialogo.SetActive(false);
        //portada.SetActive(false);
        botonesCatalago.SetActive(true);
        jefe.SetActive(false);
        Debug.Log("Terminar conversación");
        
    }

}
