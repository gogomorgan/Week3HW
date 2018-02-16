using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public int eggscore = 0;
    public int potatoscore = 0;

    // Use this for initialization
    void Start()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            instance.eggscore = 0;
            instance.potatoscore = 0;

            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
    
