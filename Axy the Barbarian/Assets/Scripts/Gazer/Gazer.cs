using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gazer : MonoBehaviour
{
    public MovementGazerController Movement;
    public Vector3 inicio = new Vector3(2, 3, 0);
    public Vector3 fin = new Vector3(2, -3, 0);
    public float Velocidad = 2;
    public bool recorrer = true;

    void Start()
    {
        Movement = this.GetComponent<MovementGazerController>();
        inicio = new Vector3(transform.position.x, transform.position.y, 0);
        fin = new Vector3(transform.position.x, transform.position.y -3, 0);
    }

    void Update()
    {
        Movement.update(this);
    }
}



    
        