using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public bool dch = false;
    public bool izq = false;
    public bool jump = false;
    public bool pausarJuego = false;
    public int salto;
    public int saludInicial;
    public int saludActual;
    public Button button;
    public Rigidbody2D rb;
    public float speedForce;
    public Text textovida;
    public GameObject pelo;
    public GameObject cara;
    public GameObject brazo1;
    public GameObject brazo2;
    public GameObject fichaCasos;
    public GameObject modoPausa;
    public GameObject modoPlay;
    public Image t1, t2, t3;
    public BarraSalud barraSalud;
    private Animator anim;
    private Color[] color= {new Color(1, 1, 1, 1),new Color(1, 1, 0, 1), new Color(0, 0, 0, 1), new Color(0.5f, 0.5f, 0.5f, 1), new Color(118, 57, 31, 255)};
    private Color[] colorpiel = { new Color(255, 255, 255, 255),  new Color(118, 57, 31, 255), new Color(67,30,16, 255), new Color(203, 134, 108, 255) };

    public GameObject fase1;
    public GameObject fase2;
    public GameObject fase3;

    public GameObject fondoMuerte;
    public int numestadio=0;
    //-1.69, -4.637184
    public bool tool1, tool2, tool3;

    public string[] nombres =
    {
        "Raúl Vargas",
        "Benito Antonio Martínez Ocasio",
        "Joaquín Gúzman",
        "Enmanuel Gazmey Santiago",
        "Ramón Ayala Rodríguez",
        "Kamal Laskar",
        "William Omar Landrón Rivera",
        "Khalid Malik Ahmad",
        "Syed Shah",




    };
    public string returnStringNombre;

    public string[] fallecimientoaeruopuerto =
    {
        "2020",
        "2021",
    };
    public string[] fallecimientoqatar =
    {
        "2020",
        "2021",
        "2019",
        "2018",
        "2017",

    };
    public string returnStringfallq;

    public string[] nacimiento =
    {
        "2000",
        "1999",
        "1998",
        "1997",
        "1996",
        "1995",
        "1994",
        "1993",
        "1992",
        "1991",
        "1990",
        "1989",
        "1988",
        "1987",
        "1986",
        "1985",
        "1984",
        "1983",
        "1982",
        "1981",
        "1980",
        "1979",
        "1978",
        "1977",
        "1976",
        "1975",
    };
    public string returnStringnac;

    public string[] causas =
    {
        "Causa de muerte: Debido a problemas de corazón por causas naturales \n " +
        "Datos de empleado: Su familia asegura que siempre tuvo buena salud, no le hicieron autopsia y más tarde les indemnizaron. ",
        "Causa de muerte: Problemas de corazón por causas naturales \n" +
        "Datos de empleado: Su familia asegura que tuvo buena salud antes de su muerte, no le hicieron autopsia y más tarde les indemnizaron.",
        "Causa de muerte: Problemas de corazón por causas naturales \n" +
        "Datos de empleado: Su familia asegura que tuvo buena salud antes de su muerte, no le hicieron autopsia y más tarde les indemnizaron.",
        "Causa de muerte: Dificultades respiratorias por causas naturales \n" +
        "Datos de empleado: Se trasladado al hospital y fue declarado muerto. Más tarde indemnizaron a su familia. Aseguran que murió mientras trabajaba",
        "Causa de muerte: Insuficiencia cardiorrespiratoria por causas naturales \n" +
        "Datos de empleado: Estuvo trabajando a 39 grados durante más de 8 horas. Nadie les contactó tras su fallecimiento, no le hicieron autopsia y más tarde les indemnizaron.",
        "Causa de muerte: Problemas de corazón no específicos \n" +
        "Datos de empleado: Estuvo trabajando durante 13 horas, nadie les contactó tras su fallecimiento ni le hicieron autopsia y más tarde les indemnizaron.",
        "Causa de muerte: Insuficiencia cardiorrespiratoria por causas naturales \n" +
        "Datos de empleado: Estuvo trabajando durante 13 horas, su familia asegura que siempre tuvo buena salud. No llegó a tiempo al hospital.",
        "Causa de muerte: Contusión craneoencefálica debido al aplastamiento de la caída de una grúa mal asegurada. \n" +
        "Datos del empleado: Joven sin estudios con siete hermanos pequeños. Le prometieron un mayor salario, sin embargo no tenían la seguridad adecuada.",
        "Causa de muerte: Caída a diferente nivel por falta de aseguramiento de los arneses. \n"+
        "Datos del empleado: Trabajaba en un turno de noche, lo que provocó que falleciera por la falta de atención médica durante esas horas",
        "Causa de muerte: Multitud de traumatismos por atropellamiento con equipo móvil, motoniveladora.\n" +
        "Datos del empleado: Padre de una niña. La empresa se negaba a reconocer su muerte.",
        "Causa de muerte: Fractura craneoencefálica por aplastamiento al caerle unas vigas encima \n" +
        "Datos del empleado: La empresa dijo que fue un error en el uso de las máquinas como justificación para no pagar la indemnización. ",
        "Causa de muerte: Traumatismo craneoencefálico, policontusión torácica y fractura en parrilla costal.\n" +
        "Datos del empleado: Le pusieron horas extras encargándose de maquinaria fuera de su profesión. ",
        "Causa de muerte: Multitud de contusiones por volcadura de vehículo en excavación. \n" +
        "Datos del empleado: La construcción no mantenía las condiciones de trabajo y era forzado a trabajar más de las horas establecidas.",
        "Causa de muerte: múltiples quemaduras en el cuerpo.\n" +
        "Datos del empleado: Le obligaron a trabajar más horas de las establecidas, tras morir su hija acabó en un orfanato. ",
        "Causa de muerte: Paro cardíaco por una descarga eléctrica.\n" +
        "Datos del empleado: Empezó a trabajar en la obra para conseguir formar una familia. A su mujer le llegó una llamada informando del fallo eléctrico y el fallecimiento de su esposo.",






    };
    public string returnStringCaus;
    public TextMeshProUGUI textNacimiento;
    public TextMeshProUGUI textFallecimientoqatar;
    public TextMeshProUGUI textFallecimientoaeropuerto;
    public TextMeshProUGUI textNombres;
    public TextMeshProUGUI textCase;
    public TextMeshProUGUI textCausas;

    public void Saveplayervida()
    {
        PlayerPrefs.SetInt("vidaPlayer", saludActual);

    }
    public void Loadplayervida()
    {
        //vida = PlayerPrefs.GetInt("vidaPlayer");
        Debug.Log(".....");
        if (PlayerPrefs.HasKey("vidaPlayer"))
        {
            saludActual = PlayerPrefs.GetInt("vidaPlayer");
        }
    }

   
    public void Start()
    {
        anim = GetComponent<Animator>();
        Loadplayervida();

        if(saludActual <= 0)
        {
            saludInicial = 100;
        }

        saludActual = saludInicial;
        barraSalud.EstablecerVidaMaxima(saludInicial);
        
    }

    public void clickLeft()
    {
        izq = true;
        anim.SetBool("Andar", true);

    }
    public void clickRight()
    {
        dch = true;
        anim.SetBool("Andar", true);

    }
    public void realeaseLeft()
    {
        izq = false;
        anim.SetBool("Andar", false);
    }
    public void realeaseRight()
    {
        dch = false;
        anim.SetBool("Andar", false);
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
        if (dch && izq)
        {
            jump = true;
            
        }
        


        if (jump )
        {
            anim.SetBool("Saltar", true);
            jump = false;
            //rb.AddForce(new Vector2(0, salto));
            transform.position += new Vector3(0f, salto, 0f) * Time.deltaTime;
            

        }
        else
        {
            anim.SetBool("Saltar", false);
        }
        
    }

    public void AnimacionAndar()
    {
        


    }

    public void DejarAndar()
    {
        
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
                if(!tool1)
                {
                    numestadio++;
                }
                tool1 = true;
                t1.enabled = true;
                
            }
            else if (collision.gameObject.tag == "Tool2")
            {
                if(!tool2)
                {
                    numestadio++;
                }
                tool2 = true;
                t2.enabled = true;
                
            }
            else if (collision.gameObject.tag == "Tool3")
            {
                if(!tool3)
                {
                    numestadio++;
                }
                tool3 = true;
                t3.enabled = true;
                
            }
            else if (collision.gameObject.tag == "agua")
            {
                saludActual += 10;
            }

            if(numestadio == 1)
            {
                fase1.SetActive(true);
            }
            else if(numestadio == 2)
            {
                fase1.SetActive(false);
                fase2.SetActive(true);
            }
            else if(numestadio==3)
            {
                fase3.SetActive(true);
                fase2.SetActive(false);
            }

        }
        else if (collision.gameObject.tag == "ladrillo")
        {
            Destroy(collision.gameObject);
            Debug.Log("UWU");
            saludActual = saludActual - 20;
            barraSalud.EstablecerVida(saludActual);
            if (saludActual <= 0)
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
        saludActual = 100;
        barraSalud.EstablecerVida(saludActual);
        PlayerPrefs.SetInt("vidaPlayer", saludActual);
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
        fondoMuerte.SetActive(true);
        fichaCasos.SetActive(true);
        returnStringNombre = nombres[Random.Range(0, nombres.Length)];
        returnStringnac = nacimiento[Random.Range(0, nacimiento.Length)];
        returnStringfallq = fallecimientoqatar[Random.Range(0, fallecimientoqatar.Length)];
        returnStringCaus = causas[Random.Range(0, causas.Length)];


        textCausas.text = returnStringCaus;
        textCase.text = Random.Range(0, 6500) + " ";
        textNombres.text = returnStringNombre;
        textNacimiento.text = returnStringnac;
        textFallecimientoqatar.text = returnStringfallq;


        Time.timeScale = 0;
        
    }
    public void Reanudar()
    {
        fondoMuerte.SetActive(false);
        fichaCasos.SetActive(false);
        Time.timeScale = 1;
        CambiarPersonaje();

    }

    public void BotonPausa()
    {
        Time.timeScale = 0;
        modoPausa.SetActive(true);
        modoPlay.SetActive(false);
    }

    public void BotonVolver()
    {
        Time.timeScale = 1;
        modoPausa.SetActive(false);
        modoPlay.SetActive(true);
    }
}
