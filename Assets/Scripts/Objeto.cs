using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public int posicion;
    
    // Start is called before the first frame update
    void Start()
    {
       

    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ladrillo")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameManager.Instance.eliminarObjeto(posicion);
        }
    }
}
