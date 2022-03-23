using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static float dropTime = 1f;
    GameObject[] blocks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        float escogerBloque = Random.Range(0, 1f);
        escogerBloque *= blocks.Length;
        Instantiate(blocks[(int)escogerBloque]);
    }
}
