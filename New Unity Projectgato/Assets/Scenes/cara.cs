using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cara : MonoBehaviour
{
    

    private void OnTriggerStay(Collider other)
    {
        
            switch (other.gameObject.name)
            {
                case "d1":
                    textoDado.caraa = 1;
                    break;
                case "d2":
                    textoDado.caraa = 2;
                    break;
                case "d3":
                    textoDado.caraa = 3;
                    break;
                case "d4":
                    textoDado.caraa = 4;
                    break;
                case "d5":
                    textoDado.caraa = 5;
                    break;
                case "d6":
                    textoDado.caraa = 6;
                    break;
            }
        switch (other.gameObject.name)
        {
            case "w1":
                textoDado.caraa1 = 1;
                break;
            case "w2":
                textoDado.caraa1 = 2;
                break;
            case "w3":
                textoDado.caraa1 = 3;
                break;
            case "w4":
                textoDado.caraa1 = 4;
                break;
            case "w5":
                textoDado.caraa1 = 5;
                break;
            case "w6":
                textoDado.caraa1 = 6;
                break;
        }
        switch (other.gameObject.name)
        {
            case "q1":
                textoDado.caraa2 = 1;
                break;
            case "q2":
                textoDado.caraa2 = 2;
                break;
            case "q3":
                textoDado.caraa2 = 3;
                break;
            case "q4":
                textoDado.caraa2 = 4;
                break;
            case "q5":
                textoDado.caraa2 = 5;
                break;
            case "q6":
                textoDado.caraa2 = 6;
                break;
        }

    }
}
