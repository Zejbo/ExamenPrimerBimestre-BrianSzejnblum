using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDePrueba : MonoBehaviour
{
    public int montoTotal;
    public string letra;
   
    // Start is called before the first frame update
    void Start()
    {
        int euros = montoTotal/220;
        int dolares = montoTotal/200;
        int reales = montoTotal/40;
        if (montoTotal < 1000 )
        {
            Debug.Log ("“El monto mínimo es $1000");
        }
        else if (montoTotal >= 1000)
        {
            switch(letra)
            {
                case "D":
                    Debug.Log("Tenes " + dolares + " dolares");
                    break;
                case "R":
                    Debug.Log("Tenes " + reales + " reales");
                    break;
                case "E":
                    Debug.Log("Tenes " + euros + "  euros");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
