using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class VRMLipSyncContextMorphTarget : MonoBehaviour
{
    public OVRLipSyncContextBase lipsyncContext;
    VRMBlendShapeProxy proxy;
    int[] VisemeToBlendTargets = { -1,4,4,5,3,3,3,3,-1,3,2,5,3,6,4 }; //AIUEOへの振り分けテーブル

    [Range(0.0f, 2.0f)]
    public float LipSyncSensitivity = 1.0f;
    public int SmoothAmount = 100;

    void Start()
    {
        lipsyncContext = GetComponent<OVRLipSyncContextBase>();
        lipsyncContext.Smoothing = SmoothAmount;
    }

    private void UpdateVRMMorph(OVRLipSync.Frame frame)
    {
        if (!proxy)
        {
            // VRMBlendShapeProxyを探す
            proxy = FindObjectOfType<VRMBlendShapeProxy>();
        }

        if (!proxy) return;
        for (int i = 1; i < VisemeToBlendTargets.Length; i++)
        {
            if (VisemeToBlendTargets[i] != -1)
            {
                proxy.SetValue((BlendShapePreset)VisemeToBlendTargets[i], Mathf.Min(1.0f, frame.Visemes[i] * LipSyncSensitivity));
            }
        }
    }

    void LateUpdate()
    {
        if (lipsyncContext == null) return;

        OVRLipSync.Frame frame = lipsyncContext.GetCurrentPhonemeFrame();
        if (frame != null)
        {
            UpdateVRMMorph(frame);
        }
    }

    // 任意のVRMBlendShapeProxyをセットする場合
    public void SetVRMBlendShapeProxy(VRMBlendShapeProxy _proxy)
    {
        proxy = _proxy;
    }
}