using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public bool answerTime = false;

    public TextMeshPro m_Object;
    private float roundTime = 30;
    public void Start()
    {
        m_Object.text = roundTime.ToString();
    }

    void FixedUpdate()
    {
        if (answerTime == false)
        {
            if (roundTime > 0)
            {
                roundTime -= Time.deltaTime;
                m_Object.text = Mathf.Round(roundTime).ToString();
            }
            else
            {
                gameObject.GetComponent<RoundsController>().setCurData();
                answerTime = true;
                Debug.Log("answet time: " + answerTime);
                roundTime = 30;
            }
        }
        if (answerTime == true)
        {
            if (roundTime > 0)
            {
                roundTime -= Time.deltaTime;
                m_Object.text = Mathf.Round(roundTime).ToString();
            }
            else
            {
                gameObject.GetComponent<RoundsController>().clearCurData();
                answerTime = false;
                Debug.Log("answet time: " + answerTime);
                roundTime = 30;
            }
        }
    }
}