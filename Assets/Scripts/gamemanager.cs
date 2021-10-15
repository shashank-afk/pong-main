using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public uniball ball;

    private int playerscore;
    
    private int computerscore;

    public void playerscores()
    {
        playerscore++;
        this.ball.resetpostion();
    }

    public void computerscores()
    {
        computerscore++;
        this.ball.resetpostion();
    }
}
