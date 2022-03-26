using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sol : MonoBehaviour
{
    public bool sunDamage = true;
    public PlayerController player;
    public Text textovida;
    public nube nube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textovida.text = "vida:" + player.vida;
        if (sunDamage == true)
        {
            quitarVida();
            player.Saveplayervida();
        }

    }

    public void quitarVida()
    {
            if(!nube.nubeEspera)
            {
            player.vida = player.vida - 1;
            //player.Loadplayervida();

            StartCoroutine(SunCooldown());
            }
            
    }


    IEnumerator SunCooldown()
    {
        sunDamage = false;
        yield return new WaitForSeconds(2);
        sunDamage = true;
    }
}
