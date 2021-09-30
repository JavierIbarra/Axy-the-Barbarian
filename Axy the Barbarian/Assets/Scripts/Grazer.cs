using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grazer : MonoBehaviour
{
    public Vector3 Movimiento;
    public float Velocidad;
    bool bajar = true;

    void Start()
    {
        
    }

    void Update()
    {
        
        if (bajar)
        {
            Vector3 abajo = new Vector3(2, -3, 0);
            transform.position = Vector3.MoveTowards(transform.position, abajo, Velocidad * Time.deltaTime);
            if (transform.position == abajo)
            {
                bajar = false;
            }

        }
        else
        {
            Vector3 arriba = new Vector3(2, 3, 0);
            transform.position = Vector3.MoveTowards(transform.position, arriba, Velocidad * Time.deltaTime);
            if (transform.position == arriba)
            {
                bajar = true;
            }

        }
        
        //transform.Translate(Vector3.down * Time.deltaTime , Space.World);
    }
}
