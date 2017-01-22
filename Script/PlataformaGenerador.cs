using UnityEngine;
using System.Collections;

public class PlataformaGenerador : MonoBehaviour {

    //public GameObject plataforma;
    public Transform puntoDeGeneracion;
    public float distanciaEntrePlataformas;

    public float distanciaEntrePlataformaMinima;
    public float distanciaEntrePlataformaMaxima;
    public GameObject[] laPlataforma;

    private int selectorDePlataforma;
    private float[] anchoDePlataforma;

    private float alturaMinima;
    public Transform puntoAlturaMaxima;
    private float alturaMaxima;
    public float maximaAlturaCambiante;
    private float alturaCambiante;

    //public ObjectPooler theObjectPooler;

    // Use this for initialization
    void Start () {
        anchoDePlataforma = new float[laPlataforma.Length];
	
        for( int i = 0; i < laPlataforma.Length; i++)
        {
            anchoDePlataforma[i] = laPlataforma[i].GetComponent<BoxCollider2D>().size.x;
        }

        alturaMinima = transform.position.y;
        alturaMaxima = puntoAlturaMaxima.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < puntoDeGeneracion.position.x)
        {

            distanciaEntrePlataformas = Random.Range(distanciaEntrePlataformaMinima, distanciaEntrePlataformaMaxima);

            selectorDePlataforma = Random.Range(0, laPlataforma.Length);

            alturaCambiante = transform.position.y + Random.Range(maximaAlturaCambiante, -maximaAlturaCambiante);
            if (alturaCambiante > alturaMaxima)
            {
                alturaCambiante = alturaMaxima;
            }else if (alturaCambiante < alturaMinima)
            {
                alturaCambiante = alturaMinima;
            }
            transform.position = new Vector3(transform.position.x + distanciaEntrePlataformas + anchoDePlataforma[selectorDePlataforma], alturaCambiante, transform.position.z);

             Instantiate(laPlataforma[selectorDePlataforma], transform.position, transform.rotation);
        }
	
	}
}
