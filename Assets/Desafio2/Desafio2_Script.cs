using Unity.VisualScripting;
using UnityEngine;

public class Desafio2_Script : MonoBehaviour
{
    public int n1, n2, n3;
    int maior;

   
    void Start()
    {
        maior = n1;
        if (maior < n2)
        {
            maior = n2;
        }
        if (maior < n3)
        {
            maior = n3;
        }

        Debug.Log("o maior numero é: " + maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
