using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Desafio8_script : MonoBehaviour
{
    public InputField nome_jogador,par_impar, n_jogador;
    public Text n_pc_txt, vencedor_txt;
    bool par;

    public void click()
    {
        if(par_impar.text.ToLower() == "par")
        {
            par = true;
        } else
        {
            par = false;
        }

        int.TryParse(n_jogador.text, out int nmr);

        int n_pc = sortear();
        n_pc_txt.text = n_pc.ToString();

        vencedor(nmr, n_pc);

    }

    int sortear()
    {
        return Random.Range(0, 100);
    }
    void vencedor(int n1 , int n2)
    {
        int resultado = n1 + n2;
        if (par)
        {
            if(resultado % 2 == 0)
            {
                alterar_Texto(nome_jogador.text + " Venceu!", resultado);
            }
            else
            {
                alterar_Texto("Pc Venceu!", resultado);
            }
        }
        else
        {
            if (!(resultado % 2 == 0))
            {
                alterar_Texto(nome_jogador.text+" Venceu!", resultado);
            }
            else
            {
                alterar_Texto("PC Venceu!", resultado);
            }
        }
    }

    void alterar_Texto(string texto, int resultado)
    {
        vencedor_txt.text = "Resultado = "+ resultado+ "\n"+ texto;
    }
}
