using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float velocidad;
    public float fuerza;
    public bool tocandoSuelo;
    public LayerMask queEsSuelo;
    public float radioCheckSuelo;
    public Transform checkSuelo;
    public bool dobleSalto;

    private Collider2D myCollider;
    private Rigidbody2D RB;
    private Animator anim;

	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
       
	}
	
	// Update is called once per frame
	void Update () {
        //tocandoSuelo = Physics2D.IsTouchingLayers(myCollider, queEsSuelo);
        tocandoSuelo = Physics2D.OverlapCircle(checkSuelo.position, radioCheckSuelo, queEsSuelo);

        RB.velocity = new Vector2(velocidad, RB.velocity.y);

        if (tocandoSuelo)
        {
            dobleSalto = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && tocandoSuelo)
        {
            Salto();
        }
        if(Input.GetKeyDown(KeyCode.Space) && !dobleSalto && !tocandoSuelo)
        {
            Salto();
            dobleSalto = true;
        }

        anim.SetFloat("Velocidad", RB.velocity.x);
        anim.SetBool("Suelo", tocandoSuelo);
    }

    public void Salto()
    {
        RB.velocity = new Vector2(RB.velocity.x, fuerza);
    }
}
