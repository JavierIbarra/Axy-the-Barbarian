using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingController : MonoBehaviour
{
    
    public void update(Skelet skelet)
    {
        ArrowShooting(skelet);
    }

    void ArrowShooting(Skelet skelet){
        skelet.TiempoEspera = skelet.Velocidad;
        

        if (skelet.Timer <= 0)
        {
            //Destroy(skelet.flechaAnterior,skelet.Velocidad);
            Instantiate(skelet.flecha, skelet.ini, Quaternion.identity);
            skelet.Timer = skelet.TiempoEspera;
        }
        skelet.Timer -= Time.deltaTime;
    }
}
