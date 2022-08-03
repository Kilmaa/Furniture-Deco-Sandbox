using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerScript : MonoBehaviour
{
    public PanelScript currentPanel = null;

    private List<PanelScript> panelHistory = new List<PanelScript>();

    // Start is called before the first frame update
    void Start()
    {
        SetupPanels();
    }

    // Update is called once per frame
    void Update()
    {
        GoToPrevious();
    }

    private void SetupPanels()
    {
        PanelScript[] panels = GetComponentsInChildren<PanelScript>();

        foreach(PanelScript panel in panels)
            panel.Setup(this);
        
        currentPanel.Show();
    }

    public void GoToPrevious()
    {
        int lastIndex = panelHistory.Count - 1;
        SetCurrent(panelHistory[lastIndex]);
        panelHistory.RemoveAt(lastIndex);
    }

    public void SetCurrentWithHistory(PanelScript newPanel)
    {
        panelHistory.Add(currentPanel);
        SetCurrent(newPanel);
    }

    private void SetCurrent(PanelScript newPanel)
    {
        currentPanel.Hide();

        currentPanel = newPanel;
        currentPanel.Show();
    }
}
