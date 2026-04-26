using UnityEngine;

public class Teste : MonoBehaviour
{

    string str = "Ola mundo";

    public int a = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = a + 22;

        Debug.Log(str +" " +  x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
