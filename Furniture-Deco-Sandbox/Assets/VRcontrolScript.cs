using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRcontrolScript : MonoBehaviour
{
    private int itemAmount;
    private Text scoreText;
    public GameObject chairPrefab;

    // Start is called before the first frame update
    void Start()
    {
        itemAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "" + itemAmount;
        }
    }

    void SpawnCupboard()
    {
        Vector3 spawnPos = new Vector3(0, 0, 1);
        //Vector3 positionRelativeToPlayer; 
        //this.transform.position = player.TransformPoint(positionRelativeToPlayer)
        GameObject newChair = Instantiate(chairPrefab, spawnPos, Quaternion.identity);
        chairPrefab.transform.Rotate(0,180,0);
        itemAmount = itemAmount + 1;
    }
}
