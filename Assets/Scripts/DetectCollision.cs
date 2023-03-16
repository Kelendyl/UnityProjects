using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    private Text scoreText;
    private Text gameOverText;
    private GameObject spawner;
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Spawner");
        
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text= score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Fish")
        {
            Destroy(target.gameObject);
            score++;
            scoreText.text = score.ToString();
        }

        if (target.tag == "Bomb")
        {
            Destroy(target.gameObject);
            spawner.SetActive(false);
            SceneManager.LoadScene("GameOverScene");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
