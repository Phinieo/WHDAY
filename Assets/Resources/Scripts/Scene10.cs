using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene10 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Appreciate how giant everything around you is.");
        m_oSceneManager.UpdateButton1Text("Hanglide on a Dorito");
        m_oSceneManager.UpdateButton2Text("Eat as much of the giant candy as you can");
        m_oSceneManager.UpdateButton3Text("Chase the guy who shrunk you");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        m_oSceneManager.m_oScore.nJackOLantern++;
        m_oSceneManager.LoadNewScene("Raygun1");
    }

    public void Button1Pressed()
    {
        m_oSceneManager.m_oScore.nSkeleton++;
        m_oSceneManager.LoadNewScene("Raygun1");
    }

    public void Button2Pressed()
    {
        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.LoadNewScene("Raygun1");
    }

    public void Button3Pressed()
    {
        m_oSceneManager.m_oScore.nScarecrow++;
        m_oSceneManager.LoadNewScene("Raygun2");
    }

}
