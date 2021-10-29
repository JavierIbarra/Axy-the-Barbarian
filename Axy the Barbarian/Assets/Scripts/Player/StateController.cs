using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateController : MonoBehaviour
{
    public void update(Player player)
    {
        Mov(player);
    }


    void Mov(Player player){
        player.transform.position += player.Movimiento * player.Velocidad * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("Enemy")){
            //SceneManager.LoadScene("SampleScene");
        }
    }

    
}
