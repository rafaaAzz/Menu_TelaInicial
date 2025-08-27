using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicialManager : MonoBehaviour
{
    [SerializeField] private string Inicio;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpçoes;

    public void Jogar()
    {
        SceneManager.LoadScene(Inicio);
    }

    public void AbrirOpçoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpçoes.SetActive(true);
    }

    public void FecharOpçoes()
    {
        painelOpçoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
