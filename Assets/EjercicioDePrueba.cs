using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDePrueba : MonoBehaviour
{
    public float montoTotal;
    public string letra;
   
    // Start is called before the first frame update
    void Start()
    {
        float euros = montoTotal/220;
        float dolares = montoTotal/200;
        float reales = montoTotal/40;
        if (montoTotal < 1000 )
        {
            Debug.Log ("“El monto mínimo es $1000");
        }
        else if (montoTotal >= 1000)
        {
            switch (letra)
            {
                case "D":
                    Debug.Log($" {montoTotal} pesos argentinos equivalen a {dolares} dolares");
                    break;
                case "R":
                    Debug.Log($" {montoTotal} pesos argentinos equivalen a {reales} reales");
                    break;
                case "E":
                    Debug.Log( $" {montoTotal} pesos argentinos equivalen a {euros} euros");
                    break;
                default:
                    Debug.Log("opcion de moneda extranjera no valida");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
