using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //All text functions moved to ScoreSystem.cs and Collectable.cs

    /*public Text countText;
    public Text winText;

    private int count;*/

    // Start is called before the first frame update
    void Start()
    {
        /*SetCountText();
        winText.text = "";*/
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var health = this.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(10);
            }
        }
    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }*/

    /*void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 2)
        {
            winText.text = "You Win!";
        }
    }*/
}
