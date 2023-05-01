using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] private GameObject NextLevelPanel;


    public void SpawnNextLevelPanel()
    {
        NextLevelPanel.SetActive(true);
    }

    public void ShutDownQuestion()
    {
        GameObject.FindGameObjectWithTag("Question").SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
