using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolController : MonoBehaviour
{
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    bool estarAlerta;
    public Transform jugador;
    public float velocidad;

    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);

        if (estarAlerta == true)
        {
            //transform.LookAt(jugador);
            Vector3 posJugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            transform.LookAt(posJugador);
            transform.position = Vector3.MoveTowards
                (transform.position, posJugador
                , velocidad * Time.deltaTime);

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }

    [Header("Animation")]
    [SerializeField]
    Animation animator;
}
