using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("SpawnPoint")){
            Destroy(other.gameObject);
        }
    }
}