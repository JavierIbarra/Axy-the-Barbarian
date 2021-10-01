using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelet : MonoBehaviour
{
    public GameObject flecha;
    public GameObject flechaAnterior;
    public float Timer, TiempoEspera;
    public Gazer gazer;

    void Start()
    {
        gazer = GameObject.Find("Gazer").GetComponent<Gazer>();
     
    }

    void Update()
    {

        TiempoEspera = gazer.Velocidad;
        

        if (Timer <= 0)
        {
            //Vector3 ini = new Vector3(transform.position.x + Random.Range(-3.0f, 3.0f), 5, 0);
            Vector3 ini = new Vector3(transform.position.x + Random.Range(-3.0f, 3.0f), transform.position.y + Random.Range(-3.0f, 3.0f), 0);
            flechaAnterior = GameObject.Find("Flecha");
            Destroy(flechaAnterior,0.1f);
            Instantiate(flecha, ini, Quaternion.identity);
            Timer = TiempoEspera;
        }
        Timer -= Time.deltaTime;
    }
}
