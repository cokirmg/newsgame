using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool izq;
    public bool drch;
    public void ClickLeft()
    {
        izq = true;
    }
    public void ClickRight()
    {
        drch = true;
    }
    public void releaseLeft()
    {
        izq = false;
    }
    public void releaseRight()
    {
        drch = false;
    }


    public void FixedUpdate()
    {
        
    }
}
