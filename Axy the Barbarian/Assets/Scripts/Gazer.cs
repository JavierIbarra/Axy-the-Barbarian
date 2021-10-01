using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gazer : MonoBehaviour
{
    public Vector3 inicio = new Vector3(2, -3, 0);
    public Vector3 fin = new Vector3(2, 3, 0);
    public float Velocidad = 2;
    bool recorrer = true;

    void Start()
    {
        
    }

    void Update()
    {
        if (recorrer)
        {
            transform.position = Vector3.MoveTowards(transform.position, inicio, Velocidad * Time.deltaTime);
            if (transform.position == inicio)
            {
                recorrer = false;
            }

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, fin, Velocidad * Time.deltaTime);
            if (transform.position == fin)
            {
                recorrer = true;
            }

        }
    }
}



    
        