using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    //Variables
    public float velocidad = 4.0f;
    public float minDist = 0.5f;
    public Transform objetivo;
    void Start()
    {
        // Buscamos objeto que tiene el tag player y le pasamos un componente transform
        //objetivo = GameObject.FindWithTag("Player").GetComponent<Transform>();
        objetivo = GameObject.FindWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {
        //Si no tenemos un target no hacemos nada, pa que vamos a movernos.
        //if (objetivo == null)
        //{
         //   return;
        //}
        // Mira hacia el target.
        transform.LookAt(objetivo);

        //Recupera la distancia que hay desde el objeto al target
        float distancia = Vector3.Distance(transform.position, objetivo.position);

        //Nos movemos hacia el target a la velocidad indicada.
        if (distancia > minDist)
        {
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{ 
     //   if (collision.gameObject.CompareTag("Respawn"))
       // {
            //Acá ponemos codigo de lo que queremos que suceda al colisionar con Respawn vuelve a la posicion 
      //      transform.position = new Vector3(-3.5f, 3.0f, 0);
       // }
    //}
}
