using UnityEngine;

public class Desafio5_Script : MonoBehaviour
{
    public string jogador_1, jogador_2;
    public int n1, n2;

    public bool jogador_1_par = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (jogador_1_par)
        {
            if (e_par())
            {
                print(jogador_1);
            }
            else
            {
                print(jogador_2);
            }
        }
        else
        {
            if (!e_par())
            {
                print(jogador_1);
            }
            else
            {
                print(jogador_2);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        bool e_par()
        {
            if ((n1 + n2) % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void print(string jogador)
        {
            Debug.Log("Jogador: " + jogador + " ganhou!");
        }
    }
}
