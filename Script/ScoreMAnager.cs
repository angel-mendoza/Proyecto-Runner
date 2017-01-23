using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMAnager : MonoBehaviour {
    public Text puntos;
    public Text mejorPuntos;
    public float puntosContador;
    public float MejorPuntosContador;

    public float puntosPorSegundo;
    public bool puntajeCreciente;
	// Use this for initialization
	void Start () {
	if(PlayerPrefs.HasKey("mejorPuntuacion"))
        {
            MejorPuntosContador = PlayerPrefs.GetFloat("mejorPuntuacion");
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (puntajeCreciente)
        {
            puntosContador += Time.deltaTime;
        }
        
        if(puntosContador > MejorPuntosContador)
        {
            MejorPuntosContador = puntosContador;
            PlayerPrefs.SetFloat("mejorPuntuacion", MejorPuntosContador);
        }
        puntos.text = "" + Mathf.Round(puntosContador);
        mejorPuntos.text = "" + Mathf.Round(MejorPuntosContador);
	}
}
