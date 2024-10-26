using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    DecorationPoints m_oScore;
    SceneScript m_oScript;
    GameObject m_goScene;
    public GameObject m_goMainCanvas;

    TextMeshProUGUI m_oButton0Text;
    TextMeshProUGUI m_oButton1Text;
    TextMeshProUGUI m_oButton2Text;
    TextMeshProUGUI m_oButton3Text;


    // Start is called before the first frame update
    void Start()
    {

        m_oScore = new DecorationPoints();


        if (m_goMainCanvas == null)
        {

            m_goMainCanvas = GameObject.Find("Main Canvas");

        }


        GameObject prefab = Resources.Load<GameObject>("Scene0"); 

        if (prefab != null)
        {
            // Instantiate the prefab in the scene
            m_goScene = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            m_goScene.transform.SetParent(m_goMainCanvas.transform, false);
        }
        else
        {

            Debug.Log("Error finding scene prefab in resoures folder");

        }

        m_oScript = m_goScene.GetComponent<SceneScript>();

        if (m_oScript == null)
        {

            Debug.Log("Error finding scene script on scene prefab");

        }

        m_oButton0Text = GameObject.Find("Button0Text").GetComponent<TextMeshProUGUI>();
        m_oButton1Text = GameObject.Find("Button1Text").GetComponent<TextMeshProUGUI>();
        m_oButton2Text = GameObject.Find("Button2Text").GetComponent<TextMeshProUGUI>();
        m_oButton3Text = GameObject.Find("Button3Text").GetComponent<TextMeshProUGUI>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Option0Clicked()
    {

        m_oScript.Button0Pressed();

    }


    public void Option1Clicked()
    {

        m_oScript.Button1Pressed();

    }

    public void Option2Clicked()
    {

        m_oScript.Button2Pressed();

    }

    public void Option3Clicked()
    {

        m_oScript.Button3Pressed();

    }


    public void UpdateButton0Text(string newText)
    {

        if(m_oButton0Text != null)
        {

            m_oButton0Text.text = newText;

        }
        else
        {

            Debug.Log("Button0Text not found");

        }

    }

    public void UpdateButton1Text(string newText)
    {

        if (m_oButton1Text != null)
        {

            m_oButton1Text.text = newText;

        }
        else
        {

            Debug.Log("Button1Text not found");

        }

    }

    public void UpdateButton2Text(string newText)
    {

        if (m_oButton2Text != null)
        {

            m_oButton2Text.text = newText;

        }
        else
        {

            Debug.Log("Button3Text not found");

        }

    }

    public void UpdateButton3Text(string newText)
    {

        if (m_oButton3Text != null)
        {

            m_oButton3Text.text = newText;

        }
        else
        {

            Debug.Log("Button3Text not found");

        }

    }




    public void LoadNewScene(string SceneName)
    {

        if(m_goScene != null)
        {

            m_oScript = null;
            Destroy(m_goScene);

        }

        GameObject prefab = Resources.Load<GameObject>(SceneName);

        if (prefab != null)
        {
            // Instantiate the prefab in the scene
            m_goScene = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            m_goScene.transform.SetParent(m_goMainCanvas.transform, false);
        }
        else
        {

            Debug.Log("Error finding scene prefab in resoures folder");

        }

        m_oScript = m_goScene.GetComponent<SceneScript>();

        if (m_oScript == null)
        {

            Debug.Log("Error finding scene script on scene prefab");

        }

    }


}


public interface SceneScript
{

    public void Button0Pressed();
    public void Button1Pressed();
    public void Button2Pressed();  
    public void Button3Pressed(); 


}

public class DecorationPoints
{

    public int nJackOLantern;
    public int nSkeleton;
    public int nGhost;
    public int nScarecrow;

    public DecorationPoints() {

        nJackOLantern = 0;
        nSkeleton = 0;
        nGhost = 0;
        nScarecrow = 0;

    }


}

