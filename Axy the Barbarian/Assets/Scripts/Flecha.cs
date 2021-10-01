using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flecha : MonoBehaviour
{
    public Gazer gazer;
    public float Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        gazer = GameObject.Find("Gazer").GetComponent<Gazer>();
        Destroy(gameObject, gazer.Velocidad);
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.position += new Vector3(0, Velocidad * Time.deltaTime, 0);
    }
}
