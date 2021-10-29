using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementGazerController : MonoBehaviour
{
    public void update(Gazer gazer)
    {
        Recorrido(gazer);
    }

    void Recorrido(Gazer gazer){
        if (gazer.recorrer)
        {
            gazer.transform.position = Vector3.MoveTowards(gazer.transform.position, gazer.inicio, gazer.Velocidad * Time.deltaTime);
            if (gazer.transform.position == gazer.inicio)
            {
                gazer.recorrer = false;
            }
        }
        else
        {
            gazer.transform.position = Vector3.MoveTowards(gazer.transform.position, gazer.fin, gazer.Velocidad * Time.deltaTime);
            if (gazer.transform.position == gazer.fin)
            {
                gazer.recorrer = true;
            }
        }
    }
}
