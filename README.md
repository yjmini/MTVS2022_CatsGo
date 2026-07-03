# MTVS2022 CatsGo

Unity 기반의 3D 캐주얼 게임 프로토타입입니다. 고양이 캐릭터와 오브젝트, 3인칭 컨트롤러, 씬 구성 에셋을 활용해 캐릭터 이동과 게임 공간 구성을 실습한 프로젝트입니다.

## 프로젝트 개요

`CatsGo`는 Unity 프로젝트 구조를 그대로 유지한 저장소입니다. 캐릭터, 고양이 모델, UI 이미지, 이펙트, 씬 파일이 포함되어 있으며, Unity Editor에서 바로 열어 게임 씬과 프리팹 구성을 확인할 수 있습니다.

## 주요 특징

- Unity 3D 씬 기반 게임 프로토타입
- Starter Assets 기반 3인칭 캐릭터 컨트롤러 사용
- 고양이/캐릭터/환경 프리팹 및 애니메이션 에셋 구성
- UI 이미지와 효과음/이펙트 리소스 포함
- `ProjectSettings`, `Packages`, `Assets`를 포함한 Unity 프로젝트 원본 구조 유지

## 기술 스택

- **Engine**: Unity
- **Language**: C#
- **Input/Controller**: Unity Starter Assets Third Person Controller
- **Assets**: Cat model, character model, environment prefabs, UI images

## 프로젝트 구조

```text
.
├── Assets/
│   ├── Image/              # UI 및 게임 화면 이미지 리소스
│   ├── Import Assets/      # 캐릭터, 고양이, 트리, 이펙트 등 외부 에셋
│   └── ...                 # Unity 씬/프리팹/스크립트/머티리얼
├── Packages/               # Unity 패키지 매니페스트
└── ProjectSettings/        # Unity 프로젝트 설정
```

## 핵심 구현 내용

### 1. Unity 프로젝트 단위 관리
Unity Editor에서 프로젝트를 열었을 때 에셋 참조가 깨지지 않도록 `Assets`, `Packages`, `ProjectSettings` 구조를 함께 보관했습니다.

### 2. 3인칭 컨트롤러 기반 플레이어 조작
Starter Assets의 입력 처리와 캐릭터 이동 컴포넌트를 사용해 기본 이동, 카메라, 모바일 입력 스크립트까지 포함된 형태로 구성했습니다.

### 3. 고양이 테마 에셋 구성
고양이 모델, 캐릭터 프리팹, UI 이미지, 환경 오브젝트를 분리해 게임 씬 제작에 필요한 리소스를 빠르게 확인할 수 있게 정리했습니다.

## 실행 방법

1. Unity Hub에서 이 저장소 폴더를 프로젝트로 추가합니다.
2. Unity Editor에서 프로젝트를 엽니다.
3. `Assets` 내 씬 파일을 열고 Play 버튼으로 실행합니다.

---
Unity 기반 3D 게임 제작 실습으로 구성한 CatsGo 프로젝트입니다.
