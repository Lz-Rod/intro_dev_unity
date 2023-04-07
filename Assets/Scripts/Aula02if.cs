using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula02if : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (8 > 9)
        {
            Debug.Log("Condição verdadeira!");
        }
        else if (7 > 9)
        {
            Debug.Log("Condição verdadeira!");
        }
        else
        {
            Debug.Log("Condição falsa!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
