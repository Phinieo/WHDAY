using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene10_2 : MonoBehaviour, SceneScript
{

    SceneManager m_oSceneManager;

    // Start is called before the first frame update
    void Start()
    {

        m_oSceneManager = GameObject.Find("GameManager").GetComponent<SceneManager>();

        m_oSceneManager.UpdateButton0Text("Make a catapult to launch candy at him");
        m_oSceneManager.UpdateButton1Text("Tie his shoelaces together");
        m_oSceneManager.UpdateButton2Text("Tickle his ankles");
        m_oSceneManager.UpdateButton3Text("Give up");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button0Pressed()
    {
        m_oSceneManager.m_oScore.nScarecrow++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.UpdateContinueButtonText("Continue...");
        m_oSceneManager.LoadNewScene("ReBigged0");
    }

    public void Button1Pressed()
    {
        m_oSceneManager.m_oScore.nSkeleton++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.UpdateContinueButtonText("Continue...");
        m_oSceneManager.LoadNewScene("ReBigged0");
    }

    public void Button2Pressed()
    {
        m_oSceneManager.m_oScore.nJackOLantern++;
        m_oSceneManager.LoadNewScene("ReBigged0");
    }

    public void Button3Pressed()
    {
        m_oSceneManager.m_oScore.nGhost++;
        m_oSceneManager.ToggleContinueButton();
        m_oSceneManager.UpdateContinueButtonText("Continue...");
        m_oSceneManager.LoadNewScene("ReBigged0");
    }

}
