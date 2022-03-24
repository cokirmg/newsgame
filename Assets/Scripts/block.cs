using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    GameLogic gameLogic;
    float timer = 0f;
    float Velocidad = 7f;
    GameObject rig;
    bool caida = true;
   
    // Start is called before the first frame update
    void Start()
    {
        gameLogic = FindObjectOfType<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
       
            //timer += 1 * Time.deltaTime;
            
            

            /*gameObject.transform.position -= new Vector3(0, 1, 0);
            timer = 0;*/
                transform.position -= new Vector3(0, Velocidad, 0) * Time.deltaTime;
                
                
               

    }
        
       
    
   
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
