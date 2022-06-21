# EndProject
졸업작품 관리용 Git

![화면 캡처 2022-04-26 155422](https://user-images.githubusercontent.com/103991146/165240716-050c47a3-21bf-4318-b6ac-66ead6d80dad.png)

## 시작 전 주의사항

해당 작품은 STEAM VR API를 사용하여 제작되고 있습니다


![화면 캡처 2022-04-19 185545](https://user-images.githubusercontent.com/103991146/165240778-06766a46-1d95-4375-b7f1-29383e52d5f3.png)

STEAM에서 STEAM VR을 설치 후, 프로그램을 실행시키면 작동합니다.


## 관련 동영상
<iframe width="560" height="315" src="https://www.youtube.com/embed/U57Ajk9aUO0" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
## 게임 설명
![화면 캡처 2022-06-10 134951](https://user-images.githubusercontent.com/103991146/173044889-df94d130-a4a8-48e7-ac77-4e1407875f24.png)
관객석에 앉아 있는 관중은 게임 실행 시 무작위 이미지로 변경되며, 플레이어가 특정 트리거를 만족시켰을 시 움직입니다
![화면 캡처 2022-06-10 135032](https://user-images.githubusercontent.com/103991146/173044899-0702af05-8966-481e-9875-835ced3ab93b.png)
플레이어(타자)의 적수가 되는 투수는, 매 투구마다 무작위 각도로 공을 던져 플레이 몰입도를 높힙니다.
![화면 캡처 2022-06-10 140525](https://user-images.githubusercontent.com/103991146/173044901-1d44a091-fb3d-40ca-8874-f96336b95300.png)
![화면 캡처 2022-06-10 140534](https://user-images.githubusercontent.com/103991146/173044906-d2586ed5-3082-4787-8590-8ce51edfe2de.png)
플레이어가 방망이를 잃어버렸을 경우를 가정하여, 플레이어 손에서 방망이가 떨어진 후, 수 초 뒤에 방망이는 초기 위치로 다시 이동하게 됩니다.

##  스크립트

| 스크립트명 | 사용 |
| ------ |----------- |
| Ball_condition | Ball_White (Clone)의 충돌 시 HIT를 전달해주며, tag가 wall인 오브젝트에 부딪힐 경우 오브젝트를 삭제 |
| Bat_Button | 배트가 해당 오브젝트와 접촉했을 경우, Gamecontroll에 트리거를 보내며 스스로를 비활성화|
| FireControll | 자신이 가지고 있는 자식 오브젝트의 FireTime()함수를 실행 |
| Foul_Count | Ball_White (Clone)과 충돌 시, 지정 음성을 출력하며 Text를 FOUL로 변경합니다 |
| Gamecontroll | Bat_Button의 트리거를 받아, Ball_White (Clone)가 배트와 충돌 시 m를 표시하며, Ball_White (Clone)가 존재하지 않을 경우 Bat_Button을 활성화|
| Homerun_cheak | 해당 스크립트를 가지고 있는 오브젝트가 Ball_White (Clone)와 충돌 시, FireControll의 함수를 작동함과 동시에 Text를 HOMERUN으로 변경합니다 |
| HomeRunFire | FireControll에서 신호를 받아, FireTime()함수를 실행합니다 |
| magunus_Test | 소유 오브젝트가 가지고 있는 addforce()의 x값의/13 x -1 만큼 소유 오브젝트의 x값을 이동시킵니다 |
| Pitcher_controll | Ball_White (Clone)을 생성 후, 랜덤한 방향으로 Ball을 addforce합니다. |
