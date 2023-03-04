using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateP : MonoBehaviour
{
    [SerializeField] public float vida;
    [SerializeField] public int moneda;
    [SerializeField] public float maximoVida;
    [SerializeField] public BarradeVida barra;
    // Start is called before the first frame update
    void Start()
    {
        moneda = 0;
        vida = maximoVida;
        barra.inicioBarradeVida(vida);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Guardar();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerData playerData = savedManager.LoadPlayerData();
            Debug.Log("Datos Guardados");
            moneda = playerData.monedas;
            vida = playerData.vidas;
            transform.position = new Vector3(playerData.position_player[0], playerData.position_player[1], playerData.position_player[2]);
            Debug.Log("Datos Cargados");

        }
    }

    // Update is called once per frame
    public void TomarDano(float dano)
    {
        vida -= dano;
        barra.VidaActual(vida);
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void contaMonedas(int money)
    {
        moneda += money;
    }
    public void Guardar()
    {
        savedManager.SavePlayerData(this);
        Debug.Log("Datos Guardados");
    }
}
