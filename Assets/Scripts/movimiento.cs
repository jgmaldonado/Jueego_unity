using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    Rigidbody2D cuerpo;
    public float velocidad;
    public int contador;
    public float salto;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        velocidad = 10.0f;
        salto = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        cuerpo.velocity = new Vector2(movHorizontal, movVertical) * velocidad;

        if (Input.GetKeyDown("space")){
            cuerpo.AddForce(Vector2.up * salto, ForceMode2D.Impulse); 
        }
            //cuerpo.AddForce(Vector2.up * movVertical * salto);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            //Acá ponemos codigo de lo que queremos que suceda al colisionar con Respawn vuelve a la posicion 
           transform.position = new Vector3(0, 0, 0);
        }

        if (collision.gameObject.CompareTag("enemigo"))
        {
            contador = contador + 1;
            Debug.Log("Puntos recogidos: " + contador);
            Destroy(collision.gameObject);
        }
    }
  /*  private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemigo"))
        {
            contador = contador + 1;
            Debug.Log("Puntos recogidos: " + contador);
            Destroy(other.gameObject);
        }
    }*/
        
       
            

}
