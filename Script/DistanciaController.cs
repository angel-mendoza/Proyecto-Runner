using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanciaController : MonoBehaviour {
    public float distanciaInicial;
    public Text texto;
	// Use this for initialization
	void Start () {
        distanciaInicial = 0;
	}
	
	// Update is called once per frame
	void Update () {
        distanciaInicial += Time.deltaTime;

	}

    public void RestaurarDistancia()
    {
        distanciaInicial = 0;
        texto.text = "" + Mathf.Round(distanciaInicial);
    }
}
