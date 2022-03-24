using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    GameLogic gameLogic;
    float timer = 0f;
    bool movable = true;
    GameObject rig;
   
    // Start is called before the first frame update
    void Start()
    {
        gameLogic = FindObjectOfType<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movable)
        {
            timer += 1 * Time.deltaTime;
            if (timer > GameLogic.dropTime)
            {

                gameObject.transform.position -= new Vector3(0, 1, 0);
                timer = 0;
                gameLogic.spawn();
                
               

            }
        }
       
    }
}
