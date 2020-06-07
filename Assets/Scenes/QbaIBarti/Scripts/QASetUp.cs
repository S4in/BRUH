using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using Mirror;

public class QASetUp: MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField question, a, b, c, d;
    public Toggle toggleA, toggleB, toggleC, toggleD;
    public static string correctAnswer;
    public static List<List<string>> quiz = new List<List<string>>();
    public void Add()
    {
        List<string> tmp = new List<string>();
        tmp.Add(question.text);
        tmp.Add(a.text);
        tmp.Add(b.text);
        tmp.Add(c.text);
        tmp.Add(d.text);
        
        question.text = "";
        a.text = "";
        b.text = "";
        c.text = "";
        d.text = "";
        if (toggleA.isOn)
        {
            correctAnswer = "A";
          
        }
        else if (toggleB.isOn)
        {
            correctAnswer = "B";
            
        }
        else if (toggleC.isOn)
        {
            correctAnswer = "C";
            
        }
        else if (toggleD.isOn)
        {
            correctAnswer = "D";
            
        }

        tmp.Add(correctAnswer);
        quiz.Add(tmp);

    }
   
    public void Apply()
    {
        GameObject networkManager = GameObject.Find("Networking");
        if (!NetworkClient.active)
        {
            networkManager.GetComponent<NetworkManager>().StartServer();
        }
        //SceneManager.LoadScene(4);//index do poprawy
    }

}