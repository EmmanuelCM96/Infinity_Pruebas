using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarradeVida : MonoBehaviour
{
    private Slider slider2;
    // Start is called before the first frame update
    private void Start()
    {
        slider2 = GetComponent<Slider>();
    }

    // Update is called once per frame
    public void VidaMaxima(float vidaMaxima)
    {
        slider2.maxValue = vidaMaxima;

    }
    public void VidaActual(float cantidadVida)
    {
        slider2.value = cantidadVida;
    }
    public void inicioBarradeVida(float cantidadVida)
    {
        VidaMaxima(cantidadVida);
        VidaActual(cantidadVida);
    }
}
