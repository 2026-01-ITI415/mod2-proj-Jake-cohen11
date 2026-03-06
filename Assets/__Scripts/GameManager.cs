using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI scoreText;

    int score = 0;
    public int level = 1;
    public int pointsPerLevel = 2500;

    public TextMeshProUGUI levelText;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
        //UpdateScore();
        CheckLevelUp();
    }

    void CheckLevelUp()
    {
        int newLevel = score / pointsPerLevel + 1;

        if (newLevel > level)
        {
            level = newLevel;
            LevelUp();
        }
    }

    void LevelUp()
    {
        levelText.text = "Level: " + level;

        Enemy.speedMultiplier *= 1.15f;
    }
}
