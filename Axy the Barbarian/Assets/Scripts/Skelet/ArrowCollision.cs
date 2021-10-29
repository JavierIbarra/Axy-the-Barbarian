using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.name == "Player"){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
