using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Haduken;
    public GameObject IceBalls;

    public GameObject player1Paddle;
    public GameObject player1Goal;

    public GameObject player2Paddle;
    public GameObject player2Goal;

    public GameObject Player1Text;
    public GameObject Player2Text;

    public bool Player1Ganhou = false;
    public bool Player2Ganhou = false;

    private int Player1Score;
    private int Player2Score;
    
    public void Player1Scored(){
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        if (Player1Score >= 10){
            Player1Ganhou = true;
        }
        ResetPosition();
    }
    public void Player2Scored(){
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        if (Player2Score >= 10){
            Player2Ganhou = true;
        }
        ResetPosition();
    }

    private void ResetPosition()
    {
        Haduken.GetComponent<Haduken>().Reset();
        IceBalls.GetComponent<IceBalls>().Reset();
        player1Paddle.GetComponent<PlayerMovement>().Reset();
        player2Paddle.GetComponent<PlayerMovement>().Reset();
    }
}
