using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrullar : MonoBehaviour
{

    [SerializeField] private float velocidadmovimiento;
    [SerializeField] private Transform[] puntosPatrullaje;
    [SerializeField] private float distanciaminima;
    private int numaletorio;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        numaletorio = Random.Range(0, puntosPatrullaje.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosPatrullaje[numaletorio].position, velocidadmovimiento * Time.deltaTime);

        if (Vector2.Distance(transform.position, puntosPatrullaje[numaletorio].position) < distanciaminima)
        {
            numaletorio++;
            if (numaletorio >= puntosPatrullaje.Length)
            {
                numaletorio = Random.Range(0, puntosPatrullaje.Length);
                girar();//girar
            }
        }
    }

    private void girar()
    {
        if (transform.position.x < puntosPatrullaje[numaletorio].position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
