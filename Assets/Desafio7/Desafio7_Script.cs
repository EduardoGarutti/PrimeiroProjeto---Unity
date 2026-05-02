using UnityEngine;
using UnityEngine.UI;

public class Desafio7_Script : MonoBehaviour
{
    int recursos = 0;
    int valorClick = 1;
    public Text recursos_txt, valorClick_txt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        recursos = recursos + valorClick;
        recursos_txt.text = recursos.ToString();
    }

    public void powerUp(int upgrade)
    {
        if(recursos < upgrade)
        {
            Debug.Log("Falta "+ (upgrade - recursos) + " recusos para o seu upgrade!");
            return;
        }

        recursos -= upgrade;
        valorClick += (upgrade/10);
        recursos_txt.text = recursos.ToString();
        valorClick_txt.text = valorClick.ToString();
    }

    
}
