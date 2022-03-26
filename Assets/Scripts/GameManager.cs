using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] go;
    public GameObject[] spawns;
    private GameObject instanceobject;
    private List<Vector3> spawnscheck;
    private bool encontrarposicion = false;
    private bool spawnbool = true;
    private bool corutina = true;
    private int nextPoint = 0;
    //Tiempo de repeticion del spawner
    public float t_respawn = 1;
    //Intervalo de repeticion del spawner
    public float tRespawn = 1;
    public bool[] posicionesocupadas = new bool[4] { false, false, false, false };
    public static float dropTime = 1f;
    public GameObject[] blocks;
    bool caida = true;
    float aparacionBloque;

    public int countinstance=0;
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
        private set
        {
            instance = value;
        }
    }
    // Start is called before the first frame update
    void Awake()
    {

        instance = this;
        InvokeRepeating("spawnObject", 3f, 3f);
        Debug.Log(countinstance);

        
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
    private void spawnObject()
    {
        if (countinstance > 3)
        {

        }
        else
        {
            //una posicion aleatoria de los waypoints
            int posicionint = Random.Range(0, spawns.Length);
            
            //esto para entrar en el bucle por si acaso
            while (posicionesocupadas[posicionint]==true)
            {

                posicionint = Random.Range(0, spawns.Length);

            }
            Vector3 posicion = spawns[posicionint].transform.position;
            Debug.Log(posicionint);
            posicionesocupadas[posicionint] = true;
            instanceobject=Instantiate(go[Random.Range(0, go.Length)], posicion, Quaternion.identity);//una vez salimos dle bucle, instanciamos el objeto en esa posicion
            instanceobject.GetComponent<Objeto>().posicion = posicionint;
            countinstance++;
        }
        




    }
    public void eliminarObjeto(int num)
    {
        countinstance--;
        posicionesocupadas[num] = false;
    }
}
