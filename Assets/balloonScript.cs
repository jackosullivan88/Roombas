using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class balloonScript : MonoBehaviour
{
    public string color;
    public GameObject redWins;
    public GameObject blueWins;
    //public Transform connectionPoint, connectionPoint2;
    public bool hasCollided = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //connectionPoint.position = connectionPoint2.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision");
        if (collision.gameObject.tag == "Hazard")
        {
            if (color == "Blue")
            {
                hasCollided = true;
                Destroy(gameObject);
                redWins.gameObject.SetActive(true);
                StartCoroutine(pauseGame(3000));
                SceneManager.LoadScene("SampleScene");

            }
            if (color == "Red")
            {
                hasCollided = true;
                Destroy(gameObject);
                blueWins.gameObject.SetActive(true);
                StartCoroutine(pauseGame(3000));
                SceneManager.LoadScene("SampleScene");

            }
        }
    }

    IEnumerator pauseGame(int time)
    {
        yield return new WaitForSeconds(time);
    }

}
