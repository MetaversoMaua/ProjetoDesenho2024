using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageSwitcher : MonoBehaviour
{

    public RawImage[] images; // Array de RawImages que serão trocadas
    public TextMeshProUGUI[] texts; // Array de TextMeshProUGUI que serão trocadas
    public KeyCode switchKey = KeyCode.R; // Tecla para trocar as imagens

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < images.Length; i++)
        {
            images[i].gameObject.SetActive(false); // Desativar todas as imagens, menos a primeira
        }

        for (int i = 1; i < texts.Length; i++)
        {
            texts[i].gameObject.SetActive(false); // Desativar todos os textos, menos o primeiro
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchKey)) // Reconhece a tecla pressionada
        {
            SwitchImageAndText(); // Função para trocar a imagem
        }
    }

    void SwitchImageAndText()
    {
        images[currentIndex].gameObject.SetActive(false); // Desativar a imagem atual
        texts[currentIndex].gameObject.SetActive(false); // Desativar o texto atual

        currentIndex = (currentIndex + 1) % images.Length; // Atualizar o índice para a próxima imagem

        images[currentIndex].gameObject.SetActive(true); // Ativar a próxima imagem
        texts[currentIndex].gameObject.SetActive(true); // Ativar o próximo texto
    }
}