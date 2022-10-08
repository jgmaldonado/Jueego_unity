using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //Variables
    
    void Start()
    {
        

    }

    void Update()
    {
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
       if (collision.gameObject.CompareTag("Respawn"))
        {
            //Acá ponemos codigo de lo que queremos que suceda al colisionar con Respawn vuelve a la posicion 
           transform.position = new Vector3(0f, 3.0f, 0);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
        }



    }
}
