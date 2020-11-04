using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cinezoom : MonoBehaviour
{

    float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;
    bool dis = false;
    public void disablevcam()
    {
        dis = true;
    }

    Vector2 firstTouchPrevPos, secondTouchPrevPos;

    [SerializeField]
    float zoomModifierSpeed = 0.001f;
   
    // Update is called once per frame
    void Update()
    {
        var camera = Camera.main;
        var brain = (camera == null) ? null : camera.GetComponent<CinemachineBrain>();
        var vcam = (brain == null) ? null : brain.ActiveVirtualCamera as CinemachineVirtualCamera;
        if (dis)
        {
            vcam.enabled = false;
        }
       

        /* if (vcam != null)
         {
             vcam.m_Lens.OrthographicSize = 30;
         }*/
        if (Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);

            firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
            secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

            touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
            touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

            zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;

            if (touchesPrevPosDifference > touchesCurPosDifference)
            {
                vcam.m_Lens.OrthographicSize += zoomModifier;
                if (vcam.m_Lens.OrthographicSize >= 36f)
                {
                    PlayerPrefs.SetInt("AllHints", 1);
                    zoomModifierSpeed = 0.01f;
                }
            }

            if (touchesPrevPosDifference < touchesCurPosDifference)
            {
                vcam.m_Lens.OrthographicSize -= zoomModifier;
            }
                

        }

        vcam.m_Lens.OrthographicSize = Mathf.Clamp(vcam.m_Lens.OrthographicSize, 6f, 260f);
        //text.text = "Camera size " + mainCamera.orthographicSize;

    }

}

