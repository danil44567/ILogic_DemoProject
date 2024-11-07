using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{
    [SerializeField] private Text counter;

    private int count = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        count++;
        UpdateText(counter, count.ToString());
    }

    private void UpdateText(Text text, string value)
    {
        text.text = value;
    }
}
