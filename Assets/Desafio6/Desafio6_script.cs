using UnityEngine;

public class Desafio6_script : MonoBehaviour
{
    public int x, y, z;
    void Start()
    {
        Debug.Log(MaiorQueMil());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool MaiorQueMil()
    {
        if((x+y)*z > 1000)
        {
            return true;
        }
        return false;
    }
}
