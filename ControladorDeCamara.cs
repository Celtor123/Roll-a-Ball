using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeCamara : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame later of the movement of the camara
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
