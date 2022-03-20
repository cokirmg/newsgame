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
            rb.AddForce(new Vector2(-speedForce, 0) * Time.deltaTime);
        }
        else if (dch && izq == false )
        {
            rb.AddForce(new Vector2(speedForce, 0) * Time.deltaTime);
        }
        else if (dch && izq )
        {
            jump = true;
        }

        if(jump)
        {
            jump = false;
            rb.AddForce(new Vector2(0, salto));
        }

    }
}
