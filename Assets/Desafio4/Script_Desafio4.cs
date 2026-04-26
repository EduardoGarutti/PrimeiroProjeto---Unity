using UnityEngine;

public class Script_Desafio4 : MonoBehaviour
{
    public int a, b, c;
    void Start()
    {
        if (a == b & a == c)
        {
            Debug.Log("É um triangulo equilátero! ");
        } else if(a == b & a!=c || b==c & b != a)
        {
            Debug.Log("É um triangulo isósceles");
        }else
        {
            Debug.Log("É um triangulo escaleno");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
