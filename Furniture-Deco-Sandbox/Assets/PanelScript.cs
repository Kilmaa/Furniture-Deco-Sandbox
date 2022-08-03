using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    private Canvas canvas = null;
    private MenuManagerScript menuManager = null;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup(MenuManagerScript menuManager)
    {
        this.menuManager = menuManager; 
        Hide();
    }

    public void Show()
    {
        canvas.enabled = true; 
    }

    public void Hide()
    {
        canvas.enabled = false; 
    }
}
