using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private int count = 0;
    public VideoClip PromotionClip;
    public VideoClip VVClip = null;
    public VideoPlayer videoPlayer;

    private void OnMouseOver() {
        if (Input.GetKeyDown(KeyCode.E)) {
            count++;
            if (count == 1) {
                videoPlayer.targetTexture.Release();
                videoPlayer.Stop();
                videoPlayer.clip = PromotionClip;
                videoPlayer.Play();
            }
            else if (count == 10) {
                if (VVClip != null) {
                    videoPlayer.targetTexture.Release();
                    videoPlayer.Stop();
                    videoPlayer.clip = VVClip;
                    videoPlayer.Play();
                }
            }
        }
    }

    private void OnApplicationQuit() {
        videoPlayer.Stop();
        videoPlayer.targetTexture.Release();
    }
}
