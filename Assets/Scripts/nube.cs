using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nube : MonoBehaviour
{
    public bool nubeEspera = false;
    float velocity;
    float direccion = 3f;
    public Animator animatordetuchinga;
    // Start is called before the first frame update
    void Start()
    {
        velocity = direccion;
    }

    // Update is called once per frame
    void Update()
    {
        if(!nubeEspera)
        {
            transform.position += new Vector3(velocity, 0, 0) * Time.deltaTime;
            
        }
        else if(nubeEspera)
        {
            transform.position += new Vector3(velocity, 0f, 0f) * Time.deltaTime;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "waypoint2")
        {
            Debug.Log("xd");
            direccion = -3f;
            velocity = direccion;
            
        }
        else if (collision.gameObject.tag == "waypoint1")
        {
            direccion = 3f;
            velocity = direccion;

        }

        if (collision.gameObject.tag == "solesito")
        {
            Debug.Log("toque sol");
            StartCoroutine(nubeCoolDown());
        }

    }
    
    private IEnumerator nubeCoolDown()
    {
        animatordetuchinga.SetBool("ponersol", false);
        nubeEspera = true;
        velocity = 0f;
        animatordetuchinga.SetBool("quitarsol",true);
        yield return new WaitForSeconds(5);
        animatordetuchinga.SetBool("quitarsol", false);
        velocity = direccion;
        animatordetuchinga.SetBool("ponersol", true);
        nubeEspera = false;

    }
}
