using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool dch = false;
    public bool izq = false;
    public bool jump = false;
    public bool pausarJuego = false;
    public int salto;
    public Rigidbody2D rb;
    public float speedForce;
    public Text textovida;
    public int vida;
    public GameObject pelo;
    public GameObject cara;
    public GameObject brazo1;
    public GameObject brazo2;
    public GameObject fichaCasos;
    public GameObject modoPausa;
    public Image t1, t2, t3;
    private Color[] color= {new Color(1, 1, 1, 1),new Color(1, 1, 0, 1), new Color(0, 0, 0, 1), new Color(0.5f, 0.5f, 0.5f, 1), new Color(118, 57, 31, 255)};
    private Color[] colorpiel = { new Color(255, 255, 255, 255),  new Color(118, 57, 31, 255), new Color(67,30,16, 255), new Color(203, 134, 108, 255) };
    //-1.69, -4.637184
    public bool tool1, tool2, tool3;
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
        else if (dch && izq)
        {
            jump = true;
        }
        

        if(jump )
        {
            jump = false;
            //rb.AddForce(new Vector2(0, salto));
            transform.position += new Vector3(0f, salto, 0f) * Time.deltaTime;
        }
        
    }

    private void ganar()
    {
        if(tool1==true && tool2==true && tool3 == true)
        {
            PlayerPrefs.GetInt("Qatar", 1);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tool1" || collision.gameObject.tag == "Tool2" || collision.gameObject.tag == "Tool3" || collision.gameObject.tag == "agua")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.eliminarObjeto(collision.gameObject.GetComponent<Objeto>().posicion);
            if (collision.gameObject.tag == "Tool1")
            {
                tool1 = true;
                t1.enabled = true;
            }
            else if (collision.gameObject.tag == "Tool2")
            {
                tool2 = true;
                t2.enabled = true;
            }
            else if (collision.gameObject.tag == "Tool3")
            {
                tool3 = true;
                t3.enabled = true;
            }
            else if (collision.gameObject.tag == "agua")
            {
                vida += 10;
            }
        }
        else if (collision.gameObject.tag == "ladrillo")
        {
            Destroy(collision.gameObject);
            Debug.Log("UWU");
            vida = vida - 20;
            if (vida <= 0)
            {
                pausarJuego = false;
                if (pausarJuego == false)
                {
                    Pausar();
                    
                }
                

            }
        }
         
    }


    public void CambiarPersonaje()
    {
        Color piel = color[Random.Range(0, color.Length)];
        transform.position = new Vector3(-1.69f, -4.637184f, 0);
        vida = 100;
        PlayerPrefs.SetInt("vidaPlayer", vida);
        pelo.GetComponent<SpriteRenderer>().color = color[Random.Range(0, color.Length)];
        cara.GetComponent<SpriteRenderer>().color = piel;
        brazo1.GetComponent<SpriteRenderer>().color = piel;
        brazo2.GetComponent<SpriteRenderer>().color = piel;
        t1.enabled = false;
        t2.enabled = false;
        t3.enabled = false;
        //pausarJuego = true;
    }

    public void Pausar()
    {
        fichaCasos.SetActive(true);
        Time.timeScale = 0;
        
    }
    public void Reanudar()
    {
        Debug.Log(pausarJuego);
        fichaCasos.SetActive(false);
        Time.timeScale = 1;
        CambiarPersonaje();

    }
}
