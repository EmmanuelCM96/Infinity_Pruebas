using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject[] Mesa;
    public Transform instanciar;
    public float distancia;
    public Transform jugador;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        if (Vector2.Distance(jugador.position, instanciar.position) < distancia)
        {
            int numeroAleatorio = Random.Range(0, Mesa.Length);
            Instantiate(Mesa[numeroAleatorio]);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
