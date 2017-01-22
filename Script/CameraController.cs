using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public PlayerController player;

    private Vector3 ultimaPosicionDelPlayer;
    private float distanciaQueSeMueve;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        ultimaPosicionDelPlayer = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        distanciaQueSeMueve = player.transform.position.x - ultimaPosicionDelPlayer.x;
        transform.position = new Vector3(transform.position.x + distanciaQueSeMueve, transform.position.y, transform.position.z);
        ultimaPosicionDelPlayer = player.transform.position;
	}
}
