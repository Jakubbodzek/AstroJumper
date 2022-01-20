using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI myText;
    public int score = 0;

    public void Start()
    {
        myText.text = "Score: 0";
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            myText.text = "Score: " + ++score;
            Destroy(other.gameObject);
        }
    }
}
