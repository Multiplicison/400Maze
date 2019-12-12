using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject winText;
    public static int count;
    public static bool winCheck = false;
    public int totalItems = 5;

    // Start is called before the first frame update
    void Start()
    {
        winText.GetComponent<Text>().text = "";
        winCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Count: " + count + "/" + totalItems;

        if(count >= totalItems)
        {
            winText.GetComponent<Text>().text = "You win!";
            winCheck = true;
        }
    }
}
