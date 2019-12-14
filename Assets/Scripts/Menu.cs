using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject panelCredits;

    private float velTransition = 10000f;

    private bool credits = false;

    private float posPanelCredit;

    // Start is called before the first frame update
    void Start()
    {
        posPanelCredit = panelCredits.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (credits && (transform.position.x +50) <panelCredits.transform.position.x)
        {

            panelCredits.transform.Translate(Vector3.left * Time.deltaTime * velTransition);

        }

        if (!credits && posPanelCredit > panelCredits.transform.position.x)
        {

            panelCredits.transform.Translate(Vector3.right * Time.deltaTime * velTransition);

        }
    }

    public void Play()
    {

        SceneManager.LoadScene("Map");

    }

    public void Credits()
    {

        credits = true;

    }

    public void Back()
    {

        credits = false;

    }

    public void Exit()
    {

        Application.Quit();

    }


}
