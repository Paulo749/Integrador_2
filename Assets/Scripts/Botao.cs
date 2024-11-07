using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

public class Botao : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject liberar;
    

    

    private void OnMouseDown()
    {
        if (!gameObject.CompareTag("Objetivo"))
        {
            obj.SetActive(true);
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Objetivo"))
        {
            obj.SetActive(false);
            liberar.SetActive(true);
            //GameManager.instance.AvançaHist();
        }
        else if (gameObject.CompareTag("Certa"))
        {
            Questoes.instance.AddAcerto();
            Questoes.instance.MudaQuestao();
        }
        





    }


}
