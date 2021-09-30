using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Video;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer oceanVideo;
    [SerializeField] private GameObject centralPanel, leftPanel, rightPanel, 
                                        welcomePanel, signInPanel, signUpPanel,
                                        backgroundOceanPanel;   

    private void Awake()
    {
        oceanVideo.isLooping = true;

        oceanVideo.Play();  
    }    

    /**Buttons Events**/
    public void toSignIn() 
    {
        welcomePanel.transform.DOMove(new Vector3(leftPanel.transform.position.x, welcomePanel.transform.position.y, welcomePanel.transform.position.z), 1.0f);
        signInPanel.transform.DOMove(new Vector3(centralPanel.transform.position.x, signInPanel.transform.position.y, signInPanel.transform.position.z), 1.0f);
    }
    public void toSignUp() 
    {
        welcomePanel.transform.DOMove(new Vector3(leftPanel.transform.position.x, welcomePanel.transform.position.y, welcomePanel.transform.position.z), 1.0f);
        signUpPanel.transform.DOMove(new Vector3(centralPanel.transform.position.x, signUpPanel.transform.position.y, signUpPanel.transform.position.z), 1.0f);
    }
    public void toWelcomePanelFromSignIn() 
    {
        ReturnToMainMenu(signInPanel);
    }
    public void toWelcomePanelFromSignUp()
    {
        ReturnToMainMenu(signUpPanel);
    }
    /**Methods**/
    private void ReturnToMainMenu(GameObject currentPanel) 
    {
        currentPanel.transform.DOMove(new Vector3(rightPanel.transform.position.x, currentPanel.transform.position.y, currentPanel.transform.position.z), 1.0f);
        welcomePanel.transform.DOMove(new Vector3(centralPanel.transform.position.x, welcomePanel.transform.position.y, welcomePanel.transform.position.z), 1.0f);  
    }
  
}
