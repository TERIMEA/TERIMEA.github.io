# EndProject
졸업작품 관리용 Git

![화면 캡처 2022-04-26 155422](https://user-images.githubusercontent.com/103991146/165240716-050c47a3-21bf-4318-b6ac-66ead6d80dad.png)

## 시작 전 주의사항

해당 작품은 STEAM VR API를 사용하여 제작되고 있습니다


![화면 캡처 2022-04-19 185545](https://user-images.githubusercontent.com/103991146/165240778-06766a46-1d95-4375-b7f1-29383e52d5f3.png)

STEAM에서 STEAM VR을 설치 후, 프로그램을 실행시키면 작동합니다.
### 


##  스크립트

| 스크립트명 | 사용 |
| ------ |----------- |
| Ball_condition | Ball_White (Clone)의 충돌 시 HIT를 전달해주며, tag가 wall인 오브젝트에 부딪힐 경우 오브젝트를 삭제 |
| Bat_Button | 배트가 해당 오브젝트와 접촉했을 경우, Gamecontroll에 트리거를 보내며 스스로를 비활성화|
| FireControll | 자신이 가지고 있는 자식 오브젝트의 FireTime()함수를 실행 |
| Foul_Count | Ball_White (Clone)과 충돌 시, 지정 음성을 출력하며 Text를 FOUL로 변경합니다 |
| Gamecontroll | Bat_Button의 트리거를 받아, Ball_White (Clone)가 배트와 충돌 시 m를 표시하며, Ball_White (Clone)가 존재하지 않을 경우 Bat_Button을 활성화|
| Homerun_cheak | 자신이 가지고 있는 자식 오브젝트의 FireTime()함수를 실행 |
| HomeRunFire | 자신이 가지고 있는 자식 오브젝트의 FireTime()함수를 실행 |
| magunus_Test | 자신이 가지고 있는 자식 오브젝트의 FireTime()함수를 실행 |
| Pitcher_controll | 자신이 가지고 있는 자식 오브젝트의 FireTime()함수를 실행 |
