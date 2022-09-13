using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dado : MonoBehaviour
{
    public int tipo;
    static Rigidbody rb;
    public static Vector3 velcidadDado;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velcidadDado = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tipo == 0)
            {
                transform.position = new Vector3(0, 5, 0); textoDado.caraa = 0;
                textoDado.caraa1 = 0;
                textoDado.caraa2 = 0;
                float dX = Random.Range(0, 360);
                float dy = Random.Range(0, 360);
                float dz = Random.Range(0, 360);



                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50);
                ///rb.AddForce(transform.forward * 120);
                rb.AddTorque(dX, dy, dz);
            }
            else if (tipo == 1)
            {
                transform.position = new Vector3(3, 5, 0); textoDado.caraa = 0;
                textoDado.caraa1 = 0;
                textoDado.caraa2 = 0;
                float dX = Random.Range(0, 360);
                float dy = Random.Range(0, 360);
                float dz = Random.Range(0, 360);



                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50);
                rb.AddForce(transform.forward * 120);
                rb.AddTorque(dX, dy, dz);
            }
            else if (tipo == 2)
            {
                transform.position = new Vector3(-3, 5, 0); textoDado.caraa = 0;
                textoDado.caraa1 = 0;
                textoDado.caraa2 = 0;
                float dX = Random.Range(0, 360);
                float dy = Random.Range(0, 360);
                float dz = Random.Range(0, 360);



                transform.rotation = Quaternion.identity;
                rb.AddForce(transform.up * 50);
                rb.AddForce(transform.forward * 120);
                rb.AddTorque(dX, dy, dz);
            }
            
        }
    }
}
