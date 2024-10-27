using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public DecorationPoints m_oScore;
    SceneScript m_oScript;
    GameObject m_goScene;
    public GameObject m_goMainCanvas;

    TextMeshProUGUI m_oButton0Text;
    TextMeshProUGUI m_oButton1Text;
    TextMeshProUGUI m_oButton2Text;
    TextMeshProUGUI m_oButton3Text;

    TextMeshProUGUI m_oContinueButtonText;
    GameObject m_goContinueButton;

    // Start is called before the first frame update
    void Start()
    {

        m_oScore = new DecorationPoints();


        if (m_goMainCanvas == null)
        {

            m_goMainCanvas = GameObject.Find("Main Canvas");

        }

        LoadNewScene("Scene0");

        m_oButton0Text = GameObject.Find("Button0Text").GetComponent<TextMeshProUGUI>();
        m_oButton1Text = GameObject.Find("Button1Text").GetComponent<TextMeshProUGUI>();
        m_oButton2Text = GameObject.Find("Button2Text").GetComponent<TextMeshProUGUI>();
        m_oButton3Text = GameObject.Find("Button3Text").GetComponent<TextMeshProUGUI>();

        m_oContinueButtonText = GameObject.Find("ContinueButtonText").GetComponent<TextMeshProUGUI>();
        m_goContinueButton = GameObject.Find("ContinueButton");

        ToggleContinueButton();


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

    public void ContinueButtonClicked()
    {

        m_oScript.Button0Pressed();

    }

    public void ToggleContinueButton()
    {

        m_goContinueButton.SetActive(!m_goContinueButton.activeSelf);

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

    public void UpdateContinueButtonText(string newText)
    {

        if (m_oContinueButtonText != null)
        {

            m_oContinueButtonText.text = newText;

        }
        else
        {

            Debug.Log("ContinueButtonText not found");

        }

    }


    public void GameOver()
    {

        List<string> highestScores = m_oScore.GetHighestScores();

        if (highestScores.Count == 1)
        {

            if (highestScores[0] == "Jack-O-Lantern")
            {

                LoadNewScene("EndJack");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");


            }else if (highestScores[0] == "Skeleton")
            {

                LoadNewScene("EndSkeleton");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");

            }
            else if (highestScores[0] == "Ghost")
            {

                LoadNewScene("EndGhost");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");

            }
            else if (highestScores[0] == "Scarecrow")
            {

                LoadNewScene("EndScarecrow");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");

            }

        }
        else
        {

            int randomIndex = Random.Range(0, highestScores.Count);

            if (highestScores[randomIndex] == "Jack-O-Lantern")
            {

                LoadNewScene("EndJack");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");

            }
            else if (highestScores[randomIndex] == "Skeleton")
            {

                LoadNewScene("EndSkeleton");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");

            }
            else if (highestScores[randomIndex] == "Ghost")
            {

                LoadNewScene("EndGhost");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");

            }
            else if (highestScores[randomIndex] == "Scarecrow")
            {

                LoadNewScene("EndScarecrow");
                ToggleContinueButton();
                UpdateContinueButtonText("Yay!");

            }


        }

    }


    public void LoadNewScene(string SceneName)
    {

        if(m_goScene != null)
        {

            m_oScript = null;
            Destroy(m_goScene);

        }

        GameObject prefab = Resources.Load<GameObject>("Scenes/" + SceneName);

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



    // Method to find the highest score and determine if there's a tie
    public List<string> GetHighestScores()
    {
        // Create a dictionary to store the names and values
        Dictionary<string, int> scores = new Dictionary<string, int>
        {
            { "Jack-O-Lantern", nJackOLantern },
            { "Skeleton", nSkeleton },
            { "Ghost", nGhost },
            { "Scarecrow", nScarecrow }
        };

        // Find the maximum value in the dictionary
        int maxScore = scores.Values.Max();

        // Find all the keys (names) with this maximum score
        List<string> highestScores = scores
            .Where(pair => pair.Value == maxScore)
            .Select(pair => pair.Key)
            .ToList();

        return highestScores;
    }


}

