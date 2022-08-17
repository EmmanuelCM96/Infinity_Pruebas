using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateP : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarradeVida barra;
    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;
    }

    // Update is called once per frame
    public void TomarDaño(float daño)
    {
        vida -= daño;
        barra.VidaActual(vida);
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
