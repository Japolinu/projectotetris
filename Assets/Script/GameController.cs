using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //do objeto
    public Text txtScore;
    public Text txtLevel;
    //da classe
    public static int Score = 0; //controla a pontuação
    public static int Level = 1; //controla o nível do jogo
    public static float Speed = 1f; //controla a velocidade do jogo

    //próximas aventuras
    public static int HighScore;
    public static string jogador;
    public static string email;
    public static string senha;

    //Atualiza o nivel do jogo após LinesUpdate
    public static int LinesUpdate = 10;
    //linhas destruidas para atualizar o nivel do jogo
    public static int LinesDestroyedUpdate;
    public static int LinesDestroyed; //linhas destruidas no total
    // Start is called before the first frame update
    void Start()
    {

    }
    public static void IncLinesDestroyed(int lines)
    {
        LinesDestroyed += lines;
        LinesDestroyedUpdate += lines;
        if (LinesDestroyedUpdate >= LinesUpdate) //LevelUp
        {
            GameController.LevelUP();
        }
    }
    public static void LevelUP()
    {
        Level++;
        if (Speed > 0.3f)
        {
            Speed = Speed - 0.1F;
        }
    }
    // Update is called once per frame
    void Update()
    {
        txtScore.text = "SCORE: " + GameController.Score;
        txtLevel.text = "LEVEL: " + GameController.Level;
    }


    // Incrementa o Score do jogo
    /// <summary>
    /// Incrementa o Score do jogo
    /// </summary>
    public static void IncScore(int LinhasDestruidas)
    {
        Score += 10 * LinhasDestruidas;
    }

    public static int GetScore()
    {
        return Score;
    }
}
