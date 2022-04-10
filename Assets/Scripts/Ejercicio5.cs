using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public int num1;
    public int num2;
    int num3;

    void Start()
    {
        if (num1 == 0 || num2 == 0)
        {
            Debug.Log("No se puede dividir por 0");
        }

        else
        {
            num3 = num1 / num2;
            Debug.Log($"{num1}/{num2} = {num3}");
        }
    }

    
}
