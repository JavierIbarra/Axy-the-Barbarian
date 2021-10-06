using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 Movimiento;
    public float Velocidad;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

     void OnCollisionEnter2D(){
        GetComponent<AudioSource>().Play();
    }
    
    void FixedUpdate(){
        Movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        Movimiento = Movimiento.normalized;
        transform.position += Movimiento * Velocidad * Time.deltaTime;
    }
}
