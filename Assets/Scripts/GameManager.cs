using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected GameObject mapa;
    [SerializeField] protected GameObject[] todosBotoes;
    //[SerializeField] protected GameObject todasCenas;
    [SerializeField] protected GameObject[] cenas;
    [SerializeField] protected GameObject[] icones;
    protected GameObject cenaAtual;
    public bool mapaAberto;
    public bool podeMover;
    public bool conversaAtiva;

    [SerializeField] Animator papel;
    


    public static GameManager instance;

    


    private void Awake()
    {
        instance = this;
    }

    protected void Update()
    {
        Mapa();
        LocalizaçãoNoMapa();
        
    }

    void LocalizaçãoNoMapa()
    {
        if (mapaAberto == true)
        {
            for (int i = 0; i < cenas.Length; i++)
            {
                if (cenas[i].activeSelf == true)
                {
                    icones[i].SetActive(true);
                }
                else
                {
                    icones[i].SetActive(false);
                }

            }
        }
    }

    void PegarItem()
    {

    }

    void Animaçao()
    {
        papel.SetTrigger("Ativar");
    }


    protected void Start()
    {
        podeMover = true;
        mapa.SetActive(false);
    }

    public void AtivaMov()
    {
        podeMover = true;
    }

    protected void Mapa()
    {
        if (mapa.activeSelf == true)
        {
            mapaAberto = true;
        }
        else if (mapa.activeSelf == false)
        {
            mapaAberto = false;
        }

        for (int i = 0; i < todosBotoes.Length; i++) 
        { 
            if (mapaAberto == false)
            {
                todosBotoes[i].SetActive(true);

            }
            else if (mapaAberto == true)
            {
                todosBotoes[i].SetActive(false);


            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (mapa.activeSelf == true)
            {
                mapa.SetActive(false);
                podeMover = true;
                mapaAberto = false;
                
                

            }
            else if (mapa.activeSelf == false)
            {
                mapa.SetActive(true);
                podeMover = false;
                mapaAberto = true;
                

            }

        }
    }

    

}
