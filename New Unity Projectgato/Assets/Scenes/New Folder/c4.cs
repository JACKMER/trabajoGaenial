using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c4 : MonoBehaviour
{
    public int[] fila;
    private bool fin=false,oprimir=false;
    private int turno;
    private float timpo;
    public int[] ficha;
    private int gard;

    public GameObject[] fichaG;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Renderer>().material.color = Color.red;
        for (int x = 0; x < 6; x++)
        {
            for (int y = 0; y < 7; y++)
            {
                
                int p = (x * 7) + y;
                ficha[p] = 0;
                if ( p> 0)
                    fichaG[p] = Instantiate(fichaG[0], new Vector3(-5+(2*y), -3.17f+(1.7f*x), -.5f), transform.rotation);
            }
        }

        //fichaG[1].GetComponent<Renderer>().material.color = Color.red;
        //fichaG[1].GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void win()
    {
        //-----------------------------
        
    }
    // Update is called once per frame
    void Update()
    {
        timpo += Time.deltaTime;
        if (timpo > .5&& fin==false)
        {
            win();
            timpo = 0;
            if (turno == 0)
            {
                
                int con = Random.Range(0, 7);
                
                for (int sal = 1; sal < 3; sal++)
                {
                    if (fila[0] == 6 && fila[1] == 6 && fila[2] == 6 && fila[3] == 6 && fila[4] == 6 && fila[5] == 6 && fila[6] == 6)
                    {
                        sal = 9;
                    }
                    if (fila[con] < 6)
                    {
                        sal=9;
                    }
                    else if(fila[con]==6)
                    {
                        if (con > 0)
                            con--;
                        else
                            con = 6;

                        
                        
                    }
                     
                    sal--;
                }
                int p = (fila[con] * 7) + con;
                Debug.Log(p);
                ficha[p] = 1;
                fichaG[p].GetComponent<Renderer>().material.color = Color.red;
                fila[con]++;
                turno = 1;
            }
            else
            {
                if (oprimir == true)
                {
                    oprimir = false;
                    
                }
                
            }
        }
    }
    public void seleccionar(int tipo)
    {
        if (fila[tipo] < 6 && turno==1)
        {
            oprimir = true;
            int p = (fila[tipo] * 7) + tipo;
            ficha[p] = 2;
            fichaG[p].GetComponent<Renderer>().material.color = Color.yellow;
            fila[tipo]++;
            turno = 0;
        }
    }
    public void pon(int al,int filan)
    {
        
    }
}
