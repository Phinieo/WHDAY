using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Take a chocolate bar");
        m_oSceneManager.UpdateButton1Text("Take some gummy worms");
        m_oSceneManager.UpdateButton2Text("Don't take anything");
        m_oSceneManager.UpdateButton3Text("Take the whole thing and run!");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        m_oSceneManager.m_oScore.nGhost++;

        int randomValue = Random.Range(0, 2); // Generates either 0 or 1

        if (randomValue == 0)
        {
            m_oSceneManager.LoadNewScene("Raygun0");
        }
        else
        {
            m_oSceneManager.LoadNewScene("Apocalypse0");
        }
    }

    public void Button1Pressed()
    {
        m_oSceneManager.m_oScore.nJackOLantern++;

        int randomValue = Random.Range(0, 2); // Generates either 0 or 1

        if (randomValue == 0)
        {
            m_oSceneManager.LoadNewScene("Raygun0");
        }
        else
        {
            m_oSceneManager.LoadNewScene("Apocalypse0");
        }
    }

    public void Button2Pressed()
    {
        m_oSceneManager.m_oScore.nScarecrow++;

        int randomValue = Random.Range(0, 2); // Generates either 0 or 1

        if (randomValue == 0)
        {
            m_oSceneManager.LoadNewScene("Raygun0");
        }
        else
        {
            m_oSceneManager.LoadNewScene("Apocalypse0");
        }
    }

    public void Button3Pressed()
    {
        m_oSceneManager.m_oScore.nSkeleton++;

        int randomValue = Random.Range(0, 2); // Generates either 0 or 1

        if (randomValue == 0)
        {
            m_oSceneManager.LoadNewScene("Raygun0");
        }
        else
        {
            m_oSceneManager.LoadNewScene("Apocalypse0");
        }
    }

}
