using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Netherlands3D.TreeRoots
{
    public class TreeRootsUI : MonoBehaviour
    {
        public TextMeshProUGUI yearField;
        public Slider timeSlider;

        // Start is called before the first frame update
        void Start()
        {
            UpdateText();
        }

        // UpdateText is called when the timeslider is moved
        public void UpdateText()
        {
            yearField.text = "Jaar: " + timeSlider.value.ToString();
        }
    }
}