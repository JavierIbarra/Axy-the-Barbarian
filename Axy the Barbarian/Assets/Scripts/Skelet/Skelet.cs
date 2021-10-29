using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelet : MonoBehaviour
{
    public ShootingController Shooting;
    public TimingController Timing;
    public GameObject flecha;
    public float Timer, TiempoEspera;
    public float Velocidad;
    public Vector2 ini;

    void Start()
    {
        Shooting = this.GetComponent<ShootingController>();
        Timing = this.GetComponent<TimingController>();
    }

    void Update()
    {
        TiempoEspera = Velocidad;
        
        if (Timer <= 0)
        {
            if (transform.childCount > 0) 
            {
                Destroy(transform.GetChild(0).gameObject);
            }
            ini = new Vector2(transform.position.x,transform.position.y);
            ini = ini + Random.insideUnitCircle * 3.0f;
            var arrow = Instantiate(flecha, ini, Quaternion.identity);
            arrow.transform.parent = gameObject.transform;
            

            Timer = TiempoEspera;
        }
        Timer -= Time.deltaTime;
    }
}
