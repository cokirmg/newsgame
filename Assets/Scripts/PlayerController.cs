using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool dch = false;
    public bool izq = false;
    public bool jump = false;

    public Rigidbody2D rb;
    public float speedForce;
    public float salto;

    public int vida;


    public void Saveplayervida()
    {
        //vida = 100;
        PlayerPrefs.SetInt("vidaPlayer", vida);
    }
    public void Loadplayervida()
    {
        //vida = PlayerPrefs.GetInt("vidaPlayer");
        Debug.Log(".....");
        if (PlayerPrefs.HasKey("vidaPlayer"))
        {
            vida = PlayerPrefs.GetInt("vidaPlayer");
        }
    }


    public void Start()
    {
        Loadplayervida();

        if(vida <= 0)
        {
            vida = 100;
        }
        
    }

    public void clickLeft()
    {
        izq = true;
    }
    public void clickRight()
    {
        dch = true;
    }
    public void realeaseLeft()
    {
        izq = false;
    }
    public void realeaseRight()
    {
        dch = false;
    }




    private void FixedUpdate()
    {
        if(izq && dch == false)
        {
            //rb.AddForce(new Vector2(-speedForce, 0) * Time.deltaTime);
            transform.position += new Vector3(-speedForce, 0f, 0f) * Time.deltaTime;
        }
        else if (dch && izq == false )
        {
            //rb.AddForce(new Vector2(speedForce, 0) * Time.deltaTime);
            transform.position += new Vector3(speedForce, 0f, 0f) * Time.deltaTime;
        }
        else if (dch && izq )
        {
            jump = true;
        }

        if(jump)
        {
            jump = false;
            //rb.AddForce(new Vector2(0, salto));
            transform.position += new Vector3(0f, salto, 0f) * Time.deltaTime;
        }

    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            Destroy(collision.gameObject);
        }
    }
}
