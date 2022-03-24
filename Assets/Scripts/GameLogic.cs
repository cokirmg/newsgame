using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static float dropTime = 1f;
    public GameObject[] blocks;
    bool caida = true;
    float aparacionBloque;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (caida)
        {
            spawn();
            StartCoroutine(Block());
        }
    }

    public void spawn()
    {
        float escogerBloque = Random.Range(0, 1f);
        escogerBloque *= blocks.Length;
        var position = new Vector3(Random.Range(-2.0f, 2.0f), 5f, 0);
        Instantiate(blocks[Mathf.FloorToInt(escogerBloque)], position, Quaternion.identity);
    }
    IEnumerator Block()
    {
        caida = false;
        yield return new WaitForSeconds(1);
        caida = true;
    }
}
