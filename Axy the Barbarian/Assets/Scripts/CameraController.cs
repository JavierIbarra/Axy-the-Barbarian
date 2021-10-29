using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 offset;

	void Start () {
		if (jugador != null){
			offset = transform.position - jugador.transform.position;
		}
		
	}
	
	void LateUpdate () {
		if (jugador == null){
			jugador = GameObject.Find("Player(Clone)");
			transform.position = new Vector3 (jugador.transform.position.x, jugador.transform.position.y, -10);
			offset = transform.position - jugador.transform.position;
		}
		else{
			transform.position = jugador.transform.position + offset;
		}
		
	}
}
