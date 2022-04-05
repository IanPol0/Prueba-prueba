//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.
//Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) 
//y cuál es el monto del total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas 
//y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public string Nombre1;
    public float CapitalAportado1;
    public string Nombre2;
    public float CapitalAportado2;
    public string Nombre3;
    public float CapitalAportado3;

    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    float Total;

    // Start is called before the first frame update
    void Start()
    {
        Total = CapitalAportado1 + CapitalAportado2 + CapitalAportado3;

        porcentaje1 = (CapitalAportado1 % Total);
        porcentaje2 = (CapitalAportado2 % Total);
        porcentaje3 = (CapitalAportado3 % Total);

        Debug.Log("Nombre: " + Nombre1 + " capital aportado: $" + CapitalAportado1 + " , Porcentaje del capital: " + porcentaje1 + "% , Monto total aportado: $" + Total);
        Debug.Log("Nombre: " + Nombre2 + " capital aportado: $" + CapitalAportado2 + " , Porcentaje del capital: " + porcentaje2 + "% , Monto total aportado: $" + Total);
        Debug.Log("Nombre: " + Nombre3 + " capital aportado: $" + CapitalAportado3 + " , Porcentaje del capital: " + porcentaje3 + "% , Monto total aportado: $" + Total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
