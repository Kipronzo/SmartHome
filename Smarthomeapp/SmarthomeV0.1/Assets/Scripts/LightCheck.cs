using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCheck : MonoBehaviour
{
    public RenderTexture LightCheckTexture;
    public static float LightLevel;
    public int Light;
    // Update is called once per frame
    void Update()
    {
        RenderTexture tmpTexture = RenderTexture.GetTemporary(LightCheckTexture.width, LightCheckTexture.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        Graphics.Blit(LightCheckTexture, tmpTexture);
        RenderTexture previous = RenderTexture.active;
        RenderTexture.active = tmpTexture;

        Texture2D temp2dTexture = new Texture2D(LightCheckTexture.width, LightCheckTexture.height);
        temp2dTexture.ReadPixels(new Rect(0, 0, tmpTexture.width, tmpTexture.height), 0, 0);
        temp2dTexture.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors = temp2dTexture.GetPixels32();

        LightLevel = 0;
        for (int i = 0; i < colors.Length; i++)
        {
            LightLevel += (0.2126f * colors[i].r) + (0.7152f * colors[i].g) + (0.0722f + colors[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture);
        Destroy(temp2dTexture);
        ////Debug.Log(LightLevel);
    }
}
