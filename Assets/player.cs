using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    public float moveSpeed = 0.1f;
    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;

    public GameObject gameManager;

    Vector3 eggstartPos;
    Vector3 potatostartPos;

    // Use this for initialization
    void Start () {

        eggstartPos = GameObject.Find("eggplant").transform.position;
        potatostartPos = GameObject.Find("potato5").transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        if (Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
        
        if (transform.position.y < -2.47 && gameObject.name == "eggplant" && GameManager.instance.potatoscore < 2)
        {
            Debug.Log("potato score" + GameManager.instance.potatoscore);
            GameManager.instance.potatoscore++;
            transform.position = eggstartPos;
        }

        else if (transform.position.y < -2.47 && gameObject.name == "eggplant" && GameManager.instance.potatoscore >= 2)
        {
            Debug.Log("potato wins");
            SceneManager.LoadScene("game over");
        }

        if (transform.position.y < -2.47 && gameObject.name == "potato5" && GameManager.instance.eggscore < 2)
        {
            GameManager.instance.eggscore++;
            transform.position = potatostartPos; 
        }

        else if (transform.position.y < -2.47 && gameObject.name == "potato5" && GameManager.instance.eggscore >= 2)
        {
            SceneManager.LoadScene("eggwin");
        }
    }
}
