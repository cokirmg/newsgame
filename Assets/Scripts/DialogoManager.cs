using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoManager : MonoBehaviour
{
    public Queue <string> sentences;
    public Text textoDigalogo;
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
        Debug.Log("Terminar conversación");
    }

}
