using UnityEngine;
using System.Collections;

public class GameMAnager : MonoBehaviour {

    public Transform generadorDePlataforma;
    private Vector3 puntoDeLaPlataformaDeSalida;
    public PlayerController Player;
    private Vector3 puntoDeSalidaDelJugador;
    private PlataformaDestructor[] plataformaLista;

	// Use this for initialization
	void Start () {
        puntoDeLaPlataformaDeSalida = generadorDePlataforma.position;
        puntoDeSalidaDelJugador = Player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ReiniciarJuego()
    {
        StartCoroutine("ReiniciarJuegoCo");
    }

    public IEnumerator ReiniciarJuegoCo()
    {
        Player.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        plataformaLista = FindObjectsOfType<PlataformaDestructor>();
        for (int i= 0; i < plataformaLista.Length; i++)
        {
            plataformaLista[i].gameObject.SetActive(false);
        }
        Player.transform.position = puntoDeSalidaDelJugador;
        generadorDePlataforma.position = puntoDeLaPlataformaDeSalida;
        Player.gameObject.SetActive(true);
    }
}
