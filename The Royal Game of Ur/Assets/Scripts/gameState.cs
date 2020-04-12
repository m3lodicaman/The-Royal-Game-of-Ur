using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class gameState
{
    public static int playerTurn;
    public static playerBehaviour bluePlayer;
    public static playerBehaviour redPlayer;

    public static playerBehaviour GetCurrentPlayer()
    {
        if(playerTurn == 0)
        {
            return redPlayer;
        }
        else
        {
            return bluePlayer;
        }
    }
}
