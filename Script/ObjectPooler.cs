using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {

    public GameObject objetoAgrupado;
    public int agrupadosCantidad;  
    List<GameObject> ObjetosAgrupados;

	// Use this for initialization
	void Start () {

        ObjetosAgrupados = new List<GameObject>();

        for (int i = 0;  i < agrupadosCantidad ; i++)
        {
            GameObject obj = (GameObject)Instantiate(objetoAgrupado);
            obj.SetActive(false);
            ObjetosAgrupados.Add(obj);
        }
	}
	
	public GameObject GetObjetosAgrupados()
    {
        for( int i = 0; i < ObjetosAgrupados.Count; i++)
        {
            if (!ObjetosAgrupados[i].activeInHierarchy)
            {
                return ObjetosAgrupados[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(objetoAgrupado);
        obj.SetActive(false);
        ObjetosAgrupados.Add(obj);
        return obj;

    }
}
