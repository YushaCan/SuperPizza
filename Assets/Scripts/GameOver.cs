using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameOver : MonoBehaviour
{
    private int highScore = 0;
    public Animator highScoreAnimator;
    public TextMeshProUGUI highScoreText;
    public static int healths;
    public static bool gainHealth = false;
    public static bool loseHealth = false;
    public static bool gameOver = false;
    public Image pizzaSlice3;
    public Image pizzaSlice2;
    public Image pizzaSlice1;
    // Empty Slices
    public Image emptyPizzaSlice3;
    public Image emptyPizzaSlice2;
    public Image emptyPizzaSlice1;
    public GameObject gameOverUI;
    void Start()
    {
        highScoreAnimator.SetBool("HighScore", false);
        healths = 3;
        gameOver = false;
    }
    void Update()
    {
        if(healths == 2 && loseHealth)
        {
            pizzaSlice3.gameObject.SetActive(false);
            emptyPizzaSlice3.gameObject.SetActive(true);
            loseHealth = false;
        }
        if (healths == 1 && loseHealth)
        {
            pizzaSlice2.gameObject.SetActive(false);
            emptyPizzaSlice2.gameObject.SetActive(true);
            loseHealth = false;
        }
        if (healths == 3 && gainHealth)
        {
            pizzaSlice3.gameObject.SetActive(true);
            emptyPizzaSlice3.gameObject.SetActive(false);
            gainHealth = false;
        }
        if (healths == 2 && gainHealth)
        {
            pizzaSlice2.gameObject.SetActive(true);
            emptyPizzaSlice2.gameObject.SetActive(false);
            gainHealth = false;
        }

        if (healths == 0)
        {
            pizzaSlice1.gameObject.SetActive(false);
            emptyPizzaSlice1.gameObject.SetActive(true);
            gameOver = true;
            Cursor.visible = true;
            //GAME OVER SCREEN
            gameOverUI.gameObject.SetActive(true);
            // If player never played this game 
            // For initialize high score
            if(PlayerPrefs.GetInt("High Score", 0) == 0)
            {
                highScoreAnimator.SetBool("HighScore", true);
                highScoreText.text = "High Score: " + ScoreManager.score;
                highScore = ScoreManager.score;
                PlayerPrefs.SetInt("High Score", highScore);
            }
            else if (ScoreManager.score > PlayerPrefs.GetInt("High Score", 0))
            {     
                PlayerPrefs.SetInt("High Score", ScoreManager.score);
                highScoreText.text = "High Score: " + ScoreManager.score;
                // CONGRATS TO NEW HIGH SCORE
                highScoreAnimator.SetBool("HighScore", true);
            }
            else if (ScoreManager.score < PlayerPrefs.GetInt("High Score", 0))
            {
                highScoreText.text = "High Score: " + PlayerPrefs.GetInt("High Score", 0);
            }

        }
    }
}