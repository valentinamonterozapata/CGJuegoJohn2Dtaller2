using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    [SerializeField] private float velocidad = 2f;
    [SerializeField] private float distancia = 1f;
    [SerializeField] private Transform controladorPiso;
    [SerializeField] private LayerMask capaSuelo;
    [SerializeField] private bool moviendoDerecha = true;

    private Rigidbody2D rb;
    private int direccion = 1; // 1 = derecha, -1 = izquierda

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direccion = moviendoDerecha ? 1 : -1;
    }

    private void FixedUpdate()
    {
        // Raycast para verificar si hay suelo adelante
        RaycastHit2D infoSuelo = Physics2D.Raycast(controladorPiso.position, Vector2.down, distancia, capaSuelo);

        // Movimiento horizontal
        rb.velocity = new Vector2(velocidad * direccion, rb.velocity.y);

        // Si no hay suelo, girar
        if (!infoSuelo)
        {
            Girar();
        }
    }

    private void Girar()
    {
        direccion *= -1; // Cambiar direcci�n
        moviendoDerecha = !moviendoDerecha;
        transform.localScale = new Vector3(direccion, 1, 1); // Voltear sprite
    }

    private void OnDrawGizmos()
    {
        if (controladorPiso != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(controladorPiso.position, controladorPiso.position + Vector3.down * distancia);
        }
    }
}
