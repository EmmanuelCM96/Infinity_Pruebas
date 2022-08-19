using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    LayerMask mask;
    public float distancia = 5f;
    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("ray");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.green);
        if (Physics.Raycast(transform.position,Vector3.forward, out hit, distancia, mask))
        {
            
            if (hit.collider.tag == "select")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<CombateP>().Guardar();
                }

            }
        }
    }
}
