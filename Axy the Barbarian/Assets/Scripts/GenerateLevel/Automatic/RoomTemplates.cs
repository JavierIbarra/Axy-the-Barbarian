using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottonRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    public GameObject closedRoom;

    public List<GameObject> rooms;

    public GameObject skelet;
    public GameObject gazer;
    public GameObject exit;

    public float rand;

    private void Start(){
        Invoke("SpawnExit", 1f);
        Invoke("SpawnEnemies", 1f);
    }

    void SpawnEnemies(){
        for (int i=0; i<rooms.Count; i++){
            SpawnGazer(rooms[i].transform.position);
            SpawnSkelet(rooms[i].transform.position);
        }
    }

    void SpawnExit(){
        Vector2 Pspawn = rooms[rooms.Count -1].transform.position;
        Pspawn.x = Pspawn.x + Random.Range(-4,4);
        Pspawn.y = Pspawn.y + Random.Range(-4,4);
        Instantiate(exit, Pspawn, Quaternion.identity);
    }

    void SpawnGazer(Vector2 position){
        Vector2 Pspawn = position;
        Pspawn.x = Pspawn.x + Random.Range(-4,4);
        Pspawn.y = Pspawn.y + Random.Range(-2,2);

        rand = Random.Range(0f,1f);
         if (rand > 0.75f){
            Instantiate(gazer, Pspawn, Quaternion.identity);
        }
    }

    void SpawnSkelet(Vector2 position){
        Vector2 Pspawn = position;
        Pspawn.x = Pspawn.x + Random.Range(-4,4);
        Pspawn.y = Pspawn.y + Random.Range(-4,4);

        rand = Random.Range(0f,1f);
         if (rand > 0.7f){
            Instantiate(skelet, Pspawn, Quaternion.identity);
        }
    }


    
}
 