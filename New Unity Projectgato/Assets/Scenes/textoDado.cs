using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textoDado : MonoBehaviour
{
    Text text;
    public int tipo;
    public static int caraa;

    public static int caraa1;

    public static int caraa2;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tipo == 0)
            text.text = caraa.ToString();
        else if (tipo == 1)
            text.text = caraa1.ToString();
        else if (tipo == 2)
            text.text = caraa2.ToString();
    }
}
