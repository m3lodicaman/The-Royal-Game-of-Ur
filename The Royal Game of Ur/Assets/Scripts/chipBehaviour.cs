using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chipBehaviour : MonoBehaviour
{
    [SerializeField] private int chipPlayer;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetSelectedChip()
    {
        if(chipPlayer == gameState.playerTurn)
        {
            gameState.GetCurrentPlayer().SetSelectedChip(gameObject);
        }
    }
}
