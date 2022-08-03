using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairScript : MonoBehaviour
{
    public GameObject chair;
    
    // Start is called before the first frame update
    void Start()
    {
        HideChair();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chairGone()
    {
        Destroy(gameObject);
    }

    public void ShowChair()
    {
        chair.SetActive(true);
    }

    public void HideChair()
    {
        chair.SetActive(false);
    }
}
