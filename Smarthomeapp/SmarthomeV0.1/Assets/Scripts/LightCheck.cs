using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCheck : MonoBehaviour
{
    public RenderTexture LightCheckTexture;
    public RenderTexture LightCheckTexture1;
    public RenderTexture LightCheckTexture2;
    public RenderTexture LightCheckTexture3;
    public RenderTexture LightCheckTexture4;
    public RenderTexture LightCheckTexture5;
    public RenderTexture LightCheckTexture6;
    public RenderTexture LightCheckTexture7;
    public RenderTexture LightCheckTexture8;
    public RenderTexture LightCheckTexture9;
    public static float AvarageLightLevel;
    public static float LightLevel;
    public static float LightLevel1;
    public static float LightLevel2;
    public static float LightLevel3;
    public static float LightLevel4;
    public static float LightLevel5;
    public static float LightLevel6;
    public static float LightLevel7;
    public static float LightLevel8;
    public static float LightLevel9;
    public int Light;

    /// <summary>
    /// Gets the light intensity based on the light sensors
    /// </summary>
    void Update()
    {
        RenderTexture tmpTexture = RenderTexture.GetTemporary(LightCheckTexture.width, LightCheckTexture.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture1 = RenderTexture.GetTemporary(LightCheckTexture1.width, LightCheckTexture1.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture2 = RenderTexture.GetTemporary(LightCheckTexture2.width, LightCheckTexture2.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture3 = RenderTexture.GetTemporary(LightCheckTexture3.width, LightCheckTexture3.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture4 = RenderTexture.GetTemporary(LightCheckTexture4.width, LightCheckTexture4.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture5 = RenderTexture.GetTemporary(LightCheckTexture5.width, LightCheckTexture5.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture6 = RenderTexture.GetTemporary(LightCheckTexture6.width, LightCheckTexture6.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture7 = RenderTexture.GetTemporary(LightCheckTexture7.width, LightCheckTexture7.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture8 = RenderTexture.GetTemporary(LightCheckTexture8.width, LightCheckTexture8.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
        RenderTexture tmpTexture9 = RenderTexture.GetTemporary(LightCheckTexture9.width, LightCheckTexture9.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
       
        Graphics.Blit(LightCheckTexture, tmpTexture);
        Graphics.Blit(LightCheckTexture1, tmpTexture1);
        Graphics.Blit(LightCheckTexture2, tmpTexture2);
        Graphics.Blit(LightCheckTexture3, tmpTexture3);
        Graphics.Blit(LightCheckTexture4, tmpTexture4);
        Graphics.Blit(LightCheckTexture5, tmpTexture5);
        Graphics.Blit(LightCheckTexture6, tmpTexture6);
        Graphics.Blit(LightCheckTexture7, tmpTexture7);
        Graphics.Blit(LightCheckTexture8, tmpTexture8);
        Graphics.Blit(LightCheckTexture9, tmpTexture9);


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
        //Debug.Log(LightLevel);

        RenderTexture.active = tmpTexture7;

        Texture2D temp2dTexture7 = new Texture2D(LightCheckTexture7.width, LightCheckTexture7.height);
        temp2dTexture7.ReadPixels(new Rect(0, 0, tmpTexture7.width, tmpTexture7.height), 0, 0);
        temp2dTexture7.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors7 = temp2dTexture7.GetPixels32();

        LightLevel7 = 0;

        for (int i = 0; i < colors7.Length; i++)
        {
            LightLevel7 += (0.2126f * colors7[i].r) + (0.7152f * colors7[i].g) + (0.0722f + colors7[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture7);
        Destroy(temp2dTexture7);
        //Debug.Log(LightLevel7);
        RenderTexture.active = tmpTexture2;

        Texture2D temp2dTexture2 = new Texture2D(LightCheckTexture2.width, LightCheckTexture2.height);
        temp2dTexture2.ReadPixels(new Rect(0, 0, tmpTexture2.width, tmpTexture2.height), 0, 0);
        temp2dTexture2.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors2 = temp2dTexture2.GetPixels32();

        LightLevel2 = 0;

        for (int i = 0; i < colors2.Length; i++)
        {
            LightLevel2 += (0.2126f * colors2[i].r) + (0.7152f * colors2[i].g) + (0.0722f + colors2[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture2);
        Destroy(temp2dTexture2);
        //Debug.Log(LightLevel2);
        RenderTexture.active = tmpTexture1;

        Texture2D temp2dTexture1 = new Texture2D(LightCheckTexture1.width, LightCheckTexture1.height);
        temp2dTexture1.ReadPixels(new Rect(0, 0, tmpTexture1.width, tmpTexture1.height), 0, 0);
        temp2dTexture1.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors1 = temp2dTexture1.GetPixels32();

        LightLevel1 = 0;

        for (int i = 0; i < colors1.Length; i++)
        {
            LightLevel1 += (0.2126f * colors1[i].r) + (0.7152f * colors1[i].g) + (0.0722f + colors1[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture1);
        Destroy(temp2dTexture1);
        //Debug.Log(LightLevel1);

        RenderTexture.active = tmpTexture3;

        Texture2D temp2dTexture3 = new Texture2D(LightCheckTexture3.width, LightCheckTexture3.height);
        temp2dTexture3.ReadPixels(new Rect(0, 0, tmpTexture3.width, tmpTexture3.height), 0, 0);
        temp2dTexture3.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors3 = temp2dTexture3.GetPixels32();

        LightLevel3 = 0;

        for (int i = 0; i < colors3.Length; i++)
        {
            LightLevel3 += (0.2126f * colors3[i].r) + (0.7152f * colors3[i].g) + (0.0722f + colors3[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture3);
        Destroy(temp2dTexture3);
        //Debug.Log(LightLevel3);

        RenderTexture.active = tmpTexture4;

        Texture2D temp2dTexture4 = new Texture2D(LightCheckTexture4.width, LightCheckTexture4.height);
        temp2dTexture4.ReadPixels(new Rect(0, 0, tmpTexture4.width, tmpTexture4.height), 0, 0);
        temp2dTexture4.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors4 = temp2dTexture4.GetPixels32();

        LightLevel4 = 0;

        for (int i = 0; i < colors4.Length; i++)
        {
            LightLevel4 += (0.2126f * colors4[i].r) + (0.7152f * colors4[i].g) + (0.0722f + colors4[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture4);
        Destroy(temp2dTexture4);
        //Debug.Log(LightLevel4);

        RenderTexture.active = tmpTexture5;

        Texture2D temp2dTexture5 = new Texture2D(LightCheckTexture5.width, LightCheckTexture5.height);
        temp2dTexture5.ReadPixels(new Rect(0, 0, tmpTexture5.width, tmpTexture5.height), 0, 0);
        temp2dTexture5.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors5 = temp2dTexture5.GetPixels32();

        LightLevel5 = 0;

        for (int i = 0; i < colors5.Length; i++)
        {
            LightLevel5 += (0.2126f * colors5[i].r) + (0.7152f * colors5[i].g) + (0.0722f + colors5[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture5);
        Destroy(temp2dTexture5);
        //Debug.Log(LightLevel5);

        RenderTexture.active = tmpTexture2;

        Texture2D temp2dTexture6 = new Texture2D(LightCheckTexture6.width, LightCheckTexture6.height);
        temp2dTexture6.ReadPixels(new Rect(0, 0, tmpTexture6.width, tmpTexture6.height), 0, 0);
        temp2dTexture6.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors6 = temp2dTexture6.GetPixels32();

        LightLevel6 = 0;

        for (int i = 0; i < colors6.Length; i++)
        {
            LightLevel6 += (0.2126f * colors6[i].r) + (0.7152f * colors6[i].g) + (0.0722f + colors6[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture6);
        Destroy(temp2dTexture6);
        //Debug.Log(LightLevel6);

        RenderTexture.active = tmpTexture8;

        Texture2D temp2dTexture8 = new Texture2D(LightCheckTexture8.width, LightCheckTexture8.height);
        temp2dTexture8.ReadPixels(new Rect(0, 0, tmpTexture8.width, tmpTexture8.height), 0, 0);
        temp2dTexture8.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors8 = temp2dTexture8.GetPixels32();

        LightLevel8 = 0;

        for (int i = 0; i < colors8.Length; i++)
        {
            LightLevel8 += (0.2126f * colors8[i].r) + (0.7152f * colors8[i].g) + (0.0722f + colors8[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture8);
        Destroy(temp2dTexture8);
        //Debug.Log(LightLevel8);

        RenderTexture.active = tmpTexture9;

        Texture2D temp2dTexture9 = new Texture2D(LightCheckTexture9.width, LightCheckTexture9.height);
        temp2dTexture9.ReadPixels(new Rect(0, 0, tmpTexture9.width, tmpTexture9.height), 0, 0);
        temp2dTexture9.Apply();

        RenderTexture.active = previous;
        //RenderTexture.RealeaseTemporary(tmpTexture);

        Color32[] colors9 = temp2dTexture9.GetPixels32();

        LightLevel9 = 0;

        for (int i = 0; i < colors9.Length; i++)
        {
            LightLevel9 += (0.2126f * colors9[i].r) + (0.7152f * colors9[i].g) + (0.0722f + colors9[i].b);
        }

        RenderTexture.ReleaseTemporary(tmpTexture9);
        Destroy(temp2dTexture9);
        //Debug.Log(LightLevel9);
        AvarageLightLevel = 0;
        AvarageLightLevel += (LightLevel + LightLevel1 + LightLevel2 + LightLevel3 + LightLevel4 + LightLevel5 + LightLevel6 + LightLevel7 + LightLevel8 + LightLevel9) / 10;
        Debug.Log(AvarageLightLevel);
    }
}
