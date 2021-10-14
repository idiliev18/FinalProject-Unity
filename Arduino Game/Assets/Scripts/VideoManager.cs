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
    public AchievementsManager achievementsManager;


    private void OnMouseOver() {
        if (Input.GetKeyDown(KeyCode.E)) {
            count++;
            if (count == 1) {
                if (VVClip == null) 
                {
                    achievementsManager.unlockAchievement(achievementsManager.christmassAchievement);
                } else 
                {
                    achievementsManager.unlockAchievement(achievementsManager.whatGreatVideoAchievement);
                }

                videoPlayer.targetTexture.Release();
                videoPlayer.Stop();
                videoPlayer.clip = PromotionClip;
                videoPlayer.Play();
            }
            else if (count == 10) {
                if (VVClip != null) {
                    achievementsManager.unlockAchievement(achievementsManager.classAchievement);
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
