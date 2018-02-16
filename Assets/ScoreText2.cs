using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText2 : MonoBehaviour {

    TextMesh mytext;

    // Use this for initialization
    void Start()
    {

        mytext = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {

        mytext.text = "score: " + GameManager.instance.eggscore;
    }
}
