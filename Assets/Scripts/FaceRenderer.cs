using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceRenderer : MonoBehaviour
{
    public GameObject obj;
    public GameObject face;
    private bool isVisible = true;
    private bool textureIsVisible = true;
    public RawImage img;

    public Texture textureS;
    public Texture textureT;
    public Texture textureF;

    private void Toggle(GameObject gameObject)
    {
        isVisible = !isVisible;
        gameObject.SetActive(isVisible);
    }

    private void ToggleTexture(GameObject gameObject){
        textureIsVisible = !textureIsVisible;
        gameObject.SetActive(textureIsVisible);
    }

    private void ChangeTexture(Texture newTexture)
    {
        if (img != null && newTexture != null)
        {
            img.texture = newTexture;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) Toggle(obj);
        if (Input.GetKeyDown(KeyCode.F)) ChangeTexture(textureF);
        if (Input.GetKeyDown(KeyCode.T)) ChangeTexture(textureT);
        if (Input.GetKeyDown(KeyCode.S)) ChangeTexture(textureS);

        if (Input.GetKeyDown(KeyCode.D)) ToggleTexture(face);
    }
}
