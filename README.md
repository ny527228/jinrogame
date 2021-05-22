# jinrogame
기말미션4 10조 김민선,임나영

# 기획 : <하이트진로 두꺼비 게임>
- 두꺼비를 화살표 키보드를 사용하여 움직여, 소주잔에 물방울을 받는 게임
- 파란 물방울을 받았을 경우 게이지가 깎이고, 빨간 물방울을 받았을 경우 게이지가 차오름
- 게이지가 모두 깎이면 게임 Clear

# 개발 멤버 : 김민선, 임나영
# 사용 라이브러리 : Visual Studio (Mac용 2019)
# 개발환경 : ios
# 설치환경 : Android
# 라이센스 : Unity Personal

# <게임기능> 
# 게임 스타트 : Start Scene일 때 마우스를 클릭하여 Game Scene 업로드
# 플레리어 컨트롤러 : 키보드 화살표 오/왼으로 플레이어 이동이 가능하게 코딩 (LefrArrow, RightArrow)
# 블루/레드 컨트롤러 : 파란 물방울을 받았을 땐 게이지가 깎이게, 빨간 물방울을 받았을 땐 게이지가 차오르는 코드 작성
# 블루/레드 제너레이터 : 각각 Prefab생성 후 제너레이터 코드 작성 후 적용. 파란 물방울과 빨간 물방울이 낙하하는 위치를 조정 후, 랜덤으로 떨어지게 코드 작성.
# 게임 디렉터 : DecreaseHP 함수에 SceneManager적용 / hp가 모두 깎였을 시 Clear Scene 등장하도록 코드 적용
