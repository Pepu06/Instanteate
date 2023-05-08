using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform spawnPointTr;
    public string buttonString;
    public string EnemyTag;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //agregar otro jugador con otro script Instantiator
        //debe instanciar prefabs con un tag diferente cada jugador
        // si un jugador colisiona una instancia del otro jugador, se destruye




        if (Input.GetButtonDown(buttonString))
        {
            GameObject clon;
            //crea clon. Quaternion (para rotar) "Indentity" (se queda igual) "(spawnPointTr.position) --> poscion en la que vamos a clonar
            clon = Instantiate(prefabProyectil, spawnPointTr.position, Quaternion.identity);
            Destroy(clon, 1);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == EnemyTag)
        {

            Destroy(gameObject);

        }
    }
}
