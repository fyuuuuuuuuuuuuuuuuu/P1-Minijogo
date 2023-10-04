using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Moeda_Text : MonoBehaviour
{
    public static Moeda_Text instance;

    public TMP_Text texto_Moeda;
    public int quantidade_atual = 0;
    // Start is called before the first frame update

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        texto_Moeda.text = quantidade_atual.ToString();
    }

    void Update()
    {
        if (quantidade_atual >= 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Aumenta_Valor(int valor)
    {
        quantidade_atual += valor;
        texto_Moeda.text =quantidade_atual.ToString() + "/8";
    }
    
}
