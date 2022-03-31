using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioCreditos : MonoBehaviour
{

    public void Cambio(string name)
    {
       
            SceneManager.LoadScene(name);
        
    }
}
