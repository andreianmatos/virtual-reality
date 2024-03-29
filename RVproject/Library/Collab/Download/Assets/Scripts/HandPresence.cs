﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR;
using Debug = UnityEngine.Debug;

public class HandPresence : MonoBehaviour
{
    public Menu menu;

    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerPrefabs;

    private InputDevice targetDevice;
    private GameObject spawnedHandModel;
    private Animator handAnimator;
    private GameObject BubbleCursor;
    private BubbleCursor BubbleCursorScript;

    // Start is called before the first frame update
    void Start()
    {
        TryInitialize();
    }

    // So that game still works even when they are no controllers
    void TryInitialize()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);


        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
            GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);
            if (prefab)
            {
                spawnedHandModel = Instantiate(prefab, transform);
                handAnimator = spawnedHandModel.GetComponent<Animator>();
            }
            else
            {
                Debug.LogError("Did not find corresponding controller model");
                spawnedHandModel = Instantiate(controllerPrefabs[0], transform);
                handAnimator = spawnedHandModel.GetComponent<Animator>();

            }
        }
        BubbleCursor = GameObject.Find("BubblePointer/BubbleCursor");
        BubbleCursorScript = BubbleCursor.GetComponent<BubbleCursor>();
        //spawnedHandModel = Instantiate(controllerPrefabs[0], transform);
        //handAnimator = spawnedHandModel.GetComponent<Animator>();

    }

    void UpdateHandAnimation()
    {
        if(targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Trigger", 0);
        }
        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!targetDevice.isValid)
            TryInitialize();
        else
        {
            UpdateHandAnimation();
            if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero)
            {
                Debug.Log("Primary Touchedpad  " + primary2DAxisValue);
                BubbleCursorScript.changePosition(primary2DAxisValue);
            }

            /*targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
            if (primaryButtonValue)
                Debug.Log("Pressing Primary Button " + primaryButtonValue);*/

            if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
            {

                SendHapticImpulse(0.5f, 1);
                BubbleCursorScript.onTriggerSelect();
            }
            
        }

    }
    public bool SendHapticImpulse(float amplitude, float duration)
    {
        HapticCapabilities capabilities;
        if (targetDevice.TryGetHapticCapabilities(out capabilities) &&
            capabilities.supportsImpulse)
        {
            return targetDevice.SendHapticImpulse(0, amplitude, duration);
        }
        return false;
    }
}
