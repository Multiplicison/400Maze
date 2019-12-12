using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{

    //public Text countText;
    //public Text winText;

    //public int count;

    // Start is called before the first frame update
    void Start()
    {
        //SetCountText();
        //winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreSystem.count += 1;
            //SetCountText();
            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    /*void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 5)
        {
            winText.text = "You Win!";
        }
    }*/
}
