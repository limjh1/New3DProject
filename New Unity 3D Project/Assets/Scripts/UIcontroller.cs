using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        scoreText.GetComponent<Text>().text = "Score : " + player.GetComponent<Transform>().position.z.ToString("N2");
    }
}
