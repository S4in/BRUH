using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Mirror;
public class Login : MonoBehaviour
{
    public NetworkManager manager;

    [SerializeField] TextMeshProUGUI loginError, registerError;
    public Button zaloguj, zarejestruj;
    public TMP_InputField loginField, hasloField, RejLoginField, RejHasloField;
    public TMPro.TMP_Dropdown loginChoice;
    public static Dictionary<string, string> accounts = new Dictionary<string, string>();

    void Awake()
    {
        //manager = GetComponent<NetworkManager>();
    }
    public void Rejestruj()
    {

        if (RejLoginField.text.Length < 5)
        {
            registerError.text = "Podany login nie posiada conajmniej 5 znaków.";
        }
        else
        {
            if (RejHasloField.text.Length < 6)
            {
                registerError.text = "Podane haslo nie posiada conajmniej 6 znaków.";
            }
            else
            {
                if (accounts.ContainsKey(RejLoginField.text))
                {
                    registerError.text = "Podany login jest juz zajety.";
                }
                else
                {
                    registerError.text = "Konto " + RejLoginField.text + " zostalo utworzone.";
                    accounts.Add(RejLoginField.text, RejHasloField.text);
                    Debug.Log(RejLoginField.text + " " + RejHasloField.text);
                    Debug.Log("Added account " + accounts.Count.ToString());
                }
            }
        }
    }

    public void Zaloguj()
    {

        if (loginChoice.value == 0) // jesli jestes studentem
        {
                                                                              //hashmapa => (k,v) = (login, haslo)
            if ((loginField.text == "admin" && hasloField.text == "test") || (accounts.ContainsKey(loginField.text) && accounts[loginField.text].Equals(hasloField.text)))
            {
                //update od Kacpiego
                GameObject.Find("UserData").GetComponent<UserData>().id = "admin";
                //koniec updatu

                /* if (!NetworkClient.active)
                 {
                     manager.StartClient();
                 }
                 manager.networkAddress = "localhost";*/

                SceneManager.LoadScene(3);
            }
            else
            {
                loginError.text = "Dane zostaly wprowadzone blednie.";
            }
        }
        else
        {
            if (loginField.text == "admin" && hasloField.text == "test")
            {
                //update od Kacpiego
                GameObject.Find("UserData").GetComponent<UserData>().id = "admin" + "test";
                //koniec updatu

                SceneManager.LoadScene(4);
            }
            else
            {
                loginError.text = "Dane zostaly wprowadzone blednie.";
            }
        }
    }

}
