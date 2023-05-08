using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTriangulo : MonoBehaviour
{
   public float speed = 0.1f;
     public float rotationSpeed = 3;
// variable publica se exponen e el inspector, es universal
    public KeyCode teclavanzar;
    public KeyCode teclatras;
    public KeyCode tecladerecha;
    public KeyCode teclaizquierda;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log(transform.position.y);

        if (Input.GetKey(teclavanzar))
        {
            transform.Translate(0, speed, 0);
        }

        if (Input.GetKey(teclatras))
        {
            transform.Translate(0, -speed, 0);
        }

       
         
         if (Input.GetKey(tecladerecha))
        {
           transform.Rotate(0, 0, -rotationSpeed);
        }

         if (Input.GetKey(teclaizquierda))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }


    }
}
