using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] go;
    public GameObject[] spawns;
    private GameObject[] instance = new GameObject[1000];
    private List<Vector3> spawnscheck;
    private bool encontrarposicion = false;
    private bool spawnbool = true;
    private bool corutina = true;
    private int nextPoint = 0;
    //Tiempo de repeticion del spawner
    public float t_respawn = 1;
    //Intervalo de repeticion del spawner
    public float tRespawn = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", 3f, 3f);
        nextPoint = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void spawnObject()
    {
        //una posicion aleatoria de los waypoints
        Vector3 posicion = spawns[Random.Range(0, spawns.Length)].transform.position;
        spawnbool = true;//esto para entrar en el bucle por si acaso
        while (spawnbool == true)
        {

            spawnbool = false;//esto para slair del bucle en caso de no encontrar un objeto en la misma posicion
            for (int x = 0; x < instance.Length; x++)//bucle recorriendo todos los objetos instanciados
            {
                if (instance[x]!=null &&instance[x].transform.position == posicion)//si ese objeto no es null y su posicion es igual a la del principio dle metodo
                {
                    spawnbool = true;//ponemos esto a true para seguir el bucle
                    break;//salimos del for
                }
            }
            if (spawnbool == true)//si es true
            {
                posicion = spawns[Random.Range(0, spawns.Length)].transform.position;//ponemos otra posicion aleatoria de los waypoints
            }

        }
        Instantiate(go[Random.Range(0, go.Length)], posicion, Quaternion.identity);//una vez salimos dle bucle, instanciamos el objeto en esa posicion





    }
}
