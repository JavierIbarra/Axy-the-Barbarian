using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openSide;

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn",0.1f);
    }

    void Spawn(){
        if (spawned == false){
            if (openSide == 1){
                rand = Random.Range(0,templates.bottonRooms.Length);
                Instantiate(templates.bottonRooms[rand], transform.position, templates.bottonRooms[rand].transform.rotation);
            }
            else if (openSide == 2){
                rand = Random.Range(0,templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
            }
            else if (openSide == 3){
                rand = Random.Range(0,templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
            }
            else if (openSide == 4){
                rand = Random.Range(0,templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
            }
            spawned = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("SpawnPoint")){
            Destroy(gameObject);
            /*
            if (other.GetComponent<RoomSpawner>().spawned == false && spawned == false){
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
            */
        }
    }
}
