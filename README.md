# ZEPETO-Unity-Barracuda-MotionCapture
### ZEPETO PoseEstimation<br>
#### digital-standard의 [ThreeDPoseUnityBarracuda 오픈소스](https://github.com/digital-standard/ThreeDPoseUnityBarracuda)를 이용했습니다.<br>
![ezgif com-gif-maker](https://user-images.githubusercontent.com/82865325/168528657-fb07afae-bc1c-4a71-a6c4-874ce59971c8.gif)<br><br>

## 제페토 씬에서 바라쿠다가 동작되게 리소스를 추가하고 제페토 캐릭터에 리깅한 샘플입니다.
### 녹화된 비디오
![ezgif com-gif-maker (1)](https://user-images.githubusercontent.com/82865325/168556151-e79b6850-ba0b-4e8b-b3c6-41e43b083b31.gif)   
### 실시간 웹캠
![ezgif com-gif-maker (2)](https://user-images.githubusercontent.com/82865325/168556778-c0d22b67-b149-42d1-b41b-dd278ebb622f.gif)   
### EasyMotionReader 사용, 포즈 저장 및 애니메이션 추출
![ezgif com-gif-maker (4)](https://user-images.githubusercontent.com/82865325/171117942-97946ee3-5b2a-46ea-b9fd-6a52dc9a4b24.gif)   
[Youtube에서 전체보기](https://www.youtube.com/watch?v=eXPUI766Q5U&ab_channel=%EA%B9%80%EC%A0%95%EC%9B%85)
1. 제페토씬 (제페토월드 빌드잇)
2. 애니메이션 추정 (ThreeDPoseUnityBarracuda 오픈소스 활용)
3. PoseReader (EasyMotionReader 오픈소스 활용)
4. PoseWrite (EasyMotionReader 오픈소스 활용)
5. UnityChan캐릭터에서 애니메이션 재사용    
- Human bone형식의 모든 캐릭터에서 저장한 포즈 애니메이션을 재생할 수 있습니다.
- InputTexture에서 UseWebCam을 True로 설정해 웹캠을 이용한 추론도 가능합니다.


#### 더 좋은 모델추론을 위한 권고
1. 고화질 웹캠 및 비디오 사용
2. 웹캠의 중앙부에서 촬영
3. 가능한 빈 공간에서 촬영

## ISSUE
- 현재 [제페토 월드](https://studio.zepeto.me/guides/unity_package_list)에서 com.unity.barracuda를 지원하지 않습니다. (현재 모바일으로 플레이시 동작하지 않음)



## Future plans
- 제페토서버통신으로 잼을 가져와 모션을 구매합니다.
- TCP통신으로 서버에 비디오를 업로드하고 추론된 에니메이션 데이터를 모바일로 이용하도록 수정할 수 있습니다.
