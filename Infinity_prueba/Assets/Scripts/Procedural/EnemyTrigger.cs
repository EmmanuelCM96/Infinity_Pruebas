using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public GameObject[] objetos;
    public float xo, xf;
    public float zo = 1, zf = 15;
    public int room;
    private void Update()
    {
        
       
    }
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i <= 10; i++) {
            int numeroAleatorio = Random.Range(0, objetos.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(xo,xf), 0 , Random.Range(zo,zf));
            Instantiate(objetos[numeroAleatorio],randomSpawnPosition,Quaternion.identity);
                }
        zo += 34;
        zf += 34;
    }
   
}
