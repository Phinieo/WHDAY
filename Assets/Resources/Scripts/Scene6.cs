using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Keep going");
        m_oSceneManager.UpdateButton1Text("Turn around");
        m_oSceneManager.UpdateButton2Text("Start leaving a candy trail");
        m_oSceneManager.UpdateButton3Text("Stay put");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        m_oSceneManager.m_oScore.nScarecrow++;
        m_oSceneManager.LoadNewScene("Castle0");
    }

    public void Button1Pressed()
    {
        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.LoadNewScene("LeafPile0");
    }

    public void Button2Pressed()
    {
        m_oSceneManager.m_oScore.nSkeleton++;
        m_oSceneManager.LoadNewScene("Woods1");
    }

    public void Button3Pressed()
    {
        m_oSceneManager.m_oScore.nJackOLantern++;
        m_oSceneManager.LoadNewScene("Woods2");
    }

}
