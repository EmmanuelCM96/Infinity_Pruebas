using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borrador : MonoBehaviour
{
    private GameObject jugador;

    private void Start()
    {
        //jugador = GameObject.FindGameObjectWithTag("Borrar");
    }
    private void Update()
    {
        jugador = GameObject.FindGameObjectWithTag("Borrar");
    }
    // Start is called before the first frame update
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Borrar")
        {
            Debug.Log("otra vez medio funciona");
            Destroy(jugador, .01f);
        }
    }
}
