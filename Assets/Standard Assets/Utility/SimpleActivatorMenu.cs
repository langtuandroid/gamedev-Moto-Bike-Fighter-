using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityStandardAssets.Utility
{
    public class SimpleActivatorMenu : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI camSwitchButtonS;
        public GameObject[] objects;


        private int _mCurrentActiveObject;


        private void OnEnable()
        {
            // active object starts from first in array
            _mCurrentActiveObject = 0;
            camSwitchButtonS.text = objects[_mCurrentActiveObject].name;
        }


        public void NextCameraA()
        {
            int nextactiveobject = _mCurrentActiveObject + 1 >= objects.Length ? 0 : _mCurrentActiveObject + 1;

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(i == nextactiveobject);
            }

            _mCurrentActiveObject = nextactiveobject;
            camSwitchButtonS.text = objects[_mCurrentActiveObject].name;
        }
    }
}
