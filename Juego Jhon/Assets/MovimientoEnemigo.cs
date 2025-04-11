using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    [SerializeField] private float velocidad = 2f;
    [SerializeField] private float distancia = 1f;
    [SerializeField] private Transform controladorPiso;
    [SerializeField] private Transform controladorPiso2;
    [SerializeField] private LayerMask capaSuelo;
    [SerializeField] private bool moviendoDerecha = true;
    [SerializeField] private Transform jugador; 

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
        RaycastHit2D infoSuelo2 = Physics2D.Raycast(controladorPiso2.position, Vector2.down, distancia, capaSuelo);
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
        moviendoDerecha = !moviendoDerecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        velocidad *= -1; // Cambiar la dirección de la velocidad
    }

    private void OnDrawGizmos()
    {
        if (controladorPiso != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(controladorPiso.position, controladorPiso.position + Vector3.down * distancia);
            Gizmos.DrawLine(controladorPiso2.position, controladorPiso2.position + Vector3.down * distancia);
        }
    }
}
