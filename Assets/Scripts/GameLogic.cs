using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static float dropTime = 1f;
    public GameObject[] blocks;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        float escogerBloque = Random.Range(0, 1f);
        escogerBloque *= blocks.Length;
        Instantiate(blocks[Mathf.FloorToInt(escogerBloque)]);
    }
}
