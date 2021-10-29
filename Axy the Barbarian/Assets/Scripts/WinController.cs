using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Player"){
            Debug.Log("Win!!!");
            Time.timeScale = 0f;
        }
    }
}
