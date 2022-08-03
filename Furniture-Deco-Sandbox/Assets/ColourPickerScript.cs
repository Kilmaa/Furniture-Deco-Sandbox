using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPickerScript : MonoBehaviour
{
    public GameControlScript gc;

    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;

    // Use this for initialization
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WhiteColor()
    {
        gc.PlayClickSound();

        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }

    public void YellowGreenColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    public void DarkOrangeColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }

    public void DarkPinkColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;
    }

    public void GrayBlueColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[4];
        CurrMat = renderer.material;
    }

    public void MatchaGreenColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[5];
        CurrMat = renderer.material;
    }

    public void YamPurpleColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[6];
        CurrMat = renderer.material;
    }

    public void LightGrayColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[7];
        CurrMat = renderer.material;
    }

    public void BlackColor()
    {
        gc.PlayClickSound();
        
        renderer.material = BodyColorMat[8];
        CurrMat = renderer.material;
    }

}
