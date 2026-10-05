using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    Player player;
    TMP_Text distanceText;


    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<TMP_Text>();
    }

    void Start()
    {
        
    }

    void Update()
    {
       int distance = Mathf.FloorToInt(player.distance);
       distanceText.text = distance + " m";
    }
}
