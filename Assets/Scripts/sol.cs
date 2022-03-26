using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sol : MonoBehaviour
{
    public bool sunDamage = true;
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sunDamage)
        {

            StartCoroutine(SunCooldown());
        }
    }

    IEnumerator SunCooldown()
    {
        sunDamage = false;
        yield return new WaitForSeconds(1);
        sunDamage = true;
    }
}
