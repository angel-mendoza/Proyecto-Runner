using UnityEngine;
using System.Collections;

public class PlataformaDestructor : MonoBehaviour {

    public GameObject PuntoDeDestruccion;

	// Use this for initialization
	void Start () {
        PuntoDeDestruccion = GameObject.Find("PuntoDeDestruccionDePlataforma");
	}
	
	// Update is called once per frame
	void Update () {
	
        if (transform.position.x < PuntoDeDestruccion.transform.position.x)
        {
           Destroy(gameObject);
           
        }
	}
}
